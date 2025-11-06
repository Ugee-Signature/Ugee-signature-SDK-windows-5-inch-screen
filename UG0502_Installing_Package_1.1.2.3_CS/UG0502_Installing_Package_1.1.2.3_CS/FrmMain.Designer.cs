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
            this.pbSignFingerImg = new System.Windows.Forms.PictureBox();
            this.btnSignFinger = new System.Windows.Forms.Button();
            this.btn_getserialnum = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbSignImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFingerImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSignFingerImg)).BeginInit();
            this.SuspendLayout();
            // 
            // pbSignImg
            // 
            this.pbSignImg.BackColor = System.Drawing.Color.Transparent;
            this.pbSignImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbSignImg.Location = new System.Drawing.Point(683, 533);
            this.pbSignImg.Name = "pbSignImg";
            this.pbSignImg.Size = new System.Drawing.Size(136, 114);
            this.pbSignImg.TabIndex = 3;
            this.pbSignImg.TabStop = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCancel.Location = new System.Drawing.Point(647, 665);
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
            this.btnSign.Location = new System.Drawing.Point(488, 665);
            this.btnSign.Name = "btnSign";
            this.btnSign.Size = new System.Drawing.Size(121, 44);
            this.btnSign.TabIndex = 5;
            this.btnSign.Text = "Signature";
            this.btnSign.UseVisualStyleBackColor = true;
            this.btnSign.Click += new System.EventHandler(this.pbSign_Click);
            // 
            // btnFinger
            // 
            this.btnFinger.Location = new System.Drawing.Point(809, 665);
            this.btnFinger.Name = "btnFinger";
            this.btnFinger.Size = new System.Drawing.Size(121, 44);
            this.btnFinger.TabIndex = 0;
            this.btnFinger.Text = "fingerprint";
            this.btnFinger.UseVisualStyleBackColor = true;
            this.btnFinger.Click += new System.EventHandler(this.btnFinger_Click);
            // 
            // pbFingerImg
            // 
            this.pbFingerImg.BackColor = System.Drawing.Color.Transparent;
            this.pbFingerImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbFingerImg.Location = new System.Drawing.Point(855, 533);
            this.pbFingerImg.Name = "pbFingerImg";
            this.pbFingerImg.Size = new System.Drawing.Size(133, 114);
            this.pbFingerImg.TabIndex = 6;
            this.pbFingerImg.TabStop = false;
            // 
            // pbSignFingerImg
            // 
            this.pbSignFingerImg.BackColor = System.Drawing.Color.Transparent;
            this.pbSignFingerImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbSignFingerImg.Location = new System.Drawing.Point(1020, 533);
            this.pbSignFingerImg.Name = "pbSignFingerImg";
            this.pbSignFingerImg.Size = new System.Drawing.Size(171, 114);
            this.pbSignFingerImg.TabIndex = 7;
            this.pbSignFingerImg.TabStop = false;
            // 
            // btnSignFinger
            // 
            this.btnSignFinger.Location = new System.Drawing.Point(955, 665);
            this.btnSignFinger.Name = "btnSignFinger";
            this.btnSignFinger.Size = new System.Drawing.Size(121, 44);
            this.btnSignFinger.TabIndex = 8;
            this.btnSignFinger.Text = "Signature and fingerprint";
            this.btnSignFinger.UseVisualStyleBackColor = true;
            this.btnSignFinger.Click += new System.EventHandler(this.btnSignFinger_Click);
            // 
            // btn_getserialnum
            // 
            this.btn_getserialnum.Location = new System.Drawing.Point(1090, 665);
            this.btn_getserialnum.Name = "btn_getserialnum";
            this.btn_getserialnum.Size = new System.Drawing.Size(121, 44);
            this.btn_getserialnum.TabIndex = 9;
            this.btn_getserialnum.Text = "number";
            this.btn_getserialnum.UseVisualStyleBackColor = true;
            this.btn_getserialnum.Click += new System.EventHandler(this.btn_getserialnum_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::UG05Demo.Properties.Resources.demo;
            this.ClientSize = new System.Drawing.Size(1264, 761);
            this.Controls.Add(this.btn_getserialnum);
            this.Controls.Add(this.btnSignFinger);
            this.Controls.Add(this.pbSignFingerImg);
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
            ((System.ComponentModel.ISupportInitialize)(this.pbSignFingerImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pbSignImg;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSign;
        private System.Windows.Forms.Button btnFinger;
        private System.Windows.Forms.PictureBox pbFingerImg;
        private System.Windows.Forms.PictureBox pbSignFingerImg;
        private System.Windows.Forms.Button btnSignFinger;
        private System.Windows.Forms.Button btn_getserialnum;
    }
}

