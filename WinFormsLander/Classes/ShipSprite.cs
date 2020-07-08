using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace WinFormsLander.Classes
{
    public class ShipSprite : Sprite
    {
        public string Name;
        public string Special;
        public Image ImageCrash;
        public Image ImageExplosion;
        public Enum.Ships Ship;
        public float Resistance;
        public float Fuel;
        public float MaxFuel;
        public float SpecialFuelConsumptionRate;
        public bool UseFuelWhenSpecialKeyPressed;
        public float FuelConsumptionRate;
        public Sprite LeftSprite;
        public Sprite RightSprite;
        public Sprite UpSprite;
        public Sprite DownSprite;

        public ShipSprite(Enum.Ships ship, PictureBox pictureBoxMain) : base(pictureBoxMain)
        {
            this.Name = "";
            this.Special = "";
            this.ImageCrash = null;
            this.ImageExplosion = WinFormsLander.Properties.Resources.explosion;
            this.Ship = ship;
            this.AccelMpS = 0;
            this.Resistance = 0;
            this.FuelConsumptionRate = 0.075F;
            this.Fuel = 0;
            this.MaxFuel = 0;

            if (ship == Enum.Ships.Type01)
            {
                this.MaxFuel = 50;
                this.SpecialFuelConsumptionRate = 0.2F; //decrementa a cada timer.Tick
                this.AccelMpS = 22F;
                this.Resistance = 3F;
                this.UseFuelWhenSpecialKeyPressed = true;
                this.Name = "Gaia Saucer";
                this.ID = "Type01";
                this.Special = "Estabilizador";
                this.ImageDefault = WinFormsLander.Properties.Resources.LanderType01;
                this.ImageCrash = WinFormsLander.Properties.Resources.LanderType01Crash;
            }
            else if (ship == Enum.Ships.Type02)
            {
                this.MaxFuel = 40;
                this.SpecialFuelConsumptionRate = 0.2F; //decrementa a cada timer.Tick
                this.AccelMpS = 18F;
                this.Resistance = 4F;
                this.UseFuelWhenSpecialKeyPressed = true;
                this.Name = "Prometeus Voyager";
                this.ID = "Type02";
                this.Special = "Propulsor Auxiliar";
                this.ImageDefault = WinFormsLander.Properties.Resources.LanderType02;
                this.ImageCrash = WinFormsLander.Properties.Resources.LanderType02Crash;
            }
            else if (ship == Enum.Ships.Type03)
            {
                this.MaxFuel = 35;
                this.SpecialFuelConsumptionRate = 0.04F; //decrementa a cada timer.Tick
                this.AccelMpS = 25F;
                this.Resistance = 3.7F;
                this.UseFuelWhenSpecialKeyPressed = false;
                this.Name = "Ares Charriot";
                this.ID = "Type03";
                this.Special = "\r\nPropulsores de Precisão";
                this.ImageDefault = WinFormsLander.Properties.Resources.LanderType03;
                this.ImageCrash = WinFormsLander.Properties.Resources.LanderType03Crash;
            }
            else if (ship == Enum.Ships.Type04)
            {
                this.MaxFuel = 30;
                this.SpecialFuelConsumptionRate = 0.5F; //decrementa a cada timer.Tick
                this.AccelMpS = 20F;
                this.Resistance = 5F;
                this.UseFuelWhenSpecialKeyPressed = true;
                this.Name = "Hades Star";
                this.ID = "Type04";
                this.Special = "Freio Eletro-Magnético";
                this.ImageDefault = WinFormsLander.Properties.Resources.LanderType04;
                this.ImageCrash = WinFormsLander.Properties.Resources.LanderType04Crash;
            }
            else if (ship == Enum.Ships.Type05)
            {
                this.MaxFuel = 39;
                this.SpecialFuelConsumptionRate = 0.15F; //decrementa a cada timer.Tick
                this.AccelMpS = 30F;
                this.Resistance = 3.2F;
                this.UseFuelWhenSpecialKeyPressed = true;
                this.Name = "Hermes Flash Rocket";
                this.ID = "Type05";
                this.Special = "Estabilização Vertical";
                this.ImageDefault = WinFormsLander.Properties.Resources.LanderType05;
                this.ImageCrash = WinFormsLander.Properties.Resources.LanderType05Crash;
            }
            else if (ship == Enum.Ships.Type06)
            {
                this.MaxFuel = 40;
                this.SpecialFuelConsumptionRate = 0.4F; //decrementa a cada timer.Tick
                this.AccelMpS = 26F;
                this.Resistance = 4.5F;
                this.UseFuelWhenSpecialKeyPressed = true;
                this.Name = "Poseidon Speedster";
                this.ID = "Type06";
                this.Special = "Inversão de Forças";
                this.ImageDefault = WinFormsLander.Properties.Resources.LanderType06;
                this.ImageCrash = WinFormsLander.Properties.Resources.LanderType06Crash;
            }
            else if (ship == Enum.Ships.Type07)
            {
                this.MaxFuel = 33;
                this.SpecialFuelConsumptionRate = 0.03F; //decrementa a cada timer.Tick
                this.AccelMpS = 19F;
                this.Resistance = 3.8F;
                this.UseFuelWhenSpecialKeyPressed = true;
                this.Name = "Athena Fortress";
                this.ID = "Type07";
                this.Special = "Anti-Gravidade";
                this.ImageDefault = WinFormsLander.Properties.Resources.LanderType07;
                this.ImageCrash = WinFormsLander.Properties.Resources.LanderType07Crash;
            }
            else if (ship == Enum.Ships.Type08)
            {
                this.MaxFuel = 25;
                this.AccelMpS = 21F;
                this.Resistance = 3F;
                this.UseFuelWhenSpecialKeyPressed = true;
                this.Name = "Soviet LK";
                this.ID = "Type08";
                this.Special = "Pára-Quedas";
                this.ImageDefault = WinFormsLander.Properties.Resources.LanderType08;
                this.ImageCrash = WinFormsLander.Properties.Resources.LanderType08Crash;
            }
            else if (ship == Enum.Ships.Type09)
            {
                this.MaxFuel = 35;
                this.AccelMpS = 16F;
                this.Resistance = 2.7F;
                this.UseFuelWhenSpecialKeyPressed = true;
                this.Name = "Apollo 11 LM \"Eagle\"";
                this.ID = "Type09";
                this.Special = "Pára-Quedas";
                this.ImageDefault = WinFormsLander.Properties.Resources.LanderType09;
                this.ImageCrash = WinFormsLander.Properties.Resources.LanderType09Crash;
            }
            else if (ship == Enum.Ships.TypeX1)
            {
                this.MaxFuel = 25;
                this.SpecialFuelConsumptionRate = -0.1F; //decrementa a cada timer.Tick
                this.AccelMpS = 18F;
                this.Resistance = 5F;
                this.UseFuelWhenSpecialKeyPressed = true;
                this.Name = "Samus' Gunship";
                this.ID = "TypeX1";
                this.Special = "Recarga";
                this.ImageDefault = WinFormsLander.Properties.Resources.LanderTypeX1;
                this.ImageCrash = WinFormsLander.Properties.Resources.LanderTypeX1Crash; 
            }
        }
    }
}
