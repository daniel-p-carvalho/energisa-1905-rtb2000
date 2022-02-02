namespace ReadWaveformExample
{
    partial class RTx_frontPanel
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
      System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
      this.Connect = new System.Windows.Forms.Button();
      this.Disconnect = new System.Windows.Forms.Button();
      this.Run = new System.Windows.Forms.Button();
      this.Exit = new System.Windows.Forms.Button();
      this.label3 = new System.Windows.Forms.Label();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.ResourceDescriptor = new System.Windows.Forms.TextBox();
      this.ResetDevice = new System.Windows.Forms.CheckBox();
      this.IDQuery = new System.Windows.Forms.CheckBox();
      this.label4 = new System.Windows.Forms.Label();
      this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
      this.Timeout = new System.Windows.Forms.NumericUpDown();
      this.label7 = new System.Windows.Forms.Label();
      this.groupBox3 = new System.Windows.Forms.GroupBox();
      this.groupBox1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.Timeout)).BeginInit();
      this.groupBox3.SuspendLayout();
      this.SuspendLayout();
      // 
      // Connect
      // 
      this.Connect.Location = new System.Drawing.Point(16, 57);
      this.Connect.Name = "Connect";
      this.Connect.Size = new System.Drawing.Size(114, 26);
      this.Connect.TabIndex = 0;
      this.Connect.Text = "Connect";
      this.Connect.UseVisualStyleBackColor = true;
      this.Connect.Click += new System.EventHandler(this.Connect_Click);
      // 
      // Disconnect
      // 
      this.Disconnect.Location = new System.Drawing.Point(136, 57);
      this.Disconnect.Name = "Disconnect";
      this.Disconnect.Size = new System.Drawing.Size(114, 26);
      this.Disconnect.TabIndex = 1;
      this.Disconnect.Text = "Disconnect";
      this.Disconnect.UseVisualStyleBackColor = true;
      this.Disconnect.Click += new System.EventHandler(this.Disconnect_Click);
      // 
      // Run
      // 
      this.Run.Enabled = false;
      this.Run.Location = new System.Drawing.Point(418, 27);
      this.Run.Name = "Run";
      this.Run.Size = new System.Drawing.Size(123, 24);
      this.Run.TabIndex = 2;
      this.Run.Text = "Run Acquisition";
      this.Run.UseVisualStyleBackColor = true;
      this.Run.Click += new System.EventHandler(this.Run_Click);
      // 
      // Exit
      // 
      this.Exit.Location = new System.Drawing.Point(418, 66);
      this.Exit.Name = "Exit";
      this.Exit.Size = new System.Drawing.Size(123, 27);
      this.Exit.TabIndex = 3;
      this.Exit.Text = "Exit Program";
      this.Exit.UseVisualStyleBackColor = true;
      this.Exit.Click += new System.EventHandler(this.Exit_Click);
      // 
      // label3
      // 
      this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.label3.ForeColor = System.Drawing.Color.SteelBlue;
      this.label3.Location = new System.Drawing.Point(131, 23);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(370, 48);
      this.label3.TabIndex = 107;
      this.label3.Text = "Rohde && Schwarz RT2000 Digital Oscilloscope Read Waveform";
      this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.ResourceDescriptor);
      this.groupBox1.Controls.Add(this.ResetDevice);
      this.groupBox1.Controls.Add(this.IDQuery);
      this.groupBox1.Controls.Add(this.label4);
      this.groupBox1.Controls.Add(this.Connect);
      this.groupBox1.Controls.Add(this.Disconnect);
      this.groupBox1.Location = new System.Drawing.Point(43, 75);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(550, 107);
      this.groupBox1.TabIndex = 108;
      this.groupBox1.TabStop = false;
      // 
      // ResourceDescriptor
      // 
      this.ResourceDescriptor.Location = new System.Drawing.Point(16, 31);
      this.ResourceDescriptor.Name = "ResourceDescriptor";
      this.ResourceDescriptor.Size = new System.Drawing.Size(234, 20);
      this.ResourceDescriptor.TabIndex = 1;
      this.ResourceDescriptor.Text = "TCPIP::200.19.148.160::INSTR";
      // 
      // ResetDevice
      // 
      this.ResetDevice.Checked = true;
      this.ResetDevice.CheckState = System.Windows.Forms.CheckState.Checked;
      this.ResetDevice.Location = new System.Drawing.Point(419, 31);
      this.ResetDevice.Name = "ResetDevice";
      this.ResetDevice.Size = new System.Drawing.Size(96, 18);
      this.ResetDevice.TabIndex = 3;
      this.ResetDevice.Text = "Reset Device";
      // 
      // IDQuery
      // 
      this.IDQuery.Checked = true;
      this.IDQuery.CheckState = System.Windows.Forms.CheckState.Checked;
      this.IDQuery.Location = new System.Drawing.Point(341, 31);
      this.IDQuery.Name = "IDQuery";
      this.IDQuery.Size = new System.Drawing.Size(72, 18);
      this.IDQuery.TabIndex = 2;
      this.IDQuery.Text = "ID Query";
      // 
      // label4
      // 
      this.label4.Location = new System.Drawing.Point(17, 12);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(120, 16);
      this.label4.TabIndex = 40;
      this.label4.Text = "Resource Descriptor";
      // 
      // chart1
      // 
      chartArea1.Name = "ChartArea1";
      this.chart1.ChartAreas.Add(chartArea1);
      this.chart1.Location = new System.Drawing.Point(43, 334);
      this.chart1.Name = "chart1";
      series1.ChartArea = "ChartArea1";
      series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
      series1.IsVisibleInLegend = false;
      series1.Name = "Series1";
      this.chart1.Series.Add(series1);
      this.chart1.Size = new System.Drawing.Size(550, 215);
      this.chart1.TabIndex = 110;
      this.chart1.Text = "chart1";
      // 
      // Timeout
      // 
      this.Timeout.DecimalPlaces = 1;
      this.Timeout.Location = new System.Drawing.Point(302, 31);
      this.Timeout.Name = "Timeout";
      this.Timeout.Size = new System.Drawing.Size(110, 20);
      this.Timeout.TabIndex = 86;
      this.Timeout.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      this.Timeout.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
      // 
      // label7
      // 
      this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.label7.Location = new System.Drawing.Point(300, 13);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(113, 15);
      this.label7.TabIndex = 87;
      this.label7.Text = "Acquisition Timeout [s]";
      // 
      // groupBox3
      // 
      this.groupBox3.Controls.Add(this.label7);
      this.groupBox3.Controls.Add(this.Timeout);
      this.groupBox3.Controls.Add(this.Run);
      this.groupBox3.Controls.Add(this.Exit);
      this.groupBox3.Location = new System.Drawing.Point(43, 188);
      this.groupBox3.Name = "groupBox3";
      this.groupBox3.Size = new System.Drawing.Size(550, 106);
      this.groupBox3.TabIndex = 113;
      this.groupBox3.TabStop = false;
      // 
      // RTx_frontPanel
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1275, 687);
      this.Controls.Add(this.groupBox3);
      this.Controls.Add(this.chart1);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.label3);
      this.Name = "RTx_frontPanel";
      this.Text = "ENERGISA";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.Timeout)).EndInit();
      this.groupBox3.ResumeLayout(false);
      this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Connect;
        private System.Windows.Forms.Button Disconnect;
        private System.Windows.Forms.Button Run;
        private System.Windows.Forms.Button Exit;
        internal System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        internal System.Windows.Forms.TextBox ResourceDescriptor;
        internal System.Windows.Forms.CheckBox ResetDevice;
        internal System.Windows.Forms.CheckBox IDQuery;
        internal System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.NumericUpDown Timeout;
        internal System.Windows.Forms.Label label7;
    private System.Windows.Forms.GroupBox groupBox3;
  }
}

