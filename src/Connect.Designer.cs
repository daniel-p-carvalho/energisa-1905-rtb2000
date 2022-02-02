namespace rtb2000_ivi
{
  partial class Connect
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
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.ResourceDescriptor = new System.Windows.Forms.TextBox();
      this.ResetDevice = new System.Windows.Forms.CheckBox();
      this.IDQuery = new System.Windows.Forms.CheckBox();
      this.label4 = new System.Windows.Forms.Label();
      this.button1 = new System.Windows.Forms.Button();
      this.Disconnect = new System.Windows.Forms.Button();
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.ResourceDescriptor);
      this.groupBox1.Controls.Add(this.ResetDevice);
      this.groupBox1.Controls.Add(this.IDQuery);
      this.groupBox1.Controls.Add(this.label4);
      this.groupBox1.Controls.Add(this.button1);
      this.groupBox1.Controls.Add(this.Disconnect);
      this.groupBox1.Location = new System.Drawing.Point(12, 12);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(550, 107);
      this.groupBox1.TabIndex = 109;
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
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(16, 57);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(114, 26);
      this.button1.TabIndex = 0;
      this.button1.Text = "button1";
      this.button1.UseVisualStyleBackColor = true;
      // 
      // Disconnect
      // 
      this.Disconnect.Location = new System.Drawing.Point(136, 57);
      this.Disconnect.Name = "Disconnect";
      this.Disconnect.Size = new System.Drawing.Size(114, 26);
      this.Disconnect.TabIndex = 1;
      this.Disconnect.Text = "Disconnect";
      this.Disconnect.UseVisualStyleBackColor = true;
      // 
      // Connect
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.groupBox1);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "Connect";
      this.ShowIcon = false;
      this.Text = "ConnectForm";
      this.TopMost = true;
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.GroupBox groupBox1;
    internal System.Windows.Forms.TextBox ResourceDescriptor;
    internal System.Windows.Forms.CheckBox ResetDevice;
    internal System.Windows.Forms.CheckBox IDQuery;
    internal System.Windows.Forms.Label label4;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button Disconnect;
  }
}