using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using WinFormsLander.Forms;
using WinFormsLander.Classes;
using System.Windows.Forms;
using System.Data;
using System.Security.Cryptography;

namespace WinFormsLander.Functions
{
    public static class Functions
    {

        //DetectCollision statics
        private static int previousPositionVertex1X;
        private static int previousPositionVertex1Y;
        private static int previousPositionVertex2X;
        private static int previousPositionVertex2Y;
        private static int previousPositionVertex3X;
        private static int previousPositionVertex3Y;
        private static int previousPositionVertex4X;
        private static int previousPositionVertex4Y;

        //ShowMessage statics
        private static string currentMessage;
        private static Color currentMessageColor;

        //ApplyStretch statics
        private static float previousRateUp;
        private static float previousRateDown;
        private static float previousRateLeft;
        private static float previousRateRight;

        public static void ShowMessage(Label label, Color color, string text)
        {
            label.ForeColor = color;
            label.Text = text;
            label.Location = new Point((int)(label.Parent.Size.Width / 2 - label.Width / 2), label.Location.Y);
        }

        public static void MoveSprite(Sprite sprite, int X, int Y)
        {
            sprite.PictureBoxMain.Location = new Point(X, Y);
        }

        public static void MoveSprite(Sprite sprite)
        {
            if (sprite != null && sprite.PictureBoxMain != null)
            {
                if (Globals.CollidedDown && sprite.VerticalVelocity > 0)
                {
                    sprite.VerticalVelocity = 0;
                }

                if (Globals.CollidedUp && sprite.VerticalVelocity < 0)
                {
                    sprite.VerticalVelocity = 0;
                }

                if (Globals.CollidedLeft && sprite.HorizontalVelocity < 0)
                {
                    sprite.HorizontalVelocity = 0;
                }

                if (Globals.CollidedRight && sprite.HorizontalVelocity > 0)
                {
                    sprite.HorizontalVelocity = 0;
                }

                sprite.X = (float)(sprite.X + sprite.HorizontalVelocity);
                sprite.Y = (float)(sprite.Y + sprite.VerticalVelocity);

                sprite.PictureBoxMain.Location = new Point((int)(sprite.X - sprite.StretchedX), (int)(sprite.Y - sprite.StretchedY));
            }
        }

        public static float CalculateTotalForce(Sprite sprite)
        {
            float f;

            if (sprite.HorizontalVelocity >= 0)
            {
                f = sprite.HorizontalVelocity;
            }
            else
            {
                f = sprite.HorizontalVelocity * -1;
            }

            if (sprite.VerticalVelocity >= 0)
            {
                f += sprite.VerticalVelocity;
            }
            else
            {
                f += sprite.VerticalVelocity * -1;
            }

            return f;
        }

        public static float CalculateTotalForceToSprite(Sprite sprite, Sprite target)
        {
            float f;

            float h = sprite.HorizontalVelocity - target.HorizontalVelocity;
            float v = sprite.VerticalVelocity - target.VerticalVelocity;

            if (h >= 0)
            {
                f = h;
            }
            else
            {
                f = h * -1;
            }

            if (v >= 0)
            {
                f += v;
            }
            else
            {
                f += v * -1;
            }

            return f;
        }

        public static void ApplyFlicker(Sprite sprite, bool enabled, bool defaultVisible)
        {
            if (enabled)
            {
                if (sprite.FlickCount == 0)
                {
                    sprite.PictureBoxMain.Visible = true;
                    sprite.FlickCount = 1;
                }
                else
                {
                    sprite.PictureBoxMain.Visible = false;
                    sprite.FlickCount = 0;
                }
            }
            else
            {
                sprite.PictureBoxMain.Visible = defaultVisible;
            }
        }

