using System;
using System.Windows.Forms;

namespace Mini_Mart_Pos
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Set Form1 (Login) as the startup form
            Application.Run(new Form1());
        }
    }
}