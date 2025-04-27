namespace UG05Demo
{
    partial class FrmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.pbSignImg = new System.Windows.Forms.PictureBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSign = new System.Windows.Forms.Button();
            this.btnFinger = new System.Windows.Forms.Button();
            this.pbFingerImg = new System.Windows.Forms.PictureBox();
            this.template1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.m_result = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbSignImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFingerImg)).BeginInit();
            this.SuspendLayout();
            // 
            // pbSignImg
            // 
            this.pbSignImg.BackColor = System.Drawing.Color.Transparent;
            this.pbSignImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbSignImg.Location = new System.Drawing.Point(711, 572);
            this.pbSignImg.Name = "pbSignImg";
            this.pbSignImg.Size = new System.Drawing.Size(283, 114);
            this.pbSignImg.TabIndex = 3;
            this.pbSignImg.TabStop = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCancel.Location = new System.Drawing.Point(891, 749);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(121, 44);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.pbCancel_Click);
            // 
            // btnSign
            // 
            this.btnSign.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSign.Location = new System.Drawing.Point(715, 749);
            this.btnSign.Name = "btnSign";
            this.btnSign.Size = new System.Drawing.Size(121, 44);
            this.btnSign.TabIndex = 5;
            this.btnSign.Text = "Sign";
            this.btnSign.UseVisualStyleBackColor = true;
            this.btnSign.Click += new System.EventHandler(this.pbSign_Click);
            // 
            // btnFinger
            // 
            this.btnFinger.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnFinger.Location = new System.Drawing.Point(1077, 749);
            this.btnFinger.Name = "btnFinger";
            this.btnFinger.Size = new System.Drawing.Size(121, 44);
            this.btnFinger.TabIndex = 0;
            this.btnFinger.Text = "Finger";
            this.btnFinger.UseVisualStyleBackColor = true;
            this.btnFinger.Click += new System.EventHandler(this.btnFinger_Click);
            // 
            // pbFingerImg
            // 
            this.pbFingerImg.BackColor = System.Drawing.Color.Transparent;
            this.pbFingerImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbFingerImg.Location = new System.Drawing.Point(1018, 572);
            this.pbFingerImg.Name = "pbFingerImg";
            this.pbFingerImg.Size = new System.Drawing.Size(133, 114);
            this.pbFingerImg.TabIndex = 6;
            this.pbFingerImg.TabStop = false;
            // 
            // template1
            // 
            this.template1.AutoSize = true;
            this.template1.Location = new System.Drawing.Point(115, 852);
            this.template1.Name = "template1";
            this.template1.Size = new System.Drawing.Size(59, 12);
            this.template1.TabIndex = 7;
            this.template1.Text = "template1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(73, 733);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(166, 115);
            this.textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(271, 733);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(166, 115);
            this.textBox2.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(323, 851);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 10;
            this.label1.Text = "template2";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.button1.Location = new System.Drawing.Point(718, 827);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 37);
            this.button1.TabIndex = 11;
            this.button1.Text = "Get Template1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(891, 826);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 37);
            this.button2.TabIndex = 12;
            this.button2.Text = "Get Template2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.button3.Location = new System.Drawing.Point(1080, 826);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(118, 37);
            this.button3.TabIndex = 13;
            this.button3.Text = "Compare";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(477, 796);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 12);
            this.label2.TabIndex = 14;
            this.label2.Text = "Compare Reslut :";
            // 
            // m_result
            // 
            this.m_result.AutoSize = true;
            this.m_result.Location = new System.Drawing.Point(588, 796);
            this.m_result.Name = "m_result";
            this.m_result.Size = new System.Drawing.Size(11, 12);
            this.m_result.TabIndex = 15;
            this.m_result.Text = "0";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::UG05Demo.Properties.Resources.demo;
            this.ClientSize = new System.Drawing.Size(1272, 949);
            this.Controls.Add(this.m_result);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.template1);
            this.Controls.Add(this.pbFingerImg);
            this.Controls.Add(this.btnFinger);
            this.Controls.Add(this.btnSign);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.pbSignImg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UG05Demo";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbSignImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFingerImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pbSignImg;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSign;
        private System.Windows.Forms.Button btnFinger;
        private System.Windows.Forms.PictureBox pbFingerImg;
        private System.Windows.Forms.Label template1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label m_result;
    }
}

