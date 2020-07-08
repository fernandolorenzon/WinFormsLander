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
    public partial class FormStageBase : FormBase
    {
        #region Properties

        public string WindDirection;
        public bool calculateBySecond = false;
        public float constVForce = 0;
        public float constHForce = 0;
        public float Drag = 0.25F;
        public float bouncingSoftness = 5F;

        public int LZDefaultX;
        public int LZDefaultY;

        #endregion

        #region Constructors

        public FormStageBase()
        {
            InitializeComponent();
        }

        #endregion

        #region Events

        private void FormStageBase_Load(object sender, EventArgs e)
        {
        }

        private void FormStageBase_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                this.LZDefaultX = this.lz.Location.X;
                this.LZDefaultY = this.lz.Location.Y;

                StageFunctions.InitializeStage();
            }
        }

        private void buttonEnd_Click(object sender, EventArgs e)
        {
            Globals.FormMain.Visible = true;
            Globals.ShipsLeft = 2;

            this.Visible = false;
        }

        #endregion

        #region Methods

        public void MoveSpeedBar()
        {
            int t = (int)(Globals.SelectedShip.TotalVelocity * Globals.SpeedBarMultiplier);

            if (t > this.progressBarSpeed.Maximum)
            {
                this.progressBarSpeed.Value = this.progressBarSpeed.Maximum;
            }
            else
            {
                this.progressBarSpeed.Value = t;
            }
        }

        public void MoveSpeedBarToLZ(float relativeVelocity)
        {
            int t = (int)(relativeVelocity * Globals.SpeedBarMultiplier);

            if (t > this.progressBarSpeedToLZ.Maximum)
            {
                this.progressBarSpeedToLZ.Value = this.progressBarSpeedToLZ.Maximum;
            }
            else
            {
                this.progressBarSpeedToLZ.Value = t;
            }

            if (relativeVelocity > Globals.SelectedShip.Resistance)
            {
                if (this.progressBarSpeedToLZ.ForeColor == Color.Lime)
                {
                    this.progressBarSpeedToLZ.ForeColor = Color.Red;
                }
                else if (this.progressBarSpeedToLZ.ForeColor == Color.Red)
                {
                    this.progressBarSpeedToLZ.ForeColor = Color.White;
                }
                else if (this.progressBarSpeedToLZ.ForeColor == Color.White)
                {
                    this.progressBarSpeedToLZ.ForeColor = Color.Red;
                }
            }
            else
            {
                this.progressBarSpeedToLZ.ForeColor = Color.Lime;
            }
        }

        #endregion
    }
}
