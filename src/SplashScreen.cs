using System.Windows.Forms;

namespace rtb2000_ivi
{
  public partial class SplashScreen : Form
  {
    private delegate void ProgressDelegate(int progress);
    private ProgressDelegate del;

    public SplashScreen()
    {
      InitializeComponent();

      this.progressBar1.Maximum = 100;
      del = this.UpdateProgressBarInternal;
    }

    private void UpdateProgressBarInternal(int progress)
    {
      if (this.Handle == null)
      {
        return;
      }
      this.progressBar1.Value = progress;
    }

    public void UpdateProgressBar(int progress)
    {
      this.Invoke(del, progress);
    }

  }
}
