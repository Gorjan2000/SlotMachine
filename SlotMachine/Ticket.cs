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
        private Graphics gfxScreenshot;

        public Ticket()
        {
            InitializeComponent();
            path = null;
        }

        private void Ticket_Load(object sender, EventArgs e)
        {
            tbTime.Text = DateTime.Now.ToString("HH:mm:ss");
            tbDate.Text = DateTime.UtcNow.Date.ToString("dd/MM/yyyy");

            string amount = ((PlayForm)f).credit.ToString();
            tbAmount.Text = string.Format("${0}.00", amount);

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
