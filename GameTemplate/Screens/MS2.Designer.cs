namespace GameTemplate
{
    partial class MS2
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
            this.message2Label1 = new System.Windows.Forms.Label();
            this.message2Label2 = new System.Windows.Forms.Label();
            this.countTimer2 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // message2Label1
            // 
            this.message2Label1.AutoSize = true;
            this.message2Label1.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.message2Label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.message2Label1.Location = new System.Drawing.Point(50, 39);
            this.message2Label1.Name = "message2Label1";
            this.message2Label1.Size = new System.Drawing.Size(689, 86);
            this.message2Label1.TabIndex = 0;
            this.message2Label1.Text = "DON\'T EVEN BOTHER";
            // 
            // message2Label2
            // 
            this.message2Label2.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.message2Label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.message2Label2.Location = new System.Drawing.Point(50, 145);
            this.message2Label2.Name = "message2Label2";
            this.message2Label2.Size = new System.Drawing.Size(622, 95);
            this.message2Label2.TabIndex = 1;
            this.message2Label2.Text = "TRYING.";
            // 
            // countTimer2
            // 
            this.countTimer2.Enabled = true;
            this.countTimer2.Interval = 1000;
            this.countTimer2.Tick += new System.EventHandler(this.countTimer2_Tick);
            // 
            // MS2
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Sound;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.message2Label2);
            this.Controls.Add(this.message2Label1);
            this.Name = "MS2";
            this.Size = new System.Drawing.Size(1000, 600);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label message2Label1;
        private System.Windows.Forms.Label message2Label2;
        private System.Windows.Forms.Timer countTimer2;
    }
}
