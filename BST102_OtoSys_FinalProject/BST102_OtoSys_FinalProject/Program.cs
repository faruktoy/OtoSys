using System;
using System.Windows.Forms;
using BST102_OtoSys_FinalProject; // Form1 bu namespace içinde tanýmlý

namespace BST102_OtoSys_FinalProject
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();                    // Görsel temayý etkinleþtirir
            Application.SetCompatibleTextRenderingDefault(false); // Varsayýlan yazý biçimini kullanýr
            Application.Run(new LoginForm());                         // Form1 arayüzü baþlatýlýr
        }
    }
}
