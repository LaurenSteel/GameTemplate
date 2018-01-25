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
    public partial class InstructionScreen : UserControl
    {
        public InstructionScreen()
        {
            InitializeComponent();
            defaultOverride();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            SoundPlayer buttonClick = new SoundPlayer(Properties.Resources.buttonClick);
            buttonClick.Play();
            ScreenControl.changeScreen(this, "MenuScreen");
        }
        public void defaultOverride()
        {
            foreach (Control c in this.Controls)
                if (c is Button)
                {
                    Button b = new Button();
                    b = (Button)c;
                    b.BackColor = Color.LightSteelBlue;
                    b.FlatStyle = FlatStyle.Flat;
                    b.FlatAppearance.MouseOverBackColor = Color.White;
                }
            }
        }
}
