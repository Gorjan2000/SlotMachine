using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlotMachine
{
    public partial class Info2 : Form
    {
        public Info2()
        {
            InitializeComponent();
            pbCherry.Image = Properties.Resources.cresa;
            pbLemon.Image = Properties.Resources.limon;
            pbDollar.Image = Properties.Resources.dolar;
            pbApple.Image = Properties.Resources.jabuka;
            pbGrape.Image = Properties.Resources.grozje;
            pbWatermelon.Image = Properties.Resources.watermelon;
            pbScatter.Image = Properties.Resources.dzvezda;
            pb7.Image = Properties.Resources.seven;
        }
    }
}
