using System;
using System.Windows.Forms;

namespace KGV_lab_5
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        public static Form1 form1;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            form1 = new Form1();
            Application.Run(form1);
        }
    }
}
