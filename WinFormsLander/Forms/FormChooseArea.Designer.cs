namespace WinFormsLander.Forms
{
    partial class FormChooseArea
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.labelBack = new System.Windows.Forms.Label();
            this.labelInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::WinFormsLander.Properties.Resources.Area1_Neiborhood_Typed;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(12, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 90);
            this.panel1.TabIndex = 0;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::WinFormsLander.Properties.Resources.Area2_JupiterMoons_Typed;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Location = new System.Drawing.Point(12, 98);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(700, 90);
            this.panel2.TabIndex = 1;
            this.panel2.Click += new System.EventHandler(this.panel2_Click);
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::WinFormsLander.Properties.Resources.Area3_OtherMoons_Typed;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Location = new System.Drawing.Point(12, 188);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(700, 90);
            this.panel3.TabIndex = 2;
            this.panel3.Click += new System.EventHandler(this.panel3_Click);
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = global::WinFormsLander.Properties.Resources.Area4_DwarfPlanets_Typed;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Location = new System.Drawing.Point(12, 278);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(700, 90);
            this.panel4.TabIndex = 3;
            this.panel4.Click += new System.EventHandler(this.panel4_Click);
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = global::WinFormsLander.Properties.Resources.Area5_AsteroidsTyped;
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Location = new System.Drawing.Point(12, 368);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(700, 90);
            this.panel5.TabIndex = 4;
            this.panel5.Click += new System.EventHandler(this.panel5_Click);
            // 
            // panel6
            // 
            this.panel6.BackgroundImage = global::WinFormsLander.Properties.Resources.Area6_MetroidUniverse_Typed;
            this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel6.Location = new System.Drawing.Point(12, 458);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(700, 90);
            this.panel6.TabIndex = 5;
            this.panel6.Click += new System.EventHandler(this.panel6_Click);
            // 
            // labelBack
            // 
            this.labelBack.AutoSize = true;
            this.labelBack.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBack.ForeColor = System.Drawing.Color.Lime;
            this.labelBack.Location = new System.Drawing.Point(740, 548);
            this.labelBack.Name = "labelBack";
            this.labelBack.Size = new System.Drawing.Size(40, 14);
            this.labelBack.TabIndex = 72;
            this.labelBack.Text = "Voltar";
            this.labelBack.Click += new System.EventHandler(this.labelBack_Click);
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.labelInfo.Location = new System.Drawing.Point(306, 552);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(173, 12);
            this.labelInfo.TabIndex = 73;
            this.labelInfo.Text = "Clique na imagem para selecionar";
            // 
            // FormChooseArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(792, 573);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.labelBack);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormChooseArea";
            this.Text = "FormChooseArea";
            this.Load += new System.EventHandler(this.FormArea_Load);
            this.VisibleChanged += new System.EventHandler(this.FormArea_VisibleChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label labelBack;
        private System.Windows.Forms.Label labelInfo;
    }
}