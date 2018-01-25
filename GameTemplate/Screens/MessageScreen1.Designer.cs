namespace GameTemplate.Screens
{
    partial class messageScreen1
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
            this.countTimer = new System.Windows.Forms.Timer(this.components);
            this.message1Label1 = new System.Windows.Forms.Label();
            this.message1Label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // countTimer
            // 
            this.countTimer.Enabled = true;
            this.countTimer.Interval = 1000;
            this.countTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // message1Label1
            // 
            this.message1Label1.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.message1Label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.message1Label1.Location = new System.Drawing.Point(109, 64);
            this.message1Label1.Name = "message1Label1";
            this.message1Label1.Size = new System.Drawing.Size(869, 98);
            this.message1Label1.TabIndex = 1;
            this.message1Label1.Text = "YOU DON\'T KNOW WHAT";
            // 
            // message1Label2
            // 
            this.message1Label2.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.message1Label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.message1Label2.Location = new System.Drawing.Point(109, 152);
            this.message1Label2.Name = "message1Label2";
            this.message1Label2.Size = new System.Drawing.Size(773, 129);
            this.message1Label2.TabIndex = 2;
            this.message1Label2.Text = "YOU\'RE GETTING INTO.";
            // 
            // messageScreen1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.message1Label2);
            this.Controls.Add(this.message1Label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "messageScreen1";
            this.Size = new System.Drawing.Size(1000, 600);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer countTimer;
        private System.Windows.Forms.Label message1Label1;
        private System.Windows.Forms.Label message1Label2;
    }
}
