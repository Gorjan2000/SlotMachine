using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlotMachine
{
    [Serializable]
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            playTapSound();
            PlayForm form = new PlayForm();
            form.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            playTapSound();
            if (MessageBox.Show("Are you sure want to exit?", "Exit Slot Machine", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            playTapSound();
            MessageBox.Show("1. Click on Input Money\n" +
                            "2. Select starting amount of money with +/-\n" +
                            "3. Click PAY TABLE button\n" +
                            "4. Click on BET button\n" +
                            "5. Select wanted bet with +/-\n" +
                            "6. To play click on SPIN or AUTO SPIN\n" +
                            "NOTE: If you want to change the bet during the game," +
                            "\nfirst you must click on BET button and then change with +/-", "Info Slot Machine");
        }

        private void playTapSound()
        {
            string sCurrentDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string tap = System.IO.Path.Combine(sCurrentDirectory, @"..\..\..\SlotMachine\Resources\rolling1.wav");
            string tap_path = Path.GetFullPath(tap);

            SoundPlayer tapSound = new SoundPlayer(tap_path);
            tapSound.Play();
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

        private void StartForm_Load(object sender, EventArgs e)
        {
            oldSize = base.Size;
        }
    }
}
