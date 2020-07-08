using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsLander.Classes
{
    public class SoundEffect
    {
        public string SourceAudioFile;
        public bool AlreadyPlaying;
        private Org.Mentalis.Multimedia.SoundFile soundFile;


        public SoundEffect(string AudioFilePath)
        {
            this.SourceAudioFile = AudioFilePath;
            this.soundFile = new Org.Mentalis.Multimedia.SoundFile(AudioFilePath);
        }

        public void Play()
        {
            if (!this.AlreadyPlaying)
            {
                this.soundFile.Repeat = false;
                this.AlreadyPlaying = true;
                this.soundFile.Play();
            }

            this.AlreadyPlaying = false;
        }

        public void PlayLooping()
        {
            if (!this.AlreadyPlaying)
            {
                this.soundFile.Repeat = true;
                this.AlreadyPlaying = true;
                this.soundFile.Play();
            }
        }

        public void PlayLooping(bool Enabled)
        {
            if (Enabled)
            {
                if (!this.AlreadyPlaying)
                {
                    this.soundFile.Repeat = true;
                    this.AlreadyPlaying = true;
                    this.soundFile.Play();
                }
            }
            else
            {
                this.Stop();
            }
        }

        public void Stop()
        {
            if (this.AlreadyPlaying)
            {
                this.soundFile.Stop();
                this.AlreadyPlaying = false;
            }
        }
    }
}
