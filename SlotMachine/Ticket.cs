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

        private void Ticket_Load(object sender, EventArgs e)
        {
            tbTime.Text = DateTime.Now.ToString("HH:mm:ss");
            tbDate.Text = DateTime.UtcNow.Date.ToString("dd/MM/yyyy");

            string amount = ((PlayForm)f).credit.ToString();
            tbAmount.Text = string.Format("${0},00",amount);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Save Ticket";
            sfd.Filter = "Ticket (*.jpg)|*.jpg";
            
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                path = sfd.FileName;
                using (Bitmap bmp = new Bitmap(this.Width, this.Height))
                {
                    this.DrawToBitmap(bmp, new Rectangle(Point.Empty, bmp.Size));
                    bmp.Save(path, ImageFormat.Png); 
                }
            }
        }
    }
}
