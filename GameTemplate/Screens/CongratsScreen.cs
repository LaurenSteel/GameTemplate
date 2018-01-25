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
    public partial class ScoreScreen : UserControl
    {
        public ScoreScreen()
        {
            InitializeComponent();

            ScreenControl.setComponentValues(this);
            defaultOverride();

            showScores();
        }

        public void showScores()
        {
            label1.Text = "";

            foreach (int i in ScreenControl.highScores)
            {
                label1.Text += i + "\n";
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            SoundPlayer buttonClick = new SoundPlayer(Properties.Resources.buttonClick);
            buttonClick.Play();
            ScreenControl.changeScreen(this, "MenuScreen");
        }

        /// <summary>
        /// Change any control default values here
        /// </summary>
        public void defaultOverride()
        {
            bestScoresLabel.Font = new Font("Segoe UI", 72);
            bestScoresLabel.Location = new Point(ScreenControl.controlWidth / 3 - bestScoresLabel.Size.Width / 3, 10);
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
    

