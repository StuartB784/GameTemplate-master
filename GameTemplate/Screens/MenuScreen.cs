using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameTemplate.Screens
{
    public partial class MenuScreen : UserControl
    {
        Color buttonBackColor = Color.White;
        Color buttonActiveColor = Color.Green;

        public MenuScreen()
        {
            InitializeComponent();

            ScreenControl.setComponentValues(this);
            //defaultOverride();
        }
        //change screens
        private void casesButton_Click(object sender, EventArgs e)
        {
            ScreenControl.changeScreen(this, "CasesScreen");
        }

        private void inventoryButton_Click(object sender, EventArgs e)
        {
            ScreenControl.changeScreen(this, "InventoryScreen");
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Change any control default values here
        /// </summary>
        public void defaultOverride()
        {
            foreach (Control c in this.Controls)
            {
                c.Location = new Point(c.Location.X, c.Location.Y + 75);             
            }

        }


    }
}
