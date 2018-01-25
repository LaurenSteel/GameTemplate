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

namespace GameTemplate
{
    public partial class MS2 : UserControl
    {
        int count2 = 0;
        SoundPlayer startUp = new SoundPlayer(Properties.Resources.startUp);
        public MS2()
        {
            InitializeComponent();

            ScreenControl.setComponentValues(this);
            defaultOverride();
            countTimer2.Interval = 1000;
            countTimer2.Enabled = true;
        }
        private void countTimer2_Tick(object sender, EventArgs e)
        {
            startUp.Play();
            count2++;
            if (count2 == 3)
            {
                ScreenControl.changeScreen(this, "GS2");
                countTimer2.Enabled = false;
            }
        }
        public void defaultOverride()
        {
            foreach (Control c in this.Controls)
            {
                c.Location = new Point(c.Location.X, c.Location.Y);
            }
            message2Label1.Font = new Font("Segoe UI", 48);
            message2Label1.Location = new Point(ScreenControl.controlWidth / 3 - message2Label1.Size.Width / 3, 35);
            message2Label2.Font = new Font("Segoe UI", 48);
            message2Label2.Location = new Point(ScreenControl.controlWidth / 3 - message2Label2.Size.Width / 3, 150);
        }
    }
}
