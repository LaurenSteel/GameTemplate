namespace GameTemplate.Screens
{
    partial class GameScreen
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
            this.components = new System.ComponentModel.Container();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.blackLabel = new System.Windows.Forms.Label();
            this.deathLabel = new System.Windows.Forms.Label();
            this.deathNumLabel = new System.Windows.Forms.Label();
            this.menuLabel = new System.Windows.Forms.Label();
            this.levelNumLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 16;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // blackLabel
            // 
            this.blackLabel.BackColor = System.Drawing.Color.Black;
            this.blackLabel.Location = new System.Drawing.Point(0, 0);
            this.blackLabel.Name = "blackLabel";
            this.blackLabel.Size = new System.Drawing.Size(1000, 60);
            this.blackLabel.TabIndex = 0;
            // 
            // deathLabel
            // 
            this.deathLabel.BackColor = System.Drawing.Color.Black;
            this.deathLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deathLabel.ForeColor = System.Drawing.Color.White;
            this.deathLabel.Location = new System.Drawing.Point(744, 12);
            this.deathLabel.Name = "deathLabel";
            this.deathLabel.Size = new System.Drawing.Size(132, 35);
            this.deathLabel.TabIndex = 1;
            this.deathLabel.Text = "DEATHS:";
            // 
            // deathNumLabel
            // 
            this.deathNumLabel.BackColor = System.Drawing.Color.Black;
            this.deathNumLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deathNumLabel.ForeColor = System.Drawing.Color.White;
            this.deathNumLabel.Location = new System.Drawing.Point(858, 12);
            this.deathNumLabel.Name = "deathNumLabel";
            this.deathNumLabel.Size = new System.Drawing.Size(135, 35);
            this.deathNumLabel.TabIndex = 3;
            // 
            // menuLabel
            // 
            this.menuLabel.BackColor = System.Drawing.Color.Black;
            this.menuLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuLabel.ForeColor = System.Drawing.Color.White;
            this.menuLabel.Location = new System.Drawing.Point(58, 12);
            this.menuLabel.Name = "menuLabel";
            this.menuLabel.Size = new System.Drawing.Size(68, 31);
            this.menuLabel.TabIndex = 4;
            this.menuLabel.Text = "ESC";
            // 
            // levelNumLabel
            // 
            this.levelNumLabel.BackColor = System.Drawing.Color.Black;
            this.levelNumLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.levelNumLabel.ForeColor = System.Drawing.Color.White;
            this.levelNumLabel.Location = new System.Drawing.Point(449, 12);
            this.levelNumLabel.Name = "levelNumLabel";
            this.levelNumLabel.Size = new System.Drawing.Size(101, 36);
            this.levelNumLabel.TabIndex = 6;
            this.levelNumLabel.Text = "LEVEL 1";
            // 
            // GameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Controls.Add(this.levelNumLabel);
            this.Controls.Add(this.menuLabel);
            this.Controls.Add(this.deathNumLabel);
            this.Controls.Add(this.deathLabel);
            this.Controls.Add(this.blackLabel);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "GameScreen";
            this.Size = new System.Drawing.Size(1000, 600);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.GameScreen_Paint);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GameScreen_KeyUp);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.GameScreen_PreviewKeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label blackLabel;
        private System.Windows.Forms.Label deathLabel;
        private System.Windows.Forms.Label deathNumLabel;
        private System.Windows.Forms.Label menuLabel;
        private System.Windows.Forms.Label levelNumLabel;
    }
}
