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
    [Serializable]
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

        private void Info2_Load(object sender, EventArgs e)
        {
            oldSize = base.Size;
        }

        private Size oldSize;


        protected override void OnResize(System.EventArgs e)
        {
            base.OnResize(e);

            foreach (Control cnt in this.Controls)
                ResizeAll(cnt, base.Size);

            oldSize = base.Size;
        }
        private void ResizeAll(Control control, Size newSize)
        {
            int width = newSize.Width - oldSize.Width;
            control.Left += (control.Left * width) / oldSize.Width;
            control.Width += (control.Width * width) / oldSize.Width;

            int height = newSize.Height - oldSize.Height;
            control.Top += (control.Top * height) / oldSize.Height;
            control.Height += (control.Height * height) / oldSize.Height;
        }
    }
}
