using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlotMachine
{
    [Serializable]
    public partial class Ticket : Form
    {

        Form f = Application.OpenForms["PlayForm"];
        string path;

        public Ticket()
        {
            InitializeComponent();
            path = null;
        }

        private void tbDate_TextChanged(object sender, EventArgs e)
        {

        }

        private Size oldSize;
        private Graphics gfxScreenshot;

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

        private void Ticket_Load(object sender, EventArgs e)
        {
            tbTime.Text = DateTime.Now.ToString("HH:mm:ss");
            tbDate.Text = DateTime.UtcNow.Date.ToString("dd/MM/yyyy");

            string amount = ((PlayForm)f).credit.ToString();
            tbAmount.Text = string.Format("${0}.00", amount);
            oldSize = base.Size;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Save Ticket";
            sfd.Filter = "Ticket (*.jpg)|*.jpg";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                path = sfd.FileName;

                Bitmap bmp = new Bitmap(this.Width, this.Height, PixelFormat.Format32bppArgb);
                bmp = new Bitmap(this.Bounds.Width, this.Bounds.Height, PixelFormat.Format32bppArgb);
                gfxScreenshot = Graphics.FromImage(bmp);
                gfxScreenshot.CopyFromScreen(this.Bounds.X, this.Bounds.Y, 0, 0, this.Bounds.Size, CopyPixelOperation.SourceCopy);
                bmp.Save(path, ImageFormat.Png);
            }
        }
    }
}
