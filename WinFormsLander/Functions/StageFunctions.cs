using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using WinFormsLander.Classes;

namespace WinFormsLander.Functions
{
    public static class StageFunctions
    {
        private static short metroidBrakeCounter;

        public static void InitializeStage()
        {
            Globals.MusicPlayer.Stop();

            Globals.Interval = Globals.TimerInterval;

            Globals.Stage.pictureBoxShipLeft1.Visible = false;
            Globals.Stage.pictureBoxShipLeft2.Visible = false;

            Globals.Stage.labelWindValue.Text = "{0}m/s {1}";
            Globals.Stage.labelGravityValue.Text = "{0}m/s²";

            Globals.Stage.lz.Location = new System.Drawing.Point(303, 552);
            Globals.LZSprite = new Sprite(Globals.Stage.lz);
            Globals.LZSprite.X = 303;
            Globals.LZSprite.Y = 552;

            if (Globals.GameType == Enum.GameType.Arcade)
            {
                if (Globals.ShipsLeft > 1)
                {
                    Globals.Stage.pictureBoxShipLeft1.Visible = true;
                    Globals.Stage.pictureBoxShipLeft2.Visible = true;
                }
                else if (Globals.ShipsLeft == 1)
                {
                    Globals.Stage.pictureBoxShipLeft1.Visible = true;
                    Globals.Stage.pictureBoxShipLeft2.Visible = false;
                }
            }
            else if (Globals.GameType == Enum.GameType.OreColleting)
            {
                Globals.OreCollected = false;

                Globals.RedOre = new Sprite(Globals.Stage.pictureBoxRedOre);
                Globals.RedOre.ImageDefault = WinFormsLander.Properties.Resources.Red_Ore;
                Globals.Stage.pictureBoxRedOre.BackgroundImage = Globals.RedOre.ImageDefault;
                Globals.Stage.pictureBoxRedOre.Visible = true;

                Globals.GreenOre = new Sprite(Globals.Stage.pictureBoxGreenOre);
                Globals.GreenOre.ImageDefault = WinFormsLander.Properties.Resources.Green_Ore;
                Globals.Stage.pictureBoxGreenOre.BackgroundImage = Globals.GreenOre.ImageDefault;
                Globals.Stage.pictureBoxGreenOre.Visible = true;

                Globals.BlueOre = new Sprite(Globals.Stage.pictureBoxBlueOre);
                Globals.BlueOre.ImageDefault = WinFormsLander.Properties.Resources.Blue_Ore;
                Globals.Stage.pictureBoxBlueOre.BackgroundImage = Globals.BlueOre.ImageDefault;
                Globals.Stage.pictureBoxBlueOre.Visible = true;
            }
            else
            {
                Globals.Stage.pictureBoxRedOre.Visible = false;
                Globals.Stage.pictureBoxGreenOre.Visible = false;
                Globals.Stage.pictureBoxBlueOre.Visible = false;
            }

            Globals.Asteroid1 = new Sprite(Globals.Stage.pictureBoxAsteroid1);
            Globals.Asteroid1.ImageDefault = WinFormsLander.Properties.Resources.Asteroid;
            Globals.Asteroid1.X = -200;
            Globals.Asteroid1.Y = -200;

            Globals.Asteroid2 = new Sprite(Globals.Stage.pictureBoxAsteroid2);
            Globals.Asteroid2.ImageDefault = WinFormsLander.Properties.Resources.Asteroid;
            Globals.Asteroid2.X = -200;
            Globals.Asteroid2.Y = -200;

            Globals.Metroid = new Sprite(Globals.Stage.pictureBoxMetroid);
            Globals.Metroid.ImageDefault = WinFormsLander.Properties.Resources.Asteroid;
            Globals.Metroid.X = -200;
            Globals.Metroid.Y = -200;

            Globals.Stage.pictureBox1.Location = new Point(Globals.Stage.pictureBox1.Location.X, -50);
            Globals.Stage.pictureBox2.Location = new Point(Globals.Stage.pictureBox2.Location.X, -50);
            Globals.Stage.pictureBox3.Location = new Point(Globals.Stage.pictureBox3.Location.X, -50);
            Globals.Stage.pictureBox4.Location = new Point(Globals.Stage.pictureBox4.Location.X, -50);
            Globals.Stage.pictureBox5.Location = new Point(Globals.Stage.pictureBox5.Location.X, -50);
            Globals.Stage.pictureBoxAsteroid1.Location = new Point(Globals.Stage.pictureBoxAsteroid1.Location.X, -50);
            Globals.Stage.pictureBoxAsteroid2.Location = new Point(Globals.Stage.pictureBoxAsteroid2.Location.X, -50);
            Globals.Stage.pictureBoxMetroid.Location = new Point(Globals.Stage.pictureBoxMetroid.Location.X, -50);

            Globals.Collided = false;
            Globals.CollidedGround = false;
            Globals.CollidedLZ = false;
            Globals.Landed = false;

            Globals.Stage.WindDirection = "N";

            Globals.EndedIntro = false;
            Globals.SpriteList = new List<Sprite>();
            Globals.SelectedShip = LanderFunctions.LoadShipSprites(Globals.SelectedShip);

            Globals.Stage.pictureBoxShipLeft1.BackgroundImage = Globals.SelectedShip.ImageDefault;
            Globals.Stage.pictureBoxShipLeft2.BackgroundImage = Globals.SelectedShip.ImageDefault;

            Globals.Stage.pictureBox1.BackgroundImage = Globals.SelectedShip.ImageDefault;
            Globals.Stage.pictureBox2.BackgroundImage = Globals.SelectedShip.LeftSprite.ImageDefault;
            Globals.Stage.pictureBox3.BackgroundImage = Globals.SelectedShip.RightSprite.ImageDefault;
            Globals.Stage.pictureBox4.BackgroundImage = Globals.SelectedShip.UpSprite.ImageDefault;
            Globals.Stage.pictureBox5.BackgroundImage = Globals.SelectedShip.DownSprite.ImageDefault;
            Globals.Stage.pictureBoxAsteroid1.BackgroundImage = Globals.Asteroid1.ImageDefault;
            Globals.Stage.pictureBoxAsteroid2.BackgroundImage = Globals.Asteroid2.ImageDefault;
            Globals.Stage.pictureBoxMetroid.BackgroundImage = Globals.Metroid.ImageDefault;

            Globals.Stage.pictureBox1.BackColor = Color.Transparent;
            Globals.Stage.pictureBox2.BackColor = Color.Transparent;
            Globals.Stage.pictureBox3.BackColor = Color.Transparent;
            Globals.Stage.pictureBox4.BackColor = Color.Transparent;
            Globals.Stage.pictureBox5.BackColor = Color.Transparent;
            Globals.Stage.pictureBoxAsteroid1.BackColor = Color.Transparent;
            Globals.Stage.pictureBoxAsteroid2.BackColor = Color.Transparent;
            Globals.Stage.pictureBoxMetroid.BackColor = Color.Transparent;

            Globals.Stage.pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            Globals.Stage.pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            Globals.Stage.pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            Globals.Stage.pictureBox4.BackgroundImageLayout = ImageLayout.Stretch;
            Globals.Stage.pictureBox5.BackgroundImageLayout = ImageLayout.Stretch;
            Globals.Stage.pictureBoxAsteroid1.BackgroundImageLayout = ImageLayout.Stretch;
            Globals.Stage.pictureBoxAsteroid2.BackgroundImageLayout = ImageLayout.Stretch;
            Globals.Stage.pictureBoxMetroid.BackgroundImageLayout = ImageLayout.Stretch;

            Globals.SelectedShip.PictureBoxMain = Globals.Stage.pictureBox1;
            Globals.SelectedShip.LeftSprite.PictureBoxMain = Globals.Stage.pictureBox2;
            Globals.SelectedShip.RightSprite.PictureBoxMain = Globals.Stage.pictureBox3;
            Globals.SelectedShip.UpSprite.PictureBoxMain = Globals.Stage.pictureBox4;
            Globals.SelectedShip.DownSprite.PictureBoxMain = Globals.Stage.pictureBox5;

            Globals.Asteroid1.ImageDefault = WinFormsLander.Properties.Resources.Asteroid;
            Globals.Stage.pictureBoxAsteroid1.BackgroundImage = Globals.Asteroid1.ImageDefault;

            Globals.Asteroid2.ImageDefault = WinFormsLander.Properties.Resources.Asteroid;
            Globals.Stage.pictureBoxAsteroid2.BackgroundImage = Globals.Asteroid2.ImageDefault;

            Globals.Metroid.ImageDefault = WinFormsLander.Properties.Resources.Metroid;
            Globals.Stage.pictureBoxMetroid.BackgroundImage = Globals.Metroid.ImageDefault;

            Globals.Stage.progressBarSpeed.Maximum = 1000;
            Globals.Stage.progressBarSpeedToLZ.Maximum = 1000;
            Globals.Stage.progressBarFuel.Maximum = (int)Globals.SelectedShip.MaxFuel;
            Globals.CollidedGround = false;
            Globals.CollidedLZ = false;

            Globals.SelectedShip.X = 40;
            Globals.SelectedShip.Y = -50;
            Globals.SelectedShip.VerticalVelocity = 0;
            Globals.SelectedShip.HorizontalVelocity = 0;
            Globals.SelectedShip.PictureBoxMain.BackgroundImage = Globals.SelectedShip.ImageDefault;
            Globals.LZSprite.PictureBoxMain.Location = new Point(Globals.Stage.LZDefaultX, Globals.Stage.LZDefaultY);
            Globals.Stage.pictureBoxCursor.Visible = false;
            Globals.Stage.labelCursor.Visible = false;

            Globals.SelectedShip.PictureBoxMain.Visible = true;
            Globals.SelectedShip.Fuel = Globals.SelectedShip.MaxFuel;
            Globals.Stage.progressBarFuel.Value = (int)Globals.SelectedShip.MaxFuel;
            Functions.ShowMessage(Globals.Stage.labelMessage, Color.Red, "");

            //Posiciona o cursor de Aceleração Perigosa
            float fraction = Globals.SelectedShip.Resistance * 100 / Globals.Stage.progressBarSpeedToLZ.Maximum;
            int x = (int)(Globals.Stage.progressBarSpeedToLZ.Size.Width * fraction) + Globals.Stage.progressBarSpeedToLZ.Location.X - (Globals.Stage.pictureBoxDanger.Size.Width / 2);

            Globals.Stage.pictureBoxDanger.Location = new Point(x, Globals.Stage.pictureBoxDanger.Location.Y);
            Globals.Stage.labelAccelDanger.Location = new Point(x, Globals.Stage.labelAccelDanger.Location.Y);

            GameFunctions.SwitchTimers(true);

            StageFunctions.LoadStage();

            Globals.Stage.pictureBoxAsteroid1.BringToFront();
            Globals.Stage.pictureBoxAsteroid2.BringToFront();
            Globals.Stage.pictureBoxMetroid.BringToFront();
            Globals.Stage.lz.BringToFront();
            Globals.Stage.labelMessage.BringToFront();

            if (Globals.GameType == Enum.GameType.OreColleting)
            {
                Globals.UpdateOre = new WinFormsLander.Forms.FormBase.UpdateForOre(StageFunctions.UpdateForOre);
            }
            else
            {
                Globals.UpdateOre = new WinFormsLander.Forms.FormBase.UpdateForOre(GameFunctions.UpdateNull);
            }

            Globals.UpdateIntro = new WinFormsLander.Forms.FormBase.UpdateForIntro(GameFunctions.UpdateIntro);
        }

