using System;
using System.Collections.Generic;
using System.Text;
using WinFormsLander.Forms;
using System.Drawing;
using System.Data;
using WinFormsLander.Classes;
using System.Windows.Forms;

namespace WinFormsLander.Functions
{
    public static class GameFunctions
    {
        public static void ApplyControls(ShipSprite sprite, Timer timer)
        {
            if (Globals.LeftKeyPressed)
            {
                sprite.HorizontalVelocity -= sprite.Accel;
            }
            else if (Globals.RightKeyPressed)
            {
                sprite.HorizontalVelocity += sprite.Accel;
            }

            if (Globals.UpKeyPressed)
            {
                sprite.VerticalVelocity -= sprite.Accel;
            }
            else if (Globals.DownKeyPressed)
            {
                sprite.VerticalVelocity += sprite.Accel;
            }
        }

        public static void ApplyPostStage()
        {
            Globals.RocketSFX.Stop();
            Globals.FloatSFX.Stop();
            Globals.SpecialSFX.Stop();
            Globals.ExplosionSFX.Stop();

            if (!Globals.EnterKeyPressed && Globals.EnterKeyPressedPrevious)
            {
                Globals.timerUpdate.Enabled = false;
                Globals.timerUpdatePaused.Enabled = false;
                
                Globals.timerUpdate.Stop();
                Globals.timerUpdatePaused.Stop();

                if (Globals.GameType == Enum.GameType.Arcade)
                {
                    if (Globals.Landed)
                    {
                        GameFunctions.ChangeStage();
                    }
                    else if (Globals.Collided)
                    {

                        if (Globals.ShipsLeft > -1)
                        {
                            Globals.ShipsLeft--;
                            StageFunctions.InitializeStage();
                        }
                        else
                        {
                            Globals.Stage.Visible = false;
                            Globals.FormMain.Visible = true;
                            Globals.ShipsLeft = 2;
                        }
                    }
                }
                else if (Globals.GameType == Enum.GameType.OreColleting)
                {
                    if (Globals.Landed)
                    {
                        if (!Globals.Stage.pictureBoxRedOre.Visible && !Globals.Stage.pictureBoxGreenOre.Visible && !Globals.Stage.pictureBoxBlueOre.Visible)
                        {
                            Globals.OreCollected = true;
                            GameFunctions.RecordFeatures(Enum.RecordType.OreCollected);
                            Globals.Stage.Visible = false;
                            Globals.ChooseStage = new FormChooseStage();
                            Globals.ChooseStage.Show();
                        }
                        else
                        {
                            StageFunctions.InitializeStage();
                        }
                    }
                    else
                    {
                        StageFunctions.InitializeStage();
                    }
                }
                else
                {
                    StageFunctions.InitializeStage();
                }
            }
        }

        public static void JumpStage()
        {
            if (!Globals.JumpStageKeyPressed && Globals.JumpStageKeyPressedPrevious)
            {
                if (Globals.GameType == Enum.GameType.Arcade)
                {
                    if (Globals.KeyPressDelay > 0)
                    {
                        Globals.KeyPressDelay = 0;
                        GameFunctions.ChangeStage();
                    }
                    else
                    {
                        Globals.KeyPressDelay++;
                    }
                }
                else if (Globals.GameType == Enum.GameType.OreColleting)
                {
                    if (Globals.KeyPressDelay > 0)
                    {
                        Globals.KeyPressDelay = 0;
                        Globals.RedOre.PictureBoxMain.Visible = false;
                        Globals.GreenOre.PictureBoxMain.Visible = false;
                        Globals.BlueOre.PictureBoxMain.Visible = false;

                        Globals.Collided = true;
                        Globals.Landed = true;
                    }
                    else
                    {
                        Globals.KeyPressDelay++;
                    }
                }
            }
        }

        public static void MoveShipSprites(ShipSprite ship)
        {
            Functions.MoveSprite(ship);
            Functions.MoveSprite(ship.DownSprite, (int)ship.X, (int)ship.Y + ship.PictureBoxMain.Size.Height);
            Functions.MoveSprite(ship.RightSprite, (int)ship.X + ship.PictureBoxMain.Size.Width, (int)ship.Y);
            Functions.MoveSprite(ship.LeftSprite, (int)ship.X - ship.PictureBoxMain.Size.Width, (int)ship.Y);
            Functions.MoveSprite(ship.UpSprite, (int)ship.X, (int)ship.Y - ship.PictureBoxMain.Size.Height);
        }

