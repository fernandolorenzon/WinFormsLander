using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using WinFormsLander.Classes;

namespace WinFormsLander.Functions
{
    public static class LanderFunctions
    {
        public static ShipSprite LoadShipSprites(ShipSprite sprite)
        {
            sprite.Accel = Functions.ConvertMpSToForce(sprite.AccelMpS, Globals.TimerInterval);

            PictureBox left = new PictureBox();
            left.Size = new Size(32, 32);
            PictureBox right = new PictureBox();
            right.Size = new Size(32, 32);
            PictureBox up = new PictureBox();
            up.Size = new Size(32, 32);
            PictureBox down = new PictureBox();
            down.Size = new Size(32, 32);

            sprite.LeftSprite = new Sprite(left);
            sprite.RightSprite = new Sprite(right);
            sprite.UpSprite = new Sprite(up);
            sprite.DownSprite = new Sprite(down);

            sprite.LeftSprite.ImageDefault = WinFormsLander.Properties.Resources.LeftBoost;
            sprite.RightSprite.ImageDefault = WinFormsLander.Properties.Resources.RightBoost;
            sprite.UpSprite.ImageDefault = WinFormsLander.Properties.Resources.UpBoost;
            sprite.DownSprite.ImageDefault = WinFormsLander.Properties.Resources.RocketBoost;

            left.BackgroundImage = sprite.LeftSprite.ImageDefault;
            right.BackgroundImage = sprite.RightSprite.ImageDefault;
            up.BackgroundImage = sprite.UpSprite.ImageDefault;
            down.BackgroundImage = sprite.DownSprite.ImageDefault;

            left.BackColor = Color.Transparent;
            right.BackColor = Color.Transparent;
            up.BackColor = Color.Transparent;
            down.BackColor = Color.Transparent;

            sprite.PictureBoxMain.BackgroundImage = sprite.ImageDefault;

            if (sprite.Ship == Enum.Ships.Type01)
            {
                Globals.UpdateLander = new WinFormsLander.Forms.FormBase.UpdateForLander(LanderFunctions.UpdateForLander01);
            }
            else if (sprite.Ship == Enum.Ships.Type02)
            {
                Globals.UpdateLander = new WinFormsLander.Forms.FormBase.UpdateForLander(LanderFunctions.UpdateForLander02);
            }
            else if (sprite.Ship == Enum.Ships.Type03)
            {
                Globals.UpdateLander = new WinFormsLander.Forms.FormBase.UpdateForLander(LanderFunctions.UpdateForLander03);
            }
            else if (sprite.Ship == Enum.Ships.Type04)
            {
                Globals.UpdateLander = new WinFormsLander.Forms.FormBase.UpdateForLander(LanderFunctions.UpdateForLander04);
            }
            else if (sprite.Ship == Enum.Ships.Type05)
            {
                Globals.UpdateLander = new WinFormsLander.Forms.FormBase.UpdateForLander(LanderFunctions.UpdateForLander05);
            }
            else if (sprite.Ship == Enum.Ships.Type06)
            {
                Globals.UpdateLander = new WinFormsLander.Forms.FormBase.UpdateForLander(LanderFunctions.UpdateForLander06);
            }
            else if (sprite.Ship == Enum.Ships.Type07)
            {
                Globals.UpdateLander = new WinFormsLander.Forms.FormBase.UpdateForLander(LanderFunctions.UpdateForLander07);
            }
            else if (sprite.Ship == Enum.Ships.Type08)
            {
                Globals.UpdateLander = new WinFormsLander.Forms.FormBase.UpdateForLander(LanderFunctions.UpdateForLander08);
            }
            else if (sprite.Ship == Enum.Ships.Type09)
            {
                Globals.UpdateLander = new WinFormsLander.Forms.FormBase.UpdateForLander(LanderFunctions.UpdateForLander09);
            }
            else if (sprite.Ship == Enum.Ships.TypeX1)
            {
                Globals.UpdateLander = new WinFormsLander.Forms.FormBase.UpdateForLander(LanderFunctions.UpdateForLanderX1);
            }

            return sprite;
        }