        public static void LoadStage()
        {
            if (Globals.CurrentStage == 0)
            {
                Globals.UpdateArea = new WinFormsLander.Forms.FormBase.UpdateForArea(StageFunctions.UpdateForAreaFree);

                StageFunctions.LoadStageFree();
            }
            else if (Globals.CurrentStage < 16)
            {
                StageFunctions.LoadArea1();
                Globals.UpdateArea = new WinFormsLander.Forms.FormBase.UpdateForArea(StageFunctions.UpdateForArea1);

                if (Globals.CurrentStage == 11)
                {
                    StageFunctions.LoadStage1_1();
                }
                else if (Globals.CurrentStage == 12)
                {
                    StageFunctions.LoadStage1_2();
                }
                else if (Globals.CurrentStage == 13)
                {
                    StageFunctions.LoadStage1_3();
                }
                else if (Globals.CurrentStage == 14)
                {
                    StageFunctions.LoadStage1_4();
                }
                else if (Globals.CurrentStage == 15)
                {
                    StageFunctions.LoadStage1_5();
                }
            }
            else if (Globals.CurrentStage < 26)
            {
                StageFunctions.LoadArea2();
                Globals.UpdateArea = new WinFormsLander.Forms.FormBase.UpdateForArea(StageFunctions.UpdateForArea2);

                if (Globals.CurrentStage == 21)
                {
                    StageFunctions.LoadStage2_1();
                }
                else if (Globals.CurrentStage == 22)
                {
                    StageFunctions.LoadStage2_2();
                }
                else if (Globals.CurrentStage == 23)
                {
                    StageFunctions.LoadStage2_3();
                }
                else if (Globals.CurrentStage == 24)
                {
                    StageFunctions.LoadStage2_4();
                }
                else if (Globals.CurrentStage == 25)
                {
                    StageFunctions.LoadStage2_5();
                }
            }
            else if (Globals.CurrentStage < 36)
            {
                StageFunctions.LoadArea3();
                Globals.UpdateArea = new WinFormsLander.Forms.FormBase.UpdateForArea(StageFunctions.UpdateForArea3);

                if (Globals.CurrentStage == 31)
                {
                    StageFunctions.LoadStage3_1();
                }
                else if (Globals.CurrentStage == 32)
                {
                    StageFunctions.LoadStage3_2();
                }
                else if (Globals.CurrentStage == 33)
                {
                    StageFunctions.LoadStage3_3();
                }
                else if (Globals.CurrentStage == 34)
                {
                    StageFunctions.LoadStage3_4();
                }
                else if (Globals.CurrentStage == 35)
                {
                    StageFunctions.LoadStage3_5();
                }
            }
            else if (Globals.CurrentStage < 46)
            {
                StageFunctions.LoadArea4();
                Globals.UpdateArea = new WinFormsLander.Forms.FormBase.UpdateForArea(StageFunctions.UpdateForArea4);

                if (Globals.CurrentStage == 41)
                {
                    StageFunctions.LoadStage4_1();
                }
                else if (Globals.CurrentStage == 42)
                {
                    StageFunctions.LoadStage4_2();
                }
                else if (Globals.CurrentStage == 43)
                {
                    StageFunctions.LoadStage4_3();
                }
                else if (Globals.CurrentStage == 44)
                {
                    StageFunctions.LoadStage4_4();
                }
                else if (Globals.CurrentStage == 45)
                {
                    StageFunctions.LoadStage4_5();
                }
            }
            else if (Globals.CurrentStage < 56)
            {
                StageFunctions.LoadArea5();
                Globals.UpdateArea = new WinFormsLander.Forms.FormBase.UpdateForArea(StageFunctions.UpdateForArea5);

                if (Globals.CurrentStage == 51)
                {
                    StageFunctions.LoadStage5_1();
                }
                else if (Globals.CurrentStage == 52)
                {
                    StageFunctions.LoadStage5_2();
                }
                else if (Globals.CurrentStage == 53)
                {
                    StageFunctions.LoadStage5_3();
                }
                else if (Globals.CurrentStage == 54)
                {
                    StageFunctions.LoadStage5_4();
                }
                else if (Globals.CurrentStage == 55)
                {
                    StageFunctions.LoadStage5_5();
                }
            }
            else if (Globals.CurrentStage < 66)
            {
                StageFunctions.LoadArea6();
                Globals.UpdateArea = new WinFormsLander.Forms.FormBase.UpdateForArea(StageFunctions.UpdateForArea6);

                if (Globals.CurrentStage == 61)
                {
                    StageFunctions.LoadStage6_1();
                }
                else if (Globals.CurrentStage == 62)
                {
                    StageFunctions.LoadStage6_2();
                }
                else if (Globals.CurrentStage == 63)
                {
                    StageFunctions.LoadStage6_3();
                }
                else if (Globals.CurrentStage == 64)
                {
                    StageFunctions.LoadStage6_4();
                }
                else if (Globals.CurrentStage == 65)
                {
                    StageFunctions.LoadStage6_5();
                }
            }
        }

        public static void LoadArea1()
        {
            Globals.Stage.lz.Size = new Size(70, 20);
            Globals.Stage.constHForce = 0;
            Globals.Stage.Drag = 0.02F;
        }

        public static void LoadArea2()
        {
            Globals.Stage.lz.Size = new Size(70, 20);

            if (Globals.Random.Next(1, 10) > 5)
            {
                Globals.LZSprite.HorizontalVelocity = 5F;
            }
            else
            {
                Globals.LZSprite.HorizontalVelocity = -5F;
            }

            if (Globals.GameType == Enum.GameType.OreColleting)
            {
                if (Globals.Random.Next(1, 10) > 5)
                {
                    Globals.RedOre.HorizontalVelocity = 3;
                    Globals.GreenOre.HorizontalVelocity = 3;
                    Globals.BlueOre.HorizontalVelocity = 3;
                }
                else
                {
                    Globals.RedOre.HorizontalVelocity = -3;
                    Globals.GreenOre.HorizontalVelocity = -3;
                    Globals.BlueOre.HorizontalVelocity = -3;
                }
            }

            Globals.Stage.Drag = 0.01F;
        }

        public static void LoadArea3()
        {
            Globals.Stage.lz.Size = new Size(70, 20);

            if (Globals.Random.Next(1, 10) > 5)
            {
                Globals.LZSprite.HorizontalVelocity = 8F;
            }
            else
            {
                Globals.LZSprite.HorizontalVelocity = -8F;
            }

            if (Globals.GameType == Enum.GameType.OreColleting)
            {
                if (Globals.Random.Next(1, 10) > 5)
                {
                    Globals.LZSprite.HorizontalVelocity = 5F;
                    Globals.RedOre.HorizontalVelocity = 3;
                    Globals.GreenOre.HorizontalVelocity = 3;
                    Globals.BlueOre.HorizontalVelocity = 3;
                }
                else
                {
                    Globals.LZSprite.HorizontalVelocity = -5F;
                    Globals.RedOre.HorizontalVelocity = -3;
                    Globals.GreenOre.HorizontalVelocity = -3;
                    Globals.BlueOre.HorizontalVelocity = -3;
                }
            }

            Globals.Stage.Drag = 0.01F;
        }

        public static void LoadArea4()
        {
            Globals.Stage.Drag = 0.01F;

            Globals.Stage.lz.Size = new Size(70, 20);

            Globals.LZSprite.VerticalVelocity = -3;

            if (Globals.Random.Next(1, 10) > 5)
            {
                Globals.LZSprite.HorizontalVelocity = 3F;
            }
            else
            {
                Globals.LZSprite.HorizontalVelocity = -3F;
            }

            if (Globals.GameType == Enum.GameType.OreColleting)
            {
                if (Globals.Random.Next(1, 10) > 5)
                {
                    Globals.RedOre.HorizontalVelocity = 3;
                    Globals.GreenOre.HorizontalVelocity = 3;
                    Globals.BlueOre.HorizontalVelocity = 3;

                    Globals.RedOre.VerticalVelocity = 2;
                    Globals.GreenOre.VerticalVelocity = 2;
                    Globals.BlueOre.VerticalVelocity = 2;
                }
                else
                {
                    Globals.RedOre.HorizontalVelocity = -3;
                    Globals.GreenOre.HorizontalVelocity = -3;
                    Globals.BlueOre.HorizontalVelocity = -3;

                    Globals.RedOre.VerticalVelocity = -2;
                    Globals.GreenOre.VerticalVelocity = -2;
                    Globals.BlueOre.VerticalVelocity = -2;
                }
            }

            Globals.Stage.Drag = 0F;

            Globals.Stage.pictureBoxAsteroid1.Visible = true;
            Globals.Asteroid1.HorizontalVelocity = 6;
        }

        public static void LoadArea5()
        {
            Globals.Stage.lz.Size = new Size(32, 22);

            if (Globals.Random.Next(1, 10) > 5)
            {
                Globals.LZSprite.HorizontalVelocity = 8F;
            }
            else
            {
                Globals.LZSprite.HorizontalVelocity = -8F;
            }

            Globals.Stage.Drag = 0.01F;

            Globals.Stage.pictureBoxAsteroid1.Visible = true;
            Globals.Stage.pictureBoxAsteroid2.Visible = true;

            Globals.Asteroid1.HorizontalVelocity = 6;
            Globals.Asteroid2.HorizontalVelocity = 6;

            if (Globals.GameType == Enum.GameType.OreColleting)
            {
                if (Globals.Random.Next(1, 10) > 5)
                {
                    Globals.LZSprite.HorizontalVelocity = 5F;
                    Globals.RedOre.HorizontalVelocity = 5;
                    Globals.GreenOre.HorizontalVelocity = 5;
                    Globals.BlueOre.HorizontalVelocity = 5;

                    Globals.GreenOre.VerticalVelocity = 5;
                    Globals.BlueOre.VerticalVelocity = 5;
                }
                else
                {
                    Globals.LZSprite.HorizontalVelocity = -5F;
                    Globals.RedOre.HorizontalVelocity = -5;
                    Globals.GreenOre.HorizontalVelocity = -5;
                    Globals.BlueOre.HorizontalVelocity = -5;

                    Globals.RedOre.VerticalVelocity = -5;
                    Globals.GreenOre.VerticalVelocity = -5;
                    Globals.BlueOre.VerticalVelocity = -5;
                }
            }
        }

