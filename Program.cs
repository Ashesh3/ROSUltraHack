using RosPublicCheat;
using System;
using System.Windows.Forms;
using System.Threading;

namespace Whynot
{
    internal static class Program
    {
        private static void threadStart()
        {
            Application.Run(new menu());
        }

        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var thread = new Thread(threadStart);
            thread.TrySetApartmentState(ApartmentState.STA);
            thread.Start();
            Application.Run(new Main());
        }
    }
}
