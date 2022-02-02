using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rtb2000_ivi
{
  public class Loader
  {
    private const int TIMER_TICK_MS = 100;
    private const int TIMER_TIMEOUT = 2000;
    private int time_elapsed;

    private static System.Timers.Timer timer1;

    public event EventHandler<LoaderEventArgs> ProgressChanged;
    public event EventHandler                  LoaderDone;

    public Loader()
    {
      /* Cria e configura novo timer */

      timer1 = new System.Timers.Timer(TIMER_TICK_MS);
      timer1.Elapsed += (o, e) =>
      {
        time_elapsed += TIMER_TICK_MS;
        if (time_elapsed >= TIMER_TIMEOUT)
        {
          timer1.Stop();
          timer1.Dispose();
          this.OnProgressChanged(100);
          this.OnLoaderDone();
        }
        else
        {
          this.OnProgressChanged((int)(time_elapsed * 100) / TIMER_TIMEOUT);
        }
      };
    }

    private void OnProgressChanged(int progress)
    {
      var handler = this.ProgressChanged;
      if (handler != null)
      {
        handler(this, new LoaderEventArgs(progress));
      }
    }

    private void OnLoaderDone()
    {
      var handler = this.LoaderDone;
      if(handler != null)
      {
        handler(this, EventArgs.Empty);
      }
    }

    public void DoLoader()
    {
      timer1.AutoReset = true;
      timer1.Enabled = true;
    }

  }

  public class LoaderEventArgs : EventArgs
  {
    public int Progress { get; private set; }

    public LoaderEventArgs(int progress)
    {
      this.Progress = progress;
    }


  }
}
