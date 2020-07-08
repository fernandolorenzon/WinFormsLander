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
    public partial class FormChooseArea : FormBase
    {
        public FormChooseArea()
        {
            InitializeComponent();
        }

        private void FormArea_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Click(object sender, EventArgs e)
        {
            Globals.CurrentStage = 11;
            this.Visible = false;
            Globals.Stage.Visible = true;
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            Globals.CurrentStage = 21;
            this.Visible = false;
            Globals.Stage.Visible = true;
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            Globals.CurrentStage = 31;
            this.Visible = false;
            Globals.Stage.Visible = true;
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            Globals.CurrentStage = 41;
            this.Visible = false;
            Globals.Stage.Visible = true;
        }

        private void panel5_Click(object sender, EventArgs e)
        {
            Globals.CurrentStage = 51;
            this.Visible = false;
            Globals.Stage.Visible = true;
        }

        private void panel6_Click(object sender, EventArgs e)
        {
            Globals.CurrentStage = 61;
            this.Visible = false;
            Globals.Stage.Visible = true;
        }

        private void labelBack_Click(object sender, EventArgs e)
        {
            Globals.FormMain.Visible = true;
            this.Visible = false;
        }

        private void FormArea_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                GameFunctions.LoadGame();

                int shipIndex = GameFunctions.GetShipIndex(Globals.SelectedShip);

                this.panel1.Enabled = true;
                this.panel2.Enabled = Globals.SaveAreasShipsCompleted[0, shipIndex];
                this.panel3.Enabled = Globals.SaveAreasShipsCompleted[1, shipIndex];
                this.panel4.Enabled = Globals.SaveAreasShipsCompleted[2, shipIndex];
                this.panel5.Enabled = Globals.SaveAreasShipsCompleted[3, shipIndex];

                bool area6Enabled = this.panel1.Enabled && this.panel2.Enabled && this.panel3.Enabled && this.panel4.Enabled && this.panel5.Enabled;

                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if (!Globals.SaveAreasOreCollected[i, j])
                        {
                            area6Enabled = false;
                        }
                    }
                }

                this.panel6.Enabled = area6Enabled;

                if (!this.panel1.Enabled)
                {
                    this.panel1.BackgroundImage = WinFormsLander.Properties.Resources.Locked;
                }

                if (!this.panel2.Enabled)
                {
                    this.panel2.BackgroundImage = WinFormsLander.Properties.Resources.Locked;
                }

                if (!this.panel3.Enabled)
                {
                    this.panel3.BackgroundImage = WinFormsLander.Properties.Resources.Locked;
                }

                if (!this.panel4.Enabled)
                {
                    this.panel4.BackgroundImage = WinFormsLander.Properties.Resources.Locked;
                }

                if (!this.panel5.Enabled)
                {
                    this.panel5.BackgroundImage = WinFormsLander.Properties.Resources.Locked;
                }

                if (!this.panel6.Enabled)
                {
                    this.panel6.BackgroundImage = WinFormsLander.Properties.Resources.Locked;
                }
            }
        }
    }
}