        public static void LoadArea6()
        {
            Globals.Stage.lz.Size = new Size(32, 22);
            Globals.SelectedShip.GForce = 0.5F;

            if (Globals.Random.Next(1, 10) > 5)
            {
                Globals.LZSprite.HorizontalVelocity = 10F;
            }
            else
            {
                Globals.LZSprite.HorizontalVelocity = -10F;
            }

            Globals.Stage.pictureBoxMetroid.Visible = true;

            Globals.Stage.Drag = 0.02F;

            if ((Globals.Metroid.X < -150 || Globals.Metroid.X > Globals.Stage.panelStage.Size.Width + 150)
            || (Globals.Metroid.Y < -150 || Globals.Metroid.Y > Globals.Stage.panelStage.Size.Height + 150))
            {
                double y = Globals.Random.NextDouble();
                Globals.Metroid.Y = (float)(-20 - (y * 100));

                double x = Globals.Random.NextDouble();
                Globals.Metroid.X = (float)(-20 - (x * 100));

                if (x > 0.5F)
                {
                    Globals.Metroid.X *= -1;
                    Globals.Metroid.X += Globals.Stage.panelStage.Size.Width;
                }
            }
        }

        public static void LoadStageFree()
        {
            Globals.Stage.constHForce = 0;
            Globals.Stage.Drag = 0.00F;
            Globals.CurrentStage = 0;
            Globals.Stage.labelStage.Text = "Estágio 0";
            Globals.Stage.labelLocation.Text = "Livre";
            Globals.LZSprite.GForce = Functions.ConvertMpSToForce(Globals.LZGForce, Globals.Interval);
            Globals.Stage.constVForce = Functions.ConvertMpSToForce(0, Globals.Interval);
            Globals.Stage.labelGravityValue.Text = string.Format(Globals.Stage.labelGravityValue.Text, Globals.LZGForce);
            Globals.Stage.labelWindValue.Text = string.Format(Globals.Stage.labelWindValue.Text, "0.00", Globals.Stage.WindDirection);
            Globals.Stage.pictureBoxLocation.BackgroundImage = WinFormsLander.Properties.Resources.LZ;
            Globals.Stage.lz.Location = new Point(300, 250);
            Globals.LZSprite.X = 300;
            Globals.LZSprite.Y = 250;
            Globals.Stage.lz.Size = new Size(32, 32);
            Globals.LZSprite.DefaultHeight = 32;
            Globals.LZSprite.DefaultWidth = 32;
        }

        public static void LoadStage1_1()
        {
            if (Globals.GameType == Enum.GameType.OreColleting)
            {
                Globals.RedOre.PictureBoxMain.Location = new Point(200, 200);
                Globals.GreenOre.PictureBoxMain.Location = new Point(50, 500);
                Globals.BlueOre.PictureBoxMain.Location = new Point(500, 300);

                Globals.RedOre.X = 200;
                Globals.RedOre.Y = 200;

                Globals.GreenOre.X = 50;
                Globals.GreenOre.Y = 500;

                Globals.BlueOre.X = 500;
                Globals.BlueOre.Y = 300;
            }

            float gravity = 1.62F;
            Globals.CurrentStage = 11;
            Globals.Stage.labelStage.Text = "Estágio 1-1";
            Globals.Stage.labelLocation.Text = "Lua";
            Globals.Stage.constVForce = Functions.ConvertMpSToForce(gravity, Globals.Interval);
            Globals.Stage.labelGravityValue.Text = string.Format(Globals.Stage.labelGravityValue.Text, gravity.ToString());
            Globals.Stage.labelWindValue.Text = string.Format(Globals.Stage.labelWindValue.Text, "0.00", Globals.Stage.WindDirection);
            Globals.Stage.pictureBoxLocation.BackgroundImage = WinFormsLander.Properties.Resources.Location_Moon;
        }

        public static void LoadStage1_2()
        {
            if (Globals.GameType == Enum.GameType.OreColleting)
            {
                Globals.RedOre.PictureBoxMain.Location = new Point(500, 200);
                Globals.GreenOre.PictureBoxMain.Location = new Point(370, 10);
                Globals.BlueOre.PictureBoxMain.Location = new Point(290, 150);

                Globals.RedOre.X = 500;
                Globals.RedOre.Y = 200;

                Globals.GreenOre.X = 370;
                Globals.GreenOre.Y = 10;

                Globals.BlueOre.X = 290;
                Globals.BlueOre.Y = 150;
            }

            float gravity = 3.69F;
            float windForce = GameFunctions.GenerateRandomWind(1, 2, Globals.Stage);
            Globals.Stage.constHForce = Functions.ConvertMpSToForce(windForce, Globals.Interval);
            Globals.CurrentStage = 12;
            Globals.Stage.labelStage.Text = "Estágio 1-2";
            Globals.Stage.labelLocation.Text = "Marte";
            Globals.Stage.panelStage.BackColor = System.Drawing.Color.DarkGoldenrod;
            Globals.Stage.constVForce = Functions.ConvertMpSToForce(gravity, Globals.Interval);
            Globals.Stage.labelGravityValue.Text = string.Format(Globals.Stage.labelGravityValue.Text, gravity.ToString());
            Globals.Stage.labelWindValue.Text = string.Format(Globals.Stage.labelWindValue.Text, Convert.ToString(windForce).Replace("-", ""), Globals.Stage.WindDirection);
            Globals.Stage.pictureBoxLocation.BackgroundImage = WinFormsLander.Properties.Resources.Location_Mars;
        }

        public static void LoadStage1_3()
        {
            if (Globals.GameType == Enum.GameType.OreColleting)
            {
                Globals.RedOre.PictureBoxMain.Location = new Point(600, 100);
                Globals.GreenOre.PictureBoxMain.Location = new Point(80, 480);
                Globals.BlueOre.PictureBoxMain.Location = new Point(350, 500);

                Globals.RedOre.X = 600;
                Globals.RedOre.Y = 10;

                Globals.GreenOre.X = 80;
                Globals.GreenOre.Y = 480;

                Globals.BlueOre.X = 350;
                Globals.BlueOre.Y = 500;
            }

            float gravity = 3.7F;
            float windForce = GameFunctions.GenerateRandomWind(1, 2, Globals.Stage);
            Globals.Stage.constHForce = Functions.ConvertMpSToForce(windForce, Globals.Interval);
            Globals.CurrentStage = 13;
            Globals.Stage.labelStage.Text = "Estágio 1-3";
            Globals.Stage.labelLocation.Text = "Mercúrio";
            Globals.Stage.panelStage.BackColor = System.Drawing.Color.Black;
            Globals.Stage.constVForce = Functions.ConvertMpSToForce(gravity, Globals.Interval);
            Globals.Stage.labelGravityValue.Text = string.Format(Globals.Stage.labelGravityValue.Text, gravity.ToString());
            Globals.Stage.labelWindValue.Text = string.Format(Globals.Stage.labelWindValue.Text, Convert.ToString(windForce).Replace("-", ""), Globals.Stage.WindDirection);
            Globals.Stage.pictureBoxLocation.BackgroundImage = WinFormsLander.Properties.Resources.Location_Mercury;
        }

        public static void LoadStage1_4()
        {
            if (Globals.GameType == Enum.GameType.OreColleting)
            {
                Globals.RedOre.PictureBoxMain.Location = new Point(550, 550);
                Globals.GreenOre.PictureBoxMain.Location = new Point(85, 420);
                Globals.BlueOre.PictureBoxMain.Location = new Point(350, 3);

                Globals.RedOre.X = 550;
                Globals.RedOre.Y = 550;

                Globals.GreenOre.X = 85;
                Globals.GreenOre.Y = 420;

                Globals.BlueOre.X = 350;
                Globals.BlueOre.Y = 3;
            }

            float gravity = 8.87F;
            float windForce = GameFunctions.GenerateRandomWind(6, 8, Globals.Stage);
            Globals.Stage.constHForce = Functions.ConvertMpSToForce(windForce, Globals.Interval);
            Globals.CurrentStage = 14;
            Globals.Stage.labelStage.Text = "Estágio 1-4";
            Globals.Stage.labelLocation.Text = "Venus";
            Globals.Stage.panelStage.BackColor = System.Drawing.Color.DarkKhaki;
            Globals.Stage.constVForce = Functions.ConvertMpSToForce(gravity, Globals.Interval);
            Globals.Stage.labelGravityValue.Text = string.Format(Globals.Stage.labelGravityValue.Text, gravity.ToString());
            Globals.Stage.labelWindValue.Text = string.Format(Globals.Stage.labelWindValue.Text, Convert.ToString(windForce).Replace("-", ""), Globals.Stage.WindDirection);
            Globals.Stage.pictureBoxLocation.BackgroundImage = WinFormsLander.Properties.Resources.Location_Venus;
        }

        public static void LoadStage1_5()
        {
            if (Globals.GameType == Enum.GameType.OreColleting)
            {
                Globals.RedOre.PictureBoxMain.Location = new Point(500, 500);
                Globals.GreenOre.PictureBoxMain.Location = new Point(370, 300);
                Globals.BlueOre.PictureBoxMain.Location = new Point(10, 560);

                Globals.RedOre.X = 500;
                Globals.RedOre.Y = 500;

                Globals.GreenOre.X = 370;
                Globals.GreenOre.Y = 300;

                Globals.BlueOre.X = 10;
                Globals.BlueOre.Y = 560;
            }

            float gravity = 9.78F;
            float windForce = GameFunctions.GenerateRandomWind(4, 5, Globals.Stage);
            Globals.Stage.constHForce = Functions.ConvertMpSToForce(windForce, Globals.Interval);
            Globals.CurrentStage = 15;
            Globals.Stage.labelStage.Text = "Estágio 1-5";
            Globals.Stage.labelLocation.Text = "Terra";
            Globals.Stage.panelStage.BackColor = System.Drawing.Color.DarkCyan;
            Globals.Stage.constVForce = Functions.ConvertMpSToForce(gravity, Globals.Interval);
            Globals.Stage.labelGravityValue.Text = string.Format(Globals.Stage.labelGravityValue.Text, gravity.ToString());
            Globals.Stage.labelWindValue.Text = string.Format(Globals.Stage.labelWindValue.Text, Convert.ToString(windForce).Replace("-", ""), Globals.Stage.WindDirection);
            Globals.Stage.pictureBoxLocation.BackgroundImage = WinFormsLander.Properties.Resources.Location_Earth;
        }

