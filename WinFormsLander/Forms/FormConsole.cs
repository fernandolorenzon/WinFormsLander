using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WinFormsLander.Classes;

namespace WinFormsLander.Forms
{
    public partial class FormConsole : FormBase
    {
        private FormStageBase form1;

        public FormConsole()
        {
            InitializeComponent();
        }

        private void FormConsole_Load(object sender, EventArgs e)
        {
            this.form1 = new FormStageBase();
            Globals.CurrentStage = 1;
            this.form1.Show();
            this.Location = new Point(this.form1.Location.X, this.form1.Location.Y + this.form1.Size.Height);
        }

        public void ShowText()
        {
            try
            {
                this.listBox1.Items.Clear();

                //if (SelectedSprite != null)
                //{
                //    float Drag = SelectedSprite.Drag + this.form1.Drag;
                //    this.listBox1.Items.Add("Sprite V Force:" + SelectedSprite.VerticalVelocity.ToString();
                //    this.listBox1.Items.Add("Sprite H Force:" + ((ShipSprite)this.form1.Sprite).HorizontalVelocity.ToString());
                //    this.listBox1.Items.Add("Sprite Tot Force:" + ((ShipSprite)this.form1.Sprite).TotalVelocity.ToString());
                //    this.listBox1.Items.Add("Sprite X:" + ((ShipSprite)this.form1.Sprite).X.ToString());
                //    this.listBox1.Items.Add("Sprite Y:" + ((ShipSprite)this.form1.Sprite).Y.ToString());
                //    this.listBox1.Items.Add("Sprite Accel:" + ((ShipSprite)this.form1.Sprite).Accel.ToString());
                //    this.listBox1.Items.Add("Sprite + Globals.Stage Drag:" + Drag.ToString());
                //    this.listBox1.Items.Add("Globals.Stage Const V Force:" + this.form1.constVForce.ToString());
                //    this.listBox1.Items.Add("Globals.Stage Const H Force:" + this.form1.constHForce.ToString());
                //    this.listBox1.Items.Add("Collided:" + this.form1.collided.ToString());
                //    this.listBox1.Items.Add("CollidedUp:" + this.form1.collidedUp.ToString());
                //    this.listBox1.Items.Add("CollidedDown:" + this.form1.collidedDown.ToString());
                //    this.listBox1.Items.Add("CollidedLeft:" + this.form1.collidedLeft.ToString());
                //    this.listBox1.Items.Add("CollidedRight:" + this.form1.collidedRight.ToString());
                //}
            }
            finally
            {
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.ShowText();
        }
    }
}
