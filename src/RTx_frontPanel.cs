using System;
using System.IO;
using System.Windows.Forms;
using RohdeSchwarz.RsRtx;
using Ivi.Driver;

namespace ReadWaveformExample
{
  public partial class RTx_frontPanel : Form
  {
    RsRtx driver;
    double[] pointsArr;

    public RTx_frontPanel()
    {
      InitializeComponent();
      Disconnect.Enabled = false;
    }

    private void Connect_Click(object sender, EventArgs e)
    {
      int chan;
      string[] chanArr = { "CH1", "CH2", "CH3", "CH4" };

      Connect.Enabled = true;
      Disconnect.Enabled = false;
      try
      {
        Run.Enabled = false;

        if (driver == null)
            driver = new RsRtx(ResourceDescriptor.Text, IDQuery.Checked, ResetDevice.Checked,"Simulate=0");

        Connect.Enabled = false;
        Disconnect.Enabled = true;

        Run.Enabled = true;
      }
      catch (Exception ex)
      {
        String message;

        message = "Instrument Status Error: ";
        message += ex.Message;
        MessageBox.Show(message);
      }

      try
      {
        /* Read Scope Setup */

        Console.WriteLine("Trigger SourceA:     {0:D}\n", driver.Trigger.SourceA);
        Console.WriteLine("Trigger Edge SlopeA: {0:D}\n", driver.Trigger.Edge.SlopeA);
        Console.WriteLine("Horizontal Scale:    {0:N}\n", driver.Acquisition.HorizontalScale);

        /* Enable scope channels */

        for (chan = 0; chan < 4; chan++)
        {
          string channelRepCap = chanArr[chan];

          if (driver.Channel[channelRepCap].Enabled)
          {
            Console.WriteLine("Channel " + channelRepCap);
            Console.WriteLine("\tVertical Scale:  {0:N}\n", driver.Channel[channelRepCap].VerticalScale);
            Console.WriteLine("\tVertical Offset: {0:N}\n", driver.Channel[channelRepCap].Offset);
            Console.WriteLine("\tTrigger LevelA:  {0:N}\n", driver.Trigger.Channel[channelRepCap].LevelA);
          }
        }
      }

      catch (Exception ex)
      {
        String message;

        message = "Error: ";
        message += ex.Message;
        MessageBox.Show(message);
      }



    }

    private void Disconnect_Click(object sender, EventArgs e)
    {
      Connect.Enabled = true;
      Disconnect.Enabled = false;

      Run.Enabled = false;
      try
      {
        if (driver != null)
        {
          driver.Close();
          driver.Dispose();
          driver = null;

          Connect.Enabled = true;
          Disconnect.Enabled = false;
        }
      }
      catch (Exception ex)
      {
        String message;

        message = "Instrument Status Error: ";
        message += ex.Message;
        MessageBox.Show(message);
      }
    }

    private void Run_Click(object sender, EventArgs e)
    {
      Run.Enabled = false;
      chart1.UseWaitCursor = true;
      string[] chanArr = { "CH1", "CH2", "CH3", "CH4" };
      PrecisionTimeSpan maximumTime = PrecisionTimeSpan.FromSeconds(Convert.ToDouble(Timeout.Text));
      IWaveform<double> waveform = null;

      try
      {
        int chan = 0;

        if (!driver.Channel[chanArr[chan]].Enabled)
            driver.Channel[chanArr[chan]].Enabled = true;

        waveform = driver.WaveformAcquisition.Waveform[chanArr[chan]].ReadWaveform(maximumTime, waveform);
                
        pointsArr = new double[waveform.Capacity];
        pointsArr = waveform.GetAllElements();

        chart1.Series["Series1"].Points.Clear();

        foreach (double d in pointsArr)
            chart1.Series["Series1"].Points.AddY(d);
                
        chart1.Update();
      }
      catch (Exception ex)
      {
        String message;

        message = "Instrument Status Error: ";
        message += ex.Message;
        MessageBox.Show(message);
        driver.UtilityFunctions.ClearStatus();
      }

      finally
      {
        Run.Enabled = true;
      }
    }

    private void Exit_Click(object sender, EventArgs e)
    {
      Close();
    }

    private void Form1_FormClosing(object sender, FormClosingEventArgs e)
    {
      if (driver != null)
      {
        driver.Close();
        driver.Dispose();
      }            
    }

  }
}
