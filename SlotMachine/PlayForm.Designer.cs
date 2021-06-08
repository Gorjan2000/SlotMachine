
namespace SlotMachine
{
    partial class PlayForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayForm));
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.btnSPIN = new System.Windows.Forms.Button();
            this.btnINPUT = new System.Windows.Forms.Button();
            this.btnINPUTMinus = new System.Windows.Forms.Button();
            this.btnINPUTPlus = new System.Windows.Forms.Button();
            this.btnPAY = new System.Windows.Forms.Button();
            this.btnBETMinus = new System.Windows.Forms.Button();
            this.btnBETPlus = new System.Windows.Forms.Button();
            this.btnBET = new System.Windows.Forms.Button();
            this.lblMsg = new System.Windows.Forms.Label();
            this.betlbl = new System.Windows.Forms.Label();
            this.infolbl = new System.Windows.Forms.Label();
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.pb4 = new System.Windows.Forms.PictureBox();
            this.pb7 = new System.Windows.Forms.PictureBox();
            this.pb8 = new System.Windows.Forms.PictureBox();
            this.pb2 = new System.Windows.Forms.PictureBox();
            this.pb5 = new System.Windows.Forms.PictureBox();
            this.pb3 = new System.Windows.Forms.PictureBox();
            this.pb6 = new System.Windows.Forms.PictureBox();
            this.pb9 = new System.Windows.Forms.PictureBox();
            this.btnCASH = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnAutoSpin = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb9)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox9.BackgroundImage")));
            this.pictureBox9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox9.Location = new System.Drawing.Point(208, 38);
            this.pictureBox9.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(603, 422);
            this.pictureBox9.TabIndex = 14;
            this.pictureBox9.TabStop = false;
            // 
            // btnSPIN
            // 
            this.btnSPIN.BackColor = System.Drawing.Color.LimeGreen;
            this.btnSPIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSPIN.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSPIN.Location = new System.Drawing.Point(860, 367);
            this.btnSPIN.Name = "btnSPIN";
            this.btnSPIN.Size = new System.Drawing.Size(109, 86);
            this.btnSPIN.TabIndex = 16;
            this.btnSPIN.Text = "SPIN";
            this.btnSPIN.UseVisualStyleBackColor = false;
            this.btnSPIN.Click += new System.EventHandler(this.btnSPIN_Click);
            // 
            // btnINPUT
            // 
            this.btnINPUT.Location = new System.Drawing.Point(270, 474);
            this.btnINPUT.Name = "btnINPUT";
            this.btnINPUT.Size = new System.Drawing.Size(75, 67);
            this.btnINPUT.TabIndex = 17;
            this.btnINPUT.Text = "INPUT MONEY";
            this.btnINPUT.UseVisualStyleBackColor = true;
            this.btnINPUT.Click += new System.EventHandler(this.btnINPUT_Click);
            // 
            // btnINPUTMinus
            // 
            this.btnINPUTMinus.Location = new System.Drawing.Point(351, 514);
            this.btnINPUTMinus.Name = "btnINPUTMinus";
            this.btnINPUTMinus.Size = new System.Drawing.Size(27, 28);
            this.btnINPUTMinus.TabIndex = 19;
            this.btnINPUTMinus.Text = "-";
            this.btnINPUTMinus.UseVisualStyleBackColor = true;
            this.btnINPUTMinus.Click += new System.EventHandler(this.btnINPUTMinus_Click);
            // 
            // btnINPUTPlus
            // 
            this.btnINPUTPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnINPUTPlus.Location = new System.Drawing.Point(351, 474);
            this.btnINPUTPlus.Name = "btnINPUTPlus";
            this.btnINPUTPlus.Size = new System.Drawing.Size(27, 26);
            this.btnINPUTPlus.TabIndex = 18;
            this.btnINPUTPlus.Text = "+";
            this.btnINPUTPlus.UseVisualStyleBackColor = true;
            this.btnINPUTPlus.Click += new System.EventHandler(this.btnINPUTPlus_Click);
            // 
            // btnPAY
            // 
            this.btnPAY.Location = new System.Drawing.Point(270, 556);
            this.btnPAY.Name = "btnPAY";
            this.btnPAY.Size = new System.Drawing.Size(75, 23);
            this.btnPAY.TabIndex = 20;
            this.btnPAY.Text = "PAY TABLE";
            this.btnPAY.UseVisualStyleBackColor = true;
            this.btnPAY.Click += new System.EventHandler(this.btnPAY_Click);
            // 
            // btnBETMinus
            // 
            this.btnBETMinus.Location = new System.Drawing.Point(730, 514);
            this.btnBETMinus.Name = "btnBETMinus";
            this.btnBETMinus.Size = new System.Drawing.Size(27, 28);
            this.btnBETMinus.TabIndex = 23;
            this.btnBETMinus.Text = "-";
            this.btnBETMinus.UseVisualStyleBackColor = true;
            this.btnBETMinus.Click += new System.EventHandler(this.btnBETMinus_Click);
            // 
            // btnBETPlus
            // 
            this.btnBETPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnBETPlus.Location = new System.Drawing.Point(730, 474);
            this.btnBETPlus.Name = "btnBETPlus";
            this.btnBETPlus.Size = new System.Drawing.Size(27, 26);
            this.btnBETPlus.TabIndex = 22;
            this.btnBETPlus.Text = "+";
            this.btnBETPlus.UseVisualStyleBackColor = true;
            this.btnBETPlus.Click += new System.EventHandler(this.btnBETPlus_Click);
            // 
            // btnBET
            // 
            this.btnBET.Location = new System.Drawing.Point(649, 474);
            this.btnBET.Name = "btnBET";
            this.btnBET.Size = new System.Drawing.Size(75, 67);
            this.btnBET.TabIndex = 21;
            this.btnBET.Text = "BET";
            this.btnBET.UseVisualStyleBackColor = true;
            this.btnBET.Click += new System.EventHandler(this.btnBET_Click);
            // 
            // lblMsg
            // 
            this.lblMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblMsg.Location = new System.Drawing.Point(404, 486);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(217, 40);
            this.lblMsg.TabIndex = 24;
            this.lblMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // betlbl
            // 
            this.betlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.betlbl.ForeColor = System.Drawing.Color.Red;
            this.betlbl.Location = new System.Drawing.Point(644, 6);
            this.betlbl.Name = "betlbl";
            this.betlbl.Size = new System.Drawing.Size(157, 30);
            this.betlbl.TabIndex = 26;
            this.betlbl.Text = "BET: ";
            // 
            // infolbl
            // 
            this.infolbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.infolbl.ForeColor = System.Drawing.Color.Red;
            this.infolbl.Location = new System.Drawing.Point(221, 6);
            this.infolbl.Name = "infolbl";
            this.infolbl.Size = new System.Drawing.Size(157, 30);
            this.infolbl.TabIndex = 25;
            this.infolbl.Text = "CREDIT: ";
            // 
            // pb1
            // 
            this.pb1.Image = global::SlotMachine.Properties.Resources.watermelon;
            this.pb1.Location = new System.Drawing.Point(226, 55);
            this.pb1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(171, 121);
            this.pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb1.TabIndex = 27;
            this.pb1.TabStop = false;
            // 
            // pb4
            // 
            this.pb4.Image = global::SlotMachine.Properties.Resources.jabuka;
            this.pb4.Location = new System.Drawing.Point(226, 191);
            this.pb4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pb4.Name = "pb4";
            this.pb4.Size = new System.Drawing.Size(171, 121);
            this.pb4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb4.TabIndex = 28;
            this.pb4.TabStop = false;
            // 
            // pb7
            // 
            this.pb7.Image = global::SlotMachine.Properties.Resources.dolar;
            this.pb7.Location = new System.Drawing.Point(226, 327);
            this.pb7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pb7.Name = "pb7";
            this.pb7.Size = new System.Drawing.Size(171, 121);
            this.pb7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb7.TabIndex = 29;
            this.pb7.TabStop = false;
            // 
            // pb8
            // 
            this.pb8.Image = global::SlotMachine.Properties.Resources.watermelon;
            this.pb8.Location = new System.Drawing.Point(423, 327);
            this.pb8.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pb8.Name = "pb8";
            this.pb8.Size = new System.Drawing.Size(171, 121);
            this.pb8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb8.TabIndex = 30;
            this.pb8.TabStop = false;
            // 
            // pb2
            // 
            this.pb2.Image = global::SlotMachine.Properties.Resources.seven;
            this.pb2.Location = new System.Drawing.Point(423, 54);
            this.pb2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pb2.Name = "pb2";
            this.pb2.Size = new System.Drawing.Size(171, 121);
            this.pb2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb2.TabIndex = 30;
            this.pb2.TabStop = false;
            // 
            // pb5
            // 
            this.pb5.Image = global::SlotMachine.Properties.Resources.grozje;
            this.pb5.Location = new System.Drawing.Point(423, 191);
            this.pb5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pb5.Name = "pb5";
            this.pb5.Size = new System.Drawing.Size(171, 121);
            this.pb5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb5.TabIndex = 31;
            this.pb5.TabStop = false;
            // 
            // pb3
            // 
            this.pb3.Image = global::SlotMachine.Properties.Resources.limon;
            this.pb3.Location = new System.Drawing.Point(620, 55);
            this.pb3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pb3.Name = "pb3";
            this.pb3.Size = new System.Drawing.Size(171, 121);
            this.pb3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb3.TabIndex = 32;
            this.pb3.TabStop = false;
            // 
            // pb6
            // 
            this.pb6.Image = global::SlotMachine.Properties.Resources.dzvezda;
            this.pb6.Location = new System.Drawing.Point(620, 191);
            this.pb6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pb6.Name = "pb6";
            this.pb6.Size = new System.Drawing.Size(171, 121);
            this.pb6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb6.TabIndex = 33;
            this.pb6.TabStop = false;
            // 
            // pb9
            // 
            this.pb9.Image = global::SlotMachine.Properties.Resources.cresa;
            this.pb9.Location = new System.Drawing.Point(620, 327);
            this.pb9.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pb9.Name = "pb9";
            this.pb9.Size = new System.Drawing.Size(171, 121);
            this.pb9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb9.TabIndex = 34;
            this.pb9.TabStop = false;
            // 
            // btnCASH
            // 
            this.btnCASH.BackColor = System.Drawing.Color.White;
            this.btnCASH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCASH.Location = new System.Drawing.Point(59, 381);
            this.btnCASH.Name = "btnCASH";
            this.btnCASH.Size = new System.Drawing.Size(98, 67);
            this.btnCASH.TabIndex = 35;
            this.btnCASH.Text = "CASH OUT";
            this.btnCASH.UseVisualStyleBackColor = false;
            this.btnCASH.Click += new System.EventHandler(this.btnCASH_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 300;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnAutoSpin
            // 
            this.btnAutoSpin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAutoSpin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAutoSpin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAutoSpin.Location = new System.Drawing.Point(860, 486);
            this.btnAutoSpin.Name = "btnAutoSpin";
            this.btnAutoSpin.Size = new System.Drawing.Size(109, 86);
            this.btnAutoSpin.TabIndex = 37;
            this.btnAutoSpin.Text = "AUTO SPIN";
            this.btnAutoSpin.UseVisualStyleBackColor = false;
            this.btnAutoSpin.Click += new System.EventHandler(this.btnAutoSpin_Click);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // PlayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1009, 609);
            this.Controls.Add(this.btnAutoSpin);
            this.Controls.Add(this.btnCASH);
            this.Controls.Add(this.pb9);
            this.Controls.Add(this.pb6);
            this.Controls.Add(this.pb3);
            this.Controls.Add(this.pb5);
            this.Controls.Add(this.pb2);
            this.Controls.Add(this.pb8);
            this.Controls.Add(this.pb7);
            this.Controls.Add(this.pb4);
            this.Controls.Add(this.pb1);
            this.Controls.Add(this.betlbl);
            this.Controls.Add(this.infolbl);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.btnBETMinus);
            this.Controls.Add(this.btnBETPlus);
            this.Controls.Add(this.btnBET);
            this.Controls.Add(this.btnPAY);
            this.Controls.Add(this.btnINPUTMinus);
            this.Controls.Add(this.btnINPUTPlus);
            this.Controls.Add(this.btnINPUT);
            this.Controls.Add(this.btnSPIN);
            this.Controls.Add(this.pictureBox9);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "PlayForm";
            this.Text = "PlayForm";
            this.Load += new System.EventHandler(this.PlayForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb9)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox9;
        internal System.Windows.Forms.Button btnSPIN;
        private System.Windows.Forms.Button btnINPUT;
        private System.Windows.Forms.Button btnINPUTMinus;
        private System.Windows.Forms.Button btnINPUTPlus;
        private System.Windows.Forms.Button btnPAY;
        private System.Windows.Forms.Button btnBETMinus;
        private System.Windows.Forms.Button btnBETPlus;
        private System.Windows.Forms.Button btnBET;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.Label betlbl;
        private System.Windows.Forms.Label infolbl;
        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.PictureBox pb4;
        private System.Windows.Forms.PictureBox pb7;
        private System.Windows.Forms.PictureBox pb8;
        private System.Windows.Forms.PictureBox pb2;
        private System.Windows.Forms.PictureBox pb5;
        private System.Windows.Forms.PictureBox pb3;
        private System.Windows.Forms.PictureBox pb6;
        private System.Windows.Forms.PictureBox pb9;
        private System.Windows.Forms.Button btnCASH;
        private System.Windows.Forms.Timer timer1;
        internal System.Windows.Forms.Button btnAutoSpin;
        private System.Windows.Forms.Timer timer2;
    }
}