using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace WinFormsLander.Classes
{
    public class Sprite
    {
        /*
         * 
         *  1------2
         *  |      |
         *  |      | 
         *  |      | 
         *  4------3
         * 
         * */

        public Point Vertex1
        {
            get
            {
                return new Point(this.PictureBoxMain.Location.X, this.PictureBoxMain.Location.Y);
            }
        }

        public Point Vertex2
        {
            get
            {
                return new Point(this.PictureBoxMain.Location.X + this.PictureBoxMain.Size.Width, this.PictureBoxMain.Location.Y);
            }
        }

        public Point Vertex3
        {
            get
            {
                return new Point(this.PictureBoxMain.Location.X + this.PictureBoxMain.Size.Width, this.PictureBoxMain.Location.Y + this.PictureBoxMain.Size.Height);
            }
        }

        public Point Vertex4
        {
            get
            {
                return new Point(this.PictureBoxMain.Location.X, this.PictureBoxMain.Location.Y + this.PictureBoxMain.Size.Height);
            }
        }

        public PictureBox PictureBoxMain;
        public string ID;
        public Image ImageDefault;
        public int FlipVCounter;
        public int FlipHCounter;
        public bool FlipV;
        public bool FlipH;
        public float VerticalVelocity;
        public float HorizontalVelocity;
        public float TotalVelocity;
        public float Y;
        public float X;
        public float StretchedY;
        public float StretchedX;
        public int DefaultHeight;
        public int DefaultWidth;
        public float VerticalVelocityLimit;
        public float HorizontalVelocityLimit;
        public float Drag;
        public float GForce;
        public bool vBouncingZone;
        public bool hBouncingZone;
        public int FlickCount;
        public float Accel;
        public float AccelMpS;

        public Sprite(PictureBox pictureBoxMain)
        {
            this.PictureBoxMain = pictureBoxMain;
            this.PictureBoxMain.BackColor = Color.Transparent;
            this.ID = "";
            this.ImageDefault = null;
            this.FlipVCounter = 0;
            this.FlipHCounter = 0;
            this.FlipV = false;
            this.FlipH = false;
            this.VerticalVelocity = 0;
            this.HorizontalVelocity = 0;
            this.TotalVelocity = 0;
            this.Y = PictureBoxMain.Location.Y;
            this.X = PictureBoxMain.Location.X;
            this.StretchedY = 0;
            this.StretchedX = 0;
            this.DefaultHeight = this.PictureBoxMain.Size.Height;
            this.DefaultWidth = this.PictureBoxMain.Size.Width;
            this.VerticalVelocityLimit = 50;
            this.HorizontalVelocityLimit = 50;
            this.Drag = 0;
            this.GForce = 0;
            this.vBouncingZone = false;
            this.hBouncingZone = false;
            this.FlickCount = 0;
            this.Accel = 0;
            this.AccelMpS = 0;

            this.PictureBoxMain.BackgroundImage = this.ImageDefault;
        }
    }
}