        public static void ChangeStage()
        {
            if (Globals.CurrentStage > 10 && Globals.CurrentStage < 15)
            {
                Globals.CurrentStage++;
                StageFunctions.InitializeStage();
            }
            else if (Globals.CurrentStage > 20 && Globals.CurrentStage < 25)
            {
                Globals.CurrentStage++;
                StageFunctions.InitializeStage();
            }
            else if (Globals.CurrentStage > 30 && Globals.CurrentStage < 35)
            {
                Globals.CurrentStage++;
                StageFunctions.InitializeStage();
            }
            else if (Globals.CurrentStage > 40 && Globals.CurrentStage < 45)
            {
                Globals.CurrentStage++;
                StageFunctions.InitializeStage();
            }
            else if (Globals.CurrentStage > 50 && Globals.CurrentStage < 55)
            {
                Globals.CurrentStage++;
                StageFunctions.InitializeStage();
            }
            else if (Globals.CurrentStage > 60 && Globals.CurrentStage < 65)
            {
                Globals.CurrentStage++;
                StageFunctions.InitializeStage();
            }
            else
            {
                Globals.Stage.Visible = false;
                Globals.ShipsLeft = 2;

                FormClear form = new FormClear();
                Functions.ShowMessage(form.labelMessage1, Color.White, "Parabéns!\r\nVocê concluiu esta área!");
                Functions.ShowMessage(form.labelMessage2, Color.White, "Pressione Enter para continuar!");
                Functions.ShowMessage(form.labelMessage3, Color.White, "");
                form.Show();

                bool clear = Globals.SaveAreasShipsCompleted[4, GameFunctions.GetShipIndex(Globals.SelectedShip)];
                bool unlocked = GameFunctions.RecordFeatures(Enum.RecordType.UnlockedArea);

                if (Globals.CurrentStage == 55 && !clear && unlocked && Globals.SelectedShip.Ship != Enum.Ships.Type09)
                {
                    Globals.UnlockedSFX.Play();
                    Functions.ShowMessage(form.labelMessage2, Color.SpringGreen, "Nave desbloqueada!");
                    Functions.ShowMessage(form.labelMessage3, Color.White, "Pressione Enter para continuar!");
                }
            }
        }

        public static void LoadGame()
        {
            if (!ValidateSaveIntegrity())
            {
                CreateNewFile();
            }

            string file = Functions.ReadEncryptedFile(Globals.SaveFilePath);

            string[] newline = { Environment.NewLine };
            string[] comma = { ";" };

            string[] lines = file.Split(newline, 2000, StringSplitOptions.RemoveEmptyEntries);

            Globals.SaveSelectedShip = lines[0].Replace(";", "");

            for (int i = 1; i < 7; i++)
            {
                string[] cells = lines[i].Split(comma, 2000, StringSplitOptions.RemoveEmptyEntries);

                for (int j = 0; j < cells.Length; j++)
                {
                    Globals.SaveAreasShipsCompleted[i - 1, j] = Convert.ToBoolean(cells[j]);
                }
            }

            for (int i = 7; i < 13; i++)
            {
                string[] cells = lines[i].Split(comma, 2000, StringSplitOptions.RemoveEmptyEntries);

                for (int j = 0; j < cells.Length; j++)
                {
                    Globals.SaveAreasOreCollected[i - 7, j] = Convert.ToBoolean(cells[j]);
                }
            }
        }

        public static void SaveGame()
        {
            string file = "";

            file = Globals.SaveSelectedShip + Environment.NewLine;

            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    file += Globals.SaveAreasShipsCompleted[i, j].ToString() + ";";
                }

