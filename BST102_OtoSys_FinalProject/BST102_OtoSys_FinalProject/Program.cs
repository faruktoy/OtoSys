using System;
using System.Windows.Forms;
using BST102_OtoSys_FinalProject; // Form1 bu namespace i�inde tan�ml�

namespace BST102_OtoSys_FinalProject
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();                    // G�rsel temay� etkinle�tirir
            Application.SetCompatibleTextRenderingDefault(false); // Varsay�lan yaz� bi�imini kullan�r
            Application.Run(new LoginForm());                         // Form1 aray�z� ba�lat�l�r
        }
    }
}
