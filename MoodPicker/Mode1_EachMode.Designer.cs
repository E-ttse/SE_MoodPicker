namespace MoodPicker
{
    partial class Mode1_EachMode
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
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new MoodPicker.Mode1_Card();
            this.pictureBox2 = new MoodPicker.Mode1_Card();
            this.pictureBox3 = new MoodPicker.Mode1_Card();
            this.pictureBox4 = new MoodPicker.Mode1_Card();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 20F);
            this.label1.Location = new System.Drawing.Point(466, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 30F);
            this.label2.Location = new System.Drawing.Point(600, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 50);
            this.label2.TabIndex = 1;
            this.label2.Text = "Happy :D";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Activity = null;
            this.pictureBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pictureBox1.Location = new System.Drawing.Point(111, 238);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Position = 0;
            this.pictureBox1.Size = new System.Drawing.Size(230, 340);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Activity = null;
            this.pictureBox2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pictureBox2.Location = new System.Drawing.Point(402, 238);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Position = 0;
            this.pictureBox2.Size = new System.Drawing.Size(230, 340);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Activity = null;
            this.pictureBox3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pictureBox3.Location = new System.Drawing.Point(683, 238);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Position = 0;
            this.pictureBox3.Size = new System.Drawing.Size(230, 340);
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Activity = null;
            this.pictureBox4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pictureBox4.Location = new System.Drawing.Point(964, 238);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Position = 0;
            this.pictureBox4.Size = new System.Drawing.Size(230, 340);
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("新細明體", 12F);
            this.button5.Location = new System.Drawing.Point(1050, 626);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(192, 63);
            this.button5.TabIndex = 7;
            this.button5.Text = "繼續...";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Mode1_EachMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Mode1_EachMode";
            this.Size = new System.Drawing.Size(1280, 720);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private MoodPicker.Mode1_Card pictureBox1;
        private MoodPicker.Mode1_Card pictureBox2;
        private MoodPicker.Mode1_Card pictureBox3;
        private MoodPicker.Mode1_Card pictureBox4;
        private System.Windows.Forms.Button button5;
    }
}
