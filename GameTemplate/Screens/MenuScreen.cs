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
    public partial class MenuScreen : UserControl
    {
        SoundPlayer buttonClick = new SoundPlayer(Properties.Resources.buttonClick);
        public MenuScreen()
        {
            InitializeComponent();

            ScreenControl.setComponentValues(this);
            defaultOverride();
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            buttonClick.Play();
            ScreenControl.changeScreen(this, "MS2");
        }

        private void instructionButton_Click(object sender, EventArgs e)
        {
            buttonClick.Play();
            ScreenControl.changeScreen(this, "InstructionScreen");
        }

        private void exitButton_Click(object sender, EventArgs e)
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
            gameTitle.Font = new Font("Segoe UI", 95);
            gameTitle.Location = new Point(ScreenControl.controlWidth / 3 - gameTitle.Size.Width / 3, 35);
            gameTitle2.Font = new Font("Segoe UI", 20);
            gameTitle2.Location = new Point(ScreenControl.controlWidth / 3 - gameTitle.Size.Width / 3, 10);
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