        public static void UpdateForLander01()
        {
            if (Globals.SelectedShip.Fuel > 0)
            {
                if (Globals.SpaceKeyPressed)
                {
                    Functions.ApplyDrag(Globals.SelectedShip.Accel * 2, Globals.SelectedShip, Enum.Axis.All);
                }

                Globals.RocketSFX.PlayLooping(Globals.LeftKeyPressed || Globals.RightKeyPressed || Globals.UpKeyPressed || Globals.DownKeyPressed || Globals.SpaceKeyPressed);

                Functions.ApplyFlicker(Globals.SelectedShip.DownSprite, Globals.UpKeyPressed || Globals.SpaceKeyPressed, false);
                Functions.ApplyFlicker(Globals.SelectedShip.RightSprite, Globals.LeftKeyPressed || Globals.SpaceKeyPressed, false);
                Functions.ApplyFlicker(Globals.SelectedShip.LeftSprite, Globals.RightKeyPressed || Globals.SpaceKeyPressed, false);
                Functions.ApplyFlicker(Globals.SelectedShip.UpSprite, Globals.DownKeyPressed || Globals.SpaceKeyPressed, false);
            }
            else
            {
                Globals.RocketSFX.Stop();
                Functions.ApplyFlicker(Globals.SelectedShip.DownSprite, false, false);
                Functions.ApplyFlicker(Globals.SelectedShip.RightSprite, false, false);
                Functions.ApplyFlicker(Globals.SelectedShip.LeftSprite, false, false);
                Functions.ApplyFlicker(Globals.SelectedShip.UpSprite, false, false);
            }
        }

        public static void UpdateForLander02()
        {
            if (Globals.SelectedShip.Fuel > 0)
            {

                if (Globals.SpaceKeyPressed)
                {
                    Globals.SelectedShip.VerticalVelocity -= (Globals.SelectedShip.Accel * 2);
                }

                Globals.RocketSFX.PlayLooping(Globals.LeftKeyPressed || Globals.RightKeyPressed || Globals.UpKeyPressed || Globals.DownKeyPressed || Globals.SpaceKeyPressed);
                Functions.ApplyFlicker(Globals.SelectedShip.DownSprite, Globals.UpKeyPressed || Globals.SpaceKeyPressed, false);
                Functions.ApplyFlicker(Globals.SelectedShip.RightSprite, Globals.LeftKeyPressed, false);
                Functions.ApplyFlicker(Globals.SelectedShip.LeftSprite, Globals.RightKeyPressed, false);
                Functions.ApplyFlicker(Globals.SelectedShip.UpSprite, Globals.DownKeyPressed, false);
            }
            else
            {
                Globals.RocketSFX.Stop();
                Functions.ApplyFlicker(Globals.SelectedShip.DownSprite, false, false);
                Functions.ApplyFlicker(Globals.SelectedShip.RightSprite, false, false);
                Functions.ApplyFlicker(Globals.SelectedShip.LeftSprite, false, false);
                Functions.ApplyFlicker(Globals.SelectedShip.UpSprite, false, false);
            }

            if (Globals.SpaceKeyPressed && !Globals.SpaceKeyPressedPrevious)
            {
                Globals.SelectedShip.DownSprite.PictureBoxMain.BackgroundImage = WinFormsLander.Properties.Resources.AuxRocketBoost;
            }
            else if (!Globals.SpaceKeyPressed && Globals.SpaceKeyPressedPrevious)
            {
                Globals.SelectedShip.DownSprite.PictureBoxMain.BackgroundImage = WinFormsLander.Properties.Resources.RocketBoost;
            }
        }

