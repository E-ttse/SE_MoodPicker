namespace MoodPicker
{
    partial class Mode2_CoinScreen
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
            this.lblCoinText = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnFlip = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCoinText
            // 
            this.lblCoinText.BackColor = System.Drawing.Color.LightSeaGreen;
            this.lblCoinText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCoinText.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblCoinText.ForeColor = System.Drawing.Color.White;
            this.lblCoinText.Location = new System.Drawing.Point(99, 146);
            this.lblCoinText.Name = "lblCoinText";
            this.lblCoinText.Size = new System.Drawing.Size(682, 445);
            this.lblCoinText.TabIndex = 1;
            this.lblCoinText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblInfo.Location = new System.Drawing.Point(859, 428);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(122, 28);
            this.lblInfo.TabIndex = 2;
            this.lblInfo.Text = "Result / 結果";
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnFlip
            // 
            this.btnFlip.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnFlip.Location = new System.Drawing.Point(864, 354);
            this.btnFlip.Name = "btnFlip";
            this.btnFlip.Size = new System.Drawing.Size(266, 40);
            this.btnFlip.TabIndex = 3;
            this.btnFlip.Text = "Flip / 擲硬幣";
            this.btnFlip.UseVisualStyleBackColor = true;
            this.btnFlip.Click += new System.EventHandler(this.btnFlip_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("宋体", 12F);
            this.button7.Location = new System.Drawing.Point(1106, 639);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(134, 48);
            this.button7.TabIndex = 14;
            this.button7.Text = "繼續";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Viner Hand ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(20, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 78);
            this.button1.TabIndex = 15;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Mode2_CoinScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.btnFlip);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblCoinText);
            this.Name = "Mode2_CoinScreen";
            this.Size = new System.Drawing.Size(1280, 720);
            this.Load += new System.EventHandler(this.Mode2_CoinScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCoinText;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnFlip;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button1;
    }
}