        /// <summary>
        /// Estica um sprite de acordo com a direção e taxa informada.
        /// </summary>
        /// <param name="sprite">Sprite a ser esticado.</param>
        /// <param name="direction">Direção em que o sprite deve ser esticado.</param>
        /// <param name="rate">Taxa de esticamento, que será multiplicada pelo tamanho. Valor 1 mantém o tamanho original.</param>
        /// <param name="minimumSize">Tamanho mínimo em pixels que o sprite deve atingir.</param>
        /// <param name="maximumSize">Tamanho máximo em pixels que o sprite deve atingir.</param>
        /// <remarks>É necessário chamar a função MoveSprite após esta para o mesmo sprite, para finalmente aplicar o esticamento corretamente.</remarks>
        public static void ApplyStretch(Sprite sprite, Enum.Direction direction, float rate, int minimumSize, int maximumSize)
        {
            if (direction == Enum.Direction.Up && rate != previousRateUp)
            {
                previousRateUp = rate;

                if (sprite.PictureBoxMain.Size.Height < minimumSize)
                {
                    sprite.PictureBoxMain.Size = new Size(sprite.PictureBoxMain.Size.Width, minimumSize);
                }
                else if (sprite.PictureBoxMain.Size.Height > maximumSize)
                {
                    sprite.PictureBoxMain.Size = new Size(sprite.PictureBoxMain.Size.Width, maximumSize);
                }
                else
                {
                    sprite.PictureBoxMain.Size = new Size(sprite.DefaultWidth, (int)(sprite.DefaultHeight * rate));
                }

                sprite.StretchedY = sprite.PictureBoxMain.Size.Height - sprite.DefaultHeight;
            }
            else if (direction == Enum.Direction.Down && rate != previousRateDown)
            {
                previousRateDown = rate;

                if (sprite.PictureBoxMain.Size.Height * rate < minimumSize)
                {
                    sprite.PictureBoxMain.Size = new Size(sprite.PictureBoxMain.Size.Width, minimumSize);
                }
                else if (sprite.PictureBoxMain.Size.Height * rate > maximumSize)
                {
                    sprite.PictureBoxMain.Size = new Size(sprite.PictureBoxMain.Size.Width, maximumSize);
                }
                else
                {
                    sprite.PictureBoxMain.Size = new Size(sprite.DefaultWidth, (int)(sprite.DefaultHeight * rate));
                }
            }
            else if (direction == Enum.Direction.Right && rate != previousRateRight)
            {
                previousRateRight = rate;

                if (sprite.PictureBoxMain.Size.Width < minimumSize)
                {
                    sprite.PictureBoxMain.Size = new Size(minimumSize, sprite.PictureBoxMain.Size.Height);
                }
                else if (sprite.PictureBoxMain.Size.Width > maximumSize)
                {
                    sprite.PictureBoxMain.Size = new Size(maximumSize, sprite.PictureBoxMain.Size.Height);
                }
                else
                {
                    sprite.PictureBoxMain.Size = new Size((int)(sprite.DefaultWidth * rate), sprite.DefaultHeight);
                }
            }
            else if (direction == Enum.Direction.Left && rate != previousRateLeft)
            {
                previousRateLeft = rate;

                if (sprite.PictureBoxMain.Size.Width < minimumSize)
                {
                    sprite.PictureBoxMain.Size = new Size(minimumSize, sprite.PictureBoxMain.Size.Height);
                }
                else if (sprite.PictureBoxMain.Size.Width > maximumSize)
                {
                    sprite.PictureBoxMain.Size = new Size(maximumSize, sprite.PictureBoxMain.Size.Height);
                }
                else
                {
                    sprite.PictureBoxMain.Size = new Size((int)(sprite.DefaultWidth * rate), sprite.DefaultHeight);
                }

                sprite.StretchedX = sprite.PictureBoxMain.Size.Width - sprite.DefaultWidth;
            }
        }

        public static void ApplyDrag(float Drag, Sprite sprite, Enum.Axis axis)
        {
            if (axis == Enum.Axis.Horizontal || axis == Enum.Axis.All)
            {
                if (sprite.HorizontalVelocity > 0)
                {
                    sprite.HorizontalVelocity -= Drag;

                    if (sprite.HorizontalVelocity < 0)
                    {
                        sprite.HorizontalVelocity = 0;
                    }
                }
                else if (sprite.HorizontalVelocity < 0)
                {
                    sprite.HorizontalVelocity += Drag;

                    if (sprite.HorizontalVelocity > 0)
                    {
                        sprite.HorizontalVelocity = 0;
                    }
                }
            }

            if (axis == Enum.Axis.Vertical || axis == Enum.Axis.All)
            {
                if (sprite.VerticalVelocity > 0)
                {
                    sprite.VerticalVelocity -= Drag;

                    if (sprite.VerticalVelocity < 0)
                    {
                        sprite.VerticalVelocity = 0;
                    }
                }
                else if (sprite.VerticalVelocity < 0)
                {
                    sprite.VerticalVelocity += Drag;

                    if (sprite.VerticalVelocity > 0)
                    {
                        sprite.VerticalVelocity = 0;
                    }
                }
            }
        }

