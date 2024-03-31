using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5_Balls
{
    public partial class Menu : Form
    {
        private int formId = 2;
        public Menu()
        {
            InitializeComponent();
        }

        private void setVariables()
        {
            Properties.Settings.Default.vCoef = (int)vCoefBox.Value;
            Properties.Settings.Default.countEll = (int)countEllBox.Value;
            if (danZoneRadio.Checked)
            {
                Properties.Settings.Default.version = 0;
            }
            else if (wallRadio.Checked)
            {
                Properties.Settings.Default.version = 1;
            }
            Properties.Settings.Default.Save();

            Program.switchForm(formId);
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            setVariables();

            Program.switchForm(formId);
        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            setVariables();

            Program.switchForm(formId);
        }

        public void formShow()
        {
            vCoefBox.Value = Properties.Settings.Default.vCoef;
            countEllBox.Value = Properties.Settings.Default.countEll;
            switch (Properties.Settings.Default.version)
            {
                case 0:
                    danZoneRadio.Enabled = true; break;

                case 1:
                    wallRadio.Enabled = true; break;
            }

            this.Show();
        }
    }
}
