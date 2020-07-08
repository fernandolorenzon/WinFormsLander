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
    public partial class FormMain : FormBase
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            Globals.Stage = new FormStageBase();
            Globals.FormMain = this;
            Globals.ChooseShip = new FormChooseShip();
            Globals.ChooseStage = new FormChooseStage();
            Globals.FormClear = new FormClear();
            Globals.ChooseArea = new FormChooseArea();

            Enum.Ships selected = Enum.Ships.Type01;

            if (Globals.SaveSelectedShip == Enum.Ships.Type01.ToString())
            {
                selected = Enum.Ships.Type01;
            }
            else if (Globals.SaveSelectedShip == Enum.Ships.Type02.ToString())
            {
                selected = Enum.Ships.Type02;
            }
            else if (Globals.SaveSelectedShip == Enum.Ships.Type03.ToString())
            {
                selected = Enum.Ships.Type03;
            }
            else if (Globals.SaveSelectedShip == Enum.Ships.Type04.ToString())
            {
                selected = Enum.Ships.Type04;
            }
            else if (Globals.SaveSelectedShip == Enum.Ships.Type05.ToString())
            {
                selected = Enum.Ships.Type05;
            }
            else if (Globals.SaveSelectedShip == Enum.Ships.Type06.ToString())
            {
                selected = Enum.Ships.Type06;
            }
            else if (Globals.SaveSelectedShip == Enum.Ships.Type07.ToString())
            {
                selected = Enum.Ships.Type07;
            }
            else if (Globals.SaveSelectedShip == Enum.Ships.Type08.ToString())
            {
                selected = Enum.Ships.Type08;
            }
            else if (Globals.SaveSelectedShip == Enum.Ships.Type09.ToString())
            {
                selected = Enum.Ships.Type09;
            }
            else if (Globals.SaveSelectedShip == Enum.Ships.TypeX1.ToString())
            {
                selected = Enum.Ships.TypeX1;
            }

            Globals.SelectedShip = LanderFunctions.LoadShipSprites(new ShipSprite(selected, this.pictureBoxLander));
        }

        private void labelArcade_Click(object sender, EventArgs e)
        {
            Globals.SelectedSFX.Play();
            Globals.GameType = Enum.GameType.Arcade;

            Globals.timerOptionDelay.Interval = 1000;
            Globals.timerOptionDelay.Enabled = true;
            Globals.timerOptionDelay.Start();
        }

        private void labelOreColleting_Click(object sender, EventArgs e)
        {
            Globals.SelectedSFX.Play();
            Globals.GameType = Enum.GameType.OreColleting;

            Globals.timerOptionDelay.Interval = 1000;
            Globals.timerOptionDelay.Enabled = true;
            Globals.timerOptionDelay.Start();
        }

        private void labelFreePlay_Click(object sender, EventArgs e)
        {
            Globals.SelectedSFX.Play();
            Globals.GameType = Enum.GameType.Free;

            Globals.timerOptionDelay.Interval = 1000;
            Globals.timerOptionDelay.Enabled = true;
            Globals.timerOptionDelay.Start();
        }

        private void labelChooseShip_Click(object sender, EventArgs e)
        {
            Globals.SelectedSFX.Play();
            this.Visible = false;
            Globals.ChooseShip = new FormChooseShip();
            Globals.ChooseShip.Show();
        }

        private void FormMain_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                Globals.MusicPlayer.PlayLooping();
            }

            this.pictureBoxLander.BackgroundImage = Globals.SelectedShip.ImageDefault;
        }

        private void labelExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