        public static void UpdateForLander03()
        {
            if (Globals.SelectedShip.Fuel > 0)
            {
                if (Globals.SpaceKeyPressed)
                {
                    Globals.SelectedShip.Accel = (Functions.ConvertMpSToForce(Globals.SelectedShip.AccelMpS, Globals.Interval) / 2);
                }
                else
                {
                    Globals.SelectedShip.Accel = Functions.ConvertMpSToForce(Globals.SelectedShip.AccelMpS, Globals.Interval);
                }

                Globals.RocketSFX.PlayLooping(Globals.LeftKeyPressed || Globals.RightKeyPressed || Globals.UpKeyPressed || Globals.DownKeyPressed);
                Functions.ApplyFlicker(Globals.SelectedShip.DownSprite, Globals.UpKeyPressed, false);
                Functions.ApplyFlicker(Globals.SelectedShip.RightSprite, Globals.LeftKeyPressed, false);
                Functions.ApplyFlicker(Globals.SelectedShip.LeftSprite, Globals.RightKeyPressed, false);
                Functions.ApplyFlicker(Globals.SelectedShip.UpSprite, Globals.DownKeyPressed, false);
            }
            else
            {
                Globals.RocketSFX.Stop();
                Functions.ApplyFlicker(Globals.SelectedShip.DownSprite, false, false);
                Functions.ApplyFlicker(Globals.SelectedShip.RightSprite, false, false);
                Functions.ApplyFlicker(Globals.SelectedShip.LeftSprite, false, false);
                Functions.ApplyFlicker(Globals.SelectedShip.UpSprite, false, false);
            }
        }

        public static void UpdateForLander04()
        {
            if (Globals.SelectedShip.Fuel > 0)
            {
                if (Globals.SpaceKeyPressed)
                {
                    Globals.SelectedShip.VerticalVelocity = 0;
                    Globals.SelectedShip.HorizontalVelocity = 0;
                }

                Globals.SpecialSFX.PlayLooping(Globals.SpaceKeyPressed);
                Globals.FloatSFX.PlayLooping(Globals.LeftKeyPressed || Globals.RightKeyPressed || Globals.UpKeyPressed || Globals.DownKeyPressed);
            }
            else
            {
                Globals.FloatSFX.Stop();
                Globals.SpecialSFX.Stop();
            }
        }

        public static void UpdateForLander05()
        {
            if (Globals.SelectedShip.Fuel > 0)
            {
                if (Globals.SpaceKeyPressed)
                {
                    Functions.ApplyDrag(Globals.SelectedShip.Accel * 2, Globals.SelectedShip, Enum.Axis.Vertical);
                }

                Globals.RocketSFX.PlayLooping(Globals.UpKeyPressed || Globals.LeftKeyPressed || Globals.RightKeyPressed || Globals.DownKeyPressed || Globals.SpaceKeyPressed);
                Functions.ApplyFlicker(Globals.SelectedShip.DownSprite, Globals.UpKeyPressed || Globals.SpaceKeyPressed || Globals.LeftKeyPressed || Globals.RightKeyPressed, false);
                Functions.ApplyFlicker(Globals.SelectedShip.UpSprite, Globals.DownKeyPressed, false);
            }
            else
            {
                Globals.RocketSFX.Stop();
                Functions.ApplyFlicker(Globals.SelectedShip.DownSprite, false, false);
                Functions.ApplyFlicker(Globals.SelectedShip.UpSprite, false, false);
            }

            if (!Globals.LeftKeyPressed && !Globals.RightKeyPressed && (Globals.LeftKeyPressedPrevious || Globals.RightKeyPressedPrevious))
            {
                Globals.SelectedShip.PictureBoxMain.BackgroundImage = WinFormsLander.Properties.Resources.LanderType05;
            }
            else if (Globals.LeftKeyPressed && !Globals.LeftKeyPressedPrevious)
            {
                Globals.SelectedShip.PictureBoxMain.BackgroundImage = WinFormsLander.Properties.Resources.LanderType05_Left;
            }
            else if (Globals.RightKeyPressed && !Globals.RightKeyPressedPrevious)
            {
                Globals.SelectedShip.PictureBoxMain.BackgroundImage = WinFormsLander.Properties.Resources.LanderType05_Right;
            }
        }

