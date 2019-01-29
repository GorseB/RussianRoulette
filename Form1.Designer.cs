namespace RussianRoulette
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnBegin = new System.Windows.Forms.Button();
            this.btnShield = new System.Windows.Forms.Button();
            this.cbxMissleSize = new System.Windows.Forms.ComboBox();
            this.JetSelect6 = new System.Windows.Forms.PictureBox();
            this.JetSelect5 = new System.Windows.Forms.PictureBox();
            this.JetSelect4 = new System.Windows.Forms.PictureBox();
            this.JetSelect3 = new System.Windows.Forms.PictureBox();
            this.JetSelect2 = new System.Windows.Forms.PictureBox();
            this.JetSelect1 = new System.Windows.Forms.PictureBox();
            this.lblShieldStatus = new System.Windows.Forms.Label();
            this.lblRapidTitle = new System.Windows.Forms.Label();
            this.lblRouletteTitle = new System.Windows.Forms.Label();
            this.btnRLoad = new System.Windows.Forms.Button();
            this.btnRFire = new System.Windows.Forms.Button();
            this.lblRStatus = new System.Windows.Forms.Label();
            this.lblGamesPlayed = new System.Windows.Forms.Label();
            this.lblLost = new System.Windows.Forms.Label();
            this.lblStreak = new System.Windows.Forms.Label();
            this.lblWon = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.JetSelect6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.JetSelect5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.JetSelect4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.JetSelect3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.JetSelect2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.JetSelect1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBegin
            // 
            this.btnBegin.Location = new System.Drawing.Point(177, 438);
            this.btnBegin.Name = "btnBegin";
            this.btnBegin.Size = new System.Drawing.Size(137, 72);
            this.btnBegin.TabIndex = 12;
            this.btnBegin.Text = "Fire!";
            this.btnBegin.UseVisualStyleBackColor = true;
            this.btnBegin.Click += new System.EventHandler(this.RapidFire_Click);
            // 
            // btnShield
            // 
            this.btnShield.Location = new System.Drawing.Point(340, 399);
            this.btnShield.Name = "btnShield";
            this.btnShield.Size = new System.Drawing.Size(134, 69);
            this.btnShield.TabIndex = 13;
            this.btnShield.Text = "Shield";
            this.btnShield.UseVisualStyleBackColor = true;
            this.btnShield.Click += new System.EventHandler(this.btnShield_Click);
            // 
            // cbxMissleSize
            // 
            this.cbxMissleSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMissleSize.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cbxMissleSize.Location = new System.Drawing.Point(177, 516);
            this.cbxMissleSize.MaxDropDownItems = 9;
            this.cbxMissleSize.Name = "cbxMissleSize";
            this.cbxMissleSize.Size = new System.Drawing.Size(137, 21);
            this.cbxMissleSize.TabIndex = 15;
            // 
            // JetSelect6
            // 
            this.JetSelect6.Image = ((System.Drawing.Image)(resources.GetObject("JetSelect6.Image")));
            this.JetSelect6.Location = new System.Drawing.Point(420, 300);
            this.JetSelect6.Name = "JetSelect6";
            this.JetSelect6.Size = new System.Drawing.Size(54, 96);
            this.JetSelect6.TabIndex = 11;
            this.JetSelect6.TabStop = false;
            this.JetSelect6.Tag = "0";
            this.JetSelect6.Click += new System.EventHandler(this.JetClick);
            this.JetSelect6.MouseEnter += new System.EventHandler(this.JetChange);
            this.JetSelect6.MouseLeave += new System.EventHandler(this.JetChange);
            // 
            // JetSelect5
            // 
            this.JetSelect5.Image = ((System.Drawing.Image)(resources.GetObject("JetSelect5.Image")));
            this.JetSelect5.Location = new System.Drawing.Point(340, 300);
            this.JetSelect5.Name = "JetSelect5";
            this.JetSelect5.Size = new System.Drawing.Size(54, 96);
            this.JetSelect5.TabIndex = 10;
            this.JetSelect5.TabStop = false;
            this.JetSelect5.Tag = "0";
            this.JetSelect5.Click += new System.EventHandler(this.JetClick);
            this.JetSelect5.MouseEnter += new System.EventHandler(this.JetChange);
            this.JetSelect5.MouseLeave += new System.EventHandler(this.JetChange);
            // 
            // JetSelect4
            // 
            this.JetSelect4.Image = ((System.Drawing.Image)(resources.GetObject("JetSelect4.Image")));
            this.JetSelect4.Location = new System.Drawing.Point(260, 300);
            this.JetSelect4.Name = "JetSelect4";
            this.JetSelect4.Size = new System.Drawing.Size(54, 96);
            this.JetSelect4.TabIndex = 9;
            this.JetSelect4.TabStop = false;
            this.JetSelect4.Tag = "0";
            this.JetSelect4.Click += new System.EventHandler(this.JetClick);
            this.JetSelect4.MouseEnter += new System.EventHandler(this.JetChange);
            this.JetSelect4.MouseLeave += new System.EventHandler(this.JetChange);
            // 
            // JetSelect3
            // 
            this.JetSelect3.Image = ((System.Drawing.Image)(resources.GetObject("JetSelect3.Image")));
            this.JetSelect3.Location = new System.Drawing.Point(180, 300);
            this.JetSelect3.Name = "JetSelect3";
            this.JetSelect3.Size = new System.Drawing.Size(54, 96);
            this.JetSelect3.TabIndex = 8;
            this.JetSelect3.TabStop = false;
            this.JetSelect3.Tag = "0";
            this.JetSelect3.Click += new System.EventHandler(this.JetClick);
            this.JetSelect3.MouseEnter += new System.EventHandler(this.JetChange);
            this.JetSelect3.MouseLeave += new System.EventHandler(this.JetChange);
            // 
            // JetSelect2
            // 
            this.JetSelect2.Image = ((System.Drawing.Image)(resources.GetObject("JetSelect2.Image")));
            this.JetSelect2.Location = new System.Drawing.Point(100, 300);
            this.JetSelect2.Name = "JetSelect2";
            this.JetSelect2.Size = new System.Drawing.Size(54, 96);
            this.JetSelect2.TabIndex = 7;
            this.JetSelect2.TabStop = false;
            this.JetSelect2.Tag = "0";
            this.JetSelect2.Click += new System.EventHandler(this.JetClick);
            this.JetSelect2.MouseEnter += new System.EventHandler(this.JetChange);
            this.JetSelect2.MouseLeave += new System.EventHandler(this.JetChange);
            // 
            // JetSelect1
            // 
            this.JetSelect1.Image = ((System.Drawing.Image)(resources.GetObject("JetSelect1.Image")));
            this.JetSelect1.Location = new System.Drawing.Point(20, 300);
            this.JetSelect1.Name = "JetSelect1";
            this.JetSelect1.Size = new System.Drawing.Size(54, 96);
            this.JetSelect1.TabIndex = 0;
            this.JetSelect1.TabStop = false;
            this.JetSelect1.Tag = "0";
            this.JetSelect1.Click += new System.EventHandler(this.JetClick);
            this.JetSelect1.MouseEnter += new System.EventHandler(this.JetChange);
            this.JetSelect1.MouseLeave += new System.EventHandler(this.JetChange);
            // 
            // lblShieldStatus
            // 
            this.lblShieldStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShieldStatus.ForeColor = System.Drawing.Color.DimGray;
            this.lblShieldStatus.Location = new System.Drawing.Point(180, 540);
            this.lblShieldStatus.Name = "lblShieldStatus";
            this.lblShieldStatus.Size = new System.Drawing.Size(294, 13);
            this.lblShieldStatus.TabIndex = 16;
            this.lblShieldStatus.Text = "You Have Two Shields Remaining!";
            this.lblShieldStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRapidTitle
            // 
            this.lblRapidTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRapidTitle.ForeColor = System.Drawing.Color.DimGray;
            this.lblRapidTitle.Location = new System.Drawing.Point(177, 399);
            this.lblRapidTitle.Name = "lblRapidTitle";
            this.lblRapidTitle.Size = new System.Drawing.Size(137, 36);
            this.lblRapidTitle.TabIndex = 17;
            this.lblRapidTitle.Text = "Rapid-Fire Mode";
            this.lblRapidTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRouletteTitle
            // 
            this.lblRouletteTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRouletteTitle.ForeColor = System.Drawing.Color.DimGray;
            this.lblRouletteTitle.Location = new System.Drawing.Point(17, 399);
            this.lblRouletteTitle.Name = "lblRouletteTitle";
            this.lblRouletteTitle.Size = new System.Drawing.Size(137, 36);
            this.lblRouletteTitle.TabIndex = 18;
            this.lblRouletteTitle.Text = "Roulette  Mode";
            this.lblRouletteTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRLoad
            // 
            this.btnRLoad.Location = new System.Drawing.Point(17, 438);
            this.btnRLoad.Name = "btnRLoad";
            this.btnRLoad.Size = new System.Drawing.Size(137, 36);
            this.btnRLoad.TabIndex = 19;
            this.btnRLoad.Text = "Load";
            this.btnRLoad.UseVisualStyleBackColor = true;
            this.btnRLoad.Click += new System.EventHandler(this.btnRLoad_Click);
            // 
            // btnRFire
            // 
            this.btnRFire.Location = new System.Drawing.Point(17, 474);
            this.btnRFire.Name = "btnRFire";
            this.btnRFire.Size = new System.Drawing.Size(137, 36);
            this.btnRFire.TabIndex = 20;
            this.btnRFire.Text = "Shoot";
            this.btnRFire.UseVisualStyleBackColor = true;
            this.btnRFire.Click += new System.EventHandler(this.btnRFire_Click);
            // 
            // lblRStatus
            // 
            this.lblRStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRStatus.ForeColor = System.Drawing.Color.DimGray;
            this.lblRStatus.Location = new System.Drawing.Point(17, 516);
            this.lblRStatus.Name = "lblRStatus";
            this.lblRStatus.Size = new System.Drawing.Size(137, 37);
            this.lblRStatus.TabIndex = 21;
            this.lblRStatus.Text = "0";
            this.lblRStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGamesPlayed
            // 
            this.lblGamesPlayed.AutoSize = true;
            this.lblGamesPlayed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGamesPlayed.ForeColor = System.Drawing.Color.DimGray;
            this.lblGamesPlayed.Location = new System.Drawing.Point(19, 9);
            this.lblGamesPlayed.Name = "lblGamesPlayed";
            this.lblGamesPlayed.Size = new System.Drawing.Size(106, 13);
            this.lblGamesPlayed.TabIndex = 22;
            this.lblGamesPlayed.Text = "Games Played : 0";
            // 
            // lblLost
            // 
            this.lblLost.AutoSize = true;
            this.lblLost.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLost.ForeColor = System.Drawing.Color.DimGray;
            this.lblLost.Location = new System.Drawing.Point(385, 42);
            this.lblLost.Name = "lblLost";
            this.lblLost.Size = new System.Drawing.Size(92, 13);
            this.lblLost.TabIndex = 23;
            this.lblLost.Text = "Games Lost : 0";
            // 
            // lblStreak
            // 
            this.lblStreak.AutoSize = true;
            this.lblStreak.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStreak.ForeColor = System.Drawing.Color.DimGray;
            this.lblStreak.Location = new System.Drawing.Point(19, 42);
            this.lblStreak.Name = "lblStreak";
            this.lblStreak.Size = new System.Drawing.Size(104, 13);
            this.lblStreak.TabIndex = 24;
            this.lblStreak.Text = "Dodge Streak : 0";
            // 
            // lblWon
            // 
            this.lblWon.AutoSize = true;
            this.lblWon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWon.ForeColor = System.Drawing.Color.DimGray;
            this.lblWon.Location = new System.Drawing.Point(383, 9);
            this.lblWon.Name = "lblWon";
            this.lblWon.Size = new System.Drawing.Size(94, 13);
            this.lblWon.TabIndex = 25;
            this.lblWon.Text = "Games Won : 0";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(340, 468);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(134, 69);
            this.btnReset.TabIndex = 26;
            this.btnReset.Text = "Load Scores";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(484, 562);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblWon);
            this.Controls.Add(this.lblStreak);
            this.Controls.Add(this.lblLost);
            this.Controls.Add(this.lblGamesPlayed);
            this.Controls.Add(this.lblRStatus);
            this.Controls.Add(this.btnRFire);
            this.Controls.Add(this.btnRLoad);
            this.Controls.Add(this.lblRouletteTitle);
            this.Controls.Add(this.lblRapidTitle);
            this.Controls.Add(this.lblShieldStatus);
            this.Controls.Add(this.cbxMissleSize);
            this.Controls.Add(this.btnShield);
            this.Controls.Add(this.btnBegin);
            this.Controls.Add(this.JetSelect6);
            this.Controls.Add(this.JetSelect5);
            this.Controls.Add(this.JetSelect4);
            this.Controls.Add(this.JetSelect3);
            this.Controls.Add(this.JetSelect2);
            this.Controls.Add(this.JetSelect1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Russian Roulette";
            this.TransparencyKey = System.Drawing.Color.Transparent;
     //       this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.JetSelect6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.JetSelect5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.JetSelect4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.JetSelect3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.JetSelect2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.JetSelect1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox JetSelect1;
        private System.Windows.Forms.PictureBox JetSelect2;
        private System.Windows.Forms.PictureBox JetSelect4;
        private System.Windows.Forms.PictureBox JetSelect5;
        private System.Windows.Forms.PictureBox JetSelect6;
        private System.Windows.Forms.Button btnBegin;
        private System.Windows.Forms.Button btnShield;
        private System.Windows.Forms.ComboBox cbxMissleSize;
        private System.Windows.Forms.Label lblShieldStatus;
        private System.Windows.Forms.Label lblRapidTitle;
        private System.Windows.Forms.Label lblRouletteTitle;
        private System.Windows.Forms.Button btnRLoad;
        private System.Windows.Forms.Button btnRFire;
        private System.Windows.Forms.PictureBox JetSelect3;
        private System.Windows.Forms.Label lblRStatus;
        private System.Windows.Forms.Label lblGamesPlayed;
        private System.Windows.Forms.Label lblLost;
        private System.Windows.Forms.Label lblWon;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblStreak;
    }
}