        public static void LoadStage2_1()
        {
            if (Globals.GameType == Enum.GameType.OreColleting)
            {
                Globals.RedOre.PictureBoxMain.Location = new Point(150, 20);
                Globals.GreenOre.PictureBoxMain.Location = new Point(365, 430);
                Globals.BlueOre.PictureBoxMain.Location = new Point(10, 550);

                Globals.RedOre.X = 150;
                Globals.RedOre.Y = 20;

                Globals.GreenOre.X = 365;
                Globals.GreenOre.Y = 430;

                Globals.BlueOre.X = 10;
                Globals.BlueOre.Y = 550;
            }

            float gravity = 1.79F;
            float windForce = GameFunctions.GenerateRandomWind(1, 2, Globals.Stage);
            Globals.Stage.constHForce = Functions.ConvertMpSToForce(windForce, Globals.Interval);
            Globals.CurrentStage = 21;
            Globals.Stage.labelStage.Text = "Estágio 2-1";
            Globals.Stage.labelLocation.Text = "Io";
            Globals.Stage.panelStage.BackColor = System.Drawing.Color.Orange;

            Globals.Stage.constVForce = Functions.ConvertMpSToForce(gravity, Globals.Interval);
            Globals.Stage.labelGravityValue.Text = string.Format(Globals.Stage.labelGravityValue.Text, gravity.ToString());
            Globals.Stage.labelWindValue.Text = string.Format(Globals.Stage.labelWindValue.Text, Convert.ToString(windForce).Replace("-", ""), Globals.Stage.WindDirection);
            Globals.Stage.pictureBoxLocation.BackgroundImage = WinFormsLander.Properties.Resources.Location_Io;
        }

        public static void LoadStage2_2()
        {
            if (Globals.GameType == Enum.GameType.OreColleting)
            {
                Globals.RedOre.PictureBoxMain.Location = new Point(100, 280);
                Globals.GreenOre.PictureBoxMain.Location = new Point(470, 300);
                Globals.BlueOre.PictureBoxMain.Location = new Point(550, 150);

                Globals.RedOre.X = 100;
                Globals.RedOre.Y = 280;

                Globals.GreenOre.X = 470;
                Globals.GreenOre.Y = 300;

                Globals.BlueOre.X = 550;
                Globals.BlueOre.Y = 150;
            }

            float gravity = 1.31F;
            float windForce = 0;
            Globals.Stage.constHForce = Functions.ConvertMpSToForce(windForce, Globals.Interval);
            Globals.CurrentStage = 22;
            Globals.Stage.labelStage.Text = "Estágio 2-2";
            Globals.Stage.labelLocation.Text = "Europa";
            Globals.Stage.panelStage.BackColor = System.Drawing.Color.Black;

            Globals.Stage.constVForce = Functions.ConvertMpSToForce(gravity, Globals.Interval);
            Globals.Stage.labelGravityValue.Text = string.Format(Globals.Stage.labelGravityValue.Text, gravity.ToString());
            Globals.Stage.labelWindValue.Text = string.Format(Globals.Stage.labelWindValue.Text, Convert.ToString(windForce).Replace("-", ""), Globals.Stage.WindDirection);
            Globals.Stage.pictureBoxLocation.BackgroundImage = WinFormsLander.Properties.Resources.Location_Europa;
        }

        public static void LoadStage2_3()
        {
            if (Globals.GameType == Enum.GameType.OreColleting)
            {
                Globals.RedOre.PictureBoxMain.Location = new Point(550, 20);
                Globals.GreenOre.PictureBoxMain.Location = new Point(500, 500);
                Globals.BlueOre.PictureBoxMain.Location = new Point(550, 150);

                Globals.RedOre.X = 550;
                Globals.RedOre.Y = 20;

                Globals.GreenOre.X = 500;
                Globals.GreenOre.Y = 500;

                Globals.BlueOre.X = 550;
                Globals.BlueOre.Y = 100;
            }

            float gravity = 1.42F;
            float windForce = 0;
            Globals.Stage.constHForce = Functions.ConvertMpSToForce(windForce, Globals.Interval);
            Globals.CurrentStage = 23;
            Globals.Stage.labelStage.Text = "Estágio 2-3";
            Globals.Stage.labelLocation.Text = "Ganimedes";
            Globals.Stage.panelStage.BackColor = System.Drawing.Color.Black;

            Globals.Stage.constVForce = Functions.ConvertMpSToForce(gravity, Globals.Interval);
            Globals.Stage.labelGravityValue.Text = string.Format(Globals.Stage.labelGravityValue.Text, gravity.ToString());
            Globals.Stage.labelWindValue.Text = string.Format(Globals.Stage.labelWindValue.Text, Convert.ToString(windForce).Replace("-", ""), Globals.Stage.WindDirection);
            Globals.Stage.pictureBoxLocation.BackgroundImage = WinFormsLander.Properties.Resources.Location_Ganymede;
        }

        public static void LoadStage2_4()
        {
            if (Globals.GameType == Enum.GameType.OreColleting)
            {
                Globals.RedOre.PictureBoxMain.Location = new Point(300, 2);
                Globals.GreenOre.PictureBoxMain.Location = new Point(2, 400);
                Globals.BlueOre.PictureBoxMain.Location = new Point(550, 25);

                Globals.RedOre.X = 300;
                Globals.RedOre.Y = 2;

                Globals.GreenOre.X = 2;
                Globals.GreenOre.Y = 400;

                Globals.BlueOre.X = 550;
                Globals.BlueOre.Y = 25;
            }

            float gravity = 1.23F;
            float windForce = 0;
            Globals.Stage.constHForce = Functions.ConvertMpSToForce(windForce, Globals.Interval);
            Globals.CurrentStage = 24;
            Globals.Stage.labelStage.Text = "Estágio 2-4";
            Globals.Stage.labelLocation.Text = "Calisto";
            Globals.Stage.panelStage.BackColor = System.Drawing.Color.Black;

            Globals.Stage.constVForce = Functions.ConvertMpSToForce(gravity, Globals.Interval);
            Globals.Stage.labelGravityValue.Text = string.Format(Globals.Stage.labelGravityValue.Text, gravity.ToString());
            Globals.Stage.labelWindValue.Text = string.Format(Globals.Stage.labelWindValue.Text, Convert.ToString(windForce).Replace("-", ""), Globals.Stage.WindDirection);
            Globals.Stage.pictureBoxLocation.BackgroundImage = WinFormsLander.Properties.Resources.Location_Callisto;
        }

        public static void LoadStage2_5()
        {
            if (Globals.GameType == Enum.GameType.OreColleting)
            {
                Globals.RedOre.PictureBoxMain.Location = new Point(500, 64);
                Globals.GreenOre.PictureBoxMain.Location = new Point(07, 470);
                Globals.BlueOre.PictureBoxMain.Location = new Point(80, 300);

                Globals.RedOre.X = 500;
                Globals.RedOre.Y = 64;

                Globals.GreenOre.X = 07;
                Globals.GreenOre.Y = 470;

                Globals.BlueOre.X = 80;
                Globals.BlueOre.Y = 300;
            }

            float gravity = 0.02F;
            float windForce = 0;
            Globals.Stage.constHForce = Functions.ConvertMpSToForce(windForce, Globals.Interval);
            Globals.CurrentStage = 25;
            Globals.Stage.labelStage.Text = "Estágio 2-5";
            Globals.Stage.labelLocation.Text = "Amalteia";
            Globals.Stage.panelStage.BackColor = System.Drawing.Color.Black;

            Globals.Stage.constVForce = Functions.ConvertMpSToForce(gravity, Globals.Interval);
            Globals.Stage.labelGravityValue.Text = string.Format(Globals.Stage.labelGravityValue.Text, gravity.ToString());
            Globals.Stage.labelWindValue.Text = string.Format(Globals.Stage.labelWindValue.Text, Convert.ToString(windForce).Replace("-", ""), Globals.Stage.WindDirection);
            Globals.Stage.pictureBoxLocation.BackgroundImage = WinFormsLander.Properties.Resources.Location_Amalthea;
        }

        public static void LoadStage3_1()
        {
            if (Globals.GameType == Enum.GameType.OreColleting)
            {
                Globals.RedOre.PictureBoxMain.Location = new Point(620, 10);
                Globals.GreenOre.PictureBoxMain.Location = new Point(400, 300);
                Globals.BlueOre.PictureBoxMain.Location = new Point(10, 560);

                Globals.RedOre.X = 620;
                Globals.RedOre.Y = 10;

                Globals.GreenOre.X = 400;
                Globals.GreenOre.Y = 300;

                Globals.BlueOre.X = 10;
                Globals.BlueOre.Y = 560;
            }

            float gravity = 1.35F;
            float windForce = GameFunctions.GenerateRandomWind(2, 3, Globals.Stage);
            Globals.CurrentStage = 31;
            Globals.Stage.labelStage.Text = "Estágio 3-1";
            Globals.Stage.labelLocation.Text = "Titã";
            Globals.Stage.panelStage.BackColor = System.Drawing.Color.Olive;
            Globals.Stage.constVForce = Functions.ConvertMpSToForce(gravity, Globals.Interval);
            Globals.Stage.labelGravityValue.Text = string.Format(Globals.Stage.labelGravityValue.Text, gravity.ToString());
            Globals.Stage.labelWindValue.Text = string.Format(Globals.Stage.labelWindValue.Text, Convert.ToString(windForce).Replace("-", ""), Globals.Stage.WindDirection);
            Globals.Stage.pictureBoxLocation.BackgroundImage = WinFormsLander.Properties.Resources.Location_Titan;
        }

        public static void LoadStage3_2()
        {
            if (Globals.GameType == Enum.GameType.OreColleting)
            {
                Globals.RedOre.PictureBoxMain.Location = new Point(100, 200);
                Globals.GreenOre.PictureBoxMain.Location = new Point(270, 300);
                Globals.BlueOre.PictureBoxMain.Location = new Point(550, 350);

                Globals.RedOre.X = 200;
                Globals.RedOre.Y = 200;

                Globals.GreenOre.X = 50;
                Globals.GreenOre.Y = 500;

                Globals.BlueOre.X = 500;
                Globals.BlueOre.Y = 300;
            }

            float gravity = 0.22F;
            float windForce = 0;
            Globals.Stage.constHForce = Functions.ConvertMpSToForce(windForce, Globals.Interval);
            Globals.CurrentStage = 32;
            Globals.Stage.labelStage.Text = "Estágio 3-2";
            Globals.Stage.labelLocation.Text = "Jápeto";
            Globals.Stage.panelStage.BackColor = System.Drawing.Color.Black;
            Globals.Stage.constVForce = Functions.ConvertMpSToForce(gravity, Globals.Interval);
            Globals.Stage.labelGravityValue.Text = string.Format(Globals.Stage.labelGravityValue.Text, gravity.ToString());
            Globals.Stage.labelWindValue.Text = string.Format(Globals.Stage.labelWindValue.Text, Convert.ToString(windForce).Replace("-", ""), Globals.Stage.WindDirection);
            Globals.Stage.pictureBoxLocation.BackgroundImage = WinFormsLander.Properties.Resources.Location_Iapetus;
        }

