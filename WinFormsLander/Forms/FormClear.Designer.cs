namespace WinFormsLander.Forms
{
    partial class FormClear
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
            this.labelMessage1 = new System.Windows.Forms.Label();
            this.labelMessage2 = new System.Windows.Forms.Label();
            this.labelMessage3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelMessage1
            // 
            this.labelMessage1.AutoSize = true;
            this.labelMessage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMessage1.ForeColor = System.Drawing.Color.White;
            this.labelMessage1.Location = new System.Drawing.Point(309, 44);
            this.labelMessage1.Name = "labelMessage1";
            this.labelMessage1.Size = new System.Drawing.Size(0, 37);
            this.labelMessage1.TabIndex = 0;
            this.labelMessage1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelMessage2
            // 
            this.labelMessage2.AutoSize = true;
            this.labelMessage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMessage2.ForeColor = System.Drawing.Color.White;
            this.labelMessage2.Location = new System.Drawing.Point(309, 165);
            this.labelMessage2.Name = "labelMessage2";
            this.labelMessage2.Size = new System.Drawing.Size(0, 37);
            this.labelMessage2.TabIndex = 1;
            this.labelMessage2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelMessage3
            // 
            this.labelMessage3.AutoSize = true;
            this.labelMessage3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMessage3.ForeColor = System.Drawing.Color.White;
            this.labelMessage3.Location = new System.Drawing.Point(309, 303);
            this.labelMessage3.Name = "labelMessage3";
            this.labelMessage3.Size = new System.Drawing.Size(0, 37);
            this.labelMessage3.TabIndex = 2;
            this.labelMessage3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormClear
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(792, 573);
            this.Controls.Add(this.labelMessage3);
            this.Controls.Add(this.labelMessage2);
            this.Controls.Add(this.labelMessage1);
            this.Name = "FormClear";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FormClear_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label labelMessage1;
        public System.Windows.Forms.Label labelMessage2;
        public System.Windows.Forms.Label labelMessage3;

    }
}
