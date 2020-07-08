using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WinFormsLander.Classes;
using System.Media;
using WinFormsLander.Functions;

namespace WinFormsLander.Forms
{
    public partial class FormBase : Form
    {
        #region Properties

        public delegate void UpdateForLander();

        public delegate void UpdateForArea();

        public delegate void UpdateForOre();

        public delegate void UpdateForIntro();

        #endregion

        #region Constructors

        public FormBase()
        {
            InitializeComponent();
        }

        #endregion

        #region Events

        private void FormBase_Load(object sender, EventArgs e)
        {
            if (Globals.FirstLoad)
            {
                try
                {
                    Globals.Random = new Random();

                    Globals.timerOptionDelay = this.timerOptionDelay;
                    Globals.timerUpdatePaused = this.timerUpdatePaused;
                    Globals.timerUpdate = this.timerUpdate;

                    Globals.RocketSFX = new Classes.SoundEffect(Environment.CurrentDirectory + "\\Sounds\\rocket.wav");
                    Globals.FloatSFX = new Classes.SoundEffect(Environment.CurrentDirectory + "\\Sounds\\float.wav");
                    Globals.SpecialSFX = new Classes.SoundEffect(Environment.CurrentDirectory + "\\Sounds\\special.wav");
                    Globals.SelectedSFX = new Classes.SoundEffect(Environment.CurrentDirectory + "\\Sounds\\selected.wav");
                    Globals.ExplosionSFX = new Classes.SoundEffect(Environment.CurrentDirectory + "\\Sounds\\explosion.wav");
                    Globals.CrashSFX = new Classes.SoundEffect(Environment.CurrentDirectory + "\\Sounds\\crash.wav");
                    Globals.CollectedSFX = new Classes.SoundEffect(Environment.CurrentDirectory + "\\Sounds\\collected.wav");
                    Globals.UnlockedSFX = new Classes.SoundEffect(Environment.CurrentDirectory + "\\Sounds\\unlocked.wav");
                    Globals.LandingSFX = new Classes.SoundEffect(Environment.CurrentDirectory + "\\Sounds\\landing.wav");
                    Globals.MusicPlayer = new Classes.SoundEffect(Environment.CurrentDirectory + "\\Music\\intro.mp3");

                    GameFunctions.LoadGame();

                    Globals.FirstLoad = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void timerUpdate_Tick(object sender, EventArgs e)
        {
            GameFunctions.Update();
        }

        private void timerOptionDelay_Tick(object sender, EventArgs e)
        {
            Globals.Stage = new FormStageBase();

            if (Globals.GameType == Enum.GameType.Arcade)
            {
                Globals.ChooseArea = new FormChooseArea();
                Globals.ChooseArea.Show();
            }
            else
            {
                Globals.ChooseStage = new FormChooseStage();
                Globals.ChooseStage.Show();
            }

            Globals.timerOptionDelay.Enabled = false;
            Globals.timerOptionDelay.Stop();

            Globals.FormMain.Visible = false;
        }

        private void timerUpdatePaused_Tick(object sender, EventArgs e)
        {
            Functions.Functions.KeyReading();
            Functions.Functions.ApplyPause(true);
        }

        private void FormBase_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        #endregion

        #region Methods



        #endregion
    }
}
