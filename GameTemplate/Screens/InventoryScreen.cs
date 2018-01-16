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
        }

        private void menu2_Click(object sender, EventArgs e)
        {
            ScreenControl.changeScreen(this, "MenuScreen");
        }
    }
}
