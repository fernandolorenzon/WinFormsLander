using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WinFormsLander.Classes;
using WinFormsLander.Functions;

namespace WinFormsLander.Forms
{
    public partial class FormChooseShip : FormBase
    {
        public ShipSprite landerSprite01;
        public ShipSprite landerSprite02;
        public ShipSprite landerSprite03;
        public ShipSprite landerSprite04;
        public ShipSprite landerSprite05;
        public ShipSprite landerSprite06;
        public ShipSprite landerSprite07;
        public ShipSprite landerSprite08;
        public ShipSprite landerSprite09;
        public ShipSprite landerSpriteX1;

        private const int fuelMultiplier = 09;

        public FormChooseShip()
        {
            InitializeComponent();
        }

        private void FormShips_Load(object sender, EventArgs e)
        {
            this.landerSprite01 = new ShipSprite(Enum.Ships.Type01, this.pictureBox01);
            this.landerSprite02 = new ShipSprite(Enum.Ships.Type02, this.pictureBox02);
            this.landerSprite03 = new ShipSprite(Enum.Ships.Type03, this.pictureBox03);
            this.landerSprite04 = new ShipSprite(Enum.Ships.Type04, this.pictureBox04);
            this.landerSprite05 = new ShipSprite(Enum.Ships.Type05, this.pictureBox05);
            this.landerSprite06 = new ShipSprite(Enum.Ships.Type06, this.pictureBox06);
            this.landerSprite07 = new ShipSprite(Enum.Ships.Type07, this.pictureBox07);
            this.landerSprite08 = new ShipSprite(Enum.Ships.Type08, this.pictureBox08);
            this.landerSprite09 = new ShipSprite(Enum.Ships.Type09, this.pictureBox09);
            this.landerSpriteX1 = new ShipSprite(Enum.Ships.TypeX1, this.pictureBoxX1);

            this.labelID01.Text = this.landerSprite01.ID;
            this.labelName01.Text = string.Format(this.labelName01.Text, this.landerSprite01.Name);
            this.labelAccel01.Text = string.Format(this.labelAccel01.Text, this.landerSprite01.AccelMpS);
            this.labelFuel01.Text = string.Format(this.labelFuel01.Text, this.landerSprite01.MaxFuel * fuelMultiplier);
            this.labelResistance01.Text = string.Format(this.labelResistance01.Text, Convert.ToDouble(this.landerSprite01.Resistance).ToString("0.00"));
            this.labelSpecial01.Text = string.Format(this.labelSpecial01.Text, this.landerSprite01.Special);

            this.labelID02.Text = this.landerSprite02.ID;
            this.labelName02.Text = string.Format(this.labelName02.Text, this.landerSprite02.Name);
            this.labelAccel02.Text = string.Format(this.labelAccel02.Text, this.landerSprite02.AccelMpS, 2);
            this.labelFuel02.Text = string.Format(this.labelFuel02.Text, this.landerSprite02.MaxFuel * fuelMultiplier);
            this.labelResistance02.Text = string.Format(this.labelResistance02.Text, Convert.ToDouble(this.landerSprite02.Resistance).ToString("0.00"));
            this.labelSpecial02.Text = string.Format(this.labelSpecial02.Text, this.landerSprite02.Special);

            this.labelID03.Text = this.landerSprite03.ID;
            this.labelName03.Text = string.Format(this.labelName03.Text, this.landerSprite03.Name);
            this.labelAccel03.Text = string.Format(this.labelAccel03.Text, this.landerSprite03.AccelMpS, 2);
            this.labelFuel03.Text = string.Format(this.labelFuel03.Text, this.landerSprite03.MaxFuel * fuelMultiplier);
            this.labelResistance03.Text = string.Format(this.labelResistance03.Text, Convert.ToDouble(this.landerSprite03.Resistance).ToString("0.00"));
            this.labelSpecial03.Text = string.Format(this.labelSpecial03.Text, this.landerSprite03.Special);

            this.labelID04.Text = this.landerSprite04.ID;
            this.labelName04.Text = string.Format(this.labelName04.Text, this.landerSprite04.Name);
            this.labelAccel04.Text = string.Format(this.labelAccel04.Text, this.landerSprite04.AccelMpS, 2);
            this.labelFuel04.Text = string.Format(this.labelFuel04.Text, this.landerSprite04.MaxFuel * fuelMultiplier);
            this.labelResistance04.Text = string.Format(this.labelResistance04.Text, Convert.ToDouble(this.landerSprite04.Resistance).ToString("0.00"));
            this.labelSpecial04.Text = string.Format(this.labelSpecial04.Text, this.landerSprite04.Special);

            this.labelID05.Text = this.landerSprite05.ID;
            this.labelName05.Text = string.Format(this.labelName05.Text, this.landerSprite05.Name);
            this.labelAccel05.Text = string.Format(this.labelAccel05.Text, this.landerSprite05.AccelMpS, 2);
            this.labelFuel05.Text = string.Format(this.labelFuel05.Text, this.landerSprite05.MaxFuel * fuelMultiplier);
            this.labelResistance05.Text = string.Format(this.labelResistance05.Text, Convert.ToDouble(this.landerSprite05.Resistance).ToString("0.00"));
            this.labelSpecial05.Text = string.Format(this.labelSpecial05.Text, this.landerSprite05.Special);

            this.labelID06.Text = this.landerSprite06.ID;
            this.labelName06.Text = string.Format(this.labelName06.Text, this.landerSprite06.Name);
            this.labelAccel06.Text = string.Format(this.labelAccel06.Text, this.landerSprite06.AccelMpS, 2);
            this.labelFuel06.Text = string.Format(this.labelFuel06.Text, this.landerSprite06.MaxFuel * fuelMultiplier);
            this.labelResistance06.Text = string.Format(this.labelResistance06.Text, Convert.ToDouble(this.landerSprite06.Resistance).ToString("0.00"));
            this.labelSpecial06.Text = string.Format(this.labelSpecial06.Text, this.landerSprite06.Special);

            this.labelID07.Text = this.landerSprite07.ID;
            this.labelName07.Text = string.Format(this.labelName07.Text, this.landerSprite07.Name);
            this.labelAccel07.Text = string.Format(this.labelAccel07.Text, this.landerSprite07.AccelMpS, 2);
            this.labelFuel07.Text = string.Format(this.labelFuel07.Text, this.landerSprite07.MaxFuel * fuelMultiplier);
            this.labelResistance07.Text = string.Format(this.labelResistance07.Text, Convert.ToDouble(this.landerSprite07.Resistance).ToString("0.00"));
            this.labelSpecial07.Text = string.Format(this.labelSpecial07.Text, this.landerSprite07.Special);

            this.labelID08.Text = this.landerSprite08.ID;
            this.labelName08.Text = string.Format(this.labelName08.Text, this.landerSprite08.Name);
            this.labelAccel08.Text = string.Format(this.labelAccel08.Text, this.landerSprite08.AccelMpS, 2);
            this.labelFuel08.Text = string.Format(this.labelFuel08.Text, this.landerSprite08.MaxFuel * fuelMultiplier);
            this.labelResistance08.Text = string.Format(this.labelResistance08.Text, Convert.ToDouble(this.landerSprite08.Resistance).ToString("0.00"));
            this.labelSpecial08.Text = string.Format(this.labelSpecial08.Text, this.landerSprite08.Special);

            this.labelID09.Text = this.landerSprite09.ID;
            this.labelName09.Text = string.Format(this.labelName09.Text, this.landerSprite09.Name);
            this.labelAccel09.Text = string.Format(this.labelAccel09.Text, this.landerSprite09.AccelMpS, 2);
            this.labelFuel09.Text = string.Format(this.labelFuel09.Text, this.landerSprite09.MaxFuel * fuelMultiplier);
            this.labelResistance09.Text = string.Format(this.labelResistance09.Text, Convert.ToDouble(this.landerSprite09.Resistance).ToString("0.00"));
            this.labelSpecial09.Text = string.Format(this.labelSpecial09.Text, this.landerSprite09.Special);

            this.labelIDX1.Text = this.landerSpriteX1.ID;
            this.labelNameX1.Text = string.Format(this.labelNameX1.Text, this.landerSpriteX1.Name);
            this.labelAccelX1.Text = string.Format(this.labelAccelX1.Text, this.landerSpriteX1.AccelMpS, 2);
            this.labelFuelX1.Text = string.Format(this.labelFuelX1.Text, this.landerSpriteX1.MaxFuel * fuelMultiplier);
            this.labelResistanceX1.Text = string.Format(this.labelResistanceX1.Text, Convert.ToDouble(this.landerSpriteX1.Resistance).ToString("0.00"));
            this.labelSpecialX1.Text = string.Format(this.labelSpecialX1.Text, this.landerSpriteX1.Special);
        }

