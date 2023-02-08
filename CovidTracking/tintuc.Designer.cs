namespace CovidTracking
{
    partial class tintuc
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.brower = new System.Windows.Forms.WebBrowser();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.brower);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2698, 1496);
            this.panel1.TabIndex = 0;
            // 
            // brower
            // 
            this.brower.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.brower.Location = new System.Drawing.Point(-452, 104);
            this.brower.MinimumSize = new System.Drawing.Size(20, 20);
            this.brower.Name = "brower";
            this.brower.Size = new System.Drawing.Size(3147, 1420);
            this.brower.TabIndex = 23;
            this.brower.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.brower_DocumentCompleted);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(846, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(191, 49);
            this.button5.TabIndex = 22;
            this.button5.Text = "Tin tức";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(640, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(191, 49);
            this.button4.TabIndex = 21;
            this.button4.Text = "PC - Covid";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(431, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(191, 49);
            this.button3.TabIndex = 20;
            this.button3.Text = "Tiêm chủng";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(224, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(191, 49);
            this.button2.TabIndex = 19;
            this.button2.Text = "Ca nhiễm";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(191, 49);
            this.button1.TabIndex = 18;
            this.button1.Text = "Tổng quan";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tintuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2698, 1496);
            this.Controls.Add(this.panel1);
            this.Name = "tintuc";
            this.Text = "tintuc";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.WebBrowser brower;
    }
}