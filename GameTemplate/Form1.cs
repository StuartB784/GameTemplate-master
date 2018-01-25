using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameTemplate
{
    public partial class Form1 : Form
    {
        //create dictionary
        public static Dictionary<string, int> inventory = new Dictionary<string, int>();

        public Form1()
        {
            InitializeComponent();

           //add to dictionary
            inventory.Add("AK-47", 0);
            inventory.Add("AWP", 0);
            inventory.Add("CZ75", 0);
            inventory.Add("Knife", 0);
            inventory.Add("FAMAS", 0);
            inventory.Add("Galil-AR", 0);
            inventory.Add("Glock-18", 0);
            inventory.Add("M4A4", 0);
            inventory.Add("MP7", 0);
            inventory.Add("MP9", 0);
            inventory.Add("Negev", 0);
            inventory.Add("Nova", 0);
            inventory.Add("P90", 0);
            inventory.Add("P2000", 0);
            inventory.Add("SG 553", 0);
            inventory.Add("UMP 45", 0);
            inventory.Add("USP-S", 0);



            // hide the mouse cursor
            //Cursor.Hide();

            // display the main menu
            Screens.MenuScreen mm = new Screens.MenuScreen();

            // set the menu to display centre screen based on screen size defaults
            mm.Size = new Size(ScreenControl.controlWidth, ScreenControl.controlHeight);
            mm.Location = ScreenControl.startCentre;

            // add main menu screen to form
            this.Controls.Add(mm);
        }
    }
}
