using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5_Balls
{
    public static class Program
    {

        private static Form1 form1;
        private static Menu form2;
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            form1 = new Form1();
            form2 = new Menu();
            Application.Run(form1);
        }

        public static void switchForm(int id)
        {
            switch(id)
            {
                case 1:
                    form1.Hide();
                    form2.formShow();
                    break;

                case 2:
                    form2.Hide();
                    form1.formShow();
                    break;
            }
        }
    }
}
