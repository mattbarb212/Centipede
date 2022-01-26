namespace Centipede
{
    partial class HighscoreSaveScreen
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
            this.letter1 = new System.Windows.Forms.Label();
            this.letter2 = new System.Windows.Forms.Label();
            this.letter3 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.letter3Down = new System.Windows.Forms.Button();
            this.letter2Down = new System.Windows.Forms.Button();
            this.letter1Down = new System.Windows.Forms.Button();
            this.letter3Up = new System.Windows.Forms.Button();
            this.letter2Up = new System.Windows.Forms.Button();
            this.letter1Up = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // letter1
            // 
            this.letter1.BackColor = System.Drawing.Color.Transparent;
            this.letter1.Font = new System.Drawing.Font("Microsoft Sans Serif", 69.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.letter1.ForeColor = System.Drawing.Color.White;
            this.letter1.Location = new System.Drawing.Point(71, 145);
            this.letter1.Name = "letter1";
            this.letter1.Size = new System.Drawing.Size(121, 107);
            this.letter1.TabIndex = 0;
            this.letter1.Text = "A";
            // 
            // letter2
            // 
            this.letter2.BackColor = System.Drawing.Color.Transparent;
            this.letter2.Font = new System.Drawing.Font("Microsoft Sans Serif", 69.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.letter2.ForeColor = System.Drawing.Color.White;
            this.letter2.Location = new System.Drawing.Point(196, 145);
            this.letter2.Name = "letter2";
            this.letter2.Size = new System.Drawing.Size(117, 107);
            this.letter2.TabIndex = 1;
            this.letter2.Text = "A";
            // 
            // letter3
            // 
            this.letter3.BackColor = System.Drawing.Color.Transparent;
            this.letter3.Font = new System.Drawing.Font("Microsoft Sans Serif", 69.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.letter3.ForeColor = System.Drawing.Color.White;
            this.letter3.Location = new System.Drawing.Point(319, 145);
            this.letter3.Name = "letter3";
            this.letter3.Size = new System.Drawing.Size(115, 107);
            this.letter3.TabIndex = 2;
            this.letter3.Text = "A";
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.ForestGreen;
            this.saveButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Location = new System.Drawing.Point(179, 314);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(133, 38);
            this.saveButton.TabIndex = 9;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // letter3Down
            // 
            this.letter3Down.BackgroundImage = global::Centipede.Properties.Resources.DownArrow;
            this.letter3Down.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.letter3Down.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.letter3Down.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.letter3Down.Location = new System.Drawing.Point(337, 255);
            this.letter3Down.Name = "letter3Down";
            this.letter3Down.Size = new System.Drawing.Size(63, 23);
            this.letter3Down.TabIndex = 8;
            this.letter3Down.UseVisualStyleBackColor = true;
            this.letter3Down.Click += new System.EventHandler(this.letter3Down_Click);
            // 
            // letter2Down
            // 
            this.letter2Down.BackgroundImage = global::Centipede.Properties.Resources.DownArrow;
            this.letter2Down.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.letter2Down.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.letter2Down.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.letter2Down.Location = new System.Drawing.Point(214, 255);
            this.letter2Down.Name = "letter2Down";
            this.letter2Down.Size = new System.Drawing.Size(63, 23);
            this.letter2Down.TabIndex = 7;
            this.letter2Down.UseVisualStyleBackColor = true;
            this.letter2Down.Click += new System.EventHandler(this.letter2Down_Click);
            // 
            // letter1Down
            // 
            this.letter1Down.BackgroundImage = global::Centipede.Properties.Resources.DownArrow;
            this.letter1Down.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.letter1Down.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.letter1Down.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.letter1Down.Location = new System.Drawing.Point(89, 255);
            this.letter1Down.Name = "letter1Down";
            this.letter1Down.Size = new System.Drawing.Size(63, 23);
            this.letter1Down.TabIndex = 6;
            this.letter1Down.UseVisualStyleBackColor = true;
            this.letter1Down.Click += new System.EventHandler(this.letter1Down_Click);
            // 
            // letter3Up
            // 
            this.letter3Up.BackgroundImage = global::Centipede.Properties.Resources.UpArrow;
            this.letter3Up.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.letter3Up.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.letter3Up.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.letter3Up.Location = new System.Drawing.Point(337, 119);
            this.letter3Up.Name = "letter3Up";
            this.letter3Up.Size = new System.Drawing.Size(63, 23);
            this.letter3Up.TabIndex = 5;
            this.letter3Up.UseVisualStyleBackColor = true;
            this.letter3Up.Click += new System.EventHandler(this.letter3Up_Click);
            // 
            // letter2Up
            // 
            this.letter2Up.BackgroundImage = global::Centipede.Properties.Resources.UpArrow;
            this.letter2Up.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.letter2Up.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.letter2Up.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.letter2Up.Location = new System.Drawing.Point(214, 119);
            this.letter2Up.Name = "letter2Up";
            this.letter2Up.Size = new System.Drawing.Size(63, 23);
            this.letter2Up.TabIndex = 4;
            this.letter2Up.UseVisualStyleBackColor = true;
            this.letter2Up.Click += new System.EventHandler(this.letter2Up_Click);
            // 
            // letter1Up
            // 
            this.letter1Up.BackgroundImage = global::Centipede.Properties.Resources.UpArrow;
            this.letter1Up.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.letter1Up.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.letter1Up.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.letter1Up.Location = new System.Drawing.Point(89, 119);
            this.letter1Up.Name = "letter1Up";
            this.letter1Up.Size = new System.Drawing.Size(63, 23);
            this.letter1Up.TabIndex = 3;
            this.letter1Up.UseVisualStyleBackColor = true;
            this.letter1Up.Click += new System.EventHandler(this.letter1Up_Click);
            // 
            // HighscoreSaveScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.letter3Down);
            this.Controls.Add(this.letter2Down);
            this.Controls.Add(this.letter1Down);
            this.Controls.Add(this.letter3Up);
            this.Controls.Add(this.letter2Up);
            this.Controls.Add(this.letter1Up);
            this.Controls.Add(this.letter3);
            this.Controls.Add(this.letter2);
            this.Controls.Add(this.letter1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "HighscoreSaveScreen";
            this.Size = new System.Drawing.Size(500, 450);
            this.Load += new System.EventHandler(this.HighscoreSaveScreen_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label letter1;
        private System.Windows.Forms.Label letter2;
        private System.Windows.Forms.Label letter3;
        private System.Windows.Forms.Button letter1Up;
        private System.Windows.Forms.Button letter2Up;
        private System.Windows.Forms.Button letter3Up;
        private System.Windows.Forms.Button letter1Down;
        private System.Windows.Forms.Button letter2Down;
        private System.Windows.Forms.Button letter3Down;
        private System.Windows.Forms.Button saveButton;
    }
}