        public static void UpdateForLander06()
        {
            if (Globals.SelectedShip.Fuel > 0)
            {
                if (Globals.SpaceKeyPressed && !Globals.SpaceKeyPressedPrevious)
                {
                    Globals.SelectedShip.HorizontalVelocity *= -0.3F;
                    Globals.SelectedShip.VerticalVelocity *= -0.3F;
                }

                Globals.FloatSFX.PlayLooping(Globals.LeftKeyPressed || Globals.RightKeyPressed || Globals.UpKeyPressed || Globals.DownKeyPressed);
            }
            else
            {
                Globals.FloatSFX.Stop();
            }
        }

        public static void UpdateForLander07()
        {
            if (Globals.SelectedShip.Fuel > 0)
            {
                if (Globals.SpaceKeyPressed)
                {
                    Globals.SelectedShip.VerticalVelocity -= Globals.Stage.constVForce;
                }

                Globals.RocketSFX.PlayLooping(Globals.LeftKeyPressed || Globals.RightKeyPressed || Globals.UpKeyPressed || Globals.DownKeyPressed);
                Functions.ApplyFlicker(Globals.SelectedShip.DownSprite, Globals.UpKeyPressed, false);
                Functions.ApplyFlicker(Globals.SelectedShip.RightSprite, Globals.LeftKeyPressed, false);
                Functions.ApplyFlicker(Globals.SelectedShip.LeftSprite, Globals.RightKeyPressed, false);
                Functions.ApplyFlicker(Globals.SelectedShip.UpSprite, Globals.DownKeyPressed, false);
            }
            else
            {
                Globals.RocketSFX.Stop();
                Functions.ApplyFlicker(Globals.SelectedShip.DownSprite, false, false);
                Functions.ApplyFlicker(Globals.SelectedShip.RightSprite, false, false);
                Functions.ApplyFlicker(Globals.SelectedShip.LeftSprite, false, false);
                Functions.ApplyFlicker(Globals.SelectedShip.UpSprite, false, false);
            }
        }

        public static void UpdateForLander08()
        {
            if (Globals.SpaceKeyPressed)
            {
                Globals.SelectedShip.VerticalVelocity -= Globals.Stage.constVForce * 0.90F;
            }

            if (Globals.SelectedShip.Fuel > 0)
            {
                Globals.RocketSFX.PlayLooping(Globals.LeftKeyPressed || Globals.RightKeyPressed || Globals.UpKeyPressed || Globals.DownKeyPressed);
                Functions.ApplyFlicker(Globals.SelectedShip.DownSprite, Globals.UpKeyPressed, false);
                Functions.ApplyFlicker(Globals.SelectedShip.RightSprite, Globals.LeftKeyPressed, false);
                Functions.ApplyFlicker(Globals.SelectedShip.LeftSprite, Globals.RightKeyPressed, false);

                if (Globals.SpaceKeyPressed)
                {
                    Functions.ApplyFlicker(Globals.SelectedShip.UpSprite, false, true);
                }
                else
                {
                    Functions.ApplyFlicker(Globals.SelectedShip.UpSprite, Globals.DownKeyPressed, false);
                }

                if (Globals.SpaceKeyPressed && !Globals.SpaceKeyPressedPrevious)
                {
                    Globals.SelectedShip.UpSprite.PictureBoxMain.BackgroundImage = WinFormsLander.Properties.Resources.Parachute;
                }
                else if (!Globals.SpaceKeyPressed && Globals.SpaceKeyPressedPrevious)
                {
                    Globals.SelectedShip.UpSprite.PictureBoxMain.BackgroundImage = WinFormsLander.Properties.Resources.UpBoost;
                }
            }
            else
            {
                Globals.RocketSFX.Stop();
                Functions.ApplyFlicker(Globals.SelectedShip.DownSprite, false, false);
                Functions.ApplyFlicker(Globals.SelectedShip.RightSprite, false, false);
                Functions.ApplyFlicker(Globals.SelectedShip.LeftSprite, false, false);
                Functions.ApplyFlicker(Globals.SelectedShip.UpSprite, false, false);
            }
        }

