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
    public partial class SwitcherV20 : Form
    {
        public SwitcherV20()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Если получится запихать в твое меню, то запихивай только форма вызывается так   ZaidelV20.ZaidelV20 zaidel = new ZaidelV20.ZaidelV20();

            ZaidelV20.ZaidelV20 zaidel = new ZaidelV20.ZaidelV20();
            zaidel.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