                file += Environment.NewLine;
            }

            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    file += Globals.SaveAreasOreCollected[i, j].ToString() + ";";
                }

                file += Environment.NewLine;
            }

            Functions.WriteDecryptedString(file, Globals.SaveFilePath);
        }

        public static void CreateNewFile()
        {
            Functions.WriteDecryptedString(Globals.DefaultSaveFile, Globals.SaveFilePath);
        }

        public static bool ValidateSaveIntegrity()
        {
            bool validated = true;

            if (!System.IO.File.Exists(Globals.SaveFilePath))
            {
                validated = false;
            }

            return validated;
        }

        public static bool RecordFeatures(Enum.RecordType type)
        {
            bool unlocked = false;

            if (type == Enum.RecordType.SelectedShip)
            {
                Globals.SaveSelectedShip = Globals.SelectedShip.Ship.ToString();
            }
            else if (type == Enum.RecordType.UnlockedArea)
            {
                int shipIndex = GameFunctions.GetShipIndex(Globals.SelectedShip);
                int areaIndex = -1;

                if (Globals.CurrentStage == 15)
                {
                    areaIndex = 0;
                }
                else if (Globals.CurrentStage == 25)
                {
                    areaIndex = 1;
                }
                else if (Globals.CurrentStage == 35)
                {
                    areaIndex = 2;
                }
                else if (Globals.CurrentStage == 45)
                {
                    areaIndex = 3;
                }
                else if (Globals.CurrentStage == 55)
                {
                    areaIndex = 4;
                }

                if (Globals.CurrentStage != 65)
                {
                    unlocked = !Globals.SaveAreasShipsCompleted[areaIndex, shipIndex];
                    Globals.SaveAreasShipsCompleted[areaIndex, shipIndex] = true;
                }
            }
            else if (type == Enum.RecordType.OreCollected)
            {
                int area = Convert.ToInt16(Globals.CurrentStage.ToString().Substring(0, 1));
                int stage = Convert.ToInt16(Globals.CurrentStage.ToString().Substring(1, 1));

                Globals.SaveAreasOreCollected[area - 1, stage - 1] = true;
            }

            GameFunctions.SaveGame();

            return unlocked;
        }

        public static bool VerifyCollision(ShipSprite sprite, Sprite lz, ref bool landed)
        {
            Globals.CollidedUp = false;
            Globals.CollidedDown = false;
            Globals.CollidedLeft = false;
            Globals.CollidedRight = false;

            if (Globals.CurrentStage != 0)
            {
                Globals.CollidedGround = GameFunctions.CollidedGround();
            }

            if (Globals.CurrentStage != 0)
            {
                Globals.CollidedLZ = GameFunctions.CollidedLZ(ref landed);
            }
            else if (Globals.StageFreeCollision)
            {
                Globals.CollidedLZ = GameFunctions.CollidedLZ(ref landed);
            }


            if (Globals.CollidedGround || Globals.CollidedLZ)
            {
                Globals.Collided = true;

                Globals.SelectedShip.VerticalVelocity = 0;
                Globals.SelectedShip.HorizontalVelocity = 0;

                Globals.Stage.pictureBox2.Visible = false;
                Globals.Stage.pictureBox3.Visible = false;
                Globals.Stage.pictureBox4.Visible = false;
                Globals.Stage.pictureBox5.Visible = false;
            }
            else
            {
                Globals.Collided = false;
            }

            return Globals.Collided;
        }

        public static bool CollidedLZ(ref bool landed)
        {
            bool collided = false;
            landed = false;

            if (Functions.DetectCollision(Globals.SelectedShip, Globals.LZSprite, ref Globals.CollidedUp, ref Globals.CollidedDown, ref Globals.CollidedLeft, ref Globals.CollidedRight))
            {
                if (Globals.RelativeVelocity > Globals.SelectedShip.Resistance || Globals.CollidedUp || Globals.CollidedLeft || Globals.CollidedRight)
                {
                    if (Globals.SelectedShip.TotalVelocity < Globals.SelectedShip.Resistance * 2.5)
                    {
                        Globals.SelectedShip.PictureBoxMain.BackgroundImage = Globals.SelectedShip.ImageCrash;
                        Globals.CrashSFX.Play();
                    }
                    else
                    {
                        Globals.SelectedShip.PictureBoxMain.BackgroundImage = Globals.SelectedShip.ImageExplosion;
                        Globals.ExplosionSFX.Play();
                    }

                    collided = true;
                }
                else
                {
                    collided = true;
                    landed = true;
                }
            }

            return collided;
        }

        public static bool CollidedGround()
        {
            bool collided = false;

            if (Functions.CollideBorder(Globals.SelectedShip, Enum.Direction.Down, Globals.Stage.panelStage.Height))
            {
                if (Globals.SelectedShip.TotalVelocity < Globals.SelectedShip.Resistance * 2.5)
                {
                    Globals.SelectedShip.PictureBoxMain.BackgroundImage = Globals.SelectedShip.ImageCrash;
                    Globals.CrashSFX.Play();
                }
                else
                {
                    Globals.SelectedShip.PictureBoxMain.BackgroundImage = Globals.SelectedShip.ImageExplosion;
                    Globals.ExplosionSFX.Play();
                }

                collided = true;
            }

            return collided;
        }

        public static void DecreaseFuel(ShipSprite sprite, ProgressBar progressBarFuel)
        {
            if (Globals.UpKeyPressed || Globals.DownKeyPressed || Globals.LeftKeyPressed || Globals.RightKeyPressed)
            {
                sprite.Fuel -= sprite.FuelConsumptionRate;
            }

            if (Globals.SpaceKeyPressed && sprite.UseFuelWhenSpecialKeyPressed)
            {
                sprite.Fuel -= sprite.SpecialFuelConsumptionRate;
            }

            if (sprite.Fuel < 0)
            {
                sprite.Fuel = 0;
            }

            if (sprite.Fuel > sprite.MaxFuel)
            {
                sprite.Fuel = sprite.MaxFuel;
            }

            progressBarFuel.Value = (int)sprite.Fuel;

            if (sprite.Fuel < progressBarFuel.Maximum / 5)
            {
                if (progressBarFuel.ForeColor == Color.SpringGreen || progressBarFuel.ForeColor == Color.Purple)
                {
                    progressBarFuel.ForeColor = Color.Red;
                }
                else if (progressBarFuel.ForeColor == Color.Red)
                {
                    progressBarFuel.ForeColor = Color.White;
                }
                else if (progressBarFuel.ForeColor == Color.White)
                {
                    progressBarFuel.ForeColor = Color.Red;
                }
            }
            else if (progressBarFuel.ForeColor != Color.Purple)
            {
                progressBarFuel.ForeColor = Color.SpringGreen;
            }
        }

        public static void UpdateNull()
        {
        }

        public static void UpdateIntro()
        {
            if (Globals.SelectedShip.Y < 50)
            {
                Globals.SelectedShip.X = 100;
                Globals.SelectedShip.Y += 1F;
                Functions.MoveSprite(Globals.SelectedShip, (int)Globals.SelectedShip.X, (int)Globals.SelectedShip.Y);
            }
            else
            {
                if (Globals.Stage.labelMessage.Text == "")
                {
                    Functions.ShowMessage(Globals.Stage.labelMessage, Color.White, "Mova para começar");
                }

                Globals.SelectedShip.VerticalVelocity = 0F;

                Functions.KeyReading();
            }

            if (Globals.UpKeyPressed || Globals.DownKeyPressed || Globals.LeftKeyPressed || Globals.RightKeyPressed)
            {
                Functions.ShowMessage(Globals.Stage.labelMessage, Color.White, "");
                Globals.SelectedShip.TotalVelocity = 0;
                Globals.RelativeVelocity = 0;
                Globals.EndedIntro = true;
                Globals.UpdateIntro = new FormBase.UpdateForIntro(GameFunctions.UpdateNull);
            }
        }

        public static void Update()
        {
            Functions.KeyReading();
            Functions.ApplyPause(!Globals.Collided);
            GameFunctions.JumpStage();

            if (Globals.Collided)
            {
                if (!Globals.Landed)
                {
                    Functions.ShowMessage(Globals.Stage.labelMessage, Color.Red, "Colidiu!\r\nPressione Enter para continuar...");
                }
                else
                {
                    Functions.ShowMessage(Globals.Stage.labelMessage, Color.LimeGreen, "Pousou!\r\nPressione Enter para continuar...");
                }

                GameFunctions.ApplyPostStage();
            }
            else
            {
                if (!Globals.EndedIntro)
                {
                    GameFunctions.UpdateIntro();
                }
                else
                {
                    GameFunctions.UpdateGeneric();

                    Globals.UpdateLander.Invoke();

                    Globals.UpdateArea.Invoke();

                    Globals.UpdateOre.Invoke();

                    StageFunctions.UpdateStage();

                    GameFunctions.UpdateAfter();
                }
            }
        }

        public static void UpdateGeneric()
        {
            if (Globals.SelectedShip.Fuel > 0)
            {
                GameFunctions.ApplyControls(Globals.SelectedShip, Globals.timerUpdate);
            }

            Functions.ApplyConstantForce(Globals.SelectedShip, Globals.Stage);
            Functions.ApplyDrag(Globals.SelectedShip, Globals.Stage, Enum.Axis.Horizontal);
            GameFunctions.MoveShipSprites(Globals.SelectedShip);
            Functions.ApplyStretch(Globals.SelectedShip.DownSprite, Enum.Direction.Down, (Globals.SelectedShip.VerticalVelocity * -1) / 8, 20, 50);
            Functions.MoveSprite(Globals.LZSprite);
            Functions.TeleportSprite(Globals.LZSprite, Globals.Stage.panelStage, Enum.Axis.All);

            if (Globals.CurrentStage == 0)
            {
                Functions.TeleportSprite(Globals.SelectedShip, Globals.Stage.panelStage, Enum.Axis.All);
            }
            else
            {
                Functions.TeleportSprite(Globals.SelectedShip, Globals.Stage.panelStage, Enum.Axis.Horizontal);
            }

            GameFunctions.VerifyCollision(Globals.SelectedShip, Globals.LZSprite, ref Globals.Landed);

            if (Globals.Landed)
            {
                Globals.LandingSFX.Play();
            }
        }

        public static void UpdateAfter()
        {

        }

        public static float GenerateRandomWind(int minValue, int maxValue, FormStageBase stage)
        {
            float wind;
            Random r = new Random();
            float f = (float)r.NextDouble();
            wind = r.Next(minValue, maxValue);
            wind += f;

            if (f > 0.5F)
            {
                wind *= -1;
                stage.WindDirection = "W";
            }
            else
            {
                stage.WindDirection = "E";
            }

            return (float)Math.Round(wind, 2, MidpointRounding.AwayFromZero);
        }

        public static void MoveOffMapCursor()
        {
            Globals.Stage.pictureBoxCursor.Location = new Point((int)(Globals.SelectedShip.PictureBoxMain.Location.X - (Globals.SelectedShip.PictureBoxMain.Size.Width / 2)), Globals.Stage.pictureBoxCursor.Location.Y);
            Globals.Stage.labelCursor.Location = new Point(Globals.Stage.pictureBoxCursor.Location.X, Globals.Stage.labelCursor.Location.Y);
            Globals.Stage.labelCursor.Text = Convert.ToString(Globals.SelectedShip.PictureBoxMain.Location.Y * -1);
        }

        public static int GetShipIndex(ShipSprite sprite)
        {
            int shipIndex = -1;

            if (Globals.SelectedShip.Ship == Enum.Ships.Type01)
            {
                shipIndex = 0;
            }
            else if (Globals.SelectedShip.Ship == Enum.Ships.Type02)
            {
                shipIndex = 1;
            }
            else if (Globals.SelectedShip.Ship == Enum.Ships.Type03)
            {
                shipIndex = 2;
            }
            else if (Globals.SelectedShip.Ship == Enum.Ships.Type04)
            {
                shipIndex = 3;
            }
            else if (Globals.SelectedShip.Ship == Enum.Ships.Type05)
            {
                shipIndex = 4;
            }
            else if (Globals.SelectedShip.Ship == Enum.Ships.Type06)
            {
                shipIndex = 5;
            }
            else if (Globals.SelectedShip.Ship == Enum.Ships.Type07)
            {
                shipIndex = 6;
            }
            else if (Globals.SelectedShip.Ship == Enum.Ships.Type08)
            {
                shipIndex = 7;
            }
            else if (Globals.SelectedShip.Ship == Enum.Ships.Type09)
            {
                shipIndex = 8;
            }
            else if (Globals.SelectedShip.Ship == Enum.Ships.TypeX1)
            {
                shipIndex = 9;
            }

            return shipIndex;
        }

        public static void SwitchTimers(bool UpdateEnabled)
        {
            if (UpdateEnabled)
            {
                Globals.timerUpdate.Enabled = true;
                Globals.timerUpdatePaused.Enabled = false;

                Globals.timerUpdate.Start();
                Globals.timerUpdatePaused.Stop();
            }
            else
            {
                Globals.timerUpdate.Enabled = false;
                Globals.timerUpdatePaused.Enabled = true;

                Globals.timerUpdate.Stop();
                Globals.timerUpdatePaused.Start();
            }
        }
    }
}
