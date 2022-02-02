using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace rtb2000_ivi
{
  static class Program
  {
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);

      //FrontPanel frontPanel = new FrontPanel();
      //frontPanel.Show();

      //Application.Run();
      Application.Run(new FrontPanel());
    }
  }
}
