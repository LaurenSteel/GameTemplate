using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GameTemplate.Dialogs;
using System.Media;

namespace GameTemplate.Screens
{
    public partial class GameScreen : UserControl
    {
        public GameScreen()
        {
            InitializeComponent();
        }
        #region required global values 
        //button control keys 
        Boolean leftArrowDown, downArrowDown, rightArrowDown, upArrowDown, escape;
        #endregion

        //GLOBAL VARIABLES
        //green space and border locations
        int xA = 215;
        int xB = 305;
        int xC = 335;
        int xD = 365;
        int xE = 605;
        int xF = 635;
        int xG = 665;
        int xH = 755;
        int yA = 225;
        int yB = 255;
        int yC = 375;
        int yD = 405;
        List<int>xGreen = new List<int> (new int [] {215, 665});
        List<int>yGreen = new List<int> (new int [] {225, 225});
        //grid squares locations
        List<int>xGridW = new List<int> (new int [] {305, 365, 425, 485, 545, 605, 635, 335, 395, 455, 515, 575, 365, 425, 485, 545, 605, 335, 395, 455, 515, 575});
        List<int>yGridW = new List<int> (new int [] {375, 255, 255, 255, 255, 255, 225, 285, 285, 285, 285, 285, 315, 315, 315, 315, 315, 345, 345, 345, 345, 345});
        List<int>xGridG = new List<int> (new int [] {335, 335, 395, 455, 515, 575, 605, 365, 425, 485, 545, 605, 335, 395, 455, 515, 575, 365, 425, 485, 545, 605});
        List<int>yGridG = new List<int>(new int [] {375, 255, 255, 255, 255, 255, 225, 285, 285, 285, 285, 285, 315, 315, 315, 315, 315, 345, 345, 345, 345, 345});
        //ints red rectangle
        int redRecX = 252;
        int redRecY = 303;
        //ints blue circles 
        string directiont;
        string directionb;
        List<int> xBluOt = new List<int>(new int[] { 338, 338 });
        List<int> yBluOt = new List<int>(new int[] { 262, 322 });
        List<int> xBluOb = new List<int>(new int[] { 615, 615 });
        List<int> yBluOb = new List<int>(new int[] { 292, 352 });
        //rec size for red and blue
        int size = 16;
        //border line ints 
        int line = 1;
        int byOne = 30;
        int pathSide = 150;
        int end = 180;
        int top = 90;
        int border = 120;
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
        Pen bluOPen = new Pen(Color.Blue, 1);
        //sound players
        SoundPlayer buttonClick = new SoundPlayer(Properties.Resources.buttonClick);
        // PreviewKeyDown required for UserControl instead of KeyDown as on a form
        private void GameScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
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
        private void GameScreen_KeyUp(object sender, KeyEventArgs e)
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
        private void gameTimer_Tick(object sender, EventArgs e)
        {
            deathNumLabel.Text = Convert.ToString(deaths);
            #region main character movements

            if (leftArrowDown == true)
            {
                redRecX-=3;
            }
            if (downArrowDown == true)
            {
                redRecY+=3;
            }
            if (rightArrowDown == true)
            {
                redRecX+=3;
            }
            if (upArrowDown == true)
            {
                redRecY-=3;
            }
            #endregion

            #region Blue Circle Movements
            for (int i = 0; i < xBluOb.Count; i++)
            {
                if (directionb == "right")
                {
                    xBluOb[i] += 6;
                }
                else
                {
                    xBluOb[i] -= 6;
                }
            }
            if (xBluOb[0] < 337)
            {
                directionb = "right";
            }

            if (xBluOb[xBluOb.Count - 1] > 615)
            {
                directionb = "left";
            }

            for (int i = 0; i < xBluOt.Count; i++)
            {
                if (directiont == "right")
                {
                    xBluOt[i] += 6;
                }
                else
                {
                    xBluOt[i] -= 6;
                }
            }
            if (xBluOt[0] < 337)
            {
                directiont = "right";
            }

            if (xBluOt[xBluOt.Count - 1] > 615)
            {
                directiont = "left";
            }
            #endregion

            #region collision detection 
            //collision with blue circle 
            Rectangle redRec = new Rectangle(redRecX, redRecY, size, size);
            for (int i = 0; i < xBluOb.Count; i++)
            {
                Rectangle recBluOb = new Rectangle(xBluOb[i], yBluOb[i], size, size);
                if (recBluOb.IntersectsWith(redRec))
                {
                    redRecX = 252;
                    redRecY = 303;
                    deaths++;
                }
            }
            for (int i = 0; i < xBluOt.Count; i++)
            {
                Rectangle recBluOt = new Rectangle(xBluOt[i], yBluOt[i], size, size);
                if (recBluOt.IntersectsWith(redRec))
                {
                    redRecX = 252;
                    redRecY = 303;
                    deaths++;
                }
            }
            //collision with border
                Rectangle lineRec1 = new Rectangle(xA, yA, line, end);
                if (lineRec1.IntersectsWith(redRec))
                {
                    redRecX+=3;
                }
            Rectangle lineRec2 = new Rectangle(xA, yA, top, line);
            if (lineRec2.IntersectsWith(redRec))
            {
                redRecY+=3;
            }
            Rectangle lineRec3 = new Rectangle(xB, yA, line, pathSide);
            if (lineRec3.IntersectsWith(redRec))
            {
                redRecX-=3;
            }
            Rectangle lineRec4 = new Rectangle(xB, yC, byOne, line);
            if (lineRec4.IntersectsWith(redRec))
            {
                redRecY+=3;
            }
            Rectangle lineRec5 = new Rectangle(xC, yB, line, border);
            if (lineRec5.IntersectsWith(redRec))
            {
                redRecX+=3;
            }
            Rectangle lineRec6 = new Rectangle(xC, yB, length, line);
            if (lineRec6.IntersectsWith(redRec))
            {
                redRecY+=3;
            }
            Rectangle lineRec7 = new Rectangle(xE, yA, line, byOne);
            if (lineRec7.IntersectsWith(redRec))
            {
                redRecX+=3;
            }
            Rectangle lineRec8 = new Rectangle(xE, yA, pathSide, line);
            if (lineRec8.IntersectsWith(redRec))
            {
                redRecY+=3;
            }
            Rectangle lineRec9 = new Rectangle(xH, yA, line, end);
            if (lineRec9.IntersectsWith(redRec))
            {
                redRecX-=3;
            }
            Rectangle lineRec10 = new Rectangle(xG, yD, top, line);
            if (lineRec10.IntersectsWith(redRec))
            {
                redRecY-=3;
            }
            Rectangle lineRec11 = new Rectangle(xG, yB, line, pathSide);
            if (lineRec11.IntersectsWith(redRec))
            {
                redRecX+=3;
            }
            Rectangle lineRec12 = new Rectangle(xF, yB, byOne, line);
            if (lineRec12.IntersectsWith(redRec))
            {
                redRecY-=3;
            }
            Rectangle lineRec13 = new Rectangle(xF, yB, line, border);
            if (lineRec13.IntersectsWith(redRec))
            {
                redRecX-=3;
            }
            Rectangle lineRec14 = new Rectangle(xD, yC, length, line);
            if (lineRec14.IntersectsWith(redRec))
            {
                redRecY-=3;
            }
            Rectangle lineRec15 = new Rectangle(xD, yC, line, byOne);
            if (lineRec15.IntersectsWith(redRec))
            {
                redRecX-=3;
            }
            Rectangle lineRec16 = new Rectangle(xA, yD, pathSide, line);
            if (lineRec16.IntersectsWith(redRec))
            {
                redRecY-=3;
            }
            //collision with green space 
            Rectangle greenRec = new Rectangle(xG, yA, top, end);
            if (greenRec.IntersectsWith(redRec))
            {
                gameTimer.Stop();
                ScreenControl.changeScreen(this, "MS2");

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
            gameTimer.Enabled = false;
            buttonClick.Play();
            rightArrowDown = leftArrowDown = upArrowDown = downArrowDown = false;

            DialogResult result = PauseDialog.Show();

            if (result == DialogResult.Cancel)
            {
                buttonClick.Play();
                gameTimer.Enabled = true;
            }
            if (result == DialogResult.Abort)
            {
                buttonClick.Play();
                ScreenControl.changeScreen(this, "MenuScreen");
            }
        }
        /// <summary>
        /// All drawing, (and only drawing), to be done here
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GameScreen_Paint(object sender, PaintEventArgs e)
        {
            //green space
            e.Graphics.FillRectangle(greenBrush, xA, yA, top, end);
            e.Graphics.FillRectangle(greenBrush, xG, yA, top, end);
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
            //blu circ
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
            //by one 
            e.Graphics.FillRectangle(lineBrush, xB, yC, byOne, line);
            e.Graphics.FillRectangle(lineBrush, xF, yB, byOne, line);
            e.Graphics.FillRectangle(lineBrush, xD, yC, line, byOne);
            e.Graphics.FillRectangle(lineBrush, xE, yA, line, byOne);
            //path
            e.Graphics.FillRectangle(lineBrush, xA, yD, pathSide, line);
            e.Graphics.FillRectangle(lineBrush, xE, yA, pathSide, line);
            //end
            e.Graphics.FillRectangle(lineBrush, xA, yA, line, end);
            e.Graphics.FillRectangle(lineBrush, xH, yA, line, end);
            //top
            e.Graphics.FillRectangle(lineBrush, xA, yA, top, line);
            e.Graphics.FillRectangle(lineBrush, xG, yD, top, line);
            //side
            e.Graphics.FillRectangle(lineBrush, xB, yA, line, pathSide);
            e.Graphics.FillRectangle(lineBrush, xG, yB, line, pathSide);
            //border 
            e.Graphics.FillRectangle(lineBrush, xC, yB, line, border);
            e.Graphics.FillRectangle(lineBrush, xF, yB, line, border);
            //length 
            e.Graphics.FillRectangle(lineBrush, xC, yB, length, line);
            e.Graphics.FillRectangle(lineBrush, xD, yC, length, line);
        }
    }
} 