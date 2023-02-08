namespace CovidTracking
{
    partial class PrimaryForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrimaryForm));
            this.jsonDataSource1 = new DevExpress.DataAccess.Json.JsonDataSource(this.components);
            this.mapControl1 = new DevExpress.XtraMap.MapControl();
            this.vectorItemsLayer1 = new DevExpress.XtraMap.VectorItemsLayer();
            this.svgFileDataAdapter1 = new DevExpress.XtraMap.SvgFileDataAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.selectBoxProvice = new System.Windows.Forms.ComboBox();
            this.jsonDataSource2 = new DevExpress.DataAccess.Json.JsonDataSource(this.components);
            this.jsonDataSource3 = new DevExpress.DataAccess.Json.JsonDataSource(this.components);
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mapControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // jsonDataSource1
            // 
            this.jsonDataSource1.Name = "jsonDataSource1";
            // 
            // mapControl1
            // 
            this.mapControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapControl1.Layers.Add(this.vectorItemsLayer1);
            this.mapControl1.Location = new System.Drawing.Point(0, 0);
            this.mapControl1.Margin = new System.Windows.Forms.Padding(2);
            this.mapControl1.Name = "mapControl1";
            this.mapControl1.NavigationPanelOptions.ZoomingStep = 3D;
            this.mapControl1.Size = new System.Drawing.Size(1944, 1059);
            this.mapControl1.TabIndex = 0;
            this.mapControl1.ZoomLevel = 3D;
            this.mapControl1.Click += new System.EventHandler(this.mapControl1_Click);
            // 
            // vectorItemsLayer1
            // 
            this.vectorItemsLayer1.Data = this.svgFileDataAdapter1;
            // 
            // svgFileDataAdapter1
            // 
            this.svgFileDataAdapter1.FileUri = new System.Uri("C:\\Du\\vn.svg", System.UriKind.Absolute);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1561, 310);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(319, 247);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1572, 238);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 43);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tổng ca nhiễm";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 9);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 37);
            this.button1.TabIndex = 3;
            this.button1.Text = "Tổng quan";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(165, 9);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(143, 37);
            this.button2.TabIndex = 4;
            this.button2.Text = "Ca nhiễm";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(320, 9);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(143, 37);
            this.button3.TabIndex = 5;
            this.button3.Text = "Tiêm chủng";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(477, 9);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(143, 37);
            this.button4.TabIndex = 6;
            this.button4.Text = "PC - Covid";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(632, 9);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(143, 37);
            this.button5.TabIndex = 7;
            this.button5.Text = "Tin tức";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // selectBoxProvice
            // 
            this.selectBoxProvice.FormattingEnabled = true;
            this.selectBoxProvice.Location = new System.Drawing.Point(1346, 16);
            this.selectBoxProvice.Margin = new System.Windows.Forms.Padding(2);
            this.selectBoxProvice.Name = "selectBoxProvice";
            this.selectBoxProvice.Size = new System.Drawing.Size(288, 27);
            this.selectBoxProvice.TabIndex = 8;
            // 
            // jsonDataSource2
            // 
            this.jsonDataSource2.Name = "jsonDataSource2";
            // 
            // jsonDataSource3
            // 
            this.jsonDataSource3.ConnectionName = "DataProvice";
            this.jsonDataSource3.Name = "jsonDataSource3";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(1660, 9);
            this.button6.Margin = new System.Windows.Forms.Padding(2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(132, 37);
            this.button6.TabIndex = 9;
            this.button6.Text = "Xem chi tiết";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // PrimaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1944, 1059);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.selectBoxProvice);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.mapControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PrimaryForm";
            this.Text = "Tổng quan";
            ((System.ComponentModel.ISupportInitialize)(this.mapControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.DataAccess.Json.JsonDataSource jsonDataSource1;
        private DevExpress.XtraMap.MapControl mapControl1;
        private DevExpress.XtraMap.VectorItemsLayer vectorItemsLayer1;
        private DevExpress.XtraMap.SvgFileDataAdapter svgFileDataAdapter1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ComboBox selectBoxProvice;
        private DevExpress.DataAccess.Json.JsonDataSource jsonDataSource2;
        private DevExpress.DataAccess.Json.JsonDataSource jsonDataSource3;
        private System.Windows.Forms.Button button6;
    }
}

