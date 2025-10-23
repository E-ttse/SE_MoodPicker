namespace MoodPicker
{
    partial class MainPage
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 50F);
            this.label1.Location = new System.Drawing.Point(541, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 84);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(295, 393);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(252, 107);
            this.button1.TabIndex = 1;
            this.button1.Text = "Mode1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(802, 393);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(235, 107);
            this.button2.TabIndex = 2;
            this.button2.Text = "Mode2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "MainPage";
            this.Size = new System.Drawing.Size(1373, 598);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}
