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
    public partial class PlayForm : Form
    {
        public Random random { get; set; }
        public int timerCount { get; set; }
        public int credit { get; set; }
        public int bet { get; set; }
        public int a { get; set; }
        public int b { get; set; }
        public int c { get; set; }
        public int d { get; set; }
        public int j { get; set; }
        public int f { get; set; }
        public int g { get; set; }
        public int h { get; set; }
        public int i { get; set; }
        public PlayForm()
        {
            InitializeComponent();
            btnBET.Enabled = false;//5
            //btnSPIN.Enabled = false;//2
            btnBETPlus.Enabled = false;//6
            btnBETMinus.Enabled = false;//7
            btnINPUT.Enabled = false;//1
            btnINPUTMinus.Enabled = false;//3
            btnINPUTPlus.Enabled = false;//4
            btnPAY.Enabled = false;//9
                                   // btnWITH.Enabled = true;8
            random = new Random();
            credit = 50;
            bet = 5;
            timerCount = 0;
            this.DoubleBuffered = true;
        }



        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void PlayForm_Load(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void btnINPUT_Click(object sender, EventArgs e)
        {
            btnBETPlus.Enabled = false;//6
            btnBETMinus.Enabled = false;//7
            btnPAY.Enabled = false;//9
            btnWITH.Enabled = true;//8
            timer1.Enabled = true;
            timer1.Interval = 50;

        }

        private void btnSPIN_Click(object sender, EventArgs e)
        {
            credit = 50;
            infolbl.Text = "CREDIT: " + "50 $";


            btnINPUTMinus.Enabled = true;//3
            btnPAY.Enabled = true;//9
            btnSPIN.Enabled = true;

        }

        private void btnINPUTMinus_Click(object sender, EventArgs e)
        {
            credit++;
            infolbl.Text = "CREDIT: " + credit.ToString() + " $";
            btnPAY.Enabled = true;//9
            btnINPUTPlus.Enabled = true;//4
        }

        private void btnINPUTPlus_Click(object sender, EventArgs e)
        {
            if ((credit > 0) && (bet < credit)) credit--;
            if (credit >= 0)
                infolbl.Text = "CREDIT: " + credit.ToString() + " $";
            if (credit == 0)
            {
                btnINPUT.Enabled = false;
                btnPAY.Enabled = false;
            }
            if (credit == 5) btnINPUTPlus.Enabled = false;
        }

        private void btnBET_Click(object sender, EventArgs e)
        {
            if ((bet <= credit) && (bet > 0)) btnSPIN.Enabled = true;
            btnBETPlus.Enabled = true;
            btnBETMinus.Enabled = true;
            betlbl.Text = "BET: " + bet.ToString() + " $";
        }
        private void btnBETPlus_Click(object sender, EventArgs e)
        {
            if (bet < credit)
            {
                btnBET.Enabled = true;
                bet++;
                betlbl.Text = "BET: " + bet.ToString() + " $";
            }
            btnBETMinus.Enabled = true;
        }

        private void btnBETMinus_Click(object sender, EventArgs e)
        {
            if (bet > 0) bet--;
            if (bet <= credit) btnINPUT.Enabled = true;
            betlbl.Text = "BET: " + bet.ToString() + " $";
            if (bet == 0)
            {
                btnINPUT.Enabled = false;
                btnBETMinus.Enabled = false;
            }
        }

        private void btnPAY_Click(object sender, EventArgs e)
        {
            btnSPIN.Enabled = false;
            btnINPUTMinus.Enabled = false;//inputminus
            btnINPUTPlus.Enabled = false;//inputplus
            btnPAY.Enabled = false;//pay
            btnBET.Enabled = true;//bet
        }

        private void btnWITH_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Vi blagodarime!\n Dali mozebi sakate povtorno da igrate?", "Kraj na igrata", MessageBoxButtons.YesNo);
            if (result1 == DialogResult.Yes)
            {
                btnINPUT.Enabled = false;
                btnBET.Enabled = false;
                btnINPUTMinus.Enabled = false;
                btnINPUTPlus.Enabled = false;
                btnBETPlus.Enabled = false;
                btnBETMinus.Enabled = false;
                btnPAY.Enabled = false;
                btnWITH.Enabled = false;
                btnSPIN.Enabled = true;
                credit = 50;
                bet = 5;
                infolbl.Text = "CREDIT: ";
                betlbl.Text = "BET: ";
                lblMsg.Text = "";
            }
            else Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timerCount += 10;
            if (timerCount < 100)
            {

                a = 1 + random.Next(9);

                b = 1 + random.Next(9);

                c = 1 + random.Next(9);
                d = 1 + random.Next(9);
                j = 1 + random.Next(9);
                f = 1 + random.Next(9);
                g = 1 + random.Next(9);
                h = 1 + random.Next(9);
                i = 1 + random.Next(9);


                switch (a)
                {
                    case 1:
                        pb1.Image = Bitmap.FromFile(@"..\SlotMachine\Resources\grapes-512.png");
                        break;
                    case 2:
                        pb1.Image = Bitmap.FromFile(@"..\SlotMachine\Resources\grapes-512.png");
                        break;
                    case 3:
                        pb1.Image = Bitmap.FromFile(@"..\SlotMachine\Resources\grapes-512.png");
                        break;

                }

                switch (b)
                {
                    case 1:
                        pb1.Image = Bitmap.FromFile(@"..\SlotMachine\Resources\casino_7-512 (1).png");
                        break;
                    case 2:
                        pb1.Image = Bitmap.FromFile(@"..\SlotMachine\Resources\casino_7-512 (1).png");
                        break;
                    case 3:
                        pb1.Image = Bitmap.FromFile(@"..\SlotMachine\Resources\casino_7-512 (1).png");
                        break;

                }
                switch (c)
                {
                    case 1:
                        pb1.Image = Bitmap.FromFile(@"..\SlotMachine\Resources\casino_7-512 (1).png");
                        break;
                    case 2:
                        pb1.Image = Bitmap.FromFile(@"..\SlotMachine\Resources\casino_7-512 (1).png");
                        break;
                    case 3:
                        pb1.Image = Bitmap.FromFile(@"..\SlotMachine\Resources\casino_7-512 (1).png");
                        break;

                }

            }
            else
            {
                timer1.Enabled = false;
                timerCount = 0;
                if ((a == b) && (a == c))
                {
                    lblMsg.Text = "Jackpot! You won " + (2 * bet).ToString() + " $!!!";
                    credit = credit + bet;
                    infolbl.Text = "CREDIT: " + credit.ToString() + " $";

                }
                else
                {
                    lblMsg.Text = "No luck, try again";
                    credit = credit - bet;
                    infolbl.Text = "CREDIT: " + credit.ToString() + " $";
                    if (credit < bet)
                    {
                        btnINPUT.Enabled = false;

                    }
                    if (credit == 0)
                    {
                        btnSPIN.Enabled = true;
                        btnWITH.Enabled = false;
                        btnBET.Enabled = false;

                    }
                }

            }
        }
    }
}
