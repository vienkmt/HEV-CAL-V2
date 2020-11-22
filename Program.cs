using System;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace HEV_Agent_V2
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool createdNew;

            Mutex m = new Mutex(true, "HEV_CAL", out createdNew);
            if (!createdNew)
            {
                // myApp is already running...
                MessageBox.Show("Phần mềm vẫn còn bận nhiều việc nên chưa tắt hẳn, hãy dùng Task Manager để End Task HEV_CAL rồi mở lại");
                return;
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmAgentScrew());
        }
    }
}