        public static void ApplyDrag(Sprite sprite, Enum.Axis axis)
        {
            ApplyDrag(sprite.Drag, sprite, axis);
        }

        public static void ApplyDrag(Sprite sprite, FormStageBase stage, Enum.Axis axis)
        {
            ApplyDrag(sprite.Drag + stage.Drag, sprite, axis);
        }

        public static void KeyReading()
        {
            Globals.UpKeyPressedPrevious = Globals.UpKeyPressed;
            Globals.LeftKeyPressedPrevious = Globals.LeftKeyPressed;
            Globals.RightKeyPressedPrevious = Globals.RightKeyPressed;
            Globals.DownKeyPressedPrevious = Globals.DownKeyPressed;
            Globals.SpaceKeyPressedPrevious = Globals.SpaceKeyPressed;
            Globals.FireKeyPressedPrevious = Globals.FireKeyPressed;
            Globals.SpaceKeyPressedPrevious = Globals.SpaceKeyPressed;
            Globals.EnterKeyPressedPrevious = Globals.EnterKeyPressed;
            Globals.JumpStageKeyPressedPrevious = Globals.JumpStageKeyPressed;

            Globals.EnterKeyPressed = WinFormsLander.Classes.Keyboard.IsKeyPressed(Keyboard.VirtualKeyStates.VK_RETURN);
            Globals.LeftKeyPressed = WinFormsLander.Classes.Keyboard.IsKeyPressed(Keyboard.VirtualKeyStates.VK_LEFT);
            Globals.RightKeyPressed = WinFormsLander.Classes.Keyboard.IsKeyPressed(Keyboard.VirtualKeyStates.VK_RIGHT);
            Globals.UpKeyPressed = WinFormsLander.Classes.Keyboard.IsKeyPressed(Keyboard.VirtualKeyStates.VK_UP);
            Globals.DownKeyPressed = WinFormsLander.Classes.Keyboard.IsKeyPressed(Keyboard.VirtualKeyStates.VK_DOWN);
            Globals.FireKeyPressed = WinFormsLander.Classes.Keyboard.IsKeyPressed(Keyboard.VirtualKeyStates.VK_CONTROL);
            Globals.SpaceKeyPressed = WinFormsLander.Classes.Keyboard.IsKeyPressed(Keyboard.VirtualKeyStates.VK_SPACE);
            Globals.JumpStageKeyPressed = WinFormsLander.Classes.Keyboard.IsKeyPressed(Keyboard.VirtualKeyStates.VK_BACK);
        }

        public static void TeleportSprite(Sprite sprite, System.Windows.Forms.Panel stage, Enum.Axis axis)
        {
            if (sprite != null && sprite.PictureBoxMain != null)
            {
                if (axis == Enum.Axis.Horizontal || axis == Enum.Axis.All)
                {
                    if (sprite.X > stage.Width)
                    {
                        sprite.X = 0 - sprite.PictureBoxMain.Width + 1;
                    }
                    else if (sprite.X < 0 - sprite.PictureBoxMain.Width)
                    {
                        sprite.X = stage.Width;
                    }
                }

                if (axis == Enum.Axis.Vertical || axis == Enum.Axis.All)
                {
                    if (sprite.PictureBoxMain.Location.Y > stage.Height)
                    {
                        sprite.Y = 0 - sprite.PictureBoxMain.Height + 1;
                    }
                    else if (sprite.PictureBoxMain.Location.Y < 0 - sprite.PictureBoxMain.Height)
                    {
                        sprite.Y = stage.Height;
                    }
                }
            }
        }

