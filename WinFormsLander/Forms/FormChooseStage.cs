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
    public partial class FormChooseStage : FormBase
    {
        int gravity = 10;

        public FormChooseStage()
        {
            InitializeComponent();
        }

        private void FormStages_Load(object sender, EventArgs e)
        {
            this.pictureBoxOre1_1.BackgroundImage = WinFormsLander.Properties.Resources.OreCollected;
            this.pictureBoxOre1_2.BackgroundImage = WinFormsLander.Properties.Resources.OreCollected;
            this.pictureBoxOre1_3.BackgroundImage = WinFormsLander.Properties.Resources.OreCollected;
            this.pictureBoxOre1_4.BackgroundImage = WinFormsLander.Properties.Resources.OreCollected;
            this.pictureBoxOre1_5.BackgroundImage = WinFormsLander.Properties.Resources.OreCollected;
            this.pictureBoxOre2_1.BackgroundImage = WinFormsLander.Properties.Resources.OreCollected;
            this.pictureBoxOre2_2.BackgroundImage = WinFormsLander.Properties.Resources.OreCollected;
            this.pictureBoxOre2_3.BackgroundImage = WinFormsLander.Properties.Resources.OreCollected;
            this.pictureBoxOre2_4.BackgroundImage = WinFormsLander.Properties.Resources.OreCollected;
            this.pictureBoxOre2_5.BackgroundImage = WinFormsLander.Properties.Resources.OreCollected;
            this.pictureBoxOre3_1.BackgroundImage = WinFormsLander.Properties.Resources.OreCollected;
            this.pictureBoxOre3_2.BackgroundImage = WinFormsLander.Properties.Resources.OreCollected;
            this.pictureBoxOre3_3.BackgroundImage = WinFormsLander.Properties.Resources.OreCollected;
            this.pictureBoxOre3_4.BackgroundImage = WinFormsLander.Properties.Resources.OreCollected;
            this.pictureBoxOre3_5.BackgroundImage = WinFormsLander.Properties.Resources.OreCollected;
            this.pictureBoxOre4_1.BackgroundImage = WinFormsLander.Properties.Resources.OreCollected;
            this.pictureBoxOre4_2.BackgroundImage = WinFormsLander.Properties.Resources.OreCollected;
            this.pictureBoxOre4_3.BackgroundImage = WinFormsLander.Properties.Resources.OreCollected;
            this.pictureBoxOre4_4.BackgroundImage = WinFormsLander.Properties.Resources.OreCollected;
            this.pictureBoxOre4_5.BackgroundImage = WinFormsLander.Properties.Resources.OreCollected;
            this.pictureBoxOre5_1.BackgroundImage = WinFormsLander.Properties.Resources.OreCollected;
            this.pictureBoxOre5_2.BackgroundImage = WinFormsLander.Properties.Resources.OreCollected;
            this.pictureBoxOre5_3.BackgroundImage = WinFormsLander.Properties.Resources.OreCollected;
            this.pictureBoxOre5_4.BackgroundImage = WinFormsLander.Properties.Resources.OreCollected;
            this.pictureBoxOre5_5.BackgroundImage = WinFormsLander.Properties.Resources.OreCollected;
            this.pictureBoxOre6_1.BackgroundImage = WinFormsLander.Properties.Resources.OreCollected;
            this.pictureBoxOre6_2.BackgroundImage = WinFormsLander.Properties.Resources.OreCollected;
            this.pictureBoxOre6_3.BackgroundImage = WinFormsLander.Properties.Resources.OreCollected;
            this.pictureBoxOre6_4.BackgroundImage = WinFormsLander.Properties.Resources.OreCollected;
            this.pictureBoxOre6_5.BackgroundImage = WinFormsLander.Properties.Resources.OreCollected;
        }

        private void labelBack_Click(object sender, EventArgs e)
        {
            Globals.FormMain.Visible = true;
            this.Visible = false;
        }

        private void checkBoxGravity_CheckedChanged(object sender, EventArgs e)
        {
            this.labelGravityValue.Visible = this.checkBoxGravity.Checked;
            this.labelAdd.Visible = this.checkBoxGravity.Checked;
            this.labelRemove.Visible = this.checkBoxGravity.Checked;
        }

        private void labelAdd_Click(object sender, EventArgs e)
        {
            if (this.gravity < 30)
            {
                this.gravity++;
            }

            this.labelGravityValue.Text = this.gravity.ToString();
        }

        private void labelRemove_Click(object sender, EventArgs e)
        {
            if (this.gravity > 1)
            {
                this.gravity--;
            }

            this.labelGravityValue.Text = this.gravity.ToString();
        }

        private void pictureBox0_1_Click(object sender, EventArgs e)
        {
            Globals.StageFreeCollision = this.checkBoxCollision.Checked;
            Globals.StageFreeGravity = this.checkBoxGravity.Checked;

            Globals.CurrentStage = 0;

            if (this.checkBoxGravity.Checked)
            {
                Globals.LZGForce = gravity;
            }
            else
            {
                Globals.LZGForce = 0;
            }
            
            this.Visible = false;
            Globals.Stage.Visible = true;


        }

        private void pictureBox1_1_Click(object sender, EventArgs e)
        {
            Globals.CurrentStage = 11;
            this.Visible = false;
            Globals.Stage.Visible = true;
        }

        private void pictureBox1_2_Click(object sender, EventArgs e)
        {
            Globals.CurrentStage = 12;
            this.Visible = false;
            Globals.Stage.Visible = true;
        }

        private void pictureBox1_3_Click(object sender, EventArgs e)
        {
            Globals.CurrentStage = 13;
            this.Visible = false;
            Globals.Stage.Visible = true;
        }

        private void pictureBox1_4_Click(object sender, EventArgs e)
        {
            Globals.CurrentStage = 14;
            this.Visible = false;
            Globals.Stage.Visible = true;
        }

        private void pictureBox1_5_Click(object sender, EventArgs e)
        {
            Globals.CurrentStage = 15;
            this.Visible = false;
            Globals.Stage.Visible = true;
        }

        private void pictureBox2_1_Click(object sender, EventArgs e)
        {
            Globals.CurrentStage = 21;
            this.Visible = false;
            Globals.Stage.Visible = true;
        }

        private void pictureBox2_2_Click(object sender, EventArgs e)
        {
            Globals.CurrentStage = 22;
            this.Visible = false;
            Globals.Stage.Visible = true;
        }

        private void pictureBox2_3_Click(object sender, EventArgs e)
        {
            Globals.CurrentStage = 23;
            this.Visible = false;
            Globals.Stage.Visible = true;
        }

        private void pictureBox2_4_Click(object sender, EventArgs e)
        {
            Globals.CurrentStage = 24;
            this.Visible = false;
            Globals.Stage.Visible = true;
        }

        private void pictureBox2_5_Click(object sender, EventArgs e)
        {
            Globals.CurrentStage = 25;
            this.Visible = false;
            Globals.Stage.Visible = true;
        }

        private void pictureBox3_1_Click(object sender, EventArgs e)
        {
            Globals.CurrentStage = 31;
            this.Visible = false;
            Globals.Stage.Visible = true;
        }

        private void pictureBox3_2_Click(object sender, EventArgs e)
        {
            Globals.CurrentStage = 32;
            this.Visible = false;
            Globals.Stage.Visible = true;
        }

        private void pictureBox3_3_Click(object sender, EventArgs e)
        {
            Globals.CurrentStage = 33;
            this.Visible = false;
            Globals.Stage.Visible = true;
        }

        private void pictureBox3_4_Click(object sender, EventArgs e)
        {
            Globals.CurrentStage = 34;
            this.Visible = false;
            Globals.Stage.Visible = true;
        }

        private void pictureBox3_5_Click(object sender, EventArgs e)
        {
            Globals.CurrentStage = 35;
            this.Visible = false;
            Globals.Stage.Visible = true;
        }

        private void pictureBox4_1_Click(object sender, EventArgs e)
        {
            Globals.CurrentStage = 41;
            this.Visible = false;
            Globals.Stage.Visible = true;
        }

        private void pictureBox4_2_Click(object sender, EventArgs e)
        {
            Globals.CurrentStage = 42;
            this.Visible = false;
            Globals.Stage.Visible = true;
        }

        private void pictureBox4_3_Click(object sender, EventArgs e)
        {
            Globals.CurrentStage = 43;
            this.Visible = false;
            Globals.Stage.Visible = true;
        }

        private void pictureBox4_4_Click(object sender, EventArgs e)
        {
            Globals.CurrentStage = 44;
            this.Visible = false;
            Globals.Stage.Visible = true;
        }

        private void pictureBox4_5_Click(object sender, EventArgs e)
        {
            Globals.CurrentStage = 45;
            this.Visible = false;
            Globals.Stage.Visible = true;
        }

        private void pictureBox5_1_Click(object sender, EventArgs e)
        {
            Globals.CurrentStage = 51;
            this.Visible = false;
            Globals.Stage.Visible = true;
        }

        private void pictureBox5_2_Click(object sender, EventArgs e)
        {
            Globals.CurrentStage = 52;
            this.Visible = false;
            Globals.Stage.Visible = true;
        }

        private void pictureBox5_3_Click(object sender, EventArgs e)
        {
            Globals.CurrentStage = 53;
            this.Visible = false;
            Globals.Stage.Visible = true;
        }

        private void pictureBox5_4_Click(object sender, EventArgs e)
        {
            Globals.CurrentStage = 54;
            this.Visible = false;
            Globals.Stage.Visible = true;
        }

        private void pictureBox5_5_Click(object sender, EventArgs e)
        {
            Globals.CurrentStage = 55;
            this.Visible = false;
            Globals.Stage.Visible = true;
        }

        private void pictureBox6_1_Click(object sender, EventArgs e)
        {
            Globals.CurrentStage = 61;
            this.Visible = false;
            Globals.Stage.Visible = true;
        }

        private void pictureBox6_2_Click(object sender, EventArgs e)
        {
            Globals.CurrentStage = 62;
            this.Visible = false;
            Globals.Stage.Visible = true;
        }

        private void pictureBox6_3_Click(object sender, EventArgs e)
        {
            Globals.CurrentStage = 63;
            this.Visible = false;
            Globals.Stage.Visible = true;
        }

        private void pictureBox6_4_Click(object sender, EventArgs e)
        {
            Globals.CurrentStage = 64;
            this.Visible = false;
            Globals.Stage.Visible = true;
        }

        private void pictureBox6_5_Click(object sender, EventArgs e)
        {
            Globals.CurrentStage = 65;
            this.Visible = false;
            Globals.Stage.Visible = true;
        }

        private void FormStages_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                Globals.MusicPlayer.PlayLooping();
                this.labelGravityValue.Text = gravity.ToString();
                Globals.Stage = new FormStageBase();

                GameFunctions.LoadGame();

                #region EnableStages

                int shipIndex = GameFunctions.GetShipIndex(Globals.SelectedShip);

                this.panel1.Enabled = true;
                this.panel2.Enabled = Globals.SaveAreasShipsCompleted[1, shipIndex];
                this.panel3.Enabled = Globals.SaveAreasShipsCompleted[2, shipIndex];
                this.panel4.Enabled = Globals.SaveAreasShipsCompleted[3, shipIndex];
                this.panel5.Enabled = Globals.SaveAreasShipsCompleted[4, shipIndex];

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

                this.pictureBox1_1.Visible = this.panel1.Enabled;
                this.pictureBox1_2.Visible = this.panel1.Enabled;
                this.pictureBox1_3.Visible = this.panel1.Enabled;
                this.pictureBox1_4.Visible = this.panel1.Enabled;
                this.pictureBox1_5.Visible = this.panel1.Enabled;

                this.label1_1.Visible = this.panel1.Enabled;
                this.label1_2.Visible = this.panel1.Enabled;
                this.label1_3.Visible = this.panel1.Enabled;
                this.label1_4.Visible = this.panel1.Enabled;
                this.label1_5.Visible = this.panel1.Enabled;

                this.pictureBox2_1.Visible = this.panel2.Enabled;
                this.pictureBox2_2.Visible = this.panel2.Enabled;
                this.pictureBox2_3.Visible = this.panel2.Enabled;
                this.pictureBox2_4.Visible = this.panel2.Enabled;
                this.pictureBox2_5.Visible = this.panel2.Enabled;

                this.label2_1.Visible = this.panel2.Enabled;
                this.label2_2.Visible = this.panel2.Enabled;
                this.label2_3.Visible = this.panel2.Enabled;
                this.label2_4.Visible = this.panel2.Enabled;
                this.label2_5.Visible = this.panel2.Enabled;

                this.pictureBox3_1.Visible = this.panel3.Enabled;
                this.pictureBox3_2.Visible = this.panel3.Enabled;
                this.pictureBox3_3.Visible = this.panel3.Enabled;
                this.pictureBox3_4.Visible = this.panel3.Enabled;
                this.pictureBox3_5.Visible = this.panel3.Enabled;

                this.label3_1.Visible = this.panel3.Enabled;
                this.label3_2.Visible = this.panel3.Enabled;
                this.label3_3.Visible = this.panel3.Enabled;
                this.label3_4.Visible = this.panel3.Enabled;
                this.label3_5.Visible = this.panel3.Enabled;

                this.pictureBox4_1.Visible = this.panel4.Enabled;
                this.pictureBox4_2.Visible = this.panel4.Enabled;
                this.pictureBox4_3.Visible = this.panel4.Enabled;
                this.pictureBox4_4.Visible = this.panel4.Enabled;
                this.pictureBox4_5.Visible = this.panel4.Enabled;

                this.label4_1.Visible = this.panel4.Enabled;
                this.label4_2.Visible = this.panel4.Enabled;
                this.label4_3.Visible = this.panel4.Enabled;
                this.label4_4.Visible = this.panel4.Enabled;
                this.label4_5.Visible = this.panel4.Enabled;

                this.pictureBox5_1.Visible = this.panel5.Enabled;
                this.pictureBox5_2.Visible = this.panel5.Enabled;
                this.pictureBox5_3.Visible = this.panel5.Enabled;
                this.pictureBox5_4.Visible = this.panel5.Enabled;
                this.pictureBox5_5.Visible = this.panel5.Enabled;

                this.label5_1.Visible = this.panel5.Enabled;
                this.label5_2.Visible = this.panel5.Enabled;
                this.label5_3.Visible = this.panel5.Enabled;
                this.label5_4.Visible = this.panel5.Enabled;
                this.label5_5.Visible = this.panel5.Enabled;

                this.pictureBox6_1.Visible = this.panel6.Enabled;
                this.pictureBox6_2.Visible = this.panel6.Enabled;
                this.pictureBox6_3.Visible = this.panel6.Enabled;
                this.pictureBox6_4.Visible = this.panel6.Enabled;
                this.pictureBox6_5.Visible = this.panel6.Enabled;

                this.label6_1.Visible = this.panel6.Enabled;
                this.label6_2.Visible = this.panel6.Enabled;
                this.label6_3.Visible = this.panel6.Enabled;
                this.label6_4.Visible = this.panel6.Enabled;
                this.label6_5.Visible = this.panel6.Enabled;

                if (!this.panel1.Enabled)
                {
                    this.panel1.BackgroundImage = WinFormsLander.Properties.Resources.Locked;
                }
                else
                {
                    this.panel1.BackgroundImage = null;
                }

                if (!this.panel2.Enabled)
                {
                    this.panel2.BackgroundImage = WinFormsLander.Properties.Resources.Locked;
                }
                else
                {
                    this.panel2.BackgroundImage = null;
                }

                if (!this.panel3.Enabled)
                {
                    this.panel3.BackgroundImage = WinFormsLander.Properties.Resources.Locked;
                }
                else
                {
                    this.panel3.BackgroundImage = null;
                }

                if (!this.panel4.Enabled)
                {
                    this.panel4.BackgroundImage = WinFormsLander.Properties.Resources.Locked;
                }
                else
                {
                    this.panel4.BackgroundImage = null;
                }

                if (!this.panel5.Enabled)
                {
                    this.panel5.BackgroundImage = WinFormsLander.Properties.Resources.Locked;
                }
                else
                {
                    this.panel5.BackgroundImage = null;
                }

                if (!this.panel6.Enabled)
                {
                    this.panel6.BackgroundImage = WinFormsLander.Properties.Resources.Locked;
                }
                else
                {
                    this.panel6.BackgroundImage = null;
                }

                #endregion

                #region EnableOre

                int areaIndex = 0;
                int stageIndex = 0;

                bool isOreColleting = Globals.GameType == Enum.GameType.OreColleting;

                if (!isOreColleting)
                {
                    this.labelSecretInfo.Visible = isOreColleting;
                    this.pictureBoxOre1_1.Visible = isOreColleting;
                    this.pictureBoxOre1_2.Visible = isOreColleting;
                    this.pictureBoxOre1_3.Visible = isOreColleting;
                    this.pictureBoxOre1_4.Visible = isOreColleting;
                    this.pictureBoxOre1_5.Visible = isOreColleting;
                    this.pictureBoxOre2_1.Visible = isOreColleting;
                    this.pictureBoxOre2_2.Visible = isOreColleting;
                    this.pictureBoxOre2_3.Visible = isOreColleting;
                    this.pictureBoxOre2_4.Visible = isOreColleting;
                    this.pictureBoxOre2_5.Visible = isOreColleting;
                    this.pictureBoxOre3_1.Visible = isOreColleting;
                    this.pictureBoxOre3_2.Visible = isOreColleting;
                    this.pictureBoxOre3_3.Visible = isOreColleting;
                    this.pictureBoxOre3_4.Visible = isOreColleting;
                    this.pictureBoxOre3_5.Visible = isOreColleting;
                    this.pictureBoxOre4_1.Visible = isOreColleting;
                    this.pictureBoxOre4_2.Visible = isOreColleting;
                    this.pictureBoxOre4_3.Visible = isOreColleting;
                    this.pictureBoxOre4_4.Visible = isOreColleting;
                    this.pictureBoxOre4_5.Visible = isOreColleting;
                    this.pictureBoxOre5_1.Visible = isOreColleting;
                    this.pictureBoxOre5_2.Visible = isOreColleting;
                    this.pictureBoxOre5_3.Visible = isOreColleting;
                    this.pictureBoxOre5_4.Visible = isOreColleting;
                    this.pictureBoxOre5_5.Visible = isOreColleting;
                    this.pictureBoxOre6_1.Visible = isOreColleting;
                    this.pictureBoxOre6_2.Visible = isOreColleting;
                    this.pictureBoxOre6_3.Visible = isOreColleting;
                    this.pictureBoxOre6_4.Visible = isOreColleting;
                    this.pictureBoxOre6_5.Visible = isOreColleting;
                }
                else
                {
                    this.pictureBoxOre1_1.Visible = this.panel1.Enabled && Globals.SaveAreasOreCollected[areaIndex, stageIndex];
                    this.pictureBoxOre1_2.Visible = this.panel1.Enabled && Globals.SaveAreasOreCollected[areaIndex, ++stageIndex];
                    this.pictureBoxOre1_3.Visible = this.panel1.Enabled && Globals.SaveAreasOreCollected[areaIndex, ++stageIndex];
                    this.pictureBoxOre1_4.Visible = this.panel1.Enabled && Globals.SaveAreasOreCollected[areaIndex, ++stageIndex];
                    this.pictureBoxOre1_5.Visible = this.panel1.Enabled && Globals.SaveAreasOreCollected[areaIndex, ++stageIndex];

                    stageIndex = 0;

                    this.pictureBoxOre2_1.Visible = this.panel2.Enabled && Globals.SaveAreasOreCollected[++areaIndex, stageIndex];
                    this.pictureBoxOre2_2.Visible = this.panel2.Enabled && Globals.SaveAreasOreCollected[areaIndex, ++stageIndex];
                    this.pictureBoxOre2_3.Visible = this.panel2.Enabled && Globals.SaveAreasOreCollected[areaIndex, ++stageIndex];
                    this.pictureBoxOre2_4.Visible = this.panel2.Enabled && Globals.SaveAreasOreCollected[areaIndex, ++stageIndex];
                    this.pictureBoxOre2_5.Visible = this.panel2.Enabled && Globals.SaveAreasOreCollected[areaIndex, ++stageIndex];

                    stageIndex = 0;

                    this.pictureBoxOre3_1.Visible = this.panel3.Enabled && Globals.SaveAreasOreCollected[++areaIndex, stageIndex];
                    this.pictureBoxOre3_2.Visible = this.panel3.Enabled && Globals.SaveAreasOreCollected[areaIndex, ++stageIndex];
                    this.pictureBoxOre3_3.Visible = this.panel3.Enabled && Globals.SaveAreasOreCollected[areaIndex, ++stageIndex];
                    this.pictureBoxOre3_4.Visible = this.panel3.Enabled && Globals.SaveAreasOreCollected[areaIndex, ++stageIndex];
                    this.pictureBoxOre3_5.Visible = this.panel3.Enabled && Globals.SaveAreasOreCollected[areaIndex, ++stageIndex];

                    stageIndex = 0;

                    this.pictureBoxOre4_1.Visible = this.panel4.Enabled && Globals.SaveAreasOreCollected[++areaIndex, stageIndex];
                    this.pictureBoxOre4_2.Visible = this.panel4.Enabled && Globals.SaveAreasOreCollected[areaIndex, ++stageIndex];
                    this.pictureBoxOre4_3.Visible = this.panel4.Enabled && Globals.SaveAreasOreCollected[areaIndex, ++stageIndex];
                    this.pictureBoxOre4_4.Visible = this.panel4.Enabled && Globals.SaveAreasOreCollected[areaIndex, ++stageIndex];
                    this.pictureBoxOre4_5.Visible = this.panel4.Enabled && Globals.SaveAreasOreCollected[areaIndex, ++stageIndex];

                    stageIndex = 0;

                    this.pictureBoxOre5_1.Visible = this.panel5.Enabled && Globals.SaveAreasOreCollected[++areaIndex, stageIndex];
                    this.pictureBoxOre5_2.Visible = this.panel5.Enabled && Globals.SaveAreasOreCollected[areaIndex, ++stageIndex];
                    this.pictureBoxOre5_3.Visible = this.panel5.Enabled && Globals.SaveAreasOreCollected[areaIndex, ++stageIndex];
                    this.pictureBoxOre5_4.Visible = this.panel5.Enabled && Globals.SaveAreasOreCollected[areaIndex, ++stageIndex];
                    this.pictureBoxOre5_5.Visible = this.panel5.Enabled && Globals.SaveAreasOreCollected[areaIndex, ++stageIndex];

                    stageIndex = 0;

                    this.pictureBoxOre6_1.Visible = this.panel6.Enabled && Globals.SaveAreasOreCollected[++areaIndex, stageIndex];
                    this.pictureBoxOre6_2.Visible = this.panel6.Enabled && Globals.SaveAreasOreCollected[areaIndex, ++stageIndex];
                    this.pictureBoxOre6_3.Visible = this.panel6.Enabled && Globals.SaveAreasOreCollected[areaIndex, ++stageIndex];
                    this.pictureBoxOre6_4.Visible = this.panel6.Enabled && Globals.SaveAreasOreCollected[areaIndex, ++stageIndex];
                    this.pictureBoxOre6_5.Visible = this.panel6.Enabled && Globals.SaveAreasOreCollected[areaIndex, ++stageIndex];
                }

                #endregion
            }
        }
    }
}
