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

        private void menu1_Click(object sender, EventArgs e)
        {
            ScreenControl.changeScreen(this, "MenuScreen");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            buttonDown = 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            buttonDown = 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            buttonDown = 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            buttonDown = 4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            buttonDown = 5;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            buttonDown = 6;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            buttonDown = 7;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            buttonDown = 8;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            buttonDown = 9;
        }

        private void gameTick_Tick(object sender, EventArgs e)
        {
            switch (buttonDown)
            {
                case 1:
                    button1.Visible = false;
                    buttonvisible.button1 = false;
                    break;

                case 2:
                    button2.Visible = false;
                    buttonvisible.button2 = false;
                    break;

                case 3:
                    button3.Visible = false;
                    buttonvisible.button3 = false;
                    break;

                case 4:
                    button4.Visible = false;
                    buttonvisible.button4 = false;
                    break;

                case 5:
                    button5.Visible = false;
                    buttonvisible.button5 = false;
                    break;

                case 6:
                    button6.Visible = false;
                    buttonvisible.button6 = false;
                    break;
                    
                case 7:
                    button7.Visible = false;
                    buttonvisible.button7 = false;
                    break;
                   
                case 8:
                    button8.Visible = false;
                    buttonvisible.button8 = false;
                    break;

                case 9:
                    button9.Visible = false;
                    buttonvisible.button9 = false;
                    break;

                default:
                    break;

                


            }

        }
    }
}
