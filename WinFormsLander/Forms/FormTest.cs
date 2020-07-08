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
    public partial class FormTest : FormBase
    {
        public Sprite sprite;
        public Sprite body;

        public FormTest()
        {
            InitializeComponent();
        }

        private void FormTest_Load(object sender, EventArgs e)
        {
            sprite = new Sprite(this.pictureBox1);
            sprite.Accel = 0.2F;

            this.body = new Sprite(this.pictureBox2);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //this.ks = Keyboard.GetState();

            //if (ks.IsKeyDown(Microsoft.Xna.Framework.Input.Keys.Up))
            //{
            //    this.sprite.VerticalVelocity -= this.sprite.Accel;
            //}

            //if (ks.IsKeyDown(Microsoft.Xna.Framework.Input.Keys.Down))
            //{
            //    this.sprite.VerticalVelocity += this.sprite.Accel;
            //}

            //if (ks.IsKeyDown(Microsoft.Xna.Framework.Input.Keys.Left))
            //{
            //    this.sprite.HorizontalVelocity -= this.sprite.Accel;
            //}

            //if (ks.IsKeyDown(Microsoft.Xna.Framework.Input.Keys.Right))
            //{
            //    this.sprite.HorizontalVelocity += this.sprite.Accel;
            //}

            //Functions.Functions.DetectCollision(this.sprite, this.body, ref Globals.CollidedUp, ref Globals.CollidedDown, ref Globals.CollidedLeft, ref Globals.CollidedRight);
            //Functions.Functions.MoveSprite(this.sprite);
        }
    }
}
