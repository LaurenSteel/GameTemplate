namespace GameTemplate.Screens
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
            this.playButton = new System.Windows.Forms.Button();
            this.instructionButton = new System.Windows.Forms.Button();
            this.gameTitle = new System.Windows.Forms.Label();
            this.gameTitle2 = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // playButton
            // 
            this.playButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.playButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playButton.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playButton.ForeColor = System.Drawing.Color.Yellow;
            this.playButton.Location = new System.Drawing.Point(37, 308);
            this.playButton.Margin = new System.Windows.Forms.Padding(2);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(275, 145);
            this.playButton.TabIndex = 6;
            this.playButton.Tag = "GameScreen";
            this.playButton.Text = "PLAY GAME";
            this.playButton.UseVisualStyleBackColor = false;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // instructionButton
            // 
            this.instructionButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.instructionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.instructionButton.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionButton.ForeColor = System.Drawing.Color.Green;
            this.instructionButton.Location = new System.Drawing.Point(362, 308);
            this.instructionButton.Margin = new System.Windows.Forms.Padding(2);
            this.instructionButton.Name = "instructionButton";
            this.instructionButton.Size = new System.Drawing.Size(275, 145);
            this.instructionButton.TabIndex = 7;
            this.instructionButton.Text = "HOW TO PLAY";
            this.instructionButton.UseVisualStyleBackColor = false;
            this.instructionButton.Click += new System.EventHandler(this.instructionButton_Click);
            // 
            // gameTitle
            // 
            this.gameTitle.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameTitle.ForeColor = System.Drawing.Color.Red;
            this.gameTitle.Location = new System.Drawing.Point(3, 50);
            this.gameTitle.Name = "gameTitle";
            this.gameTitle.Size = new System.Drawing.Size(994, 236);
            this.gameTitle.TabIndex = 11;
            this.gameTitle.Text = "HARDEST GAME";
            // 
            // gameTitle2
            // 
            this.gameTitle2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameTitle2.Location = new System.Drawing.Point(30, 10);
            this.gameTitle2.Name = "gameTitle2";
            this.gameTitle2.Size = new System.Drawing.Size(371, 40);
            this.gameTitle2.TabIndex = 12;
            this.gameTitle2.Text = "    THE WORLD\'S . . . ";
            // 
            // exitButton
            // 
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.exitButton.Location = new System.Drawing.Point(688, 308);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(275, 145);
            this.exitButton.TabIndex = 13;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // MenuScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.gameTitle2);
            this.Controls.Add(this.gameTitle);
            this.Controls.Add(this.instructionButton);
            this.Controls.Add(this.playButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MenuScreen";
            this.Size = new System.Drawing.Size(1000, 600);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button instructionButton;
        private System.Windows.Forms.Label gameTitle;
        private System.Windows.Forms.Label gameTitle2;
        private System.Windows.Forms.Button exitButton;
    }
}