        public static bool DetectCollision(Sprite sprite, Sprite body, ref bool collidedUp, ref bool collidedDown, ref bool collidedLeft, ref bool collidedRight)
        {
            bool collided = false;
            collidedUp = false;
            collidedDown = false;
            collidedLeft = false;
            collidedRight = false;

            previousPositionVertex1X = sprite.Vertex1.X;
            previousPositionVertex1Y = sprite.Vertex1.Y;
            previousPositionVertex2X = sprite.Vertex2.X;
            previousPositionVertex2Y = sprite.Vertex2.Y;
            previousPositionVertex3X = sprite.Vertex3.X;
            previousPositionVertex3Y = sprite.Vertex3.Y;
            previousPositionVertex4X = sprite.Vertex4.X;
            previousPositionVertex4Y = sprite.Vertex4.Y;

            //Colisão abaixo do sprite
            if ((sprite.Vertex4.X >= body.Vertex1.X && sprite.Vertex4.X <= body.Vertex2.X) ||
                (sprite.Vertex3.X >= body.Vertex1.X && sprite.Vertex3.X <= body.Vertex2.X))
            {
                if ((sprite.Vertex4.Y >= body.Vertex1.Y && sprite.Vertex4.Y <= body.Vertex4.Y) ||
                    (sprite.Vertex3.Y >= body.Vertex1.Y && sprite.Vertex3.Y <= body.Vertex4.Y))
                {
                    collidedDown = true;
                }
            }
            //Colisão acima do sprite
            if ((sprite.Vertex1.X >= body.Vertex4.X && sprite.Vertex1.X <= body.Vertex3.X) ||
                     (sprite.Vertex2.X >= body.Vertex4.X && sprite.Vertex2.X <= body.Vertex3.X))
            {
                if ((sprite.Vertex1.Y >= body.Vertex1.Y && sprite.Vertex1.Y <= body.Vertex4.Y) ||
                    (sprite.Vertex2.Y >= body.Vertex1.Y && sprite.Vertex2.Y <= body.Vertex4.Y))
                {
                    collidedUp = true;
                }
            }
            //Colisão à esquerda do sprite 
            if ((sprite.Vertex1.Y >= body.Vertex2.Y && sprite.Vertex1.Y <= body.Vertex3.Y) ||
                     (sprite.Vertex4.Y >= body.Vertex2.Y && sprite.Vertex4.Y <= body.Vertex3.Y))
            {
                if ((sprite.Vertex1.X >= body.Vertex1.X && sprite.Vertex1.X <= body.Vertex2.X) ||
                    (sprite.Vertex4.X >= body.Vertex1.X && sprite.Vertex4.X <= body.Vertex2.X))
                {
                    collidedLeft = true;
                }
            }
            //Colisão à direita do sprite
            if ((sprite.Vertex2.Y >= body.Vertex1.Y && sprite.Vertex2.Y <= body.Vertex4.Y) ||
                     (sprite.Vertex3.Y >= body.Vertex1.Y && sprite.Vertex3.Y <= body.Vertex4.Y))
            {
                if ((sprite.Vertex2.X >= body.Vertex1.X && sprite.Vertex2.X <= body.Vertex2.X) ||
                    (sprite.Vertex3.X >= body.Vertex1.X && sprite.Vertex3.X <= body.Vertex2.X))
                {
                    collidedRight = true;
                }
            }

            if (collidedUp || collidedDown || collidedLeft || collidedRight)
            {
                collided = true;
            }

            if (collided)
            {
                //Tira-teima
                //movimento <-
                if (previousPositionVertex1X > sprite.Vertex1.X)
                {
                    collidedRight = false;
                }
                //movimento ->
                else if (previousPositionVertex1X < sprite.Vertex1.X)
                {
                    collidedLeft = false;
                }

                //movimento ^
                if (previousPositionVertex1X > sprite.Vertex1.X)
                {
                    collidedDown = false;
                }
                //movimento v
                else if (previousPositionVertex1X < sprite.Vertex1.X)
                {
                    collidedUp = false;
                }

                if (collidedLeft && collidedUp)
                {
                    if (previousPositionVertex1Y <= body.Vertex3.Y && previousPositionVertex1X >= body.Vertex3.X)
                    {
                        collidedUp = false;
                    }
                    else
                    {
                        collidedLeft = false;
                    }
                }

                if (collidedRight && collidedUp)
                {
                    if (previousPositionVertex2Y <= body.Vertex4.Y && previousPositionVertex2X <= body.Vertex4.X)
                    {
                        collidedUp = false;
                    }
                    else
                    {
                        collidedRight = false;
                    }
                }

                if (collidedLeft && collidedDown)
                {
                    if (previousPositionVertex4Y >= body.Vertex2.Y && previousPositionVertex4X >= body.Vertex2.X)
                    {
                        collidedDown = false;
                    }
                    else
                    {
                        collidedLeft = false;
                    }
                }

                if (collidedRight && collidedDown)
                {
                    if (previousPositionVertex3Y >= body.Vertex1.Y && previousPositionVertex3X <= body.Vertex1.X)
                    {
                        collidedDown = false;
                    }
                    else
                    {
                        collidedRight = false;
                    }
                }

                //Ajuste da posição do sprite com relação ao objeto colidido
                if (collidedUp)
                {
                    sprite.Y = body.Vertex4.Y;
                }
                else if (collidedDown)
                {
                    sprite.Y = body.Vertex1.Y - sprite.PictureBoxMain.Size.Height;
                }
                else if (collidedLeft)
                {
                    sprite.X = body.Vertex2.X;
                }
                else if (collidedRight)
                {
                    sprite.X = body.Vertex1.X - sprite.PictureBoxMain.Size.Width;
                }
            }

            return collided;
        }

