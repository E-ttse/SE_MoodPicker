namespace MoodPicker
{
    partial class Mode2_AddList
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
            this.button1 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button9 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Viner Hand ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(20, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 78);
            this.button1.TabIndex = 0;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("宋体", 12F);
            this.button2.Location = new System.Drawing.Point(544, 124);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 48);
            this.button2.TabIndex = 2;
            this.button2.Text = "新增種類";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("宋体", 12F);
            this.button3.Location = new System.Drawing.Point(777, 124);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(134, 48);
            this.button3.TabIndex = 5;
            this.button3.Text = "新增選項";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(544, 296);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(400, 25);
            this.textBox1.TabIndex = 6;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("宋体", 12F);
            this.button4.Location = new System.Drawing.Point(854, 339);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(90, 33);
            this.button4.TabIndex = 7;
            this.button4.Text = "確認";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("宋体", 12F);
            this.button5.Location = new System.Drawing.Point(1012, 124);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(134, 48);
            this.button5.TabIndex = 8;
            this.button5.Text = "選擇此清單";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(99, 127);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(368, 516);
            this.treeView1.TabIndex = 10;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("宋体", 12F);
            this.button6.Location = new System.Drawing.Point(544, 419);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(134, 48);
            this.button6.TabIndex = 11;
            this.button6.Text = "刪除種類";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("宋体", 12F);
            this.button7.Location = new System.Drawing.Point(777, 419);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(134, 48);
            this.button7.TabIndex = 12;
            this.button7.Text = "刪除選項";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("宋体", 12F);
            this.button8.Location = new System.Drawing.Point(1012, 419);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(134, 48);
            this.button8.TabIndex = 13;
            this.button8.Text = "修改選項";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 20F);
            this.label2.Location = new System.Drawing.Point(538, 507);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 34);
            this.label2.TabIndex = 14;
            this.label2.Text = "請修改選項";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(544, 580);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(400, 25);
            this.textBox2.TabIndex = 15;
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("宋体", 12F);
            this.button9.Location = new System.Drawing.Point(854, 622);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(90, 33);
            this.button9.TabIndex = 16;
            this.button9.Text = "確認";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 20F);
            this.label1.Location = new System.Drawing.Point(538, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(406, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "請輸入欲新增的種類/選項";
            // 
            // Mode2_AddList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button9);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Mode2_AddList";
            this.Size = new System.Drawing.Size(1280, 720);
            this.Load += new System.EventHandler(this.Mode2_AddList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label1;
    }
}
