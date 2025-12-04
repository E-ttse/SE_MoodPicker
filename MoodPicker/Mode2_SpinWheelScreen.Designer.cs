namespace MoodPicker
{
    partial class Mode2_SpinWheelScreen
    {
        /// <summary> 
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 元件設計工具產生的程式碼

        /// <summary> 
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button7 = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnSpin = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.spinWheelControl1 = new MoodPicker.SpinWheelControl();
            this.mainPage1 = new MoodPicker.MainPage();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("宋体", 12F);
            this.button7.Location = new System.Drawing.Point(1106, 639);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(134, 48);
            this.button7.TabIndex = 16;
            this.button7.Text = "繼續";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(965, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(115, 37);
            this.lblTitle.TabIndex = 17;
            this.lblTitle.Text = "清單：-";
            // 
            // btnSpin
            // 
            this.btnSpin.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnSpin.Location = new System.Drawing.Point(972, 323);
            this.btnSpin.Name = "btnSpin";
            this.btnSpin.Size = new System.Drawing.Size(137, 58);
            this.btnSpin.TabIndex = 18;
            this.btnSpin.Text = "Spin / 旋轉";
            this.btnSpin.UseVisualStyleBackColor = true;
            this.btnSpin.Click += new System.EventHandler(this.btnSpin_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblInfo.Location = new System.Drawing.Point(967, 425);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(122, 28);
            this.lblInfo.TabIndex = 21;
            this.lblInfo.Text = "Result / 結果";
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // spinWheelControl1
            // 
            this.spinWheelControl1.Location = new System.Drawing.Point(153, 130);
            this.spinWheelControl1.Name = "spinWheelControl1";
            this.spinWheelControl1.Size = new System.Drawing.Size(595, 492);
            this.spinWheelControl1.TabIndex = 20;
            // 
            // mainPage1
            // 
            this.mainPage1.Location = new System.Drawing.Point(512, 445);
            this.mainPage1.Name = "mainPage1";
            this.mainPage1.Size = new System.Drawing.Size(8, 8);
            this.mainPage1.TabIndex = 19;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Viner Hand ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(20, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 78);
            this.button1.TabIndex = 22;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Mode2_SpinWheelScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.spinWheelControl1);
            this.Controls.Add(this.mainPage1);
            this.Controls.Add(this.btnSpin);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.button7);
            this.Name = "Mode2_SpinWheelScreen";
            this.Size = new System.Drawing.Size(1280, 720);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnSpin;
        private MainPage mainPage1;
        private SpinWheelControl spinWheelControl1;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button button1;
    }
}