        public static bool DetectCollision(Sprite sprite1, Sprite sprite2)
        {
            bool partial1 = false;
            bool partial2 = false;

            int xDistance = sprite2.Vertex2.X - sprite1.Vertex1.X;
            int yDistance = sprite2.Vertex4.Y - sprite1.Vertex1.Y;

            //Verifica se sprite2 está mais à esquerda que sprite1
            if (sprite2.Vertex1.X < sprite1.Vertex1.X)
            {
                xDistance = sprite1.Vertex2.X - sprite2.Vertex1.X;
            }

            //Verifica se sprite2 está mais ao topo que sprite1
            if (sprite2.Vertex1.Y < sprite1.Vertex1.Y)
            {
                yDistance = sprite1.Vertex4.Y - sprite2.Vertex1.Y;
            }

            int xSize = sprite1.PictureBoxMain.Size.Width + sprite2.PictureBoxMain.Size.Width;
            int ySize = sprite1.PictureBoxMain.Size.Height + sprite2.PictureBoxMain.Size.Height;

            if (xDistance <= xSize)
            {
                partial1 = true;
            }

            if (partial1)
            {
                if (yDistance <= ySize)
                {
                    partial2 = true;
                }
            }

            return partial2;
        }

        public static bool CollideBorder(Sprite sprite, Enum.Direction direction, int collisionPoint)
        {
            bool collided = false;

            if (direction == Enum.Direction.Down)
            {
                if (sprite.Vertex3.Y >= collisionPoint)
                {
                    collided = true;
                }
            }

            return collided;
        }

        public static void BounceObject(Sprite sprite, Panel stage, float bouncingSoftness)
        {
            if (sprite.PictureBoxMain.Location.X > stage.Width - sprite.PictureBoxMain.Width)
            {
                if (sprite.HorizontalVelocity > 0)
                {
                    if (!sprite.hBouncingZone)
                    {
                        sprite.HorizontalVelocity -= bouncingSoftness;

                        if (sprite.HorizontalVelocity < 0)
                        {
                            sprite.HorizontalVelocity = 0;
                        }

                        sprite.HorizontalVelocity *= -1;
                        sprite.hBouncingZone = true;
                    }
                }

                sprite.PictureBoxMain.Location = new Point(stage.Width - sprite.PictureBoxMain.Width, sprite.PictureBoxMain.Location.Y);
            }

            else if (sprite.PictureBoxMain.Location.X < 0)
            {
                if (!sprite.hBouncingZone)
                {
                    if (sprite.HorizontalVelocity < 0)
                    {
                        sprite.HorizontalVelocity += bouncingSoftness;

                        if (sprite.HorizontalVelocity > 0)
                        {
                            sprite.HorizontalVelocity = 0;
                        }
                    }

                    sprite.HorizontalVelocity *= -1;
                    sprite.hBouncingZone = true;
                }

                sprite.PictureBoxMain.Location = new Point(0, sprite.PictureBoxMain.Location.Y);
            }
            else
            {
                sprite.hBouncingZone = false;
            }

            if (sprite.PictureBoxMain.Location.Y > stage.Height - sprite.PictureBoxMain.Height)
            {
                if (sprite.VerticalVelocity > 0)
                {
                    if (!sprite.vBouncingZone)
                    {
                        sprite.VerticalVelocity -= bouncingSoftness;

                        if (sprite.VerticalVelocity < 0)
                        {
                            sprite.VerticalVelocity = 0;
                        }

                        sprite.VerticalVelocity *= -1;
                        sprite.vBouncingZone = true;
                    }
                }

                sprite.PictureBoxMain.Location = new Point(sprite.PictureBoxMain.Location.X, stage.Height - sprite.PictureBoxMain.Height);
            }

            else if (sprite.PictureBoxMain.Location.Y < 0)
            {
                if (!sprite.vBouncingZone)
                {
                    if (sprite.VerticalVelocity < 0)
                    {
                        sprite.VerticalVelocity += bouncingSoftness;

                        if (sprite.VerticalVelocity > 0)
                        {
                            sprite.VerticalVelocity = 0;
                        }
                    }

                    sprite.VerticalVelocity *= -1;
                    sprite.vBouncingZone = true;
                }

                sprite.PictureBoxMain.Location = new Point(sprite.PictureBoxMain.Location.X, 0);
            }
            else
            {
                sprite.vBouncingZone = false;
            }

        }

