namespace rtb2000_ivi
{
    partial class FrontPanel
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
      System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
      System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
      System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
      System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
      System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
      System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
      System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
      System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
      System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
      System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
      System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
      System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
      this.Run = new System.Windows.Forms.Button();
      this.Exit = new System.Windows.Forms.Button();
      this.viChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
      this.Timeout = new System.Windows.Forms.NumericUpDown();
      this.label7 = new System.Windows.Forms.Label();
      this.groupBox3 = new System.Windows.Forms.GroupBox();
      this.refMeterGroupBox = new System.Windows.Forms.GroupBox();
      this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
      this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
      this.statusStrip1 = new System.Windows.Forms.StatusStrip();
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.ferramentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.conectarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.desconetectarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.opçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      ((System.ComponentModel.ISupportInitialize)(this.viChart)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.Timeout)).BeginInit();
      this.groupBox3.SuspendLayout();
      this.refMeterGroupBox.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
      this.groupBox1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
      this.menuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // Run
      // 
      this.Run.Enabled = false;
      this.Run.Location = new System.Drawing.Point(138, 30);
      this.Run.Name = "Run";
      this.Run.Size = new System.Drawing.Size(123, 24);
      this.Run.TabIndex = 2;
      this.Run.Text = "Run Acquisition";
      this.Run.UseVisualStyleBackColor = true;
      // 
      // Exit
      // 
      this.Exit.Location = new System.Drawing.Point(138, 69);
      this.Exit.Name = "Exit";
      this.Exit.Size = new System.Drawing.Size(123, 27);
      this.Exit.TabIndex = 3;
      this.Exit.Text = "Exit Program";
      this.Exit.UseVisualStyleBackColor = true;
      // 
      // viChart
      // 
      chartArea5.Name = "ChartArea1";
      this.viChart.ChartAreas.Add(chartArea5);
      legend3.Name = "Legend1";
      legend3.Position.Auto = false;
      legend3.Position.Height = 17.75701F;
      legend3.Position.Width = 17.12204F;
      legend3.Position.X = 70F;
      legend3.Position.Y = 10F;
      this.viChart.Legends.Add(legend3);
      this.viChart.Location = new System.Drawing.Point(6, 19);
      this.viChart.Name = "viChart";
      series7.BorderWidth = 3;
      series7.ChartArea = "ChartArea1";
      series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
      series7.Color = System.Drawing.Color.Blue;
      series7.Legend = "Legend1";
      series7.Name = "Tensão";
      series8.BorderWidth = 3;
      series8.ChartArea = "ChartArea1";
      series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
      series8.Color = System.Drawing.Color.Red;
      series8.Legend = "Legend1";
      series8.Name = "Corrente";
      series8.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
      this.viChart.Series.Add(series7);
      this.viChart.Series.Add(series8);
      this.viChart.Size = new System.Drawing.Size(550, 215);
      this.viChart.TabIndex = 110;
      this.viChart.Text = "chart1";
      // 
      // Timeout
      // 
      this.Timeout.DecimalPlaces = 1;
      this.Timeout.Location = new System.Drawing.Point(22, 34);
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
      this.label7.Location = new System.Drawing.Point(20, 16);
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
      this.groupBox3.Location = new System.Drawing.Point(51, 252);
      this.groupBox3.Name = "groupBox3";
      this.groupBox3.Size = new System.Drawing.Size(276, 106);
      this.groupBox3.TabIndex = 113;
      this.groupBox3.TabStop = false;
      // 
      // refMeterGroupBox
      // 
      this.refMeterGroupBox.Controls.Add(this.chart1);
      this.refMeterGroupBox.Controls.Add(this.viChart);
      this.refMeterGroupBox.Location = new System.Drawing.Point(12, 32);
      this.refMeterGroupBox.Name = "refMeterGroupBox";
      this.refMeterGroupBox.Size = new System.Drawing.Size(570, 616);
      this.refMeterGroupBox.TabIndex = 114;
      this.refMeterGroupBox.TabStop = false;
      this.refMeterGroupBox.Text = "Medidor de Referência";
      // 
      // chart1
      // 
      chartArea6.Name = "ChartArea1";
      this.chart1.ChartAreas.Add(chartArea6);
      this.chart1.Location = new System.Drawing.Point(6, 285);
      this.chart1.Name = "chart1";
      series9.ChartArea = "ChartArea1";
      series9.Color = System.Drawing.Color.Blue;
      series9.Name = "freqs";
      this.chart1.Series.Add(series9);
      this.chart1.Size = new System.Drawing.Size(550, 215);
      this.chart1.TabIndex = 111;
      this.chart1.Text = "chart1";
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.chart2);
      this.groupBox1.Controls.Add(this.chart3);
      this.groupBox1.Controls.Add(this.groupBox3);
      this.groupBox1.Location = new System.Drawing.Point(588, 32);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(570, 616);
      this.groupBox1.TabIndex = 115;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Medidor em Análise";
      // 
      // chart2
      // 
      chartArea7.Name = "ChartArea1";
      this.chart2.ChartAreas.Add(chartArea7);
      this.chart2.Location = new System.Drawing.Point(6, 285);
      this.chart2.Name = "chart2";
      series10.ChartArea = "ChartArea1";
      series10.Color = System.Drawing.Color.Blue;
      series10.Name = "freqs";
      this.chart2.Series.Add(series10);
      this.chart2.Size = new System.Drawing.Size(550, 215);
      this.chart2.TabIndex = 111;
      this.chart2.Text = "chart2";
      // 
      // chart3
      // 
      chartArea8.Name = "ChartArea1";
      this.chart3.ChartAreas.Add(chartArea8);
      legend4.Name = "Legend1";
      legend4.Position.Auto = false;
      legend4.Position.Height = 17.75701F;
      legend4.Position.Width = 17.12204F;
      legend4.Position.X = 70F;
      legend4.Position.Y = 10F;
      this.chart3.Legends.Add(legend4);
      this.chart3.Location = new System.Drawing.Point(6, 19);
      this.chart3.Name = "chart3";
      series11.BorderWidth = 3;
      series11.ChartArea = "ChartArea1";
      series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
      series11.Color = System.Drawing.Color.Blue;
      series11.Legend = "Legend1";
      series11.Name = "Tensão";
      series12.BorderWidth = 3;
      series12.ChartArea = "ChartArea1";
      series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
      series12.Color = System.Drawing.Color.Red;
      series12.Legend = "Legend1";
      series12.Name = "Corrente";
      series12.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
      this.chart3.Series.Add(series11);
      this.chart3.Series.Add(series12);
      this.chart3.Size = new System.Drawing.Size(550, 215);
      this.chart3.TabIndex = 110;
      this.chart3.Text = "chart1";
      // 
      // statusStrip1
      // 
      this.statusStrip1.Location = new System.Drawing.Point(0, 665);
      this.statusStrip1.Name = "statusStrip1";
      this.statusStrip1.Size = new System.Drawing.Size(1169, 22);
      this.statusStrip1.TabIndex = 116;
      this.statusStrip1.Text = "statusStrip1";
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.ferramentasToolStripMenuItem,
            this.ajudaToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(1169, 24);
      this.menuStrip1.TabIndex = 117;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // arquivoToolStripMenuItem
      // 
      this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairToolStripMenuItem});
      this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
      this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
      this.arquivoToolStripMenuItem.Text = "A&rquivo";
      // 
      // sairToolStripMenuItem
      // 
      this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
      this.sairToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+F4";
      this.sairToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F4)));
      this.sairToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.sairToolStripMenuItem.Text = "Sai&r";
      // 
      // ferramentasToolStripMenuItem
      // 
      this.ferramentasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.conectarToolStripMenuItem,
            this.desconetectarToolStripMenuItem,
            this.toolStripSeparator1,
            this.opçõesToolStripMenuItem});
      this.ferramentasToolStripMenuItem.Name = "ferramentasToolStripMenuItem";
      this.ferramentasToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
      this.ferramentasToolStripMenuItem.Text = "&Ferramentas";
      // 
      // ajudaToolStripMenuItem
      // 
      this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobreToolStripMenuItem});
      this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
      this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
      this.ajudaToolStripMenuItem.Text = "&Ajuda";
      // 
      // conectarToolStripMenuItem
      // 
      this.conectarToolStripMenuItem.Name = "conectarToolStripMenuItem";
      this.conectarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.conectarToolStripMenuItem.Text = "&Conectar";
      // 
      // desconetectarToolStripMenuItem
      // 
      this.desconetectarToolStripMenuItem.Name = "desconetectarToolStripMenuItem";
      this.desconetectarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.desconetectarToolStripMenuItem.Text = "&Disconectar";
      // 
      // toolStripSeparator1
      // 
      this.toolStripSeparator1.Name = "toolStripSeparator1";
      this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
      // 
      // opçõesToolStripMenuItem
      // 
      this.opçõesToolStripMenuItem.Name = "opçõesToolStripMenuItem";
      this.opçõesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.opçõesToolStripMenuItem.Text = "&Opções";
      // 
      // sobreToolStripMenuItem
      // 
      this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
      this.sobreToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.sobreToolStripMenuItem.Text = "&Sobre";
      // 
      // FrontPanel
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1169, 687);
      this.Controls.Add(this.statusStrip1);
      this.Controls.Add(this.menuStrip1);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.refMeterGroupBox);
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "FrontPanel";
      this.Text = "Analisador de Fraudes em Medidores";
      this.Load += new System.EventHandler(this.FrontPanel_Load);
      ((System.ComponentModel.ISupportInitialize)(this.viChart)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.Timeout)).EndInit();
      this.groupBox3.ResumeLayout(false);
      this.refMeterGroupBox.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
      this.groupBox1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Run;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.DataVisualization.Charting.Chart viChart;
        private System.Windows.Forms.NumericUpDown Timeout;
        internal System.Windows.Forms.Label label7;
    private System.Windows.Forms.GroupBox groupBox3;
    private System.Windows.Forms.GroupBox refMeterGroupBox;
    private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
    private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
    private System.Windows.Forms.StatusStrip statusStrip1;
    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem ferramentasToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem conectarToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem desconetectarToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    private System.Windows.Forms.ToolStripMenuItem opçõesToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
  }
}

