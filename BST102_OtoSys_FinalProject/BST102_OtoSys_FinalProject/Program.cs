using System;
using System.Windows.Forms;
using BST102_OtoSys_FinalProject;

namespace BST102_OtoSys_FinalProject
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();                    
            Application.SetCompatibleTextRenderingDefault(false); 
            Application.Run(new LoginForm());                         
        }
    }
}
