using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameTemplate

{
    public partial class CasesScreen : UserControl
    {
        int buttonDown;

        public CasesScreen()
        {
            //using the buttonvisible class 
            InitializeComponent();
            button1.Visible = buttonvisible.button1;
            button2.Visible = buttonvisible.button2;
            button3.Visible = buttonvisible.button3;
            button4.Visible = buttonvisible.button4;
            button5.Visible = buttonvisible.button5;
            button6.Visible = buttonvisible.button6;
            button7.Visible = buttonvisible.button7;
            button8.Visible = buttonvisible.button8;
            button9.Visible = buttonvisible.button9;

        }
        //change the screen
        private void menu1_Click(object sender, EventArgs e)
        {
            ScreenControl.changeScreen(this, "MenuScreen");
        }
        //changing buttons invisible for the rest of the program
        private void button1_Click(object sender, EventArgs e)
        {
            buttonDown = 1;
            ScreenControl.changeScreen(this, "AnimationScreen");
            buttonvisible.button1 = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            buttonDown = 2;
            ScreenControl.changeScreen(this, "AnimationScreen");
            buttonvisible.button2 = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            buttonDown = 3;
            ScreenControl.changeScreen(this, "AnimationScreen");
            buttonvisible.button3 = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            buttonDown = 4;
            ScreenControl.changeScreen(this, "AnimationScreen");
            buttonvisible.button4 = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            buttonDown = 5;
            ScreenControl.changeScreen(this, "AnimationScreen");
            buttonvisible.button5 = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            buttonDown = 6;
            ScreenControl.changeScreen(this, "AnimationScreen");
            buttonvisible.button6 = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            buttonDown = 7;
            ScreenControl.changeScreen(this, "AnimationScreen");
            buttonvisible.button7 = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            buttonDown = 8;
            ScreenControl.changeScreen(this, "AnimationScreen");
            buttonvisible.button8 = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            buttonDown = 9;
            ScreenControl.changeScreen(this, "AnimationScreen");
            buttonvisible.button9 = false;
        }
    }
}
