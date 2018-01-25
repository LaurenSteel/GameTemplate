using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;


namespace GameTemplate.Screens
{
    public partial class messageScreen1 : UserControl
    {
        int count = 0;
        SoundPlayer startUp = new SoundPlayer(Properties.Resources.startUp);
        SoundPlayer duringGame = new SoundPlayer(Properties.Resources.duringGame);
        public messageScreen1()
        {
            InitializeComponent();

            ScreenControl.setComponentValues(this);
            defaultOverride();
            countTimer.Interval = 1000;
            countTimer.Enabled = true;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            startUp.Play();
            count++; 
            if (count == 3)
            {
                ScreenControl.changeScreen(this, "GameScreen");
                countTimer.Enabled = false;
            }
        }
        public void defaultOverride()
        {
            foreach (Control c in this.Controls)
            {
                c.Location = new Point(c.Location.X, c.Location.Y);
            }
            message1Label1.Font = new Font("Segoe UI", 48);
            message1Label1.Location = new Point(ScreenControl.controlWidth / 3 - message1Label1.Size.Width / 3, 35);
            message1Label2.Font = new Font("Segoe UI", 48);
            message1Label2.Location = new Point(ScreenControl.controlWidth / 3 - message1Label1.Size.Width / 3, 150);
        }
        }
    }

