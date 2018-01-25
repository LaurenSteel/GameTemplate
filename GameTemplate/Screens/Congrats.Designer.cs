namespace GameTemplate
{
    partial class Congrats
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
            this.congratsLabel = new System.Windows.Forms.Label();
            this.congratsLabel2 = new System.Windows.Forms.Label();
            this.congratsLabel3 = new System.Windows.Forms.Label();
            this.congratsLabel4 = new System.Windows.Forms.Label();
            this.menuButton2 = new System.Windows.Forms.Button();
            this.exitButton2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // congratsLabel
            // 
            this.congratsLabel.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.congratsLabel.ForeColor = System.Drawing.Color.Red;
            this.congratsLabel.Location = new System.Drawing.Point(50, 25);
            this.congratsLabel.Name = "congratsLabel";
            this.congratsLabel.Size = new System.Drawing.Size(747, 95);
            this.congratsLabel.TabIndex = 0;
            this.congratsLabel.Text = "CONGRATULATIONS! ";
            // 
            // congratsLabel2
            // 
            this.congratsLabel2.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.congratsLabel2.ForeColor = System.Drawing.Color.Red;
            this.congratsLabel2.Location = new System.Drawing.Point(50, 120);
            this.congratsLabel2.Name = "congratsLabel2";
            this.congratsLabel2.Size = new System.Drawing.Size(747, 96);
            this.congratsLabel2.TabIndex = 1;
            this.congratsLabel2.Text = "YOU HAVE CONQUERED";
            // 
            // congratsLabel3
            // 
            this.congratsLabel3.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.congratsLabel3.ForeColor = System.Drawing.Color.Red;
            this.congratsLabel3.Location = new System.Drawing.Point(50, 216);
            this.congratsLabel3.Name = "congratsLabel3";
            this.congratsLabel3.Size = new System.Drawing.Size(757, 98);
            this.congratsLabel3.TabIndex = 2;
            this.congratsLabel3.Text = "THE WORLD\'S HARDEST";
            // 
            // congratsLabel4
            // 
            this.congratsLabel4.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.congratsLabel4.ForeColor = System.Drawing.Color.Red;
            this.congratsLabel4.Location = new System.Drawing.Point(50, 303);
            this.congratsLabel4.Name = "congratsLabel4";
            this.congratsLabel4.Size = new System.Drawing.Size(747, 89);
            this.congratsLabel4.TabIndex = 3;
            this.congratsLabel4.Text = "GAME.";
            // 
            // menuButton2
            // 
            this.menuButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuButton2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuButton2.Location = new System.Drawing.Point(150, 395);
            this.menuButton2.Name = "menuButton2";
            this.menuButton2.Size = new System.Drawing.Size(275, 145);
            this.menuButton2.TabIndex = 4;
            this.menuButton2.Text = "MENU";
            this.menuButton2.UseVisualStyleBackColor = true;
            this.menuButton2.Enter += new System.EventHandler(this.menuButton2_Enter);
            // 
            // exitButton2
            // 
            this.exitButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton2.Location = new System.Drawing.Point(575, 395);
            this.exitButton2.Name = "exitButton2";
            this.exitButton2.Size = new System.Drawing.Size(275, 145);
            this.exitButton2.TabIndex = 5;
            this.exitButton2.Text = "EXIT";
            this.exitButton2.UseVisualStyleBackColor = true;
            this.exitButton2.Enter += new System.EventHandler(this.exitButton2_Enter);
            // 
            // Congrats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Controls.Add(this.exitButton2);
            this.Controls.Add(this.menuButton2);
            this.Controls.Add(this.congratsLabel4);
            this.Controls.Add(this.congratsLabel3);
            this.Controls.Add(this.congratsLabel2);
            this.Controls.Add(this.congratsLabel);
            this.Name = "Congrats";
            this.Size = new System.Drawing.Size(1000, 600);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label congratsLabel;
        private System.Windows.Forms.Label congratsLabel2;
        private System.Windows.Forms.Label congratsLabel3;
        private System.Windows.Forms.Label congratsLabel4;
        private System.Windows.Forms.Button menuButton2;
        private System.Windows.Forms.Button exitButton2;
    }
}
