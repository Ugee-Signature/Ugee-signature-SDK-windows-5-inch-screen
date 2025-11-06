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

        //Interface key callback: Cancel 3 Re-sign 1 confirm 2
        private delegate int UgeeGetKeyCallBack_delegate(int key);

        [DllImport("UG05Sign.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi, EntryPoint = "UgeeGetKeyCallBack")]
        private extern static int UgeeGetKeyCallBack(UgeeGetKeyCallBack_delegate callback);

        //Obtain the serial number
        [DllImport("UG05Sign.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi, EntryPoint = "UgeeGetSerialNum")]
        public extern static IntPtr UgeeGetSerialNum();

        [DllImport("UG05Sign.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi, EntryPoint = "UgeeFreeMemory")]
        public extern static void UgeeFreeMemory(IntPtr ptr);
        

        string SignFilePath = "";
        string FingerFilePath = "";
        string SignFingerFilePath = "";
        UgeeGetBase64CallBack_delegate callback;
        UgeeGetKeyCallBack_delegate keyCallback;
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

            keyCallback = new UgeeGetKeyCallBack_delegate(KEY_FUNC);
            UgeeGetKeyCallBack(keyCallback);

            string signPath = System.Environment.CurrentDirectory + "\\" + "img";

            if (!Directory.Exists(signPath))
            {
                Directory.CreateDirectory(signPath);
            }
            SignFilePath = signPath + "\\" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".png";
            FingerFilePath = signPath + "\\ finger.png";
            UgeeStartSign(5, SignFilePath);//Signature
            //UgeeStartFinger(5, FingerFilePath);Fingerprint
            //UgeeStartSignFinger(5, SignFilePath,50, FingerFilePath);//Signature+Fingerprint

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
        private int KEY_FUNC(int key)
        {
            try
            {
                //Interface key callback: Cancel 3 Re-sign 1 confirm 2
                if (key == 1)//Re-sign
                    Console.WriteLine("Re-sign");
                else if (key == 2)//confirm
                    Console.WriteLine("confirm"); 
                else if (key == 3)//Cancel
                    Console.WriteLine("Cancel");

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

        private int SFBASE64_FUNC(string Base64)
        {
            try
            {
                pbSignFingerImg.BackgroundImage = ConvertBase64ToFile(Base64);
                pbSignFingerImg.Refresh();
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
            UgeeStartFinger(80, FingerFilePath);//Fingerprint
        }

        private void btnSignFinger_Click(object sender, EventArgs e)
        {
            UgeeOpenDevice();

            callback = new UgeeGetBase64CallBack_delegate(SFBASE64_FUNC);
            UgeeGetBase64CallBack(callback);

            keyCallback = new UgeeGetKeyCallBack_delegate(KEY_FUNC);
            UgeeGetKeyCallBack(keyCallback);

            string signPath = System.Environment.CurrentDirectory + "\\" + "img";

            if (!Directory.Exists(signPath))
            {
                Directory.CreateDirectory(signPath);
            }
            SignFilePath = signPath + "\\" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".png";
            SignFingerFilePath = signPath + "\\ sfinger.png";
            UgeeStartSignFinger(5, SignFilePath, 50, SignFingerFilePath);///Signature+Fingerprint
        }

        private void btn_getserialnum_Click(object sender, EventArgs e)
        {
            UgeeOpenDevice();
            IntPtr serialNum = UgeeGetSerialNum();
            string str2 = Marshal.PtrToStringAnsi(serialNum);//Obtain the serial number
            UgeeFreeMemory(serialNum);
            MessageBox.Show(str2, "number");
        }
    }
}