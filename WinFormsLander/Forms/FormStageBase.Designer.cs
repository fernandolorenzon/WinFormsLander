namespace WinFormsLander.Forms
{
    partial class FormStageBase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStageBase));
            this.panelCurrentStage = new System.Windows.Forms.Panel();
            this.pictureBoxLocation = new System.Windows.Forms.PictureBox();
            this.labelLocation = new System.Windows.Forms.Label();
            this.labelStage = new System.Windows.Forms.Label();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.labelShipsLeft = new System.Windows.Forms.Label();
            this.pictureBoxShipLeft2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxShipLeft1 = new System.Windows.Forms.PictureBox();
            this.buttonEnd = new System.Windows.Forms.Button();
            this.labelSpeed = new System.Windows.Forms.Label();
            this.progressBarSpeed = new System.Windows.Forms.ProgressBar();
            this.labelAccelDanger = new System.Windows.Forms.Label();
            this.pictureBoxDanger = new System.Windows.Forms.PictureBox();
            this.pictureBoxSpecialLED = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelConsole = new System.Windows.Forms.Panel();
            this.labelGravity = new System.Windows.Forms.Label();
            this.labelWindValue = new System.Windows.Forms.Label();
            this.labelGravityValue = new System.Windows.Forms.Label();
            this.labelWind = new System.Windows.Forms.Label();
            this.labelFuel = new System.Windows.Forms.Label();
            this.progressBarFuel = new System.Windows.Forms.ProgressBar();
            this.labelAccelToLZ = new System.Windows.Forms.Label();
            this.progressBarSpeedToLZ = new System.Windows.Forms.ProgressBar();
            this.panelStage = new System.Windows.Forms.Panel();
            this.pictureBoxMetroid = new System.Windows.Forms.PictureBox();
            this.pictureBoxAsteroid2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxBlueOre = new System.Windows.Forms.PictureBox();
            this.pictureBoxGreenOre = new System.Windows.Forms.PictureBox();
            this.pictureBoxRedOre = new System.Windows.Forms.PictureBox();
            this.pictureBoxAsteroid1 = new System.Windows.Forms.PictureBox();
            this.labelCursor = new System.Windows.Forms.Label();
            this.pictureBoxCursor = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelMessage = new System.Windows.Forms.Label();
            this.lz = new System.Windows.Forms.PictureBox();
            this.panelCurrentStage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLocation)).BeginInit();
            this.panelInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShipLeft2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShipLeft1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDanger)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSpecialLED)).BeginInit();
            this.panelConsole.SuspendLayout();
            this.panelStage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMetroid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAsteroid2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBlueOre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGreenOre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRedOre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAsteroid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCursor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lz)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCurrentStage
            // 
            this.panelCurrentStage.BackColor = System.Drawing.Color.Black;
            this.panelCurrentStage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelCurrentStage.Controls.Add(this.pictureBoxLocation);
            this.panelCurrentStage.Controls.Add(this.labelLocation);
            this.panelCurrentStage.Controls.Add(this.labelStage);
            this.panelCurrentStage.Location = new System.Drawing.Point(675, 469);
            this.panelCurrentStage.Name = "panelCurrentStage";
            this.panelCurrentStage.Size = new System.Drawing.Size(120, 107);
            this.panelCurrentStage.TabIndex = 25;
            // 
            // pictureBoxLocation
            // 
            this.pictureBoxLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxLocation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBoxLocation.Location = new System.Drawing.Point(23, 44);
            this.pictureBoxLocation.Name = "pictureBoxLocation";
            this.pictureBoxLocation.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxLocation.TabIndex = 4;
            this.pictureBoxLocation.TabStop = false;
            // 
            // labelLocation
            // 
            this.labelLocation.AutoSize = true;
            this.labelLocation.Font = new System.Drawing.Font("Latha", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLocation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.labelLocation.Location = new System.Drawing.Point(7, 22);
            this.labelLocation.Name = "labelLocation";
            this.labelLocation.Size = new System.Drawing.Size(76, 19);
            this.labelLocation.TabIndex = 3;
            this.labelLocation.Text = "Location";
            // 
            // labelStage
            // 
            this.labelStage.AutoSize = true;
            this.labelStage.Font = new System.Drawing.Font("Latha", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.labelStage.Location = new System.Drawing.Point(7, 3);
            this.labelStage.Name = "labelStage";
            this.labelStage.Size = new System.Drawing.Size(53, 19);
            this.labelStage.TabIndex = 2;
            this.labelStage.Text = "Stage";
            // 
            // panelInfo
            // 
            this.panelInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelInfo.BackColor = System.Drawing.Color.Teal;
            this.panelInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelInfo.Controls.Add(this.labelShipsLeft);
            this.panelInfo.Controls.Add(this.pictureBoxShipLeft2);
            this.panelInfo.Controls.Add(this.pictureBoxShipLeft1);
            this.panelInfo.Controls.Add(this.buttonEnd);
            this.panelInfo.Controls.Add(this.labelSpeed);
            this.panelInfo.Controls.Add(this.progressBarSpeed);
            this.panelInfo.Controls.Add(this.labelAccelDanger);
            this.panelInfo.Controls.Add(this.pictureBoxDanger);
            this.panelInfo.Controls.Add(this.pictureBoxSpecialLED);
            this.panelInfo.Controls.Add(this.label1);
            this.panelInfo.Controls.Add(this.panelConsole);
            this.panelInfo.Controls.Add(this.labelFuel);
            this.panelInfo.Controls.Add(this.progressBarFuel);
            this.panelInfo.Controls.Add(this.labelAccelToLZ);
            this.panelInfo.Controls.Add(this.progressBarSpeedToLZ);
            this.panelInfo.Location = new System.Drawing.Point(675, 0);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(120, 471);
            this.panelInfo.TabIndex = 24;
            // 
            // labelShipsLeft
            // 
            this.labelShipsLeft.AutoSize = true;
            this.labelShipsLeft.Font = new System.Drawing.Font("Lucida Console", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.labelShipsLeft.Location = new System.Drawing.Point(3, 204);
            this.labelShipsLeft.Name = "labelShipsLeft";
            this.labelShipsLeft.Size = new System.Drawing.Size(47, 10);
            this.labelShipsLeft.TabIndex = 27;
            this.labelShipsLeft.Text = "Naves:";
            // 
            // pictureBoxShipLeft2
            // 
            this.pictureBoxShipLeft2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxShipLeft2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBoxShipLeft2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxShipLeft2.Location = new System.Drawing.Point(43, 218);
            this.pictureBoxShipLeft2.Name = "pictureBoxShipLeft2";
            this.pictureBoxShipLeft2.Size = new System.Drawing.Size(34, 34);
            this.pictureBoxShipLeft2.TabIndex = 26;
            this.pictureBoxShipLeft2.TabStop = false;
            // 
            // pictureBoxShipLeft1
            // 
            this.pictureBoxShipLeft1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxShipLeft1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBoxShipLeft1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxShipLeft1.Location = new System.Drawing.Point(5, 218);
            this.pictureBoxShipLeft1.Name = "pictureBoxShipLeft1";
            this.pictureBoxShipLeft1.Size = new System.Drawing.Size(34, 34);
            this.pictureBoxShipLeft1.TabIndex = 25;
            this.pictureBoxShipLeft1.TabStop = false;
            // 
            // buttonEnd
            // 
            this.buttonEnd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonEnd.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.buttonEnd.Location = new System.Drawing.Point(5, 337);
            this.buttonEnd.Name = "buttonEnd";
            this.buttonEnd.Size = new System.Drawing.Size(104, 23);
            this.buttonEnd.TabIndex = 24;
            this.buttonEnd.TabStop = false;
            this.buttonEnd.Text = "Terminar";
            this.buttonEnd.UseVisualStyleBackColor = false;
            this.buttonEnd.Click += new System.EventHandler(this.buttonEnd_Click);
            // 
            // labelSpeed
            // 
            this.labelSpeed.AutoSize = true;
            this.labelSpeed.Font = new System.Drawing.Font("Lucida Console", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.labelSpeed.Location = new System.Drawing.Point(3, 7);
            this.labelSpeed.Name = "labelSpeed";
            this.labelSpeed.Size = new System.Drawing.Size(82, 10);
            this.labelSpeed.TabIndex = 23;
            this.labelSpeed.Text = "Velocidade:";
            // 
            // progressBarSpeed
            // 
            this.progressBarSpeed.BackColor = System.Drawing.Color.Black;
            this.progressBarSpeed.ForeColor = System.Drawing.Color.Lime;
            this.progressBarSpeed.Location = new System.Drawing.Point(5, 20);
            this.progressBarSpeed.MarqueeAnimationSpeed = 5;
            this.progressBarSpeed.Name = "progressBarSpeed";
            this.progressBarSpeed.Size = new System.Drawing.Size(104, 23);
            this.progressBarSpeed.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBarSpeed.TabIndex = 22;
            // 
            // labelAccelDanger
            // 
            this.labelAccelDanger.AutoSize = true;
            this.labelAccelDanger.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.labelAccelDanger.ForeColor = System.Drawing.Color.Brown;
            this.labelAccelDanger.Location = new System.Drawing.Point(54, 114);
            this.labelAccelDanger.Name = "labelAccelDanger";
            this.labelAccelDanger.Size = new System.Drawing.Size(41, 9);
            this.labelAccelDanger.TabIndex = 21;
            this.labelAccelDanger.Text = "Danger";
            // 
            // pictureBoxDanger
            // 
            this.pictureBoxDanger.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxDanger.Image = global::WinFormsLander.Properties.Resources.Off_Map_Cursor;
            this.pictureBoxDanger.Location = new System.Drawing.Point(57, 95);
            this.pictureBoxDanger.Name = "pictureBoxDanger";
            this.pictureBoxDanger.Size = new System.Drawing.Size(16, 16);
            this.pictureBoxDanger.TabIndex = 20;
            this.pictureBoxDanger.TabStop = false;
            // 
            // pictureBoxSpecialLED
            // 
            this.pictureBoxSpecialLED.BackgroundImage = global::WinFormsLander.Properties.Resources.LED_OFF;
            this.pictureBoxSpecialLED.Location = new System.Drawing.Point(76, 175);
            this.pictureBoxSpecialLED.Name = "pictureBoxSpecialLED";
            this.pictureBoxSpecialLED.Size = new System.Drawing.Size(16, 16);
            this.pictureBoxSpecialLED.TabIndex = 10;
            this.pictureBoxSpecialLED.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 10);
            this.label1.TabIndex = 9;
            this.label1.Text = "Especial:";
            // 
            // panelConsole
            // 
            this.panelConsole.BackColor = System.Drawing.Color.Black;
            this.panelConsole.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelConsole.Controls.Add(this.labelGravity);
            this.panelConsole.Controls.Add(this.labelWindValue);
            this.panelConsole.Controls.Add(this.labelGravityValue);
            this.panelConsole.Controls.Add(this.labelWind);
            this.panelConsole.Location = new System.Drawing.Point(0, 366);
            this.panelConsole.Name = "panelConsole";
            this.panelConsole.Size = new System.Drawing.Size(120, 100);
            this.panelConsole.TabIndex = 8;
            // 
            // labelGravity
            // 
            this.labelGravity.AutoSize = true;
            this.labelGravity.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.labelGravity.ForeColor = System.Drawing.Color.Lime;
            this.labelGravity.Location = new System.Drawing.Point(5, 9);
            this.labelGravity.Name = "labelGravity";
            this.labelGravity.Size = new System.Drawing.Size(85, 12);
            this.labelGravity.TabIndex = 4;
            this.labelGravity.Text = "Gravidade:";
            // 
            // labelWindValue
            // 
            this.labelWindValue.AutoSize = true;
            this.labelWindValue.Font = new System.Drawing.Font("Lucida Console", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.labelWindValue.ForeColor = System.Drawing.Color.Lime;
            this.labelWindValue.Location = new System.Drawing.Point(3, 68);
            this.labelWindValue.Name = "labelWindValue";
            this.labelWindValue.Size = new System.Drawing.Size(97, 14);
            this.labelWindValue.TabIndex = 7;
            this.labelWindValue.Text = "{0}m/s {1}";
            // 
            // labelGravityValue
            // 
            this.labelGravityValue.AutoSize = true;
            this.labelGravityValue.Font = new System.Drawing.Font("Lucida Console", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.labelGravityValue.ForeColor = System.Drawing.Color.Lime;
            this.labelGravityValue.Location = new System.Drawing.Point(5, 23);
            this.labelGravityValue.Name = "labelGravityValue";
            this.labelGravityValue.Size = new System.Drawing.Size(70, 14);
            this.labelGravityValue.TabIndex = 5;
            this.labelGravityValue.Text = "{0}m/s²";
            // 
            // labelWind
            // 
            this.labelWind.AutoSize = true;
            this.labelWind.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.labelWind.ForeColor = System.Drawing.Color.Lime;
            this.labelWind.Location = new System.Drawing.Point(6, 53);
            this.labelWind.Name = "labelWind";
            this.labelWind.Size = new System.Drawing.Size(53, 12);
            this.labelWind.TabIndex = 6;
            this.labelWind.Text = "Vento:";
            // 
            // labelFuel
            // 
            this.labelFuel.AutoSize = true;
            this.labelFuel.Font = new System.Drawing.Font("Lucida Console", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.labelFuel.Location = new System.Drawing.Point(3, 128);
            this.labelFuel.Name = "labelFuel";
            this.labelFuel.Size = new System.Drawing.Size(89, 10);
            this.labelFuel.TabIndex = 3;
            this.labelFuel.Text = "Combustível:";
            // 
            // progressBarFuel
            // 
            this.progressBarFuel.BackColor = System.Drawing.Color.Black;
            this.progressBarFuel.ForeColor = System.Drawing.Color.SpringGreen;
            this.progressBarFuel.Location = new System.Drawing.Point(5, 141);
            this.progressBarFuel.MarqueeAnimationSpeed = 5;
            this.progressBarFuel.Name = "progressBarFuel";
            this.progressBarFuel.Size = new System.Drawing.Size(104, 23);
            this.progressBarFuel.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBarFuel.TabIndex = 2;
            // 
            // labelAccelToLZ
            // 
            this.labelAccelToLZ.AutoSize = true;
            this.labelAccelToLZ.Font = new System.Drawing.Font("Lucida Console", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.labelAccelToLZ.Location = new System.Drawing.Point(3, 59);
            this.labelAccelToLZ.Name = "labelAccelToLZ";
            this.labelAccelToLZ.Size = new System.Drawing.Size(110, 10);
            this.labelAccelToLZ.TabIndex = 1;
            this.labelAccelToLZ.Text = "Veloc. Nave/LZ:";
            // 
            // progressBarSpeedToLZ
            // 
            this.progressBarSpeedToLZ.BackColor = System.Drawing.Color.Black;
            this.progressBarSpeedToLZ.ForeColor = System.Drawing.Color.Lime;
            this.progressBarSpeedToLZ.Location = new System.Drawing.Point(5, 72);
            this.progressBarSpeedToLZ.MarqueeAnimationSpeed = 5;
            this.progressBarSpeedToLZ.Name = "progressBarSpeedToLZ";
            this.progressBarSpeedToLZ.Size = new System.Drawing.Size(104, 23);
            this.progressBarSpeedToLZ.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBarSpeedToLZ.TabIndex = 0;
            // 
            // panelStage
            // 
            this.panelStage.BackColor = System.Drawing.Color.Black;
            this.panelStage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelStage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelStage.Controls.Add(this.pictureBoxMetroid);
            this.panelStage.Controls.Add(this.pictureBoxAsteroid2);
            this.panelStage.Controls.Add(this.pictureBoxBlueOre);
            this.panelStage.Controls.Add(this.pictureBoxGreenOre);
            this.panelStage.Controls.Add(this.pictureBoxRedOre);
            this.panelStage.Controls.Add(this.pictureBoxAsteroid1);
            this.panelStage.Controls.Add(this.labelCursor);
            this.panelStage.Controls.Add(this.pictureBoxCursor);
            this.panelStage.Controls.Add(this.pictureBox5);
            this.panelStage.Controls.Add(this.pictureBox4);
            this.panelStage.Controls.Add(this.pictureBox3);
            this.panelStage.Controls.Add(this.pictureBox2);
            this.panelStage.Controls.Add(this.pictureBox1);
            this.panelStage.Controls.Add(this.labelMessage);
            this.panelStage.Controls.Add(this.lz);
            this.panelStage.Location = new System.Drawing.Point(0, 0);
            this.panelStage.Name = "panelStage";
            this.panelStage.Size = new System.Drawing.Size(677, 576);
            this.panelStage.TabIndex = 1;
            // 
            // pictureBoxMetroid
            // 
            this.pictureBoxMetroid.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxMetroid.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxMetroid.BackgroundImage")));
            this.pictureBoxMetroid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxMetroid.Location = new System.Drawing.Point(314, 260);
            this.pictureBoxMetroid.Name = "pictureBoxMetroid";
            this.pictureBoxMetroid.Size = new System.Drawing.Size(16, 16);
            this.pictureBoxMetroid.TabIndex = 26;
            this.pictureBoxMetroid.TabStop = false;
            this.pictureBoxMetroid.Visible = false;
            // 
            // pictureBoxAsteroid2
            // 
            this.pictureBoxAsteroid2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxAsteroid2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxAsteroid2.BackgroundImage")));
            this.pictureBoxAsteroid2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxAsteroid2.Location = new System.Drawing.Point(314, 232);
            this.pictureBoxAsteroid2.Name = "pictureBoxAsteroid2";
            this.pictureBoxAsteroid2.Size = new System.Drawing.Size(32, 22);
            this.pictureBoxAsteroid2.TabIndex = 25;
            this.pictureBoxAsteroid2.TabStop = false;
            this.pictureBoxAsteroid2.Visible = false;
            // 
            // pictureBoxBlueOre
            // 
            this.pictureBoxBlueOre.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxBlueOre.BackgroundImage = global::WinFormsLander.Properties.Resources.Blue_Ore;
            this.pictureBoxBlueOre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxBlueOre.Location = new System.Drawing.Point(416, 204);
            this.pictureBoxBlueOre.Name = "pictureBoxBlueOre";
            this.pictureBoxBlueOre.Size = new System.Drawing.Size(16, 16);
            this.pictureBoxBlueOre.TabIndex = 24;
            this.pictureBoxBlueOre.TabStop = false;
            this.pictureBoxBlueOre.Visible = false;
            // 
            // pictureBoxGreenOre
            // 
            this.pictureBoxGreenOre.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxGreenOre.BackgroundImage = global::WinFormsLander.Properties.Resources.Green_Ore;
            this.pictureBoxGreenOre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxGreenOre.Location = new System.Drawing.Point(394, 204);
            this.pictureBoxGreenOre.Name = "pictureBoxGreenOre";
            this.pictureBoxGreenOre.Size = new System.Drawing.Size(16, 16);
            this.pictureBoxGreenOre.TabIndex = 23;
            this.pictureBoxGreenOre.TabStop = false;
            this.pictureBoxGreenOre.Visible = false;
            // 
            // pictureBoxRedOre
            // 
            this.pictureBoxRedOre.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxRedOre.BackgroundImage = global::WinFormsLander.Properties.Resources.Red_Ore;
            this.pictureBoxRedOre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxRedOre.Location = new System.Drawing.Point(372, 204);
            this.pictureBoxRedOre.Name = "pictureBoxRedOre";
            this.pictureBoxRedOre.Size = new System.Drawing.Size(16, 16);
            this.pictureBoxRedOre.TabIndex = 22;
            this.pictureBoxRedOre.TabStop = false;
            this.pictureBoxRedOre.Visible = false;
            // 
            // pictureBoxAsteroid1
            // 
            this.pictureBoxAsteroid1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxAsteroid1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxAsteroid1.BackgroundImage")));
            this.pictureBoxAsteroid1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxAsteroid1.Location = new System.Drawing.Point(314, 204);
            this.pictureBoxAsteroid1.Name = "pictureBoxAsteroid1";
            this.pictureBoxAsteroid1.Size = new System.Drawing.Size(32, 22);
            this.pictureBoxAsteroid1.TabIndex = 21;
            this.pictureBoxAsteroid1.TabStop = false;
            this.pictureBoxAsteroid1.Visible = false;
            // 
            // labelCursor
            // 
            this.labelCursor.AutoSize = true;
            this.labelCursor.BackColor = System.Drawing.Color.Transparent;
            this.labelCursor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCursor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelCursor.Location = new System.Drawing.Point(385, 17);
            this.labelCursor.Name = "labelCursor";
            this.labelCursor.Size = new System.Drawing.Size(14, 13);
            this.labelCursor.TabIndex = 20;
            this.labelCursor.Text = "0";
            this.labelCursor.Visible = false;
            // 
            // pictureBoxCursor
            // 
            this.pictureBoxCursor.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCursor.Image = global::WinFormsLander.Properties.Resources.Off_Map_Cursor;
            this.pictureBoxCursor.Location = new System.Drawing.Point(388, -2);
            this.pictureBoxCursor.Name = "pictureBoxCursor";
            this.pictureBoxCursor.Size = new System.Drawing.Size(16, 16);
            this.pictureBoxCursor.TabIndex = 19;
            this.pictureBoxCursor.TabStop = false;
            this.pictureBoxCursor.Visible = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.Location = new System.Drawing.Point(223, 204);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(32, 32);
            this.pictureBox5.TabIndex = 18;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Visible = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(185, 204);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(32, 32);
            this.pictureBox4.TabIndex = 17;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Visible = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(142, 204);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 32);
            this.pictureBox3.TabIndex = 16;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(104, 204);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(66, 204);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelMessage.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMessage.ForeColor = System.Drawing.Color.White;
            this.labelMessage.Location = new System.Drawing.Point(239, 89);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(228, 37);
            this.labelMessage.TabIndex = 13;
            this.labelMessage.Text = "labelMessage";
            this.labelMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lz
            // 
            this.lz.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lz.Image = ((System.Drawing.Image)(resources.GetObject("lz.Image")));
            this.lz.Location = new System.Drawing.Point(303, 552);
            this.lz.Name = "lz";
            this.lz.Size = new System.Drawing.Size(129, 22);
            this.lz.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lz.TabIndex = 12;
            this.lz.TabStop = false;
            // 
            // FormStageBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(792, 573);
            this.ControlBox = false;
            this.Controls.Add(this.panelCurrentStage);
            this.Controls.Add(this.panelInfo);
            this.Controls.Add(this.panelStage);
            this.DoubleBuffered = true;
            this.Name = "FormStageBase";
            this.Text = "FormStageBase";
            this.Load += new System.EventHandler(this.FormStageBase_Load);
            this.VisibleChanged += new System.EventHandler(this.FormStageBase_VisibleChanged);
            this.panelCurrentStage.ResumeLayout(false);
            this.panelCurrentStage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLocation)).EndInit();
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShipLeft2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShipLeft1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDanger)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSpecialLED)).EndInit();
            this.panelConsole.ResumeLayout(false);
            this.panelConsole.PerformLayout();
            this.panelStage.ResumeLayout(false);
            this.panelStage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMetroid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAsteroid2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBlueOre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGreenOre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRedOre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAsteroid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCursor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lz)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panelCurrentStage;
        public System.Windows.Forms.Label labelLocation;
        public System.Windows.Forms.Label labelStage;
        public System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.Label labelFuel;
        public System.Windows.Forms.ProgressBar progressBarFuel;
        public System.Windows.Forms.ProgressBar progressBarSpeedToLZ;
        public System.Windows.Forms.Panel panelStage;
        public System.Windows.Forms.PictureBox lz;
        public System.Windows.Forms.Label labelGravity;
        public System.Windows.Forms.Label labelGravityValue;
        public System.Windows.Forms.Label labelWindValue;
        public System.Windows.Forms.Label labelWind;
        private System.Windows.Forms.Panel panelConsole;
        public System.Windows.Forms.PictureBox pictureBoxLocation;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label labelMessage;
        public System.Windows.Forms.PictureBox pictureBox5;
        public System.Windows.Forms.PictureBox pictureBox4;
        public System.Windows.Forms.PictureBox pictureBox3;
        public System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.PictureBox pictureBoxCursor;
        public System.Windows.Forms.PictureBox pictureBoxDanger;
        public System.Windows.Forms.ProgressBar progressBarSpeed;
        public System.Windows.Forms.Label labelAccelToLZ;
        public System.Windows.Forms.Label labelAccelDanger;
        public System.Windows.Forms.Label labelSpeed;
        public System.Windows.Forms.Label labelCursor;
        public System.Windows.Forms.PictureBox pictureBoxSpecialLED;
        private System.Windows.Forms.Button buttonEnd;
        public System.Windows.Forms.Label labelShipsLeft;
        public System.Windows.Forms.PictureBox pictureBoxShipLeft2;
        public System.Windows.Forms.PictureBox pictureBoxShipLeft1;
        public System.Windows.Forms.PictureBox pictureBoxAsteroid1;
        public System.Windows.Forms.PictureBox pictureBoxRedOre;
        public System.Windows.Forms.PictureBox pictureBoxGreenOre;
        public System.Windows.Forms.PictureBox pictureBoxBlueOre;
        public System.Windows.Forms.PictureBox pictureBoxAsteroid2;
        public System.Windows.Forms.PictureBox pictureBoxMetroid;
    }
}