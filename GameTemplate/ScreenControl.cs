﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using GameTemplate.Screens;

namespace GameTemplate
{
    class ScreenControl
    {
        // high score values
        public static List<int> highScores = new List<int>();

        // screen and user control values
        public static int controlWidth = 1000;
        public static int controlHeight = 600;
        
        public static int screenWidth = Screen.PrimaryScreen.WorkingArea.Width;
        public static int screenHeight = Screen.PrimaryScreen.WorkingArea.Height;
        
        public static Point startCentre = new Point(screenWidth / 2 - controlWidth / 2, screenHeight / 2 - controlHeight / 2);

        // button values
        public static Size buttonSize = new Size(275, 145);
        public static Color buttonBackColor = Color.LightSteelBlue;
        public static Color buttonActiveColor = Color.White;
        public static FlatStyle buttonFlatStyle = FlatStyle.Flat;
        public static Font buttonFont = new Font("Segoe UI", 20);

        public static Boolean firstTime = true;

        public static void buttonLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = buttonBackColor;
        }

        public static void buttonEnter(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = buttonActiveColor;
        }

        public static void changeScreen(UserControl current, string next)
        {

            //tmp is set to the form that this control is on
            Form tmp = current.FindForm();
            tmp.Controls.Remove(current);
            UserControl ns = null;

            switch (next)
            {
                case "MessageScreen1":
                    ns = new messageScreen1();
                    break;
                case "GameScreen":
                    ns = new GameScreen();
                    break;
                case "MS2":
                    ns = new MS2();
                    break;
                case "GS2":
                    ns = new GS2();
                    break;
                case "Congrats":
                    ns = new Congrats();
                    break;
                case "MenuScreen":
                    ns = new MenuScreen();
                    break;
                case "InstructionScreen":
                    ns = new InstructionScreen();
                    break;
                
            }
            ns.Size = new Size(controlWidth, controlHeight);
            ns.Location = startCentre;
            tmp.Controls.Add(ns);
            ns.Focus();
        }

        public static void setComponentValues(UserControl uc)
        {
            foreach (Control c in uc.Controls)
            {
                //will make the font of all components equal to buttonFont value
                c.Font = buttonFont;

                if (c is Button)
                {
                    Button b = new Button();
                    b = (Button)c;

                    b.Font = buttonFont;
                    b.BackColor = buttonBackColor;
                    b.Size = buttonSize;
                    b.FlatStyle = buttonFlatStyle;
                    b.Enter += buttonEnter;
                    b.Leave += buttonLeave;
                }
            }
        }

        public static void setComponentValues(Form f)
        {
            foreach (Control c in f.Controls)
            {
                //will make the font of all components equal to buttonFont value
                c.Font = buttonFont;

                if (c is Button)
                {
                    Button b = new Button();
                    b = (Button)c;

                    b.Font = buttonFont;
                    b.BackColor = buttonBackColor;
                    b.Size = buttonSize;
                    b.FlatStyle = buttonFlatStyle;
                }
                // centre components on user control
                c.Location = new Point(controlWidth / 2 - c.Width / 2, c.Location.Y);
            }
        }
    }
}

