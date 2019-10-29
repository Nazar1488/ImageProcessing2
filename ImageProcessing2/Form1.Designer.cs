namespace ImageProcessing2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea21 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend21 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series21 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea22 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend22 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series22 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea23 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend23 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series23 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea24 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend24 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series24 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.luminanceChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.redChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.greenChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.blueChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.equalizeBtn = new System.Windows.Forms.Button();
            this.robertsImage = new System.Windows.Forms.PictureBox();
            this.previtImage = new System.Windows.Forms.PictureBox();
            this.sobelImage = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.luminanceChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.robertsImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.previtImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sobelImage)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(6, 19);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(612, 400);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(624, 432);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Image";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1059, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.toolStripSeparator,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(177, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveAsToolStripMenuItem.Text = "Save &As";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.blueChart);
            this.groupBox2.Controls.Add(this.greenChart);
            this.groupBox2.Controls.Add(this.redChart);
            this.groupBox2.Controls.Add(this.equalizeBtn);
            this.groupBox2.Controls.Add(this.luminanceChart);
            this.groupBox2.Location = new System.Drawing.Point(642, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(412, 681);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Charts";
            // 
            // luminanceChart
            // 
            chartArea21.Name = "ChartArea1";
            this.luminanceChart.ChartAreas.Add(chartArea21);
            legend21.Name = "Legend1";
            this.luminanceChart.Legends.Add(legend21);
            this.luminanceChart.Location = new System.Drawing.Point(6, 19);
            this.luminanceChart.Name = "luminanceChart";
            series21.ChartArea = "ChartArea1";
            series21.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series21.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            series21.IsVisibleInLegend = false;
            series21.Legend = "Legend1";
            series21.Name = "Series1";
            this.luminanceChart.Series.Add(series21);
            this.luminanceChart.Size = new System.Drawing.Size(400, 150);
            this.luminanceChart.TabIndex = 0;
            this.luminanceChart.Text = "chart1";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // redChart
            // 
            chartArea22.Name = "ChartArea1";
            this.redChart.ChartAreas.Add(chartArea22);
            legend22.Name = "Legend1";
            this.redChart.Legends.Add(legend22);
            this.redChart.Location = new System.Drawing.Point(6, 175);
            this.redChart.Name = "redChart";
            this.redChart.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.Red};
            series22.ChartArea = "ChartArea1";
            series22.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series22.Color = System.Drawing.Color.Red;
            series22.IsVisibleInLegend = false;
            series22.Legend = "Legend1";
            series22.Name = "Series1";
            this.redChart.Series.Add(series22);
            this.redChart.Size = new System.Drawing.Size(400, 150);
            this.redChart.TabIndex = 1;
            this.redChart.Text = "chart1";
            // 
            // greenChart
            // 
            chartArea23.Name = "ChartArea1";
            this.greenChart.ChartAreas.Add(chartArea23);
            legend23.Name = "Legend1";
            this.greenChart.Legends.Add(legend23);
            this.greenChart.Location = new System.Drawing.Point(6, 331);
            this.greenChart.Name = "greenChart";
            series23.ChartArea = "ChartArea1";
            series23.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series23.Color = System.Drawing.Color.Green;
            series23.IsVisibleInLegend = false;
            series23.Legend = "Legend1";
            series23.Name = "Series1";
            this.greenChart.Series.Add(series23);
            this.greenChart.Size = new System.Drawing.Size(400, 150);
            this.greenChart.TabIndex = 2;
            this.greenChart.Text = "chart2";
            // 
            // blueChart
            // 
            chartArea24.Name = "ChartArea1";
            this.blueChart.ChartAreas.Add(chartArea24);
            legend24.Name = "Legend1";
            this.blueChart.Legends.Add(legend24);
            this.blueChart.Location = new System.Drawing.Point(6, 487);
            this.blueChart.Name = "blueChart";
            series24.ChartArea = "ChartArea1";
            series24.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series24.Color = System.Drawing.Color.Blue;
            series24.IsVisibleInLegend = false;
            series24.Legend = "Legend1";
            series24.Name = "Series1";
            this.blueChart.Series.Add(series24);
            this.blueChart.Size = new System.Drawing.Size(400, 150);
            this.blueChart.TabIndex = 3;
            this.blueChart.Text = "chart3";
            // 
            // equalizeBtn
            // 
            this.equalizeBtn.Location = new System.Drawing.Point(169, 643);
            this.equalizeBtn.Name = "equalizeBtn";
            this.equalizeBtn.Size = new System.Drawing.Size(75, 23);
            this.equalizeBtn.TabIndex = 1;
            this.equalizeBtn.Text = "Equalize";
            this.equalizeBtn.UseVisualStyleBackColor = true;
            this.equalizeBtn.Click += new System.EventHandler(this.EqualizeBtn_Click);
            // 
            // robertsImage
            // 
            this.robertsImage.Location = new System.Drawing.Point(6, 19);
            this.robertsImage.Name = "robertsImage";
            this.robertsImage.Size = new System.Drawing.Size(200, 200);
            this.robertsImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.robertsImage.TabIndex = 2;
            this.robertsImage.TabStop = false;
            this.robertsImage.DoubleClick += new System.EventHandler(this.RobertsImage_DoubleClick);
            // 
            // previtImage
            // 
            this.previtImage.Location = new System.Drawing.Point(212, 19);
            this.previtImage.Name = "previtImage";
            this.previtImage.Size = new System.Drawing.Size(200, 200);
            this.previtImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.previtImage.TabIndex = 3;
            this.previtImage.TabStop = false;
            this.previtImage.DoubleClick += new System.EventHandler(this.PrevitImage_DoubleClick);
            // 
            // sobelImage
            // 
            this.sobelImage.Location = new System.Drawing.Point(418, 19);
            this.sobelImage.Name = "sobelImage";
            this.sobelImage.Size = new System.Drawing.Size(200, 200);
            this.sobelImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.sobelImage.TabIndex = 4;
            this.sobelImage.TabStop = false;
            this.sobelImage.DoubleClick += new System.EventHandler(this.SobelImage_DoubleClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.previtImage);
            this.groupBox3.Controls.Add(this.sobelImage);
            this.groupBox3.Controls.Add(this.robertsImage);
            this.groupBox3.Location = new System.Drawing.Point(12, 465);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(624, 243);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Operators";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(64, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Roberts";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(290, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Prewitt";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(497, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Sobel";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 720);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Image Processing";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.luminanceChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.robertsImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.previtImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sobelImage)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataVisualization.Charting.Chart luminanceChart;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.DataVisualization.Charting.Chart blueChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart greenChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart redChart;
        private System.Windows.Forms.Button equalizeBtn;
        private System.Windows.Forms.PictureBox sobelImage;
        private System.Windows.Forms.PictureBox previtImage;
        private System.Windows.Forms.PictureBox robertsImage;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