        public static void ApplyConstantForce(Sprite sprite, FormStageBase stage)
        {
            sprite.HorizontalVelocity += stage.constHForce;
            sprite.VerticalVelocity += stage.constVForce;
        }

        public static void ApplyForceLimits(Sprite sprite, FormStageBase stage)
        {
            if (sprite.VerticalVelocityLimit != 0)
            {
                if (sprite.VerticalVelocity > sprite.VerticalVelocityLimit)
                {
                    sprite.VerticalVelocity = sprite.VerticalVelocityLimit;
                }
                else if ((sprite.VerticalVelocity * -1) > sprite.VerticalVelocityLimit)
                {
                    sprite.VerticalVelocity = sprite.VerticalVelocityLimit * -1;
                }
            }

            if (sprite.HorizontalVelocityLimit != 0)
            {
                if (sprite.HorizontalVelocity > sprite.HorizontalVelocityLimit)
                {
                    sprite.HorizontalVelocity = sprite.HorizontalVelocityLimit;
                }
                else if ((sprite.HorizontalVelocity * -1) > sprite.HorizontalVelocityLimit)
                {
                    sprite.HorizontalVelocity = sprite.HorizontalVelocityLimit * -1;
                }
            }
        }

        public static void ApplyGravity(Sprite gravityCenter, Sprite affectedBody)
        {
            float vDistance = (gravityCenter.Y + (gravityCenter.PictureBoxMain.Height / 2)) - (affectedBody.Y + (affectedBody.PictureBoxMain.Height / 2));
            float hDistance = (gravityCenter.X + (gravityCenter.PictureBoxMain.Width / 2)) - (affectedBody.X + (affectedBody.PictureBoxMain.Width / 2));

            if (vDistance > 0)
            {
                affectedBody.VerticalVelocity += gravityCenter.GForce;
            }
            else if (vDistance < 0)
            {
                affectedBody.VerticalVelocity -= gravityCenter.GForce;
            }

            if (hDistance > 0)
            {
                affectedBody.HorizontalVelocity += gravityCenter.GForce;
            }
            else if (hDistance < 0)
            {
                affectedBody.HorizontalVelocity -= gravityCenter.GForce;
            }
        }

        public static void ValueBySecond(ref float value, int timerInterval)
        {
            float deltaTime = 1000 / timerInterval;
            value /= deltaTime;
        }

        public static float ConvertForceToMpS(float force, int timerInterval)
        {
            float g;

            //Convert Ticks to Seconds
            g = force * (1000 / timerInterval);

            //Convert pixel (10cm) to meter (*10)
            //g = g * 10;

            return (float)Math.Round(g, 2, MidpointRounding.AwayFromZero);
        }

        public static float ConvertMpSToForce(float force, int timerInterval)
        {
            float f;

            //Convert Ticks to Seconds
            f = force / (1000 / timerInterval / 0.5F);

            //Convert  meter to pixel (10cm)
            //f = f / 10;

            return (float)Math.Round(f, 4, MidpointRounding.AwayFromZero);
        }

        public static void KillSprite(Sprite sprite, bool kill)
        {
            if (kill)
            {
                sprite.PictureBoxMain = null;
                sprite = null;
            }
        }

