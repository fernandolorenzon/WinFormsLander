using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using WinFormsLander.Forms;
using System.Media;
using System.Windows.Forms;

namespace WinFormsLander.Classes
{
    class Globals
    {
        public static bool FirstLoad = true;
        public static bool PausedMain = false;
        public static bool Paused = false;
        public static bool EndedIntro = false;
        public static ShipSprite SelectedShip;
        public static Sprite LZSprite;
        public static Random Random;
        public static int TimerInterval = 20;
        public const string SaveFilePath = "Save.dat";

        public static Timer timerOptionDelay;
        public static Timer timerUpdatePaused;
        public static Timer timerUpdate;

        public static FormStageBase Stage;
        public static FormChooseStage ChooseStage;
        public static FormChooseShip ChooseShip;
        public static FormChooseArea ChooseArea;
        public static FormClear FormClear;
        public static FormMain FormMain;
        public static int CurrentStage;
        
        public static Classes.SoundEffect RocketSFX;
        public static Classes.SoundEffect FloatSFX;
        public static Classes.SoundEffect SpecialSFX;
        public static Classes.SoundEffect SelectedSFX;
        public static Classes.SoundEffect ExplosionSFX;
        public static Classes.SoundEffect CrashSFX;
        public static Classes.SoundEffect CollectedSFX;
        public static Classes.SoundEffect UnlockedSFX;
        public static Classes.SoundEffect LandingSFX;
        public static Classes.SoundEffect MusicPlayer;

        public static List<Sprite> SpriteList;
        public static Enum.GameType GameType;
        public static bool Landed = false;
        public static bool Collided = false;
        public static bool CollidedGround = false;
        public static bool CollidedLZ = false;
        public static bool CollidedUp = false;
        public static bool CollidedDown = false;
        public static bool CollidedLeft = false;
        public static bool CollidedRight = false;
        public static float RelativeVelocity;
        public static int SpeedBarMultiplier = 100;
        public static int Interval = 20;
        public static int ShipsLeft = 2;
        public static float LZGForce;
        public static Sprite Asteroid1;
        public static Sprite Asteroid2;
        public static Sprite Metroid;
        public static Sprite RedOre;
        public static Sprite BlueOre;
        public static Sprite GreenOre;
        public static bool OreCollected = false;

        public static WinFormsLander.Forms.FormBase.UpdateForLander UpdateLander;
        public static WinFormsLander.Forms.FormBase.UpdateForArea UpdateArea;
        public static WinFormsLander.Forms.FormBase.UpdateForOre UpdateOre;
        public static WinFormsLander.Forms.FormBase.UpdateForIntro UpdateIntro;

        public static bool StageFreeCollision;
        public static bool StageFreeGravity;

        public static int KeyPressDelay = 0;

        public static bool SpaceKeyPressed;
        public static bool SpaceKeyPressedPrevious;

        public static bool LeftKeyPressed;
        public static bool LeftKeyPressedPrevious;

        public static bool RightKeyPressed;
        public static bool RightKeyPressedPrevious;

        public static bool UpKeyPressed;
        public static bool UpKeyPressedPrevious;

        public static bool DownKeyPressed;
        public static bool DownKeyPressedPrevious;

        public static bool FireKeyPressed;
        public static bool FireKeyPressedPrevious;

        public static bool EnterKeyPressed;
        public static bool EnterKeyPressedPrevious;

        public static bool JumpStageKeyPressed;
        public static bool JumpStageKeyPressedPrevious;

        //Save
        public static string SaveSelectedShip;

        public static bool[,] SaveAreasShipsCompleted = new bool[6,10];
        public static bool[,] SaveAreasOreCollected = new bool[6, 5];

        public static string DefaultSaveFile = @"Type01;
False;False;False;False;False;False;False;False;False;False;
False;False;False;False;False;False;False;False;False;False;
False;False;False;False;False;False;False;False;False;False;
False;False;False;False;False;False;False;False;False;False;
False;False;False;False;False;False;False;False;False;False;
False;False;False;False;False;False;False;False;False;False;
False;False;False;False;False;
False;False;False;False;False;
False;False;False;False;False;
False;False;False;False;False;
False;False;False;False;False;
False;False;False;False;False;";
    }
}