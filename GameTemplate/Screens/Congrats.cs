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
    public partial class Congrats : UserControl
    {
        SoundPlayer buttonClick = new SoundPlayer(Properties.Resources.buttonClick);
        public Congrats()
        {
            InitializeComponent();

            ScreenControl.setComponentValues(this);
            defaultOverride();
        }
        private void menuButton2_Enter(object sender, EventArgs e)
        {
            buttonClick.Play();
            ScreenControl.changeScreen(this, "menuScreen");
        }
        private void exitButton2_Enter(object sender, EventArgs e)
        {
            buttonClick.Play();
            Application.Exit();
        }

        /// <summary>
        /// Change any control default values here
        /// </summary>
        public void defaultOverride()
        {
            foreach (Control c in this.Controls)
            {
                c.Location = new Point(c.Location.X, c.Location.Y);
            }
            congratsLabel.Font = new Font("Segoe UI", 48);
            congratsLabel.Location = new Point(ScreenControl.controlWidth / 3 - congratsLabel.Size.Width / 3, 25);
            congratsLabel2.Font = new Font("Segoe UI", 48);
            congratsLabel2.Location = new Point(ScreenControl.controlWidth / 3 - congratsLabel2.Size.Width / 3, 100);
            congratsLabel3.Font = new Font("Segoe UI", 48);
            congratsLabel3.Location = new Point(ScreenControl.controlWidth / 3 - congratsLabel3.Size.Width / 3, 175);
            congratsLabel4.Font = new Font("Segoe UI", 48);
            congratsLabel4.Location = new Point(ScreenControl.controlWidth / 3 - congratsLabel4.Size.Width / 3, 250);
            foreach (Control c in this.Controls)
            {
                if (c is Button)
                {
                    Button b = new Button();
                    b = (Button)c;
                    b.BackColor = Color.LightSteelBlue;
                    b.FlatAppearance.MouseOverBackColor = Color.White;
                }
            }
        }
    }
}
