using authorization;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reshala
{
    public partial class Switcher : Form
    {
       
        Gaus gaus = new Gaus();
        Zaidel zaidel = new Zaidel();
        public Switcher()
        {
            InitializeComponent();
        }

        private void Switcher_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < tabControl1.TabCount - 1; i++)
            {
                tabControl1.SelectedIndex = i;
            }
            tabControl1.SelectedIndex = 0;
        }

        private void tabPage_Gaus_Enter(object sender, EventArgs e)
        {

          
            // AddNewTab(this.tabPage1, gause);
        }
        private void tabPage_Zaidel_Enter(object sender, EventArgs e)
        {
            AddNewTab(this.tabPage2, zaidel);
        }
        private void AddNewTab(TabPage tab, Form frm)       /*Метод добавляющий форму в tabPage*/
        {
            frm.TopLevel = false;
            frm.Parent = tab;
            frm.Visible = true;

            frm.Location = new Point(0, 0);
            frm.FormBorderStyle = FormBorderStyle.None;

        }

        private void Switcher_FormClosing(object sender, FormClosingEventArgs e)
        {
            Sign_IN_OUT sign = new Sign_IN_OUT();
            sign.Show();
        }
    }
}
