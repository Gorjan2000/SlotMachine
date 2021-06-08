using System;
using System.IO;
using System.Media;
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
        public bool timerFlag { get; set; }
        public int temp;

        // string grozje = Path.GetFullPath(@"SlotMachine\Resources\grozje.png");
        //string dzveza = Path.GetFullPath(@"SlotMachine\Resources\dzvezda.png");
        //string limon = Path.GetFullPath(@"SlotMachine\Resources\limon.png");
        //string dolar = Path.GetFullPath(@"SlotMachine\Resources\dolar.png");
        //string watermelon = Path.GetFullPath(@"SlotMachine\Resources\watermelon.png");
        //string jabuka = Path.GetFullPath(@"SlotMachine\Resources\jabuka.png");
        //string cresa = Path.GetFullPath(@"SlotMachine\Resources\cresa.png");
        //string seven = Path.GetFullPath(@"SlotMachine\Resources\seven.png");



        public PlayForm()
        {
            
            InitializeComponent();
            btnSPIN.Enabled = false;
            btnBET.Enabled = false;
            btnINPUTPlus.Enabled = false;
            btnINPUTMinus.Enabled = false;
            btnBETPlus.Enabled = false;
            btnBETMinus.Enabled = false;
            btnPAY.Enabled = false;
            btnCASH.Enabled = false;
            btnAutoSpin.Enabled = false;
            timerFlag = false;
            random = new Random();
            credit = 50;
            bet = 5;
            timerCount = 0;
            temp = 0;
            this.DoubleBuffered = true;
        }


        private void PlayForm_Load(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void btnSPIN_Click(object sender, EventArgs e)
        {
            
            btnBETPlus.Enabled = false;
            btnBETMinus.Enabled = false;
            btnPAY.Enabled = false;
            btnCASH.Enabled = true;
            timer1.Enabled = true;
            timer1.Interval = 50;
            playRollingSound();
        }
        private void btnSPIH2(object sender, EventArgs e)
        {

            btnBETPlus.Enabled = false;
            btnBETMinus.Enabled = false;
            btnPAY.Enabled = false;
            btnCASH.Enabled = true;
            timer1.Enabled = true;
            timer1.Interval = 300;
            playRollingSound();
        }




        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }
        private void dobivka(int koeficient,int dupliranje=1)
        {
            playWinSound();
            lblMsg.Text = "Jackpot! You won " + (dupliranje*koeficient * bet).ToString() + " $!!!";
            credit = credit +(dupliranje* (koeficient * bet));
            infolbl.Text = "CREDIT: " + credit.ToString() + " $";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            timerCount = timerCount + 10;
            if (timerCount < 200)
            {
                
                a = 1+random.Next(9);
                b = 1 + random.Next(9);
                c = 1 + random.Next(9);
                d = 1 + random.Next(9);
                f = 1 + random.Next(9);
                g = 1 + random.Next(9);
                h = 1 + random.Next(9);
                i = 1 + random.Next(9);
                j = 1 + random.Next(9);
                

                switch (a)
                {
                    case 1:
                        pb1.Image = Properties.Resources.cresa;
                        break;
                    case 2:
                        pb1.Image = Properties.Resources.dolar;
                        break;
                    case 3:
                        pb1.Image = Properties.Resources.jabuka;
                        break;
                    case 4:
                        pb1.Image = Properties.Resources.limon;
                        break;
                    case 5:
                        pb1.Image = Properties.Resources.grozje;
                        break;
                    case 6:
                        pb1.Image = Properties.Resources.dzvezda;
                        break;
                    case 7:
                        pb1.Image = Properties.Resources.seven;
                        break;
                    case 8:
                        pb1.Image = Properties.Resources.watermelon;
                        break;
                   

                }

                switch (b)
                {
                    case 1:
                        pb2.Image = Properties.Resources.cresa;
                        break;
                    case 2:
                        pb2.Image = Properties.Resources.dolar;
                        break;
                    case 3:
                        pb2.Image = Properties.Resources.jabuka;
                        break;
                    case 4:
                        pb2.Image = Properties.Resources.limon;
                        break;
                    case 5:
                        pb2.Image = Properties.Resources.grozje;
                        break;
                    case 6:
                        pb2.Image = Properties.Resources.dzvezda;
                        break;
                    case 7:
                        pb2.Image = Properties.Resources.seven;
                        break;
                    case 8:
                        pb2.Image = Properties.Resources.watermelon;
                        break;

                }
                switch (c)
                {
                    case 1:
                        pb3.Image = Properties.Resources.cresa;
                        break;
                    case 2:
                        pb3.Image = Properties.Resources.dolar;
                        break;
                    case 3:
                        pb3.Image = Properties.Resources.jabuka;
                        break;
                    case 4:
                        pb3.Image = Properties.Resources.limon;
                        break;
                    case 5:
                        pb3.Image = Properties.Resources.grozje;
                        break;
                    case 6:
                        pb3.Image = Properties.Resources.dzvezda;
                        break;
                    case 7:
                        pb3.Image = Properties.Resources.seven;
                        break;
                    case 8:
                        pb3.Image = Properties.Resources.watermelon;
                        break;

                }
                switch (d)
                {
                    case 1:
                        pb4.Image = Properties.Resources.cresa;
                        break;
                    case 2:
                        pb4.Image = Properties.Resources.dolar;
                        break;
                    case 3:
                        pb4.Image = Properties.Resources.jabuka;
                        break;
                    case 4:
                        pb4.Image = Properties.Resources.limon;
                        break;
                    case 5:
                        pb4.Image = Properties.Resources.grozje;
                        break;
                    case 6:
                        pb4.Image = Properties.Resources.dzvezda;
                        break;
                    case 7:
                        pb4.Image = Properties.Resources.seven;
                        break;
                    case 8:
                        pb4.Image = Properties.Resources.watermelon;
                        break;

                }
                switch (f)
                {
                    case 1:
                        pb5.Image = Properties.Resources.cresa;
                        break;
                    case 2:
                        pb5.Image = Properties.Resources.dolar;
                        break;
                    case 3:
                        pb5.Image = Properties.Resources.jabuka;
                        break;
                    case 4:
                        pb5.Image = Properties.Resources.limon;
                        break;
                    case 5:
                        pb5.Image = Properties.Resources.grozje;
                        break;
                    case 6:
                        pb5.Image = Properties.Resources.dzvezda;
                        break;
                    case 7:
                        pb5.Image = Properties.Resources.seven;
                        break;
                    case 8:
                        pb5.Image = Properties.Resources.watermelon;
                        break;

                }
                switch (g)
                {
                    case 1:
                        pb6.Image = Properties.Resources.cresa;
                        break;
                    case 2:
                        pb6.Image = Properties.Resources.dolar;
                        break;
                    case 3:
                        pb6.Image = Properties.Resources.jabuka;
                        break;
                    case 4:
                        pb6.Image = Properties.Resources.limon;
                        break;
                    case 5:
                        pb6.Image = Properties.Resources.grozje;
                        break;
                    case 6:
                        pb6.Image = Properties.Resources.dzvezda;
                        break;
                    case 7:
                        pb6.Image = Properties.Resources.seven;
                        break;
                    case 8:
                        pb6.Image = Properties.Resources.watermelon;
                        break;

                }
                switch (h)
                {
                    case 1:
                        pb7.Image = Properties.Resources.cresa;
                        break;
                    case 2:
                        pb7.Image = Properties.Resources.dolar;
                        break;
                    case 3:
                        pb7.Image = Properties.Resources.jabuka;
                        break;
                    case 4:
                        pb7.Image = Properties.Resources.limon;
                        break;
                    case 5:
                        pb7.Image = Properties.Resources.grozje;
                        break;
                    case 6:
                        pb7.Image = Properties.Resources.dzvezda;
                        break;
                    case 7:
                        pb7.Image = Properties.Resources.seven;
                        break;
                    case 8:
                        pb7.Image = Properties.Resources.watermelon;
                        break;

                }
                switch (i)
                {
                    case 1:
                        pb8.Image = Properties.Resources.cresa;
                        break;
                    case 2:
                        pb8.Image = Properties.Resources.dolar;
                        break;
                    case 3:
                        pb8.Image = Properties.Resources.jabuka;
                        break;
                    case 4:
                        pb8.Image = Properties.Resources.limon;
                        break;
                    case 5:
                        pb8.Image = Properties.Resources.grozje;
                        break;
                    case 6:
                        pb8.Image = Properties.Resources.dzvezda;
                        break;
                    case 7:
                        pb8.Image = Properties.Resources.seven;
                        break;
                    case 8:
                        pb8.Image = Properties.Resources.watermelon;
                        break;

                }
                switch (j)
                {
                    case 1:
                        pb9.Image = Properties.Resources.cresa;
                        break;
                    case 2:
                        pb9.Image = Properties.Resources.dolar;
                        break;
                    case 3:
                        pb9.Image = Properties.Resources.jabuka;
                        break;
                    case 4:
                        pb9.Image = Properties.Resources.limon;
                        break;
                    case 5:
                        pb9.Image = Properties.Resources.grozje;
                        break;
                    case 6:
                        pb9.Image = Properties.Resources.dzvezda;
                        break;
                    case 7:
                        pb9.Image = Properties.Resources.seven;
                        break;
                    case 8:
                        pb9.Image = Properties.Resources.watermelon;
                        break;

                }

            }
            else
            {
             
                timer1.Enabled = false;
                timerCount = 0;
               
                if ((a == b) && (a == c))
                {
                    //prv red e ist
                    if ((d == f) && (f == g) && (a == d)&&(a==h)&&(h==i)&&(i==j))
                    {
                        if (a == 1)
                        {
                            //cresa
                            dobivka(2,3);
                        }
                        if (a == 2)
                        {
                            //dolar
                            dobivka(3,3);
                        }
                        if (a == 3)
                        {
                            dobivka(2,3);
                            //jabuka
                        }
                        if (a == 4)
                        {
                            dobivka(2,3);
                            //limon
                        }
                        if (a == 5)
                        {
                            dobivka(5,3);
                            //grozje
                        }
                        if (a == 6)
                        {
                            dobivka(5,3);
                            //dzvezda
                        }
                        if (a == 7)
                        {
                            dobivka(10,3);
                            //seven
                        }
                        if (a == 8)
                        {
                            dobivka(5,3);
                            //lubenica
                        }
                        //site redovi se isti
                        

                    }
                    else if((d == f) && (f == g) && (a == d))
                    {
                        if (a == 1)
                        {
                            //cresa
                            dobivka(2, 2);
                        }
                        if (a == 2)
                        {
                            //dolar
                            dobivka(3, 2);
                        }
                        if (a == 3)
                        {
                            dobivka(2, 2);
                            //jabuka
                        }
                        if (a == 4)
                        {
                            dobivka(2, 2);
                            //limon
                        }
                        if (a == 5)
                        {
                            dobivka(5, 2);
                            //grozje
                        }
                        if (a == 6)
                        {
                            dobivka(5, 2);
                            //dzvezda
                        }
                        if (a == 7)
                        {
                            dobivka(10, 2);
                            //seven
                        }
                        if (a == 8)
                        {
                            dobivka(5, 2);
                            //lubenica
                        }
                        //prv i vtor
                    }
                    else if((h == i) && (i == j) && (a == h))
                    {
                        //prv i tret se isti
                        if (a == 1)
                        {
                            //cresa
                            dobivka(2, 2);
                        }
                        if (a == 2)
                        {
                            //dolar
                            dobivka(3, 2);
                        }
                        if (a == 3)
                        {
                            dobivka(2, 2);
                            //jabuka
                        }
                        if (a == 4)
                        {
                            dobivka(2, 2);
                            //limon
                        }
                        if (a == 5)
                        {
                            dobivka(5, 2);
                            //grozje
                        }
                        if (a == 6)
                        {
                            dobivka(5, 2);
                            //dzvezda
                        }
                        if (a == 7)
                        {
                            dobivka(10, 2);
                            //seven
                        }
                        if (a == 8)
                        {
                            dobivka(5, 2);
                            //lubenica
                        }
                    }
                    else
                    {
                        if (a == 1)
                        {
                            //cresa
                            dobivka(2);
                        }
                        if (a == 2)
                        {
                            //dolar
                            dobivka(3);
                        }
                        if (a == 3)
                        {
                            dobivka(2);
                            //jabuka
                        }
                        if (a == 4)
                        {
                            dobivka(2);
                            //limon
                        }
                        if (a == 5)
                        {
                            dobivka(5);
                            //grozje
                        }
                        if (a == 6)
                        {
                            dobivka(5);
                            //dzvezda
                        }
                        if (a == 7)
                        {
                            dobivka(10);
                            //seven
                        }
                        if (a == 8)
                        {
                            dobivka(5);
                            //lubenica
                        }
                    }
                }
                if ((d == f) && (f == g))
                {
                    //vtor red e ist
                    if((h == i) && (i == j) && (h == d))
                    {
                        if (d == 1)
                        {
                            //cresa
                            dobivka(2, 2);
                        }
                        if (d == 2)
                        {
                            //dolar
                            dobivka(3, 2);
                        }
                        if (d == 3)
                        {
                            dobivka(2, 2);
                            //jabuka
                        }
                        if (d == 4)
                        {
                            dobivka(2, 2);
                            //limon
                        }
                        if (d == 5)
                        {
                            dobivka(5, 2);
                            //grozje
                        }
                        if (d == 6)
                        {
                            dobivka(5, 2);
                            //dzvezda
                        }
                        if (d == 7)
                        {
                            dobivka(10, 2);
                            //seven
                        }
                        if (d == 8)
                        {
                            dobivka(5, 2);
                            //lubenica
                        }
                        //vtor i tret red se isti
                    }
                    else
                    {
                        if (d == 1)
                        {
                            //cresa
                            dobivka(2, 2);
                        }
                        if (d == 2)
                        {
                            //dolar
                            dobivka(3, 2);
                        }
                        if (d == 3)
                        {
                            dobivka(2, 2);
                            //jabuka
                        }
                        if (d == 4)
                        {
                            dobivka(2, 2);
                            //limon
                        }
                        if (d == 5)
                        {
                            dobivka(5, 2);
                            //grozje
                        }
                        if (d == 6)
                        {
                            dobivka(5, 2);
                            //dzvezda
                        }
                        if (d == 7)
                        {
                            dobivka(10, 2);
                            //seven
                        }
                        if (d == 8)
                        {
                            dobivka(5, 2);
                            //lubenica
                        }
                    }

                }
                if ((h == i) && (i == j))
                {
                    //tret red e ist
                    if (h == 1)
                    {
                        //cresa
                        dobivka(2);
                    }
                    if (h == 2)
                    {
                        //dolar
                        dobivka(3);
                    }
                    if (h == 3)
                    {
                        dobivka(2);
                        //jabuka
                    }
                    if (h == 4)
                    {
                        dobivka(2);
                        //limon
                    }
                    if (h == 5)
                    {
                        dobivka(5);
                        //grozje
                    }
                    if (h == 6)
                    {
                        dobivka(5);
                        //dzvezda
                    }
                    if (h == 7)
                    {
                        dobivka(10);
                        //seven
                    }
                    if (h == 8)
                    {
                        dobivka(5);
                        //lubenica
                    }
                }
                if ((a == f) && (f == j))
                {

                    //glavna diagonala
                    if((c == f) && (f == h) && (h == a))
                    {
                        if (a == 1)
                        {
                            //cresa
                            dobivka(2,2);
                        }
                        if (a == 2)
                        {
                            //dolar
                            dobivka(3,2);
                        }
                        if (a == 3)
                        {
                            dobivka(2,2);
                            //jabuka
                        }
                        if (a == 4)
                        {
                            dobivka(2,2);
                            //limon
                        }
                        if (a == 5)
                        {
                            dobivka(5,2);
                            //grozje
                        }
                        if (a == 6)
                        {
                            dobivka(5,2);
                            //dzvezda
                        }
                        if (a == 7)
                        {
                            dobivka(10,2);
                            //seven
                        }
                        if (a == 8)
                        {
                            dobivka(5,2);
                            //lubenica
                        }
                        //glavna i sporedna
                    }
                    else
                    {
                        if (a == 1)
                        {
                            //cresa
                            dobivka(2);
                        }
                        if (a == 2)
                        {
                            //dolar
                            dobivka(3);
                        }
                        if (a == 3)
                        {
                            dobivka(2);
                            //jabuka
                        }
                        if (a == 4)
                        {
                            dobivka(2);
                            //limon
                        }
                        if (a == 5)
                        {
                            dobivka(5);
                            //grozje
                        }
                        if (a == 6)
                        {
                            dobivka(5);
                            //dzvezda
                        }
                        if (a == 7)
                        {
                            dobivka(10);
                            //seven
                        }
                        if (a == 8)
                        {
                            dobivka(5);
                            //lubenica
                        }
                    }
                }
                if ((c == f) && (f == h))
                {
                    //sporedna diagonala
                    if (h == 1)
                    {
                        //cresa
                        dobivka(2);
                    }
                    if (h == 2)
                    {
                        //dolar
                        dobivka(3);
                    }
                    if (h == 3)
                    {
                        dobivka(2);
                        //jabuka
                    }
                    if (h == 4)
                    {
                        dobivka(2);
                        //limon
                    }
                    if (h == 5)
                    {
                        dobivka(5);
                        //grozje
                    }
                    if (h == 6)
                    {
                        dobivka(5);
                        //dzvezda
                    }
                    if (h == 7)
                    {
                        dobivka(10);
                        //seven
                    }
                    if (h == 8)
                    {
                        dobivka(5);
                        //lubenica
                    }
                }

                else
                {
                    lblMsg.Text = "No luck, try again";
                    credit = credit - bet;
                    infolbl.Text = "CREDIT: " + credit.ToString() + " $";
                    if (credit < bet)
                    {
                        btnSPIN.Enabled = false;
                        btnAutoSpin.Enabled = false;
                        timer2.Stop();

                    }
                    if (credit <= 0)
                    {
                        MessageBox.Show("You don't have enough credits to play!", "Game Over");
                        btnSPIN.Enabled = false;
                        btnCASH.Enabled = true;
                        btnBET.Enabled = false;
                        btnAutoSpin.Enabled = false;
                        timer2.Stop();
                    }
                }

            }
        }
        private void btnINPUT_Click(object sender, EventArgs e)
        {
            credit = 50;
            infolbl.Text = "CREDIT: " + "50 $";

            btnINPUTPlus.Enabled = true;

            btnPAY.Enabled = true;
            btnINPUT.Enabled = false;


        }



        private void btnINPUTPlus_Click(object sender, EventArgs e)
        {
            credit+=5;
            infolbl.Text = "CREDIT: " + credit.ToString() + " $";
            btnPAY.Enabled = true;
            btnINPUTMinus.Enabled = true;

        }

        private void btnINPUTMinus_Click(object sender, EventArgs e)
        {
            if ((credit > 0) && (bet < credit)) credit-=5;
            if (credit >= 0)
                infolbl.Text = "CREDIT: " + credit.ToString() + " $";
            if (credit == 0)
            {
                btnSPIN.Enabled = false;
                btnAutoSpin.Enabled = false;
                btnPAY.Enabled = false;
            }
            if (credit == 5) btnINPUTMinus.Enabled = false;


        }

        private void btnBET_Click(object sender, EventArgs e)
        {
            if ((bet <= credit) && (bet > 0))
            {
                btnSPIN.Enabled = true;
                btnAutoSpin.Enabled = true;
            }
            btnBETPlus.Enabled = true;
            btnBETMinus.Enabled = true;
            betlbl.Text = "BET: " + bet.ToString() + " $";




        }

        private void btnBETMinus_Click(object sender, EventArgs e)
        {
            if (bet > 0) bet-=5;
            if (bet <= credit)
            {
                btnSPIN.Enabled = true;
                btnAutoSpin.Enabled = true;
            } 
            betlbl.Text = "BET: " + bet.ToString() + " $";
            if (bet == 0)
            {
                btnSPIN.Enabled = false;
                btnAutoSpin.Enabled = false;
                btnBETMinus.Enabled = false;
            }



        }

        private void btnBETPlus_Click(object sender, EventArgs e)
        {
            if (bet < credit)
            {
                btnSPIN.Enabled = true;
                btnAutoSpin.Enabled = true;
                bet+=5;
                betlbl.Text = "BET: " + bet.ToString() + " $";
            }
            btnBETMinus.Enabled = true;

        }

        private void btnPAY_Click(object sender, EventArgs e)
        {

            btnINPUT.Enabled = false;
            btnINPUTPlus.Enabled = false;
            btnINPUTMinus.Enabled = false;
            btnPAY.Enabled = false;
            btnBET.Enabled = true;

        }

        private void btnCASH_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show($"Thank you for playing! You won ${credit}. \n", "Ticket");
            if (res == DialogResult.Yes)
            {
                btnSPIN.Enabled = false;
                btnAutoSpin.Enabled = false;
                btnBET.Enabled = false;
                btnINPUTPlus.Enabled = false;
                btnINPUTMinus.Enabled = false;
                btnBETPlus.Enabled = false;
                btnBETMinus.Enabled = false;
                btnPAY.Enabled = false;
                btnCASH.Enabled = false;
                btnINPUT.Enabled = true;
                credit = 50;
                bet = 5;
                infolbl.Text = "CREDIT: ";
                betlbl.Text = "BET: ";
                lblMsg.Text = "";
                this.Close();
            }
            else Application.Exit();

        }

        private void playRollingSound()
        {
            string sCurrentDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string rolling1 = System.IO.Path.Combine(sCurrentDirectory, @"..\..\..\SlotMachine\Resources\rolling1.wav");
            string rolling_path = Path.GetFullPath(rolling1);

            string rolling2 = System.IO.Path.Combine(sCurrentDirectory, @"..\..\..\SlotMachine\Resources\rolling2.wav");
            string rolling2_path = Path.GetFullPath(rolling2);

            SoundPlayer tapSound = new SoundPlayer(rolling_path);
            tapSound.Play();
            SoundPlayer rollSound = new SoundPlayer(rolling2_path);
            rollSound.Play();
        }

        private void playWinSound()
        {
            string sCurrentDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string dobivka = System.IO.Path.Combine(sCurrentDirectory, @"..\..\..\SlotMachine\Resources\dobivka.wav");
            string dobivka_path = Path.GetFullPath(dobivka);

            SoundPlayer winSound = new SoundPlayer(dobivka_path);
            winSound.Play();
           
        }


        private void btnAutoSpin_Click(object sender, EventArgs e)
        {

            
            if (credit==0 || credit<bet)
            {
                timer1.Stop();
                timer2.Stop();
                temp = 0;
                timerFlag = false;
            }
             if(!timerFlag)
            {
                timerFlag = true;
                
                timer2.Start();
                if(temp > 0)
                    timer2.Interval = 3200;
                temp++;

            }
            else
            {
                timerFlag = false;
                timer1.Stop();
                timer2.Stop();
                temp = 0;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

            btnSPIN_Click(sender, e);
            
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            Info2 info = new Info2();
            info.ShowDialog();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
