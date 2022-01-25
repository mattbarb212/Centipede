
namespace Centipede
{
    partial class MenuScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PlayButton = new System.Windows.Forms.Button();
            this.controlsButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.highscoreButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PlayButton
            // 
            this.PlayButton.BackColor = System.Drawing.Color.Black;
            this.PlayButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.PlayButton.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.PlayButton.FlatAppearance.BorderSize = 5;
            this.PlayButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PlayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlayButton.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayButton.ForeColor = System.Drawing.Color.White;
            this.PlayButton.Location = new System.Drawing.Point(292, 107);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(132, 36);
            this.PlayButton.TabIndex = 0;
            this.PlayButton.Text = "Play";
            this.PlayButton.UseVisualStyleBackColor = false;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // controlsButton
            // 
            this.controlsButton.BackColor = System.Drawing.Color.Black;
            this.controlsButton.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.controlsButton.FlatAppearance.BorderSize = 5;
            this.controlsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.controlsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.controlsButton.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.controlsButton.ForeColor = System.Drawing.Color.White;
            this.controlsButton.Location = new System.Drawing.Point(292, 182);
            this.controlsButton.Name = "controlsButton";
            this.controlsButton.Size = new System.Drawing.Size(132, 38);
            this.controlsButton.TabIndex = 1;
            this.controlsButton.Text = "Controls";
            this.controlsButton.UseVisualStyleBackColor = false;
            this.controlsButton.Click += new System.EventHandler(this.controlsButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Black;
            this.exitButton.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.exitButton.FlatAppearance.BorderSize = 5;
            this.exitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.Location = new System.Drawing.Point(292, 335);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(132, 38);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // highscoreButton
            // 
            this.highscoreButton.BackColor = System.Drawing.Color.Black;
            this.highscoreButton.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.highscoreButton.FlatAppearance.BorderSize = 5;
            this.highscoreButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.highscoreButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.highscoreButton.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highscoreButton.ForeColor = System.Drawing.Color.White;
            this.highscoreButton.Location = new System.Drawing.Point(292, 258);
            this.highscoreButton.Name = "highscoreButton";
            this.highscoreButton.Size = new System.Drawing.Size(132, 38);
            this.highscoreButton.TabIndex = 3;
            this.highscoreButton.Text = "Highscores";
            this.highscoreButton.UseVisualStyleBackColor = false;
            // 
            // MenuScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImage = global::Centipede.Properties.Resources.CentipedeMenuImage;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.highscoreButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.controlsButton);
            this.Controls.Add(this.PlayButton);
            this.Name = "MenuScreen";
            this.Size = new System.Drawing.Size(500, 450);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button PlayButton;
        private System.Windows.Forms.Button controlsButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button highscoreButton;
    }
}
