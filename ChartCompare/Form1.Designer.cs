namespace ChartCompare
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnUploadNoVPN = new System.Windows.Forms.Button();
            this.openFileNoVPN = new System.Windows.Forms.OpenFileDialog();
            this.btnUploadVPN = new System.Windows.Forms.Button();
            this.openFileVPN = new System.Windows.Forms.OpenFileDialog();
            this.charIpLeft = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelFileNoVPN = new System.Windows.Forms.Label();
            this.labelFileVPN = new System.Windows.Forms.Label();
            this.chartNonVPN = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartVPN = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.charIpLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartNonVPN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartVPN)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUploadNoVPN
            // 
            this.btnUploadNoVPN.Location = new System.Drawing.Point(12, 12);
            this.btnUploadNoVPN.Name = "btnUploadNoVPN";
            this.btnUploadNoVPN.Size = new System.Drawing.Size(100, 20);
            this.btnUploadNoVPN.TabIndex = 0;
            this.btnUploadNoVPN.Text = "Upload No VPN";
            this.btnUploadNoVPN.UseVisualStyleBackColor = true;
            this.btnUploadNoVPN.Click += new System.EventHandler(this.btnUploadNoVPN_Click);
            // 
            // openFileNoVPN
            // 
            this.openFileNoVPN.FileName = "openFileNoVPN";
            this.openFileNoVPN.Filter = "Text files (*.txt)|*.txt";
            this.openFileNoVPN.InitialDirectory = "F:\\\\";
            this.openFileNoVPN.RestoreDirectory = true;
            // 
            // btnUploadVPN
            // 
            this.btnUploadVPN.Location = new System.Drawing.Point(12, 51);
            this.btnUploadVPN.Name = "btnUploadVPN";
            this.btnUploadVPN.Size = new System.Drawing.Size(100, 20);
            this.btnUploadVPN.TabIndex = 2;
            this.btnUploadVPN.Text = "Upload VPN";
            this.btnUploadVPN.UseVisualStyleBackColor = true;
            this.btnUploadVPN.Click += new System.EventHandler(this.btnUploadVPN_Click);
            // 
            // openFileVPN
            // 
            this.openFileVPN.FileName = "openFileVPN";
            this.openFileVPN.Filter = "Text files (*.txt)|*.txt";
            this.openFileVPN.InitialDirectory = "F:\\\\";
            this.openFileVPN.RestoreDirectory = true;
            // 
            // charIpLeft
            // 
            chartArea1.AxisX.LabelStyle.Format = "HH:mm:ss";
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisY.MajorGrid.Enabled = false;
            chartArea1.Name = "ChartArea1";
            this.charIpLeft.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.charIpLeft.Legends.Add(legend1);
            this.charIpLeft.Location = new System.Drawing.Point(140, 12);
            this.charIpLeft.Name = "charIpLeft";
            this.charIpLeft.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.charIpLeft.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.Blue,
        System.Drawing.Color.Red};
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series No VPN";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Series VPN";
            series2.YValuesPerPoint = 2;
            this.charIpLeft.Series.Add(series1);
            this.charIpLeft.Series.Add(series2);
            this.charIpLeft.Size = new System.Drawing.Size(781, 340);
            this.charIpLeft.TabIndex = 4;
            this.charIpLeft.Text = "chart1";
            // 
            // labelFileNoVPN
            // 
            this.labelFileNoVPN.AutoSize = true;
            this.labelFileNoVPN.Location = new System.Drawing.Point(12, 35);
            this.labelFileNoVPN.Name = "labelFileNoVPN";
            this.labelFileNoVPN.Size = new System.Drawing.Size(0, 13);
            this.labelFileNoVPN.TabIndex = 1;
            // 
            // labelFileVPN
            // 
            this.labelFileVPN.AutoSize = true;
            this.labelFileVPN.Location = new System.Drawing.Point(12, 74);
            this.labelFileVPN.Name = "labelFileVPN";
            this.labelFileVPN.Size = new System.Drawing.Size(0, 13);
            this.labelFileVPN.TabIndex = 3;
            // 
            // chartNonVPN
            // 
            chartArea2.AxisX.LabelStyle.Format = "HH:mm:ss";
            chartArea2.AxisX.MajorGrid.Enabled = false;
            chartArea2.AxisY.MajorGrid.Enabled = false;
            chartArea2.Name = "ChartArea1";
            this.chartNonVPN.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartNonVPN.Legends.Add(legend2);
            this.chartNonVPN.Location = new System.Drawing.Point(12, 381);
            this.chartNonVPN.Name = "chartNonVPN";
            this.chartNonVPN.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chartNonVPN.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.Blue,
        System.Drawing.Color.Red};
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "Series No VPN";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.Name = "Series VPN";
            series4.YValuesPerPoint = 2;
            this.chartNonVPN.Series.Add(series3);
            this.chartNonVPN.Series.Add(series4);
            this.chartNonVPN.Size = new System.Drawing.Size(460, 340);
            this.chartNonVPN.TabIndex = 5;
            this.chartNonVPN.Text = "chart1";
            // 
            // chartVPN
            // 
            chartArea3.AxisX.LabelStyle.Format = "HH:mm:ss";
            chartArea3.AxisX.MajorGrid.Enabled = false;
            chartArea3.AxisY.MajorGrid.Enabled = false;
            chartArea3.Name = "ChartArea1";
            this.chartVPN.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartVPN.Legends.Add(legend3);
            this.chartVPN.Location = new System.Drawing.Point(487, 381);
            this.chartVPN.Name = "chartVPN";
            this.chartVPN.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chartVPN.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.Red,
        System.Drawing.Color.Blue};
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Legend = "Legend1";
            series5.Name = "Series No VPN";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Legend = "Legend1";
            series6.Name = "Series VPN";
            series6.YValuesPerPoint = 2;
            this.chartVPN.Series.Add(series5);
            this.chartVPN.Series.Add(series6);
            this.chartVPN.Size = new System.Drawing.Size(460, 340);
            this.chartVPN.TabIndex = 6;
            this.chartVPN.Text = "chart2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Type:";
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(55, 98);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(35, 13);
            this.labelType.TabIndex = 8;
            this.labelType.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 733);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chartVPN);
            this.Controls.Add(this.chartNonVPN);
            this.Controls.Add(this.btnUploadNoVPN);
            this.Controls.Add(this.labelFileNoVPN);
            this.Controls.Add(this.btnUploadVPN);
            this.Controls.Add(this.labelFileVPN);
            this.Controls.Add(this.charIpLeft);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.charIpLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartNonVPN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartVPN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUploadNoVPN;
        private System.Windows.Forms.DataVisualization.Charting.Chart charIpLeft;
        private System.Windows.Forms.OpenFileDialog openFileNoVPN;
        private System.Windows.Forms.OpenFileDialog openFileVPN;
        private System.Windows.Forms.Button btnUploadVPN;
        private System.Windows.Forms.Label labelFileNoVPN;
        private System.Windows.Forms.Label labelFileVPN;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartNonVPN;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartVPN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelType;
    }
}