        public static void LoadStage3_3()
        {
            if (Globals.GameType == Enum.GameType.OreColleting)
            {
                Globals.RedOre.PictureBoxMain.Location = new Point(100, 200);
                Globals.GreenOre.PictureBoxMain.Location = new Point(270, 300);
                Globals.BlueOre.PictureBoxMain.Location = new Point(550, 350);

                Globals.RedOre.X = 200;
                Globals.RedOre.Y = 200;

                Globals.GreenOre.X = 50;
                Globals.GreenOre.Y = 500;

                Globals.BlueOre.X = 500;
                Globals.BlueOre.Y = 300;
            }

            float gravity = 0.07F;
            float windForce = 0;
            Globals.Stage.constHForce = Functions.ConvertMpSToForce(windForce, Globals.Interval);
            Globals.CurrentStage = 33;
            Globals.Stage.labelStage.Text = "Estágio 3-3";
            Globals.Stage.labelLocation.Text = "Miranda";
            Globals.Stage.panelStage.BackColor = System.Drawing.Color.Black;
            Globals.Stage.constVForce = Functions.ConvertMpSToForce(gravity, Globals.Interval);
            Globals.Stage.labelGravityValue.Text = string.Format(Globals.Stage.labelGravityValue.Text, gravity.ToString());
            Globals.Stage.labelWindValue.Text = string.Format(Globals.Stage.labelWindValue.Text, Convert.ToString(windForce).Replace("-", ""), Globals.Stage.WindDirection);
            Globals.Stage.pictureBoxLocation.BackgroundImage = WinFormsLander.Properties.Resources.Location_Miranda;
        }

        public static void LoadStage3_4()
        {
            if (Globals.GameType == Enum.GameType.OreColleting)
            {
                Globals.RedOre.PictureBoxMain.Location = new Point(100, 200);
                Globals.GreenOre.PictureBoxMain.Location = new Point(270, 300);
                Globals.BlueOre.PictureBoxMain.Location = new Point(550, 350);

                Globals.RedOre.X = 200;
                Globals.RedOre.Y = 200;

                Globals.GreenOre.X = 50;
                Globals.GreenOre.Y = 500;

                Globals.BlueOre.X = 500;
                Globals.BlueOre.Y = 300;
            }

            float gravity = 0.38F;
            float windForce = 0;
            Globals.Stage.constHForce = Functions.ConvertMpSToForce(windForce, Globals.Interval);
            Globals.CurrentStage = 34;
            Globals.Stage.labelStage.Text = "Estágio 3-4";
            Globals.Stage.labelLocation.Text = "Titânia";
            Globals.Stage.panelStage.BackColor = System.Drawing.Color.Black;
            Globals.Stage.constVForce = Functions.ConvertMpSToForce(gravity, Globals.Interval);
            Globals.Stage.labelGravityValue.Text = string.Format(Globals.Stage.labelGravityValue.Text, gravity.ToString());
            Globals.Stage.labelWindValue.Text = string.Format(Globals.Stage.labelWindValue.Text, Convert.ToString(windForce).Replace("-", ""), Globals.Stage.WindDirection);
            Globals.Stage.pictureBoxLocation.BackgroundImage = WinFormsLander.Properties.Resources.Location_Titania;
        }

        public static void LoadStage3_5()
        {
            if (Globals.GameType == Enum.GameType.OreColleting)
            {
                Globals.RedOre.PictureBoxMain.Location = new Point(100, 200);
                Globals.GreenOre.PictureBoxMain.Location = new Point(270, 300);
                Globals.BlueOre.PictureBoxMain.Location = new Point(550, 350);

                Globals.RedOre.X = 200;
                Globals.RedOre.Y = 200;

                Globals.GreenOre.X = 50;
                Globals.GreenOre.Y = 500;

                Globals.BlueOre.X = 500;
                Globals.BlueOre.Y = 300;

            }

            float gravity = 0.77F;
            float windForce = 0;
            Globals.Stage.constHForce = Functions.ConvertMpSToForce(windForce, Globals.Interval);
            Globals.CurrentStage = 35;
            Globals.Stage.labelStage.Text = "Estágio 3-5";
            Globals.Stage.labelLocation.Text = "Tritão";
            Globals.Stage.panelStage.BackColor = System.Drawing.Color.Black;
            Globals.Stage.constVForce = Functions.ConvertMpSToForce(gravity, Globals.Interval);
            Globals.Stage.labelGravityValue.Text = string.Format(Globals.Stage.labelGravityValue.Text, gravity.ToString());
            Globals.Stage.labelWindValue.Text = string.Format(Globals.Stage.labelWindValue.Text, Convert.ToString(windForce).Replace("-", ""), Globals.Stage.WindDirection);
            Globals.Stage.pictureBoxLocation.BackgroundImage = WinFormsLander.Properties.Resources.Location_Triton;
        }

        public static void LoadStage4_1()
        {
            if (Globals.GameType == Enum.GameType.OreColleting)
            {
                Globals.RedOre.PictureBoxMain.Location = new Point(350, 200);
                Globals.GreenOre.PictureBoxMain.Location = new Point(50, 450);
                Globals.BlueOre.PictureBoxMain.Location = new Point(550, 450);

                Globals.RedOre.X = 350;
                Globals.RedOre.Y = 200;

                Globals.GreenOre.X = 50;
                Globals.GreenOre.Y = 450;

                Globals.BlueOre.X = 550;
                Globals.BlueOre.Y = 450;
            }

            float gravity = 0.27F;
            float windForce = 0;
            Globals.Stage.constHForce = Functions.ConvertMpSToForce(windForce, Globals.Interval);
            Globals.CurrentStage = 41;
            Globals.Stage.labelStage.Text = "Estágio 4-1";
            Globals.Stage.labelLocation.Text = "Ceres";
            Globals.Stage.panelStage.BackColor = System.Drawing.Color.Black;
            Globals.Stage.constVForce = Functions.ConvertMpSToForce(gravity, Globals.Interval);
            Globals.Stage.labelGravityValue.Text = string.Format(Globals.Stage.labelGravityValue.Text, gravity.ToString());
            Globals.Stage.labelWindValue.Text = string.Format(Globals.Stage.labelWindValue.Text, Convert.ToString(windForce).Replace("-", ""), Globals.Stage.WindDirection);
            Globals.Stage.pictureBoxLocation.BackgroundImage = WinFormsLander.Properties.Resources.Location_Ceres;
        }

        public static void LoadStage4_2()
        {
            if (Globals.GameType == Enum.GameType.OreColleting)
            {
                Globals.RedOre.PictureBoxMain.Location = new Point(100, 200);
                Globals.GreenOre.PictureBoxMain.Location = new Point(270, 200);
                Globals.BlueOre.PictureBoxMain.Location = new Point(450, 350);

                Globals.RedOre.X = 100;
                Globals.RedOre.Y = 200;

                Globals.GreenOre.X = 270;
                Globals.GreenOre.Y = 200;

                Globals.BlueOre.X = 450;
                Globals.BlueOre.Y = 350;
            }

            float gravity = 0.44F;
            float windForce = 0;
            Globals.Stage.constHForce = Functions.ConvertMpSToForce(windForce, Globals.Interval);
            Globals.CurrentStage = 42;
            Globals.Stage.labelStage.Text = "Estágio 4-2";
            Globals.Stage.labelLocation.Text = "Haumeia";
            Globals.Stage.panelStage.BackColor = System.Drawing.Color.Black;
            Globals.Stage.constVForce = Functions.ConvertMpSToForce(gravity, Globals.Interval);
            Globals.Stage.labelGravityValue.Text = string.Format(Globals.Stage.labelGravityValue.Text, gravity.ToString());
            Globals.Stage.labelWindValue.Text = string.Format(Globals.Stage.labelWindValue.Text, Convert.ToString(windForce).Replace("-", ""), Globals.Stage.WindDirection);
            Globals.Stage.pictureBoxLocation.BackgroundImage = WinFormsLander.Properties.Resources.Location_Haumea;
        }

        public static void LoadStage4_3()
        {
            if (Globals.GameType == Enum.GameType.OreColleting)
            {
                Globals.RedOre.PictureBoxMain.Location = new Point(180, 270);
                Globals.GreenOre.PictureBoxMain.Location = new Point(270, 270);
                Globals.BlueOre.PictureBoxMain.Location = new Point(550, 270);

                Globals.RedOre.X = 180;
                Globals.RedOre.Y = 270;

                Globals.GreenOre.X = 50;
                Globals.GreenOre.Y = 270;

                Globals.BlueOre.X = 500;
                Globals.BlueOre.Y = 270;
            }

            float gravity = 0.65F;
            float windForce = 0;
            Globals.Stage.constHForce = Functions.ConvertMpSToForce(windForce, Globals.Interval);
            Globals.CurrentStage = 43;
            Globals.Stage.labelStage.Text = "Estágio 4-3";
            Globals.Stage.labelLocation.Text = "Plutão";
            Globals.Stage.panelStage.BackColor = System.Drawing.Color.Black;
            Globals.Stage.constVForce = Functions.ConvertMpSToForce(gravity, Globals.Interval);
            Globals.Stage.labelGravityValue.Text = string.Format(Globals.Stage.labelGravityValue.Text, gravity.ToString());
            Globals.Stage.labelWindValue.Text = string.Format(Globals.Stage.labelWindValue.Text, Convert.ToString(windForce).Replace("-", ""), Globals.Stage.WindDirection);
            Globals.Stage.pictureBoxLocation.BackgroundImage = WinFormsLander.Properties.Resources.Location_Pluto;
        }

        public static void LoadStage4_4()
        {
            if (Globals.GameType == Enum.GameType.OreColleting)
            {
                Globals.RedOre.PictureBoxMain.Location = new Point(50, 550);
                Globals.GreenOre.PictureBoxMain.Location = new Point(100, 550);
                Globals.BlueOre.PictureBoxMain.Location = new Point(550, 550);

                Globals.RedOre.X = 50;
                Globals.RedOre.Y = 550;

                Globals.GreenOre.X = 100;
                Globals.GreenOre.Y = 550;

                Globals.BlueOre.X = 550;
                Globals.BlueOre.Y = 550;
            }

            float gravity = 0.80F;
            float windForce = 0;
            Globals.Stage.constHForce = Functions.ConvertMpSToForce(windForce, Globals.Interval);
            Globals.CurrentStage = 44;
            Globals.Stage.labelStage.Text = "Estágio 4-4";
            Globals.Stage.labelLocation.Text = "Eris";
            Globals.Stage.panelStage.BackColor = System.Drawing.Color.Black;
            Globals.Stage.constVForce = Functions.ConvertMpSToForce(gravity, Globals.Interval);
            Globals.Stage.labelGravityValue.Text = string.Format(Globals.Stage.labelGravityValue.Text, gravity.ToString());
            Globals.Stage.labelWindValue.Text = string.Format(Globals.Stage.labelWindValue.Text, Convert.ToString(windForce).Replace("-", ""), Globals.Stage.WindDirection);
            Globals.Stage.pictureBoxLocation.BackgroundImage = WinFormsLander.Properties.Resources.Location_Eris;
        }

