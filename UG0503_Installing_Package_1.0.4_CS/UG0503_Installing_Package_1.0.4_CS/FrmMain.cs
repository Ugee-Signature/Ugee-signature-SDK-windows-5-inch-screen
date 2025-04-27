using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace UG05Demo
{
    public partial class FrmMain : Form
    {
        //OpenDevice(0:success;other:failed)
        [DllImport("UG05Sign.dll", CallingConvention = CallingConvention.StdCall, EntryPoint = "UgeeOpenDevice")]
        public extern static int UgeeOpenDevice();

        //StartSign
        [DllImport("UG05Sign.dll", CallingConvention = CallingConvention.StdCall, EntryPoint = "UgeeStartSign")]
        public extern static int UgeeStartSign(int penWidth, string SignPath);

        //GetBase64CallBack
        private delegate int UgeeGetBase64CallBack_delegate(string Base64);

        [DllImport("UG05Sign.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi, EntryPoint = "UgeeGetBase64CallBack")]
        private extern static int UgeeGetBase64CallBack(UgeeGetBase64CallBack_delegate callback);

        //CloseDevice(0:success;other:failed)
        [DllImport("UG05Sign.dll", CallingConvention = CallingConvention.StdCall, EntryPoint = "UgeeCloseDevice")]
        public extern static int UgeeCloseDevice();

        [DllImport("UG05Sign.dll", CallingConvention = CallingConvention.StdCall, EntryPoint = "UgeeStartFinger")]
        public extern static int UgeeStartFinger(int quality, string szFingerPath);

        [DllImport("UG05Sign.dll", CallingConvention = CallingConvention.StdCall, EntryPoint = "UgeeStartSignFinger")]
        public extern static int UgeeStartSignFinger(int penWidth, string SignPath,int quality, string szFingerPath);


        [DllImport("UG05Sign.dll", CallingConvention = CallingConvention.StdCall, EntryPoint = "UgeeGetANSITemplate")]
        public extern static IntPtr UgeeGetANSITemplate();

        [DllImport("UG05Sign.dll", CallingConvention = CallingConvention.StdCall, EntryPoint = "UgeeGetISOTemplate")]
        public extern static IntPtr UgeeGetISOTemplate();

        [DllImport("UG05Sign.dll", CallingConvention = CallingConvention.StdCall, EntryPoint = "UgeeCompareTemplates")]
        public extern static int UgeeCompareTemplates( string template1, string template2);

        [DllImport("UG05Sign.dll", CallingConvention = CallingConvention.StdCall, EntryPoint = "UgeeFreeString")]
        public extern static void UgeeFreeString(IntPtr str);
        

        string SignFilePath = "";
        string FingerFilePath = "";
        UgeeGetBase64CallBack_delegate callback;
        public FrmMain()
        {
            InitializeComponent();
        }

        //Sign
        private void pbSign_Click(object sender, EventArgs e)
        {
            UgeeOpenDevice();

            callback = new UgeeGetBase64CallBack_delegate(BASE64_FUNC);
            UgeeGetBase64CallBack(callback);

            string signPath = System.Environment.CurrentDirectory + "\\" + "img";

            if (!Directory.Exists(signPath))
            {
                Directory.CreateDirectory(signPath);
            }
            SignFilePath = signPath + "\\" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".png";
            FingerFilePath = signPath + "\\ finger.png";
            UgeeStartSign(5, SignFilePath);//签字
            //UgeeStartFinger(5, FingerFilePath);指纹
            //UgeeStartSignFinger(5, SignFilePath,50, FingerFilePath);//签字+指纹

        }
        private int BASE64_FUNC(string Base64)
        {
            try
            {
                pbSignImg.BackgroundImage = ConvertBase64ToFile(Base64);
                //pbSignImg.BackgroundImage = Image.FromFile(SignFilePath);
                pbSignImg.Refresh();
                return 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return -1;
            }
        }
        private int FBASE64_FUNC(string Base64)
        {
            try
            {
                pbFingerImg.BackgroundImage = ConvertBase64ToFile(Base64);
                //pbSignImg.BackgroundImage = Image.FromFile(SignFilePath);
                pbFingerImg.Refresh();
                return 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return -1;
            }
        }
        /// <summary>
        /// Base64
        /// </summary>
        /// <param name="base64">Base64</param>
        public static Image ConvertBase64ToFile(string base64)
        {
            string dummyData = base64.Trim().Replace("%", "").Replace(",", "").Replace(" ", "+");
            if (dummyData.Length % 4 > 0)
            {
                dummyData = dummyData.PadRight(dummyData.Length + 4 - dummyData.Length % 4, '=');
            }
            MemoryStream stream = new MemoryStream(Convert.FromBase64String(dummyData));
            Bitmap img = new Bitmap(stream);
            return img;
        }

        //Cancel
        private void pbCancel_Click(object sender, EventArgs e)
        {
            UgeeCloseDevice();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
        }

        private void btnFinger_Click(object sender, EventArgs e)
        {
            UgeeOpenDevice();

            callback = new UgeeGetBase64CallBack_delegate(FBASE64_FUNC);
            UgeeGetBase64CallBack(callback);

            string signPath = System.Environment.CurrentDirectory + "\\" + "img";

            if (!Directory.Exists(signPath))
            {
                Directory.CreateDirectory(signPath);
            }
            FingerFilePath = signPath + "\\ finger.png";
            UgeeStartFinger(80, FingerFilePath);//指纹
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IntPtr resultPtr = UgeeGetANSITemplate();
            string strAnsiTemplate = Marshal.PtrToStringAnsi(resultPtr);
            textBox1.Text = strAnsiTemplate;
            UgeeFreeString(resultPtr);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            IntPtr resultPtr = UgeeGetANSITemplate();
            string strAnsiTemplate = Marshal.PtrToStringAnsi(resultPtr);
            textBox2.Text = strAnsiTemplate;
            UgeeFreeString(resultPtr);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string str1 = textBox1.Text;
            string str2 = textBox2.Text;
            int result = UgeeCompareTemplates(str1, str2);
            m_result.Text = result.ToString();
        }
    }
}