        public static void UpdateForLander09()
        {
            if (Globals.SpaceKeyPressed)
            {
                Globals.SelectedShip.VerticalVelocity -= Globals.Stage.constVForce * 0.90F;
            }

            if (Globals.SelectedShip.Fuel > 0)
            {
                Globals.RocketSFX.PlayLooping(Globals.LeftKeyPressed || Globals.RightKeyPressed || Globals.UpKeyPressed || Globals.DownKeyPressed);
                Functions.ApplyFlicker(Globals.SelectedShip.DownSprite, Globals.UpKeyPressed, false);
                Functions.ApplyFlicker(Globals.SelectedShip.RightSprite, Globals.LeftKeyPressed, false);
                Functions.ApplyFlicker(Globals.SelectedShip.LeftSprite, Globals.RightKeyPressed, false);

                if (Globals.SpaceKeyPressed)
                {
                    Functions.ApplyFlicker(Globals.SelectedShip.UpSprite, false, true);
                }
                else
                {
                    Functions.ApplyFlicker(Globals.SelectedShip.UpSprite, Globals.DownKeyPressed, false);
                }

                if (Globals.SpaceKeyPressed && !Globals.SpaceKeyPressedPrevious)
                {
                    Globals.SelectedShip.UpSprite.PictureBoxMain.BackgroundImage = WinFormsLander.Properties.Resources.Parachute;
                }
                else if (!Globals.SpaceKeyPressed && Globals.SpaceKeyPressedPrevious)
                {
                    Globals.SelectedShip.UpSprite.PictureBoxMain.BackgroundImage = WinFormsLander.Properties.Resources.UpBoost;
                }
            }
            else
            {
                Globals.RocketSFX.Stop();
                Functions.ApplyFlicker(Globals.SelectedShip.DownSprite, false, false);
                Functions.ApplyFlicker(Globals.SelectedShip.RightSprite, false, false);
                Functions.ApplyFlicker(Globals.SelectedShip.LeftSprite, false, false);
                Functions.ApplyFlicker(Globals.SelectedShip.UpSprite, false, false);
            }
        }

        public static void UpdateForLanderX1()
        {
            Globals.SpecialSFX.PlayLooping(Globals.SpaceKeyPressed);

            if (Globals.SelectedShip.Fuel > 0)
            {
                if (Globals.SpaceKeyPressed)
                {
                    //Cancela acelerações atribuidas
                    if (Globals.LeftKeyPressed)
                    {
                        Globals.SelectedShip.HorizontalVelocity += Globals.SelectedShip.Accel;
                        Globals.SelectedShip.Fuel += Globals.SelectedShip.FuelConsumptionRate;
                    }
                    else if (Globals.RightKeyPressed)
                    {
                        Globals.SelectedShip.HorizontalVelocity -= Globals.SelectedShip.Accel;
                        Globals.SelectedShip.Fuel += Globals.SelectedShip.FuelConsumptionRate;
                    }

                    if (Globals.UpKeyPressed)
                    {
                        Globals.SelectedShip.VerticalVelocity += Globals.SelectedShip.Accel;
                        Globals.SelectedShip.Fuel += Globals.SelectedShip.FuelConsumptionRate;
                    }
                    else if (Globals.DownKeyPressed)
                    {
                        Globals.SelectedShip.VerticalVelocity -= Globals.SelectedShip.Accel;
                        Globals.SelectedShip.Fuel += Globals.SelectedShip.FuelConsumptionRate;
                    }
                }

                Globals.FloatSFX.PlayLooping(Globals.LeftKeyPressed || Globals.RightKeyPressed || Globals.UpKeyPressed || Globals.DownKeyPressed);
            }
            else
            {
                Globals.FloatSFX.Stop();
            }
        }
    }
}