        private void lander01_Click(object sender, EventArgs e)
        {
            this.ApplySelection(this.landerSprite01);
        }

        private void lander02_Click(object sender, EventArgs e)
        {
            this.ApplySelection(this.landerSprite02);
        }

        private void pictureBox03_Click(object sender, EventArgs e)
        {
            this.ApplySelection(this.landerSprite03);
        }

        private void pictureBox04_Click(object sender, EventArgs e)
        {
            this.ApplySelection(this.landerSprite04);
        }

        private void pictureBox05_Click(object sender, EventArgs e)
        {
            this.ApplySelection(this.landerSprite05);
        }

        private void pictureBox06_Click(object sender, EventArgs e)
        {
            this.ApplySelection(this.landerSprite06);
        }

        private void pictureBox07_Click(object sender, EventArgs e)
        {
            this.ApplySelection(this.landerSprite07);
        }

        private void pictureBox08_Click(object sender, EventArgs e)
        {
            this.ApplySelection(this.landerSprite08);
        }

        private void pictureBox09_Click(object sender, EventArgs e)
        {
            this.ApplySelection(this.landerSprite09);
        }

        private void pictureBoxX1_Click(object sender, EventArgs e)
        {
            this.ApplySelection(this.landerSpriteX1);
        }

        private void labelBack_Click(object sender, EventArgs e)
        {
            Globals.FormMain.Visible = true;
            this.Visible = false;
        }

