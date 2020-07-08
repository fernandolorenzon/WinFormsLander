namespace WinFormsLander.Forms
{
    partial class FormMain
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelArcade = new System.Windows.Forms.Label();
            this.labelChooseShip = new System.Windows.Forms.Label();
            this.pictureBoxLander = new System.Windows.Forms.PictureBox();
            this.labelCurrent = new System.Windows.Forms.Label();
            this.labelFreePlay = new System.Windows.Forms.Label();
            this.labelExit = new System.Windows.Forms.Label();
            this.labelCollectOre = new System.Windows.Forms.Label();
            this.labelInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLander)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Font = new System.Drawing.Font("Arial", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.Lime;
            this.labelTitle.Location = new System.Drawing.Point(223, 22);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(385, 51);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "WinForms Lander";
            // 
            // labelArcade
            // 
            this.labelArcade.AutoSize = true;
            this.labelArcade.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelArcade.ForeColor = System.Drawing.Color.Lime;
            this.labelArcade.Location = new System.Drawing.Point(10, 533);
            this.labelArcade.Name = "labelArcade";
            this.labelArcade.Size = new System.Drawing.Size(46, 14);
            this.labelArcade.TabIndex = 1;
            this.labelArcade.Text = "Arcade";
            this.labelArcade.Click += new System.EventHandler(this.labelArcade_Click);
            // 
            // labelChooseShip
            // 
            this.labelChooseShip.AutoSize = true;
            this.labelChooseShip.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChooseShip.ForeColor = System.Drawing.Color.Lime;
            this.labelChooseShip.Location = new System.Drawing.Point(231, 533);
            this.labelChooseShip.Name = "labelChooseShip";
            this.labelChooseShip.Size = new System.Drawing.Size(84, 14);
            this.labelChooseShip.TabIndex = 2;
            this.labelChooseShip.Text = "Escolher Nave";
            this.labelChooseShip.Click += new System.EventHandler(this.labelChooseShip_Click);
            // 
            // pictureBoxLander
            // 
            this.pictureBoxLander.Location = new System.Drawing.Point(544, 524);
            this.pictureBoxLander.Name = "pictureBoxLander";
            this.pictureBoxLander.Size = new System.Drawing.Size(32, 32);
            this.pictureBoxLander.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLander.TabIndex = 13;
            this.pictureBoxLander.TabStop = false;
            // 
            // labelCurrent
            // 
            this.labelCurrent.AutoSize = true;
            this.labelCurrent.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrent.ForeColor = System.Drawing.Color.Lime;
            this.labelCurrent.Location = new System.Drawing.Point(471, 533);
            this.labelCurrent.Name = "labelCurrent";
            this.labelCurrent.Size = new System.Drawing.Size(67, 14);
            this.labelCurrent.TabIndex = 14;
            this.labelCurrent.Text = "Nave Atual:";
            // 
            // labelFreePlay
            // 
            this.labelFreePlay.AutoSize = true;
            this.labelFreePlay.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFreePlay.ForeColor = System.Drawing.Color.Lime;
            this.labelFreePlay.Location = new System.Drawing.Point(160, 533);
            this.labelFreePlay.Name = "labelFreePlay";
            this.labelFreePlay.Size = new System.Drawing.Size(65, 14);
            this.labelFreePlay.TabIndex = 15;
            this.labelFreePlay.Text = "Jogo Livre";
            this.labelFreePlay.Click += new System.EventHandler(this.labelFreePlay_Click);
            // 
            // labelExit
            // 
            this.labelExit.AutoSize = true;
            this.labelExit.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExit.ForeColor = System.Drawing.Color.Lime;
            this.labelExit.Location = new System.Drawing.Point(752, 550);
            this.labelExit.Name = "labelExit";
            this.labelExit.Size = new System.Drawing.Size(28, 14);
            this.labelExit.TabIndex = 16;
            this.labelExit.Text = "Sair";
            this.labelExit.Click += new System.EventHandler(this.labelExit_Click);
            // 
            // labelCollectOre
            // 
            this.labelCollectOre.AutoSize = true;
            this.labelCollectOre.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCollectOre.ForeColor = System.Drawing.Color.Lime;
            this.labelCollectOre.Location = new System.Drawing.Point(62, 533);
            this.labelCollectOre.Name = "labelCollectOre";
            this.labelCollectOre.Size = new System.Drawing.Size(92, 14);
            this.labelCollectOre.TabIndex = 17;
            this.labelCollectOre.Text = "Coletar Minério";
            this.labelCollectOre.Click += new System.EventHandler(this.labelOreColleting_Click);
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.labelInfo.Location = new System.Drawing.Point(340, 552);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(133, 12);
            this.labelInfo.TabIndex = 18;
            this.labelInfo.Text = "Clique na opção desejada";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::WinFormsLander.Properties.Resources.LunarLander;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(792, 573);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.labelCollectOre);
            this.Controls.Add(this.labelExit);
            this.Controls.Add(this.labelFreePlay);
            this.Controls.Add(this.labelCurrent);
            this.Controls.Add(this.pictureBoxLander);
            this.Controls.Add(this.labelChooseShip);
            this.Controls.Add(this.labelArcade);
            this.Controls.Add(this.labelTitle);
            this.Name = "FormMain";
            this.Text = "WinForms Lander";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.VisibleChanged += new System.EventHandler(this.FormMain_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLander)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelArcade;
        private System.Windows.Forms.Label labelChooseShip;
        public System.Windows.Forms.PictureBox pictureBoxLander;
        private System.Windows.Forms.Label labelCurrent;
        private System.Windows.Forms.Label labelFreePlay;
        private System.Windows.Forms.Label labelExit;
        private System.Windows.Forms.Label labelCollectOre;
        private System.Windows.Forms.Label labelInfo;
    }
}