        public static void LoadStage4_5()
        {
            if (Globals.GameType == Enum.GameType.OreColleting)
            {
                Globals.RedOre.PictureBoxMain.Location = new Point(630, 200);
                Globals.GreenOre.PictureBoxMain.Location = new Point(5, 300);
                Globals.BlueOre.PictureBoxMain.Location = new Point(300, 300);

                Globals.RedOre.X = 630;
                Globals.RedOre.Y = 200;

                Globals.GreenOre.X = 5;
                Globals.GreenOre.Y = 300;

                Globals.BlueOre.X = 300;
                Globals.BlueOre.Y = 300;
            }

            float gravity = 0.40F;
            float windForce = 0;
            Globals.Stage.constHForce = Functions.ConvertMpSToForce(windForce, Globals.Interval);
            Globals.CurrentStage = 45;
            Globals.Stage.labelStage.Text = "Estágio 4-5";
            Globals.Stage.labelLocation.Text = "Sedna";
            Globals.Stage.panelStage.BackColor = System.Drawing.Color.Black;
            Globals.Stage.constVForce = Functions.ConvertMpSToForce(gravity, Globals.Interval);
            Globals.Stage.labelGravityValue.Text = string.Format(Globals.Stage.labelGravityValue.Text, gravity.ToString());
            Globals.Stage.labelWindValue.Text = string.Format(Globals.Stage.labelWindValue.Text, Convert.ToString(windForce).Replace("-", ""), Globals.Stage.WindDirection);
            Globals.Stage.pictureBoxLocation.BackgroundImage = WinFormsLander.Properties.Resources.Location_Sedna;
        }

        public static void LoadStage5_1()
        {
            if (Globals.GameType == Enum.GameType.OreColleting)
            {
                Globals.RedOre.PictureBoxMain.Location = new Point(100, 250);
                Globals.GreenOre.PictureBoxMain.Location = new Point(300, 400);
                Globals.BlueOre.PictureBoxMain.Location = new Point(550, 550);

                Globals.RedOre.X = 100;
                Globals.RedOre.Y = 250;

                Globals.GreenOre.X = 300;
                Globals.GreenOre.Y = 400;

                Globals.BlueOre.X = 550;
                Globals.BlueOre.Y = 550;
            }

            float gravity = 0.18F;
            float windForce = 0;
            Globals.Stage.constHForce = Functions.ConvertMpSToForce(windForce, Globals.Interval);
            Globals.CurrentStage = 51;
            Globals.Stage.labelStage.Text = "Estágio 5-1";
            Globals.Stage.labelLocation.Text = "Palas";
            Globals.Stage.panelStage.BackColor = System.Drawing.Color.Black;
            Globals.Stage.constVForce = Functions.ConvertMpSToForce(gravity, Globals.Interval);
            Globals.Stage.labelGravityValue.Text = string.Format(Globals.Stage.labelGravityValue.Text, gravity.ToString());
            Globals.Stage.labelWindValue.Text = string.Format(Globals.Stage.labelWindValue.Text, Convert.ToString(windForce).Replace("-", ""), Globals.Stage.WindDirection);
            Globals.Stage.pictureBoxLocation.BackgroundImage = WinFormsLander.Properties.Resources.Location_Pallas;
        }

        public static void LoadStage5_2()
        {
            if (Globals.GameType == Enum.GameType.OreColleting)
            {
                Globals.RedOre.PictureBoxMain.Location = new Point(500, 200);
                Globals.GreenOre.PictureBoxMain.Location = new Point(500, 300);
                Globals.BlueOre.PictureBoxMain.Location = new Point(500, 350);

                Globals.RedOre.X = 500;
                Globals.RedOre.Y = 200;

                Globals.GreenOre.X = 500;
                Globals.GreenOre.Y = 300;

                Globals.BlueOre.X = 500;
                Globals.BlueOre.Y = 350;
            }

            float gravity = 0.22F;
            float windForce = 0;
            Globals.Stage.constHForce = Functions.ConvertMpSToForce(windForce, Globals.Interval);
            Globals.CurrentStage = 52;
            Globals.Stage.labelStage.Text = "Estágio 5-2";
            Globals.Stage.labelLocation.Text = "Vesta";
            Globals.Stage.panelStage.BackColor = System.Drawing.Color.Black;
            Globals.Stage.constVForce = Functions.ConvertMpSToForce(gravity, Globals.Interval);
            Globals.Stage.labelGravityValue.Text = string.Format(Globals.Stage.labelGravityValue.Text, gravity.ToString());
            Globals.Stage.labelWindValue.Text = string.Format(Globals.Stage.labelWindValue.Text, Convert.ToString(windForce).Replace("-", ""), Globals.Stage.WindDirection);
            Globals.Stage.pictureBoxLocation.BackgroundImage = WinFormsLander.Properties.Resources.Location_Vesta;
        }

        public static void LoadStage5_3()
        {
            if (Globals.GameType == Enum.GameType.OreColleting)
            {
                Globals.RedOre.PictureBoxMain.Location = new Point(100, 200);
                Globals.GreenOre.PictureBoxMain.Location = new Point(270, 300);
                Globals.BlueOre.PictureBoxMain.Location = new Point(550, 350);

                Globals.RedOre.X = 100;
                Globals.RedOre.Y = 200;

                Globals.GreenOre.X = 270;
                Globals.GreenOre.Y = 300;

                Globals.BlueOre.X = 550;
                Globals.BlueOre.Y = 350;
            }

            float gravity = 0.09F;
            float windForce = 0;
            Globals.Stage.constHForce = Functions.ConvertMpSToForce(windForce, Globals.Interval);
            Globals.CurrentStage = 53;
            Globals.Stage.labelStage.Text = "Estágio 5-3";
            Globals.Stage.labelLocation.Text = "Hígia";
            Globals.Stage.panelStage.BackColor = System.Drawing.Color.Black;
            Globals.Stage.constVForce = Functions.ConvertMpSToForce(gravity, Globals.Interval);
            Globals.Stage.labelGravityValue.Text = string.Format(Globals.Stage.labelGravityValue.Text, gravity.ToString());
            Globals.Stage.labelWindValue.Text = string.Format(Globals.Stage.labelWindValue.Text, Convert.ToString(windForce).Replace("-", ""), Globals.Stage.WindDirection);
            Globals.Stage.pictureBoxLocation.BackgroundImage = WinFormsLander.Properties.Resources.Location_Hygiea;
        }

        public static void LoadStage5_4()
        {
            if (Globals.GameType == Enum.GameType.OreColleting)
            {
                Globals.RedOre.PictureBoxMain.Location = new Point(400, 200);
                Globals.GreenOre.PictureBoxMain.Location = new Point(270, 300);
                Globals.BlueOre.PictureBoxMain.Location = new Point(500, 300);

                Globals.RedOre.X = 400;
                Globals.RedOre.Y = 200;

                Globals.GreenOre.X = 270;
                Globals.GreenOre.Y = 300;

                Globals.BlueOre.X = 500;
                Globals.BlueOre.Y = 300;
            }

            float gravity = 0.01F;
            float windForce = 0;
            Globals.Stage.constHForce = Functions.ConvertMpSToForce(windForce, Globals.Interval);
            Globals.CurrentStage = 54;
            Globals.Stage.labelStage.Text = "Estágio 5-4";
            Globals.Stage.labelLocation.Text = "Ida";
            Globals.Stage.panelStage.BackColor = System.Drawing.Color.Black;
            Globals.Stage.constVForce = Functions.ConvertMpSToForce(gravity, Globals.Interval);
            Globals.Stage.labelGravityValue.Text = string.Format(Globals.Stage.labelGravityValue.Text, gravity.ToString());
            Globals.Stage.labelWindValue.Text = string.Format(Globals.Stage.labelWindValue.Text, Convert.ToString(windForce).Replace("-", ""), Globals.Stage.WindDirection);
            Globals.Stage.pictureBoxLocation.BackgroundImage = WinFormsLander.Properties.Resources.Location_Ida;
        }

        public static void LoadStage5_5()
        {
            if (Globals.GameType == Enum.GameType.OreColleting)
            {
                Globals.RedOre.PictureBoxMain.Location = new Point(500, 200);
                Globals.GreenOre.PictureBoxMain.Location = new Point(200, 300);
                Globals.BlueOre.PictureBoxMain.Location = new Point(500, 350);

                Globals.RedOre.X = 500;
                Globals.RedOre.Y = 200;

                Globals.GreenOre.X = 200;
                Globals.GreenOre.Y = 300;

                Globals.BlueOre.X = 500;
                Globals.BlueOre.Y = 350;
            }

            float gravity = 0.15F;
            float windForce = 0;
            Globals.Stage.constHForce = Functions.ConvertMpSToForce(windForce, Globals.Interval);
            Globals.CurrentStage = 55;
            Globals.Stage.labelStage.Text = "Estágio 5-5";
            Globals.Stage.labelLocation.Text = "Varuna";
            Globals.Stage.panelStage.BackColor = System.Drawing.Color.Black;
            Globals.Stage.constVForce = Functions.ConvertMpSToForce(gravity, Globals.Interval);
            Globals.Stage.labelGravityValue.Text = string.Format(Globals.Stage.labelGravityValue.Text, gravity.ToString());
            Globals.Stage.labelWindValue.Text = string.Format(Globals.Stage.labelWindValue.Text, Convert.ToString(windForce).Replace("-", ""), Globals.Stage.WindDirection);
            Globals.Stage.pictureBoxLocation.BackgroundImage = WinFormsLander.Properties.Resources.Location_Varuna;
        }

        public static void LoadStage6_1()
        {
            if (Globals.GameType == Enum.GameType.OreColleting)
            {
                Globals.RedOre.PictureBoxMain.Location = new Point(600, 500);
                Globals.GreenOre.PictureBoxMain.Location = new Point(300, 300);
                Globals.BlueOre.PictureBoxMain.Location = new Point(150, 350);

                Globals.RedOre.X = 600;
                Globals.RedOre.Y = 500;

                Globals.GreenOre.X = 300;
                Globals.GreenOre.Y = 300;

                Globals.BlueOre.X = 150;
                Globals.BlueOre.Y = 350;
            }

            float gravity = 8.40F;
            float windForce = GameFunctions.GenerateRandomWind(4, 5, Globals.Stage);
            Globals.Stage.constHForce = Functions.ConvertMpSToForce(windForce, Globals.Interval);
            Globals.CurrentStage = 61;
            Globals.Stage.labelStage.Text = "Estágio 6-1";
            Globals.Stage.labelLocation.Text = "Zebes";
            Globals.Stage.panelStage.BackColor = System.Drawing.Color.DimGray;

            Globals.Stage.constVForce = Functions.ConvertMpSToForce(gravity, Globals.Interval);
            Globals.Stage.labelGravityValue.Text = string.Format(Globals.Stage.labelGravityValue.Text, gravity.ToString());
            Globals.Stage.labelWindValue.Text = string.Format(Globals.Stage.labelWindValue.Text, Convert.ToString(windForce).Replace("-", ""), Globals.Stage.WindDirection);
            Globals.Stage.pictureBoxLocation.BackgroundImage = WinFormsLander.Properties.Resources.Location_Zebes;
        }

