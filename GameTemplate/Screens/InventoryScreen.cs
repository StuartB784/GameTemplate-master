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
    public partial class InventoryScreen : UserControl
    {
        public InventoryScreen()
        {
            InitializeComponent();
            //shows the dictionary values on the labels

            knifelabel.Text = "" + Form1.inventory["Knife"];
            awplabel.Text = "" + Form1.inventory["AWP"];
            ak47label.Text = "" + Form1.inventory["AK-47"];
            cz75label.Text = "" + Form1.inventory["CZ75"];
            mp7label.Text = "" + Form1.inventory["MP7"];
            sg553label.Text = "" + Form1.inventory["SG 553"];
            famaslabel.Text = "" + Form1.inventory["FAMAS"];
            m4a4label.Text = "" + Form1.inventory["M4A4"];
            mp9label.Text = "" + Form1.inventory["MP9"];
            negevlabel.Text = "" + Form1.inventory["Negev"];
            p2000label.Text = "" + Form1.inventory["P2000"];
            galilarlabel.Text = "" + Form1.inventory["Galil-AR"];
            glock18label.Text = "" + Form1.inventory["Glock-18"];
            novalabel.Text = "" + Form1.inventory["Nova"];
            p90label.Text = "" + Form1.inventory["P90"];
            ump45label.Text = "" + Form1.inventory["UMP 45"];
            uspslabel.Text = "" + Form1.inventory["USP-S"];

            Refresh();
        }
        //change screen
        private void menu2_Click(object sender, EventArgs e)
        {
            ScreenControl.changeScreen(this, "MenuScreen");
        }
    }
}
