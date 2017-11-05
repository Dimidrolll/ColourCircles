using System;
using System.Windows.Forms;
using System.Diagnostics;

namespace ColourCircles
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Process.GetCurrentProcess().ProcessorAffinity = (IntPtr)1;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