        public static void LoadStage6_2()
        {
            if (Globals.GameType == Enum.GameType.OreColleting)
            {
                Globals.RedOre.PictureBoxMain.Location = new Point(600, 500);
                Globals.GreenOre.PictureBoxMain.Location = new Point(300, 300);
                Globals.BlueOre.PictureBoxMain.Location = new Point(150, 350);

                Globals.RedOre.X = 600;
                Globals.RedOre.Y = 500;

                Globals.GreenOre.X = 300;
                Globals.GreenOre.Y = 300;

                Globals.BlueOre.X = 150;
                Globals.BlueOre.Y = 350;
            }

            float gravity = 7.60F;
            float windForce = GameFunctions.GenerateRandomWind(4, 5, Globals.Stage);
            Globals.Stage.constHForce = Functions.ConvertMpSToForce(windForce, Globals.Interval);
            Globals.CurrentStage = 62;
            Globals.Stage.labelStage.Text = "Estágio 6-2";
            Globals.Stage.labelLocation.Text = "SR-388";
            Globals.Stage.panelStage.BackColor = System.Drawing.Color.SeaGreen;

            Globals.Stage.constVForce = Functions.ConvertMpSToForce(gravity, Globals.Interval);
            Globals.Stage.labelGravityValue.Text = string.Format(Globals.Stage.labelGravityValue.Text, gravity.ToString());
            Globals.Stage.labelWindValue.Text = string.Format(Globals.Stage.labelWindValue.Text, Convert.ToString(windForce).Replace("-", ""), Globals.Stage.WindDirection);
            Globals.Stage.pictureBoxLocation.BackgroundImage = WinFormsLander.Properties.Resources.Location_SR388;
        }

        public static void LoadStage6_3()
        {
            if (Globals.GameType == Enum.GameType.OreColleting)
            {
                Globals.RedOre.PictureBoxMain.Location = new Point(600, 500);
                Globals.GreenOre.PictureBoxMain.Location = new Point(300, 300);
                Globals.BlueOre.PictureBoxMain.Location = new Point(150, 350);

                Globals.RedOre.X = 600;
                Globals.RedOre.Y = 500;

                Globals.GreenOre.X = 300;
                Globals.GreenOre.Y = 300;

                Globals.BlueOre.X = 150;
                Globals.BlueOre.Y = 350;
            }

            float gravity = 0.01F;
            float windForce = GameFunctions.GenerateRandomWind(0, 0, Globals.Stage);
            Globals.Stage.constHForce = Functions.ConvertMpSToForce(windForce, Globals.Interval);
            Globals.CurrentStage = 63;
            Globals.Stage.labelStage.Text = "Estágio 6-3";
            Globals.Stage.labelLocation.Text = "Space Lab";
            Globals.Stage.panelStage.BackColor = System.Drawing.Color.Black;

            Globals.Stage.constVForce = Functions.ConvertMpSToForce(gravity, Globals.Interval);
            Globals.Stage.labelGravityValue.Text = string.Format(Globals.Stage.labelGravityValue.Text, gravity.ToString());
            Globals.Stage.labelWindValue.Text = string.Format(Globals.Stage.labelWindValue.Text, Convert.ToString(windForce).Replace("-", ""), Globals.Stage.WindDirection);
            Globals.Stage.pictureBoxLocation.BackgroundImage = WinFormsLander.Properties.Resources.Location_BiologicSpaceLab;
        }

        public static void LoadStage6_4()
        {
            if (Globals.GameType == Enum.GameType.OreColleting)
            {
                Globals.RedOre.PictureBoxMain.Location = new Point(600, 500);
                Globals.GreenOre.PictureBoxMain.Location = new Point(300, 300);
                Globals.BlueOre.PictureBoxMain.Location = new Point(150, 350);

                Globals.RedOre.X = 600;
                Globals.RedOre.Y = 500;

                Globals.GreenOre.X = 300;
                Globals.GreenOre.Y = 300;

                Globals.BlueOre.X = 150;
                Globals.BlueOre.Y = 350;
            }

            float gravity = 10.6F;
            float windForce = GameFunctions.GenerateRandomWind(4, 5, Globals.Stage);
            Globals.Stage.constHForce = Functions.ConvertMpSToForce(windForce, Globals.Interval);
            Globals.CurrentStage = 64;
            Globals.Stage.labelStage.Text = "Estágio 6-4";
            Globals.Stage.labelLocation.Text = "Tallon IV";
            Globals.Stage.panelStage.BackColor = System.Drawing.Color.RosyBrown;

            Globals.Stage.constVForce = Functions.ConvertMpSToForce(gravity, Globals.Interval);
            Globals.Stage.labelGravityValue.Text = string.Format(Globals.Stage.labelGravityValue.Text, gravity.ToString());
            Globals.Stage.labelWindValue.Text = string.Format(Globals.Stage.labelWindValue.Text, Convert.ToString(windForce).Replace("-", ""), Globals.Stage.WindDirection);
            Globals.Stage.pictureBoxLocation.BackgroundImage = WinFormsLander.Properties.Resources.Location_TallonIV;
        }

        public static void LoadStage6_5()
        {
            if (Globals.GameType == Enum.GameType.OreColleting)
            {
                Globals.RedOre.PictureBoxMain.Location = new Point(600, 500);
                Globals.GreenOre.PictureBoxMain.Location = new Point(300, 300);
                Globals.BlueOre.PictureBoxMain.Location = new Point(150, 350);

                Globals.RedOre.X = 600;
                Globals.RedOre.Y = 500;

                Globals.GreenOre.X = 300;
                Globals.GreenOre.Y = 300;

                Globals.BlueOre.X = 150;
                Globals.BlueOre.Y = 350;
            }

            float gravity = 9.03F;
            float windForce = GameFunctions.GenerateRandomWind(4, 5, Globals.Stage);
            Globals.Stage.constHForce = Functions.ConvertMpSToForce(windForce, Globals.Interval);
            Globals.CurrentStage = 65;
            Globals.Stage.labelStage.Text = "Estágio 6-5";
            Globals.Stage.labelLocation.Text = "Aether";
            Globals.Stage.panelStage.BackColor = System.Drawing.Color.Teal;

            Globals.Stage.constVForce = Functions.ConvertMpSToForce(gravity, Globals.Interval);
            Globals.Stage.labelGravityValue.Text = string.Format(Globals.Stage.labelGravityValue.Text, gravity.ToString());
            Globals.Stage.labelWindValue.Text = string.Format(Globals.Stage.labelWindValue.Text, Convert.ToString(windForce).Replace("-", ""), Globals.Stage.WindDirection);
            Globals.Stage.pictureBoxLocation.BackgroundImage = WinFormsLander.Properties.Resources.Location_Aether;
        }

        public static void UpdateStage()
        {
            Globals.RelativeVelocity = Functions.CalculateTotalForceToSprite(Globals.SelectedShip, Globals.LZSprite);
            Globals.SelectedShip.TotalVelocity = Functions.CalculateTotalForce(Globals.SelectedShip);
            Globals.Stage.MoveSpeedBar();
            Globals.Stage.MoveSpeedBarToLZ(Globals.RelativeVelocity);
            GameFunctions.DecreaseFuel(Globals.SelectedShip, Globals.Stage.progressBarFuel);

            if (Globals.SpaceKeyPressed)
            {
                Globals.Stage.pictureBoxSpecialLED.BackgroundImage = WinFormsLander.Properties.Resources.LED_ON;
            }
            else
            {
                Globals.Stage.pictureBoxSpecialLED.BackgroundImage = WinFormsLander.Properties.Resources.LED_OFF;
            }

            if (Globals.SelectedShip.PictureBoxMain.Location.Y < 0 - Globals.SelectedShip.PictureBoxMain.Size.Height)
            {
                Globals.Stage.labelCursor.Visible = true;
                Globals.Stage.pictureBoxCursor.Visible = true;
                GameFunctions.MoveOffMapCursor();
            }
            else
            {
                Globals.Stage.labelCursor.Visible = false;
                Globals.Stage.pictureBoxCursor.Visible = false;
            }
        }

        public static void UpdateForOre()
        {
            if (Globals.RedOre.PictureBoxMain.Visible)
            {
                Functions.MoveSprite(Globals.RedOre);
                Functions.TeleportSprite(Globals.RedOre, Globals.Stage.panelStage, Enum.Axis.All);

                if (Functions.DetectCollision(Globals.RedOre, Globals.SelectedShip))
                {
                    Globals.RedOre.PictureBoxMain.Visible = false;
                    Globals.CollectedSFX.Play();
                }
            }

            if (Globals.GreenOre.PictureBoxMain.Visible)
            {
                Functions.MoveSprite(Globals.GreenOre);
                Functions.TeleportSprite(Globals.GreenOre, Globals.Stage.panelStage, Enum.Axis.All);

                if (Functions.DetectCollision(Globals.GreenOre, Globals.SelectedShip))
                {
                    Globals.GreenOre.PictureBoxMain.Visible = false;
                    Globals.CollectedSFX.Play();
                }
            }

            if (Globals.BlueOre.PictureBoxMain.Visible)
            {
                Functions.MoveSprite(Globals.BlueOre);
                Functions.TeleportSprite(Globals.BlueOre, Globals.Stage.panelStage, Enum.Axis.All);

                if (Functions.DetectCollision(Globals.BlueOre, Globals.SelectedShip))
                {
                    Globals.BlueOre.PictureBoxMain.Visible = false;
                    Globals.CollectedSFX.Play();
                }
            }
        }

        public static void UpdateForAreaFree()
        {
            Functions.ApplyGravity(Globals.LZSprite, Globals.SelectedShip);
        }

        public static void UpdateForArea1()
        {
        }

        public static void UpdateForArea2()
        {
        }

        public static void UpdateForArea3()
        {
            if (Globals.Stage.lz.Location.X < 0 || Globals.Stage.lz.Location.X > Globals.Stage.panelStage.Width - Globals.Stage.lz.Size.Width)
            {
                Globals.LZSprite.HorizontalVelocity *= -1;
            }

            if (Globals.GameType == Enum.GameType.OreColleting)
            {
                Globals.RedOre.FlickCount++;
                Globals.GreenOre.FlickCount++;
                Globals.BlueOre.FlickCount++;

                if (Globals.RedOre.FlickCount > 50)
                {
                    Globals.RedOre.FlickCount = 0;

                    if (Globals.Random.Next() > 0.5F)
                    {
                        Globals.RedOre.HorizontalVelocity *= -1;
                    }
                }

                if (Globals.GreenOre.FlickCount > 80)
                {
                    Globals.GreenOre.FlickCount = 0;

                    if (Globals.Random.Next() > 0.5F)
                    {
                        Globals.GreenOre.HorizontalVelocity *= -1;
                    }
                }

                if (Globals.BlueOre.FlickCount > 25)
                {
                    Globals.BlueOre.FlickCount = 0;

                    if (Globals.Random.Next() > 0.5F)
                    {
                        Globals.BlueOre.HorizontalVelocity *= -1;
                    }
                }
            }
        }

