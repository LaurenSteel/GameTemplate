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
    public partial class GS2 : UserControl
    {
        public GS2()
        {
            InitializeComponent();
        }
        #region required global values 
        //button control keys 
        Boolean leftArrowDown, downArrowDown, rightArrowDown, upArrowDown, escape;
        #endregion

        //GLOBAL VARIABLES
        //green space and border locations
        int xA = 230;
        int xB = 320;
        int xC = 680;
        int xD = 770;
        int yA = 240;
        int yB = 300;
        int yC = 360;
        int yD = 420;
        List<int> xGreen = new List<int>(new int[] { 230, 680 });
        List<int> yGreen = new List<int>(new int[] { 300, 300 });
        //grid squares locations
        List<int> xGridW = new List<int>(new int[] { 350, 410, 470, 530, 590, 650, 320, 380, 440, 500, 560, 620, 350, 410, 470, 530, 590, 650, 320, 380, 440, 500, 560, 620, 350, 410, 470, 530, 590, 650, 320, 380, 440, 500, 560, 620 });
        List<int> yGridW = new List<int>(new int[] { 240, 240, 240, 240, 240, 240, 270, 270, 270, 270, 270, 270, 300, 300, 300, 300, 300, 300, 330, 330, 330, 330, 330, 330, 360, 360, 360, 360, 360, 360, 390, 390, 390, 390, 390, 390 });
        List<int> xGridG = new List<int>(new int[] { 320, 380, 440, 500, 560, 620, 350, 410, 470, 530, 590, 650, 320, 380, 440, 500, 560, 620, 350, 410, 470, 530, 590, 650, 320, 380, 440, 500, 560, 620, 350, 410, 470, 530, 590, 650 });
        List<int> yGridG = new List<int>(new int[] { 240, 240, 240, 240, 240, 240, 270, 270, 270, 270, 270, 270, 300, 300, 300, 300, 300, 300, 330, 330, 330, 330, 330, 330, 360, 360, 360, 360, 360, 360, 390, 390, 390, 390, 390, 390 });
        //ints red rectangle
        int redRecX = 267;
        int redRecY = 322;
        //ints blue circles
        string directiont;
        string directionb;
        List<int> xBluOt = new List<int>(new int[] { 327, 387, 447, 507, 567, 627 });
        List<int> yBluOt = new List<int>(new int[] { 242, 242, 242, 242, 242, 242 });
        List<int> xBluOb = new List<int>(new int[] { 357, 417, 477, 537, 597, 657 });
        List<int> yBluOb = new List<int>(new int[] { 378, 378, 378, 378, 378, 378 });
        //ints yellow circles
        int xYellO = 427;
        int yYellO = 322;
        int yellO = 0;
        //size of objects
        int size = 16;
        //border line ints
        int line = 1;
        int byOne = 30;
        int byTwo = 60;
        int byThree = 150;
        int length = 271;
        //deaths and level
        int deaths = 0;
        //Graphics objects
        SolidBrush greenBrush = new SolidBrush(Color.LightGreen);
        SolidBrush gridWBrush = new SolidBrush(Color.White);
        SolidBrush gridGBrush = new SolidBrush(Color.LightGray);
        SolidBrush redRecBrush = new SolidBrush(Color.Red);
        SolidBrush lineBrush = new SolidBrush(Color.Black);
        SolidBrush bluOBrush = new SolidBrush(Color.Blue);
        SolidBrush yellOBrush = new SolidBrush(Color.Yellow);
        Pen bluOPen = new Pen(Color.Blue, 1);
        Pen yellOPen = new Pen(Color.Yellow, 1);
        //sound players
        SoundPlayer buttonClick = new SoundPlayer(Properties.Resources.buttonClick);
        SoundPlayer yellowO = new SoundPlayer(Properties.Resources.yellowO);
        // PreviewKeyDown required for UserControl instead of KeyDown as on a form
        private void GS2_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            deathNumLabel.Text = Convert.ToString(deaths);
            if (e.KeyCode == Keys.Escape)
            {
                pauseGame();
            }
            //player button presses
            switch (e.KeyCode)
            {
                case Keys.Left:
                    leftArrowDown = true;
                    break;
                case Keys.Down:
                    downArrowDown = true;
                    break;
                case Keys.Right:
                    rightArrowDown = true;
                    break;
                case Keys.Up:
                    upArrowDown = true;
                    break;
                default:
                    break;
            }
        }
        private void GS2_KeyUp(object sender, KeyEventArgs e)
        {
            //player button releases
            switch (e.KeyCode)
            {
                case Keys.Left:
                    leftArrowDown = false;
                    break;
                case Keys.Down:
                    downArrowDown = false;
                    break;
                case Keys.Right:
                    rightArrowDown = false;
                    break;
                case Keys.Up:
                    upArrowDown = false;
                    break;
                default:
                    break;
            }
        }
        /// <summary>
        /// All game update logic must be placed in this event method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gameTimer2_Tick(object sender, EventArgs e)
        {
            //SoundPlayer duringGame = new SoundPlayer(Properties.Resources.duringGame);
            //duringGame.Play();
            #region main character movements
            if (leftArrowDown == true)
            {
                redRecX--;
            }
            if (downArrowDown == true)
            {
                redRecY++;
            }
            if (rightArrowDown == true)
            {
                redRecX++;
            }
            if (upArrowDown == true)
            {
                redRecY--;
            }
            #endregion
            #region Blue Circle Movements
            for (int i = 0; i < yBluOb.Count; i++)
            {
                if (directionb == "down")
                {
                    yBluOb[i] += 6;
                }
                else
                {
                    yBluOb[i] -= 6;
                }
            }
            if (yBluOb[0] > 318)
            {
                directionb = "up";
            }
            if (yBluOb[yBluOb.Count - 1] < 238)
            {
                directionb = "down";
            }
            for (int i = 0; i < yBluOt.Count; i++)
            {
                if (directiont == "down")
                {
                    xBluOt[i] += 6;
                }
                else
                {
                    xBluOt[i] -= 6;
                }
            }
            if (yBluOt[0] > 318)
            {
                directiont = "up";
            }
            if (yBluOt[yBluOt.Count - 1] < 238)
            {
                directiont = "down";
            }

            #endregion
            #region collision detection
            Rectangle redRec = new Rectangle(redRecX, redRecY, size, size);
            for (int i = 0; i < xBluOb.Count; i++)
            {
                Rectangle recBluOb = new Rectangle(xBluOb[i], yBluOb[i], size, size);
                if (recBluOb.IntersectsWith(redRec))
                {
                    redRecX = 267;
                    redRecY = 322;
                    deaths++;
                }
            }
            for (int i = 0; i < xBluOt.Count; i++)
            {
                Rectangle recBluOt = new Rectangle(xBluOt[i], yBluOt[i], size, size);
                if (recBluOt.IntersectsWith(redRec))
                {
                    redRecX = 267;
                    redRecY = 322;
                    deaths++;
                }
            }
            Rectangle lineRec1 = new Rectangle(xA, yB, line, byTwo);
            if (lineRec1.IntersectsWith(redRec))
            {
                redRecX++;
            }
            Rectangle lineRec2 = new Rectangle(xA, yB, byThree, line);
            if (lineRec2.IntersectsWith(redRec))
            {
                redRecY++;
            }
            Rectangle lineRec3 = new Rectangle(xB, yA, line, byTwo);
            if (lineRec3.IntersectsWith(redRec))
            {
                redRecX++;
            }
            Rectangle lineRec4 = new Rectangle(xB, yA, length, line);
            if (lineRec4.IntersectsWith(redRec))
            {
                redRecY++;
            }
            Rectangle lineRec5 = new Rectangle(xC, yA, line, byTwo);
            if (lineRec5.IntersectsWith(redRec))
            {
                redRecX--;
            }
            Rectangle lineRec6 = new Rectangle(xC, yB, byThree, line);
            if (lineRec6.IntersectsWith(redRec))
            {
                redRecY++;
            }
            Rectangle lineRec7 = new Rectangle(xC, yD, line, byTwo);
            if (lineRec7.IntersectsWith(redRec))
            {
                redRecX--;
            }
            Rectangle lineRec8 = new Rectangle(xC, yB, byThree, line);
            if (lineRec8.IntersectsWith(redRec))
            {
                redRecY--;
            }
            Rectangle lineRec9 = new Rectangle(xC, yC, line, byTwo);
            if (lineRec9.IntersectsWith(redRec))
            {
                redRecX--;
            }
            Rectangle lineRec10 = new Rectangle(xB, yD, length, line);
            if (lineRec10.IntersectsWith(redRec))
            {
                redRecY--;
            }
            Rectangle lineRec11 = new Rectangle(xB, yC, line, byTwo);
            if (lineRec11.IntersectsWith(redRec))
            {
                redRecX++;
            }
            Rectangle lineRec12 = new Rectangle(xA, yC, byThree, line);
            if (lineRec12.IntersectsWith(redRec))
            {
                redRecY--;
            }
            Rectangle yellCirc = new Rectangle(xYellO, yYellO, size, size);
            if (yellCirc.IntersectsWith(redRec))
            {
                yellO++;
                yellowO.Play();
            }
            Rectangle greenRec = new Rectangle(xC, yB, byThree, byTwo);
            if (greenRec.IntersectsWith(redRec) && yellO ==1)
            {
                gameTimer2.Stop();
                ScreenControl.changeScreen(this, "Congrats");
            }
            #endregion

            //refresh the screen, which causes the GameScreen_Paint method to run
            Refresh();
        }
        /// <summary>
        /// Open the pause dialog box and gets Cancel or Abort result from it
        /// </summary>
        private void pauseGame()
        {
            buttonClick.Play();
            gameTimer2.Enabled = false;
            rightArrowDown = leftArrowDown = upArrowDown = downArrowDown = false;

            DialogResult result = Dialogs.PauseDialog.Show();

            if (result == DialogResult.Cancel)
            {
                buttonClick.Play();
                gameTimer2.Enabled = true;
            }
            if (result == DialogResult.Abort)
            {
                buttonClick.Play();
                ScreenControl.changeScreen(this, "MenuScreen");
            }
        }

        /// <summary>
        /// All drawing, (and only drawing), to be done   
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GS2_Paint(object sender, PaintEventArgs e)
        {
            //green space
            e.Graphics.FillRectangle(greenBrush, xA, yB, byThree, byTwo);
            e.Graphics.FillRectangle(greenBrush, xC, yB, byThree, byTwo);
            //grid w
            for (int i = 0; i < xGridW.Count; i++)
            {
                e.Graphics.FillRectangle(gridWBrush, xGridW[i], yGridW[i], byOne, byOne);
            }
            //gris g
            for (int i = 0; i < xGridG.Count; i++)
            {
                e.Graphics.FillRectangle(gridGBrush, xGridG[i], yGridG[i], byOne, byOne);
            }
            //red rec
            e.Graphics.FillRectangle(redRecBrush, redRecX, redRecY, size, size);
            //yellow circle
            e.Graphics.DrawEllipse(yellOPen, xYellO, yYellO, size, size);
            e.Graphics.FillEllipse(yellOBrush, xYellO, yYellO, size, size);
            //blu circles
            for (int i = 0; i < xBluOb.Count; i++)
            {
                e.Graphics.DrawEllipse(bluOPen, xBluOb[i], yBluOb[i], size, size);
                e.Graphics.FillEllipse(bluOBrush, xBluOb[i], yBluOb[i], size, size);
            }
            for (int i = 0; i < xBluOt.Count; i++)
            {
                e.Graphics.DrawEllipse(bluOPen, xBluOt[i], yBluOt[i], size, size);
                e.Graphics.FillEllipse(bluOBrush, xBluOt[i], yBluOt[i], size, size);
            }
            //by two
            e.Graphics.FillRectangle(lineBrush, xA, yB, line, byTwo);
            e.Graphics.FillRectangle(lineBrush, xB, yA, line, byTwo);
            e.Graphics.FillRectangle(lineBrush, xB, yC, line, byTwo);
            e.Graphics.FillRectangle(lineBrush, xC, yA, line, byTwo);
            e.Graphics.FillRectangle(lineBrush, xC, yC, line, byTwo);
            e.Graphics.FillRectangle(lineBrush, xD, yB, line, byTwo);
            //byThree
            e.Graphics.FillRectangle(lineBrush, xA, yB, byThree, line);
            e.Graphics.FillRectangle(lineBrush, xA, yC, byThree, line);
            e.Graphics.FillRectangle(lineBrush, xC, yB, byThree, line);
            e.Graphics.FillRectangle(lineBrush, xC, yC, byThree, line);
            //length
            e.Graphics.FillRectangle(lineBrush, xB, yA, length, line);
            e.Graphics.FillRectangle(lineBrush, xB, yD, length, line);
        }
    }
}

    