        private void ApplySelection(ShipSprite selectedShip)
        {
            Globals.SelectedShip = LanderFunctions.LoadShipSprites(selectedShip);
            Globals.FormMain.Visible = true;
            this.Visible = false;
            GameFunctions.RecordFeatures(Enum.RecordType.SelectedShip);
        }

        private void FormShips_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                GameFunctions.LoadGame();
                int shipIndex = 0;

                this.panel01.Enabled = true; ;
                this.panel02.Enabled = Globals.SaveAreasShipsCompleted[4, shipIndex];
                this.panel03.Enabled = Globals.SaveAreasShipsCompleted[4, ++shipIndex];
                this.panel04.Enabled = Globals.SaveAreasShipsCompleted[4, ++shipIndex];
                this.panel05.Enabled = Globals.SaveAreasShipsCompleted[4, ++shipIndex];
                this.panel06.Enabled = Globals.SaveAreasShipsCompleted[4, ++shipIndex];
                this.panel07.Enabled = Globals.SaveAreasShipsCompleted[4, ++shipIndex];
                this.panel08.Enabled = Globals.SaveAreasShipsCompleted[4, ++shipIndex];
                this.panel09.Enabled = Globals.SaveAreasShipsCompleted[4, ++shipIndex];

                bool shipX1Enabled = true;

                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if (!Globals.SaveAreasOreCollected[i, j])
                        {
                            shipX1Enabled = false;
                        }
                    }
                }

                this.panelX1.Enabled = shipX1Enabled;

                this.pictureBox01.Visible = this.panel01.Enabled;
                this.pictureBox02.Visible = this.panel02.Enabled;
                this.pictureBox03.Visible = this.panel03.Enabled;
                this.pictureBox04.Visible = this.panel04.Enabled;
                this.pictureBox05.Visible = this.panel05.Enabled;
                this.pictureBox06.Visible = this.panel06.Enabled;
                this.pictureBox07.Visible = this.panel07.Enabled;
                this.pictureBox08.Visible = this.panel08.Enabled;
                this.pictureBox09.Visible = this.panel09.Enabled;
                this.pictureBoxX1.Visible = this.panelX1.Enabled;

                if (!this.panel01.Enabled)
                {
                    this.panel01.BackgroundImage = WinFormsLander.Properties.Resources.Locked;
                    this.labelID01.Visible = this.panel01.Enabled;
                    this.labelName01.Visible = this.panel01.Enabled;
                    this.labelFuel01.Visible = this.panel01.Enabled;
                    this.labelResistance01.Visible = this.panel01.Enabled;
                    this.labelSpecial01.Visible = this.panel01.Enabled;
                }

                if (!this.panel02.Enabled)
                {
                    this.panel02.BackgroundImage = WinFormsLander.Properties.Resources.Locked;
                    this.labelID02.Visible = this.panel02.Enabled;
                    this.labelName02.Visible = this.panel02.Enabled;
                    this.labelFuel02.Visible = this.panel02.Enabled;
                    this.labelResistance02.Visible = this.panel02.Enabled;
                    this.labelSpecial02.Visible = this.panel02.Enabled;
                }

                if (!this.panel03.Enabled)
                {
                    this.panel03.BackgroundImage = WinFormsLander.Properties.Resources.Locked;
                    this.labelID03.Visible = this.panel03.Enabled;
                    this.labelName03.Visible = this.panel03.Enabled;
                    this.labelFuel03.Visible = this.panel03.Enabled;
                    this.labelResistance03.Visible = this.panel03.Enabled;
                    this.labelSpecial03.Visible = this.panel03.Enabled;
                }

                if (!this.panel04.Enabled)
                {
                    this.panel04.BackgroundImage = WinFormsLander.Properties.Resources.Locked;
                    this.labelID04.Visible = this.panel04.Enabled;
                    this.labelName04.Visible = this.panel04.Enabled;
                    this.labelFuel04.Visible = this.panel04.Enabled;
                    this.labelResistance04.Visible = this.panel04.Enabled;
                    this.labelSpecial04.Visible = this.panel04.Enabled;
                }

                if (!this.panel05.Enabled)
                {
                    this.panel05.BackgroundImage = WinFormsLander.Properties.Resources.Locked;
                    this.labelID05.Visible = this.panel05.Enabled;
                    this.labelName05.Visible = this.panel05.Enabled;
                    this.labelFuel05.Visible = this.panel05.Enabled;
                    this.labelResistance05.Visible = this.panel05.Enabled;
                    this.labelSpecial05.Visible = this.panel05.Enabled;
                }

                if (!this.panel06.Enabled)
                {
                    this.panel06.BackgroundImage = WinFormsLander.Properties.Resources.Locked;
                    this.labelID06.Visible = this.panel06.Enabled;
                    this.labelName06.Visible = this.panel06.Enabled;
                    this.labelFuel06.Visible = this.panel06.Enabled;
                    this.labelResistance06.Visible = this.panel06.Enabled;
                    this.labelSpecial06.Visible = this.panel06.Enabled;
                }

                if (!this.panel07.Enabled)
                {
                    this.panel07.BackgroundImage = WinFormsLander.Properties.Resources.Locked;
                    this.labelID07.Visible = this.panel07.Enabled;
                    this.labelName07.Visible = this.panel07.Enabled;
                    this.labelFuel07.Visible = this.panel07.Enabled;
                    this.labelResistance07.Visible = this.panel07.Enabled;
                    this.labelSpecial07.Visible = this.panel07.Enabled;
                }

                if (!this.panel08.Enabled)
                {
                    this.panel08.BackgroundImage = WinFormsLander.Properties.Resources.Locked;
                    this.labelID08.Visible = this.panel08.Enabled;
                    this.labelName08.Visible = this.panel08.Enabled;
                    this.labelFuel08.Visible = this.panel08.Enabled;
                    this.labelResistance08.Visible = this.panel08.Enabled;
                    this.labelSpecial08.Visible = this.panel08.Enabled;
                }

                if (!this.panel09.Enabled)
                {
                    this.panel09.BackgroundImage = WinFormsLander.Properties.Resources.Locked;
                    this.labelID09.Visible = this.panel09.Enabled;
                    this.labelName09.Visible = this.panel09.Enabled;
                    this.labelFuel09.Visible = this.panel09.Enabled;
                    this.labelResistance09.Visible = this.panel09.Enabled;
                    this.labelSpecial09.Visible = this.panel09.Enabled;
                }

                if (!this.panelX1.Enabled)
                {
                    this.panelX1.BackgroundImage = WinFormsLander.Properties.Resources.Locked;
                    this.labelIDX1.Visible = this.panelX1.Enabled;
                    this.labelNameX1.Visible = this.panelX1.Enabled;
                    this.labelFuelX1.Visible = this.panelX1.Enabled;
                    this.labelResistanceX1.Visible = this.panelX1.Enabled;
                    this.labelSpecialX1.Visible = this.panelX1.Enabled;
                }
            }
        }
    }
}