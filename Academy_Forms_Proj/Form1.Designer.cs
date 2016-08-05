namespace Academy_Forms_Proj
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.computerName = new System.Windows.Forms.Button();
            this.computerNameBox = new System.Windows.Forms.TextBox();
            this.computerNameLabel = new System.Windows.Forms.Label();
            this.UserNameButton = new System.Windows.Forms.Button();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.UserNameBox = new System.Windows.Forms.TextBox();
            this.cpuNameLabel = new System.Windows.Forms.Label();
            this.cpuNameBox = new System.Windows.Forms.TextBox();
            this.cpuNameButton = new System.Windows.Forms.Button();
            this.totalRamLabel = new System.Windows.Forms.Label();
            this.totalRamBox = new System.Windows.Forms.TextBox();
            this.totalRamButton = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cpuTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // computerName
            // 
            this.computerName.Location = new System.Drawing.Point(12, 545);
            this.computerName.Name = "computerName";
            this.computerName.Size = new System.Drawing.Size(153, 23);
            this.computerName.TabIndex = 6;
            this.computerName.Text = "Show Computer name";
            this.computerName.UseVisualStyleBackColor = true;
            this.computerName.Click += new System.EventHandler(this.computerName_Click);
            // 
            // computerNameBox
            // 
            this.computerNameBox.Location = new System.Drawing.Point(171, 548);
            this.computerNameBox.Name = "computerNameBox";
            this.computerNameBox.Size = new System.Drawing.Size(498, 20);
            this.computerNameBox.TabIndex = 7;
            // 
            // computerNameLabel
            // 
            this.computerNameLabel.AutoSize = true;
            this.computerNameLabel.Location = new System.Drawing.Point(196, 532);
            this.computerNameLabel.Name = "computerNameLabel";
            this.computerNameLabel.Size = new System.Drawing.Size(80, 13);
            this.computerNameLabel.TabIndex = 8;
            this.computerNameLabel.Text = "ComputerName";
            // 
            // UserNameButton
            // 
            this.UserNameButton.Location = new System.Drawing.Point(12, 503);
            this.UserNameButton.Name = "UserNameButton";
            this.UserNameButton.Size = new System.Drawing.Size(153, 23);
            this.UserNameButton.TabIndex = 9;
            this.UserNameButton.Text = "Show user name";
            this.UserNameButton.UseVisualStyleBackColor = true;
            this.UserNameButton.Click += new System.EventHandler(this.UserNameButton_Click);
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Location = new System.Drawing.Point(207, 490);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(58, 13);
            this.UserNameLabel.TabIndex = 11;
            this.UserNameLabel.Text = "User name";
            // 
            // UserNameBox
            // 
            this.UserNameBox.Location = new System.Drawing.Point(171, 505);
            this.UserNameBox.Name = "UserNameBox";
            this.UserNameBox.Size = new System.Drawing.Size(498, 20);
            this.UserNameBox.TabIndex = 10;
            // 
            // cpuNameLabel
            // 
            this.cpuNameLabel.AutoSize = true;
            this.cpuNameLabel.Location = new System.Drawing.Point(207, 443);
            this.cpuNameLabel.Name = "cpuNameLabel";
            this.cpuNameLabel.Size = new System.Drawing.Size(58, 13);
            this.cpuNameLabel.TabIndex = 14;
            this.cpuNameLabel.Text = "CPU name";
            // 
            // cpuNameBox
            // 
            this.cpuNameBox.Location = new System.Drawing.Point(171, 458);
            this.cpuNameBox.Name = "cpuNameBox";
            this.cpuNameBox.Size = new System.Drawing.Size(498, 20);
            this.cpuNameBox.TabIndex = 13;
            // 
            // cpuNameButton
            // 
            this.cpuNameButton.Location = new System.Drawing.Point(12, 456);
            this.cpuNameButton.Name = "cpuNameButton";
            this.cpuNameButton.Size = new System.Drawing.Size(153, 23);
            this.cpuNameButton.TabIndex = 12;
            this.cpuNameButton.Text = "Show CPU name";
            this.cpuNameButton.UseVisualStyleBackColor = true;
            this.cpuNameButton.Click += new System.EventHandler(this.cpuNameButton_Click);
            // 
            // totalRamLabel
            // 
            this.totalRamLabel.AutoSize = true;
            this.totalRamLabel.Location = new System.Drawing.Point(207, 399);
            this.totalRamLabel.Name = "totalRamLabel";
            this.totalRamLabel.Size = new System.Drawing.Size(58, 13);
            this.totalRamLabel.TabIndex = 17;
            this.totalRamLabel.Text = "Total RAM";
            // 
            // totalRamBox
            // 
            this.totalRamBox.Location = new System.Drawing.Point(171, 414);
            this.totalRamBox.Name = "totalRamBox";
            this.totalRamBox.Size = new System.Drawing.Size(498, 20);
            this.totalRamBox.TabIndex = 16;
            // 
            // totalRamButton
            // 
            this.totalRamButton.Location = new System.Drawing.Point(12, 412);
            this.totalRamButton.Name = "totalRamButton";
            this.totalRamButton.Size = new System.Drawing.Size(153, 23);
            this.totalRamButton.TabIndex = 15;
            this.totalRamButton.Text = "Show total RAM";
            this.totalRamButton.UseVisualStyleBackColor = true;
            this.totalRamButton.Click += new System.EventHandler(this.totalRamButton_Click);
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(199, 12);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.MarkerBorderWidth = 10;
            series3.Name = "CpuUsage";
            series3.Points.Add(dataPoint2);
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.Name = "RamUsage";
            this.chart1.Series.Add(series3);
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(555, 366);
            this.chart1.TabIndex = 18;
            this.chart1.Text = "chart1";
            // 
            // cpuTimer
            // 
            this.cpuTimer.Enabled = true;
            this.cpuTimer.Interval = 5000;
            this.cpuTimer.Tick += new System.EventHandler(this.cpuTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 621);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.totalRamLabel);
            this.Controls.Add(this.totalRamBox);
            this.Controls.Add(this.totalRamButton);
            this.Controls.Add(this.cpuNameLabel);
            this.Controls.Add(this.cpuNameBox);
            this.Controls.Add(this.cpuNameButton);
            this.Controls.Add(this.UserNameLabel);
            this.Controls.Add(this.UserNameBox);
            this.Controls.Add(this.UserNameButton);
            this.Controls.Add(this.computerNameLabel);
            this.Controls.Add(this.computerNameBox);
            this.Controls.Add(this.computerName);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button computerName;
        private System.Windows.Forms.TextBox computerNameBox;
        private System.Windows.Forms.Label computerNameLabel;
        private System.Windows.Forms.Button UserNameButton;
        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.TextBox UserNameBox;
        private System.Windows.Forms.Label cpuNameLabel;
        private System.Windows.Forms.TextBox cpuNameBox;
        private System.Windows.Forms.Button cpuNameButton;
        private System.Windows.Forms.Label totalRamLabel;
        private System.Windows.Forms.TextBox totalRamBox;
        private System.Windows.Forms.Button totalRamButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Timer cpuTimer;
    }
}

