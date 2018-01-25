namespace GameTemplate
{
    partial class GS2
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
            this.blackLabel = new System.Windows.Forms.Label();
            this.deathsLabel = new System.Windows.Forms.Label();
            this.deathNumLabel = new System.Windows.Forms.Label();
            this.levelLabel = new System.Windows.Forms.Label();
            this.menuLabel = new System.Windows.Forms.Label();
            this.gameTimer2 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // blackLabel
            // 
            this.blackLabel.BackColor = System.Drawing.Color.Black;
            this.blackLabel.Location = new System.Drawing.Point(0, 0);
            this.blackLabel.Name = "blackLabel";
            this.blackLabel.Size = new System.Drawing.Size(1000, 60);
            this.blackLabel.TabIndex = 0;
            // 
            // deathsLabel
            // 
            this.deathsLabel.BackColor = System.Drawing.Color.Black;
            this.deathsLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deathsLabel.ForeColor = System.Drawing.Color.White;
            this.deathsLabel.Location = new System.Drawing.Point(744, 12);
            this.deathsLabel.Name = "deathsLabel";
            this.deathsLabel.Size = new System.Drawing.Size(132, 35);
            this.deathsLabel.TabIndex = 1;
            this.deathsLabel.Text = "DEATHS:";
            // 
            // deathNumLabel
            // 
            this.deathNumLabel.BackColor = System.Drawing.Color.Black;
            this.deathNumLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deathNumLabel.Location = new System.Drawing.Point(858, 12);
            this.deathNumLabel.Name = "deathNumLabel";
            this.deathNumLabel.Size = new System.Drawing.Size(135, 35);
            this.deathNumLabel.TabIndex = 2;
            // 
            // levelLabel
            // 
            this.levelLabel.BackColor = System.Drawing.Color.Black;
            this.levelLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.levelLabel.ForeColor = System.Drawing.Color.White;
            this.levelLabel.Location = new System.Drawing.Point(449, 12);
            this.levelLabel.Name = "levelLabel";
            this.levelLabel.Size = new System.Drawing.Size(101, 36);
            this.levelLabel.TabIndex = 3;
            this.levelLabel.Text = "LEVEL 2";
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
            // gameTimer2
            // 
            this.gameTimer2.Enabled = true;
            this.gameTimer2.Interval = 16;
            this.gameTimer2.Tick += new System.EventHandler(this.gameTimer2_Tick);
            // 
            // GS2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Controls.Add(this.menuLabel);
            this.Controls.Add(this.levelLabel);
            this.Controls.Add(this.deathNumLabel);
            this.Controls.Add(this.deathsLabel);
            this.Controls.Add(this.blackLabel);
            this.Name = "GS2";
            this.Size = new System.Drawing.Size(1000, 600);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.GS2_Paint);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GS2_KeyUp);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.GS2_PreviewKeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label blackLabel;
        private System.Windows.Forms.Label deathsLabel;
        private System.Windows.Forms.Label deathNumLabel;
        private System.Windows.Forms.Label levelLabel;
        private System.Windows.Forms.Label menuLabel;
        private System.Windows.Forms.Timer gameTimer2;
    }
}