        public static void ApplyPause(bool enabled)
        {
            if (enabled)
            {
                if (!Globals.EnterKeyPressed && Globals.EnterKeyPressedPrevious)
                {
                    if (!Globals.Paused)
                    {
                        Globals.Paused = true;
                        GameFunctions.SwitchTimers(false);
                        currentMessage = Globals.Stage.labelMessage.Text;
                        currentMessageColor = Globals.Stage.labelMessage.ForeColor;

                        Functions.ShowMessage(Globals.Stage.labelMessage, Color.White, "Pause");
                    }
                    else
                    {
                        Globals.Paused = false;
                        GameFunctions.SwitchTimers(true);
                        Functions.ShowMessage(Globals.Stage.labelMessage, currentMessageColor, currentMessage);
                    }
                }
            }
        }

        public static string Encrypt(string Message)
        {
            string Passphrase = "abc";
            byte[] Results;
            System.Text.UTF8Encoding UTF8 = new System.Text.UTF8Encoding();

            // Step 1. We hash the passphrase using MD5
            // We use the MD5 hash generator as the result is a 128 bit byte array
            // which is a valid length for the TripleDES encoder we use below

            MD5CryptoServiceProvider HashProvider = new MD5CryptoServiceProvider();
            byte[] TDESKey = HashProvider.ComputeHash(UTF8.GetBytes(Passphrase));

            // Step 2. Create a new TripleDESCryptoServiceProvider object
            TripleDESCryptoServiceProvider TDESAlgorithm = new TripleDESCryptoServiceProvider();

            // Step 3. Setup the encoder
            TDESAlgorithm.Key = TDESKey;
            TDESAlgorithm.Mode = CipherMode.ECB;
            TDESAlgorithm.Padding = PaddingMode.PKCS7;

            // Step 4. Convert the input string to a byte[]
            byte[] DataToEncrypt = UTF8.GetBytes(Message);

            // Step 5. Attempt to encrypt the string
            try
            {
                ICryptoTransform Encryptor = TDESAlgorithm.CreateEncryptor();
                Results = Encryptor.TransformFinalBlock(DataToEncrypt, 0, DataToEncrypt.Length);
            }
            finally
            {
                // Clear the TripleDes and Hashprovider services of any sensitive information
                TDESAlgorithm.Clear();
                HashProvider.Clear();
            }

            // Step 6. Return the encrypted string as a base64 encoded string
            return Convert.ToBase64String(Results);
        }

        public static string Decrypt(string Message)
        {
            string Passphrase = "abc";
            byte[] Results;
            System.Text.UTF8Encoding UTF8 = new System.Text.UTF8Encoding();

            // Step 1. We hash the passphrase using MD5
            // We use the MD5 hash generator as the result is a 128 bit byte array
            // which is a valid length for the TripleDES encoder we use below

            MD5CryptoServiceProvider HashProvider = new MD5CryptoServiceProvider();
            byte[] TDESKey = HashProvider.ComputeHash(UTF8.GetBytes(Passphrase));

            // Step 2. Create a new TripleDESCryptoServiceProvider object
            TripleDESCryptoServiceProvider TDESAlgorithm = new TripleDESCryptoServiceProvider();

            // Step 3. Setup the decoder
            TDESAlgorithm.Key = TDESKey;
            TDESAlgorithm.Mode = CipherMode.ECB;
            TDESAlgorithm.Padding = PaddingMode.PKCS7;

            // Step 4. Convert the input string to a byte[]
            byte[] DataToDecrypt = Convert.FromBase64String(Message);

            // Step 5. Attempt to decrypt the string
            try
            {
                ICryptoTransform Decryptor = TDESAlgorithm.CreateDecryptor();
                Results = Decryptor.TransformFinalBlock(DataToDecrypt, 0, DataToDecrypt.Length);
            }
            finally
            {
                // Clear the TripleDes and Hashprovider services of any sensitive information
                TDESAlgorithm.Clear();
                HashProvider.Clear();
            }

            // Step 6. Return the decrypted string in UTF8 format
            return UTF8.GetString(Results);
        }

        public static string ReadEncryptedFile(string path)
        {
            System.IO.StreamReader reader = new System.IO.StreamReader(path);

            string file = reader.ReadToEnd();

            reader.Close();

            return Functions.Decrypt(file);
        }

        public static void WriteDecryptedString(string decryptedContent, string path)
        {
            System.IO.StreamWriter writer = new System.IO.StreamWriter(path, false);

            string encrypted = Functions.Encrypt(decryptedContent);

            writer.Write(encrypted);

            writer.Close();
        }
    }
}