        public static void UpdateForArea4()
        {
            if (Globals.LZSprite.VerticalVelocity == 0)
            {
                Globals.LZSprite.VerticalVelocity = -3;
            }

            if (Globals.Stage.lz.Location.Y < (Globals.Stage.panelStage.Size.Height * 0.66F) || Globals.Stage.lz.Location.Y > (Globals.Stage.panelStage.Size.Height - Globals.Stage.lz.Size.Height + 3))
            {
                Globals.LZSprite.VerticalVelocity *= -1;
            }

            if ((Globals.Asteroid1.X < -150 || Globals.Asteroid1.X > Globals.Stage.panelStage.Size.Width + 150)
            || (Globals.Asteroid1.Y < -150 || Globals.Asteroid1.Y > Globals.Stage.panelStage.Size.Height + 150))
            {
                double y = Globals.Random.NextDouble();
                Globals.Asteroid1.Y = (float)(-20 - (y * 100));

                double x = Globals.Random.NextDouble();
                Globals.Asteroid1.X = (float)(-20 - (x * 100));

                Globals.Asteroid1.VerticalVelocity = Globals.Random.Next(1, 10);
                Globals.Asteroid1.HorizontalVelocity = Globals.Random.Next(1, 10);

                if (x > 0.5F)
                {
                    Globals.Asteroid1.X *= -1;
                    Globals.Asteroid1.X += Globals.Stage.panelStage.Size.Width;
                    Globals.Asteroid1.HorizontalVelocity *= -1;
                }
            }
            else
            {
                if (Functions.DetectCollision(Globals.SelectedShip, Globals.Asteroid1, ref Globals.CollidedUp, ref Globals.CollidedDown, ref Globals.CollidedLeft, ref Globals.CollidedRight))
                {
                    Globals.Collided = true;
                    Globals.SelectedShip.PictureBoxMain.BackgroundImage = Globals.SelectedShip.ImageExplosion;
                    Globals.ExplosionSFX.Play();
                }

                Functions.MoveSprite(Globals.Asteroid1);
            }

            if (Globals.GameType == Enum.GameType.OreColleting)
            {
                Globals.RedOre.FlickCount++;
                Globals.GreenOre.FlickCount++;
                Globals.BlueOre.FlickCount++;

                if (Globals.RedOre.FlickCount > 50)
                {
                    Globals.RedOre.FlickCount = 0;

                    if (Globals.Random.NextDouble() > 0.5F)
                    {
                        Globals.RedOre.HorizontalVelocity *= -1;
                    }

                    if (Globals.Random.NextDouble() > 0.5F)
                    {
                        Globals.RedOre.VerticalVelocity *= -1;
                    }
                }

                if (Globals.GreenOre.FlickCount > 80)
                {
                    Globals.GreenOre.FlickCount = 0;

                    if (Globals.Random.NextDouble() > 0.5F)
                    {
                        Globals.GreenOre.HorizontalVelocity *= -1;
                    }

                    if (Globals.Random.NextDouble() > 0.5F)
                    {
                        Globals.GreenOre.VerticalVelocity *= -1;
                    }
                }

                if (Globals.BlueOre.FlickCount > 25)
                {
                    Globals.BlueOre.FlickCount = 0;

                    if (Globals.Random.NextDouble() > 0.5F)
                    {
                        Globals.BlueOre.HorizontalVelocity *= -1;
                    }

                    if (Globals.Random.NextDouble() > 0.5F)
                    {
                        Globals.BlueOre.VerticalVelocity *= -1;
                    }
                }
            }
        }

        public static void UpdateForArea5()
        {
            if (Globals.Stage.lz.Location.X < 0 || Globals.Stage.lz.Location.X > Globals.Stage.panelStage.Width - Globals.Stage.lz.Size.Width)
            {
                Globals.LZSprite.HorizontalVelocity *= -1;
            }

            if ((Globals.Asteroid1.X < -150 || Globals.Asteroid1.X > Globals.Stage.panelStage.Size.Width + 150)
                || (Globals.Asteroid1.Y < -150 || Globals.Asteroid1.Y > Globals.Stage.panelStage.Size.Height + 150))
            {
                double y = Globals.Random.NextDouble();
                Globals.Asteroid1.Y = (float)(-20 - (y * 100));

                double x = Globals.Random.NextDouble();
                Globals.Asteroid1.X = (float)(-20 - (x * 100));

                Globals.Asteroid1.VerticalVelocity = Globals.Random.Next(1, 10);
                Globals.Asteroid1.HorizontalVelocity = Globals.Random.Next(1, 10);

                if (x > 0.5F)
                {
                    Globals.Asteroid1.X *= -1;
                    Globals.Asteroid1.X += Globals.Stage.panelStage.Size.Width;
                    Globals.Asteroid1.HorizontalVelocity *= -1;
                }
            }
            else
            {
                if (Functions.DetectCollision(Globals.SelectedShip, Globals.Asteroid1, ref Globals.CollidedUp, ref Globals.CollidedDown, ref Globals.CollidedLeft, ref Globals.CollidedRight))
                {
                    Globals.Collided = true;
                    Globals.SelectedShip.PictureBoxMain.BackgroundImage = Globals.SelectedShip.ImageExplosion;
                    Globals.ExplosionSFX.Play();
                }

                Functions.MoveSprite(Globals.Asteroid1);
            }

            if ((Globals.Asteroid2.X < -150 || Globals.Asteroid2.X > Globals.Stage.panelStage.Size.Width + 150)
            || (Globals.Asteroid2.Y < -150 || Globals.Asteroid2.Y > Globals.Stage.panelStage.Size.Height + 150))
            {
                double y = Globals.Random.NextDouble();
                Globals.Asteroid2.Y = (float)(-20 - (y * 100));

                double x = Globals.Random.NextDouble();
                Globals.Asteroid2.X = (float)(-20 - (x * 100));

                Globals.Asteroid2.VerticalVelocity = Globals.Random.Next(1, 10);
                Globals.Asteroid2.HorizontalVelocity = Globals.Random.Next(1, 10);

                if (x > 0.5F)
                {
                    Globals.Asteroid2.X *= -1;
                    Globals.Asteroid2.X += Globals.Stage.panelStage.Size.Width;
                    Globals.Asteroid2.HorizontalVelocity *= -1;
                }
            }
            else
            {
                if (Functions.DetectCollision(Globals.SelectedShip, Globals.Asteroid2, ref Globals.CollidedUp, ref Globals.CollidedDown, ref Globals.CollidedLeft, ref Globals.CollidedRight))
                {
                    Globals.Collided = true;
                    Globals.SelectedShip.PictureBoxMain.BackgroundImage = Globals.SelectedShip.ImageExplosion;
                    Globals.ExplosionSFX.Play();
                }

                Functions.MoveSprite(Globals.Asteroid2);
            }

            if (Globals.GameType == Enum.GameType.OreColleting)
            {
                Globals.RedOre.FlickCount++;
                Globals.GreenOre.FlickCount++;
                Globals.BlueOre.FlickCount++;

                if (Globals.RedOre.FlickCount > 50)
                {
                    Globals.RedOre.FlickCount = 0;

                    if (Globals.Random.NextDouble() > 0.5F)
                    {
                        Globals.RedOre.VerticalVelocity = 0;
                        Globals.RedOre.HorizontalVelocity = 5;
                    }
                    else
                    {
                        Globals.RedOre.VerticalVelocity = 5;
                        Globals.RedOre.HorizontalVelocity = 0;
                    }

                    if (Globals.Random.NextDouble() > 0.5F)
                    {
                        Globals.RedOre.VerticalVelocity *= -1;
                        Globals.RedOre.HorizontalVelocity *= -1;
                    }
                }

                if (Globals.GreenOre.FlickCount > 80)
                {
                    Globals.GreenOre.FlickCount = 0;

                    if (Globals.Random.NextDouble() > 0.5F)
                    {
                        Globals.GreenOre.HorizontalVelocity *= -1;
                    }

                    if (Globals.Random.NextDouble() > 0.5F)
                    {
                        Globals.GreenOre.VerticalVelocity *= -1;
                    }
                }

                if (Globals.BlueOre.FlickCount > 25)
                {
                    Globals.BlueOre.FlickCount = 0;

                    if (Globals.Random.NextDouble() > 0.5F)
                    {
                        Globals.BlueOre.HorizontalVelocity *= -1;
                    }

                    if (Globals.Random.NextDouble() > 0.5F)
                    {
                        Globals.BlueOre.VerticalVelocity *= -1;
                    }
                }
            }
        }

        public static void UpdateForArea6()
        {
            metroidBrakeCounter++;
            Functions.ApplyGravity(Globals.SelectedShip, Globals.Metroid);
            Functions.MoveSprite(Globals.Metroid);

            if (metroidBrakeCounter == 50)
            {
                Globals.Metroid.HorizontalVelocity = 0;
                Globals.Metroid.VerticalVelocity = 0;
                metroidBrakeCounter = 0;
            }

            if (Functions.DetectCollision(Globals.Metroid, Globals.SelectedShip))
            {
                Globals.SelectedShip.Fuel -= Globals.SelectedShip.FuelConsumptionRate * 2;

                Globals.Stage.progressBarFuel.ForeColor = Color.Purple;
            }
            else
            {
                Globals.Stage.progressBarFuel.ForeColor = Color.SpringGreen;
            }

            if (Globals.GameType == Enum.GameType.OreColleting)
            {
                Globals.RedOre.FlickCount++;
                Globals.GreenOre.FlickCount++;
                Globals.BlueOre.FlickCount++;

                if (Globals.RedOre.FlickCount > 100)
                {
                    Globals.RedOre.FlickCount = 0;
                    Globals.RedOre.X = Globals.Random.Next(5, 630);
                    Globals.RedOre.Y = Globals.Random.Next(5, 530);
                }

                if (Globals.GreenOre.FlickCount > 80)
                {
                    Globals.GreenOre.FlickCount = 0;
                    Globals.GreenOre.X = Globals.Random.Next(5, 630);
                    Globals.GreenOre.Y = Globals.Random.Next(5, 530);
                }

                if (Globals.BlueOre.FlickCount > 65)
                {
                    Globals.BlueOre.FlickCount = 0;
                    Globals.BlueOre.X = Globals.Random.Next(5, 630);
                    Globals.BlueOre.Y = Globals.Random.Next(5, 530);
                }
            }
        }
    }
}
