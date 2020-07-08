namespace WinFormsLander.Forms
{
    partial class FormBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timerUpdate = new System.Windows.Forms.Timer(this.components);
            this.timerOptionDelay = new System.Windows.Forms.Timer(this.components);
            this.timerUpdatePaused = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // timerUpdate
            // 
            this.timerUpdate.Interval = 20;
            this.timerUpdate.Tick += new System.EventHandler(this.timerUpdate_Tick);
            // 
            // timerOptionDelay
            // 
            this.timerOptionDelay.Interval = 1000;
            this.timerOptionDelay.Tick += new System.EventHandler(this.timerOptionDelay_Tick);
            // 
            // timerUpdatePaused
            // 
            this.timerUpdatePaused.Interval = 20;
            this.timerUpdatePaused.Tick += new System.EventHandler(this.timerUpdatePaused_Tick);
            // 
            // FormBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 573);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormBase";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormBase";
            this.Load += new System.EventHandler(this.FormBase_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormBase_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Timer timerUpdate;
        private System.Windows.Forms.Timer timerOptionDelay;
        private System.Windows.Forms.Timer timerUpdatePaused;
    }
}