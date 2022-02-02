using System;
using System.IO;
using System.Windows.Forms;
using RohdeSchwarz.RsRtx;
using Ivi.Driver;
using System.Threading;

namespace rtb2000_ivi
{
  public partial class FrontPanel : Form
  {
    private bool load_done;

    private SplashScreen splashScreen;

    public FrontPanel()
    {
      InitializeComponent();
    }

    private void WaitSplashScreen()
    {
      this.splashScreen = new SplashScreen();
      this.splashScreen.Show();

      while (!load_done)
      {
        Application.DoEvents();
      }

      splashScreen.Close();
      this.splashScreen.Dispose();
    }

    private void FrontPanel_Load(object sender, EventArgs e)
    {
      /* Carrega a SplashScreen em uma nova Thread */

      Loader loader = new Loader();
      loader.ProgressChanged += (o, ex) =>
      {
        this.splashScreen.UpdateProgressBar(ex.Progress);
      };

      loader.LoaderDone += (o, ex) =>
      {
        load_done = true;
      };

      Thread thread = new Thread(new ThreadStart(this.WaitSplashScreen));
      thread.Start();
      loader.DoLoader();
      thread.Join();
      this.Activate();
    }
  }
}
