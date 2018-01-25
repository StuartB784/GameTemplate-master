using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace GameTemplate
{
    public partial class Animation : UserControl
    {
        //setting variables 
        String image;
        int t = 200;

        public Animation()
        {
            InitializeComponent();           
        }
           
        //change screen to menu
        private void button1_Click(object sender, EventArgs e)
        {
            ScreenControl.changeScreen(this, "CasesScreen");

        }   
        // loading animation after loading the animation screen
        private void Animation_Load(object sender, EventArgs e)
        {
            for (int animationnumber = 1; animationnumber <= 10;)
            {

                Random caseopen = new Random();
                int finditem = caseopen.Next(1, 101);

                if (finditem > 98)
                {
                    reel3.Image = GameTemplate.Properties.Resources.Falchion_Knife_Slaughter;
                    reel3.Refresh();
                    Thread.Sleep(t);
                    image = "Knife";
                    animationnumber++;
                }
                else if (finditem >= 95)
                {
                    if (caseopen.Next(1, 3) == 1)
                    {
                        reel3.Image = GameTemplate.Properties.Resources.AK_47_Aquamarine_Revenge;
                        reel3.Refresh();
                        Thread.Sleep(t);
                        image = "AK-47";
                        animationnumber++;
                    }
                    else
                    {
                        reel3.Image = GameTemplate.Properties.Resources.AWP_Hyper_Beast;
                        reel3.Refresh();
                        Thread.Sleep(t);
                        image = "AWP";
                        animationnumber++;
                    }
                }
                else if (finditem >= 90)
                {
                    if (caseopen.Next(1, 4) == 1)
                    {
                        reel3.Image = GameTemplate.Properties.Resources.CZ75_Auto_Yellow_Jacket;
                        reel3.Refresh();
                        Thread.Sleep(t);
                        image = "CZ75";
                        animationnumber++;
                    }
                    else if (caseopen.Next(1, 4) == 2)
                    {
                        reel3.Image = GameTemplate.Properties.Resources.MP7_Nemesis;
                        reel3.Refresh();
                        Thread.Sleep(t);
                        image = "MP7";
                        animationnumber++;
                    }
                    else
                    {
                        reel3.Image = GameTemplate.Properties.Resources.SG_553_Cyrex;
                        reel3.Refresh();
                        Thread.Sleep(t);
                        image = "SG 553";
                        animationnumber++;
                    }
                }
                else if (finditem >= 80)
                {
                    if (caseopen.Next(1, 6) == 1)
                    {
                        reel3.Image = GameTemplate.Properties.Resources.Negev_Loudmouth;
                        reel3.Refresh();
                        Thread.Sleep(t);
                        image = "Negev";
                        animationnumber++;
                    }
                    else if (caseopen.Next(1, 6) == 2)
                    {
                        reel3.Image = GameTemplate.Properties.Resources.P2000_Handgun;
                        reel3.Refresh();
                        Thread.Sleep(t);
                        image = "P2000";
                        animationnumber++;
                    }
                    else if (caseopen.Next(1, 6) == 3)
                    {
                        reel3.Image = GameTemplate.Properties.Resources.FAMAS_Neural_Net;
                        reel3.Refresh();
                        Thread.Sleep(t);

                        image = "FAMAS";
                        animationnumber++;
                    }
                    else if (caseopen.Next(1, 6) == 4)
                    {
                        reel3.Image = GameTemplate.Properties.Resources.M4A4_Evil_Daimyo;
                        reel3.Refresh();
                        Thread.Sleep(t);
                        image = "M4A4";
                        animationnumber++;
                    }
                    else
                    {
                        reel3.Image = GameTemplate.Properties.Resources.MP9_Ruby_Poison_Dart;
                        reel3.Refresh();
                        Thread.Sleep(t);
                        image = "MP9";
                        animationnumber++;
                    }

                }
                else if (finditem >= 50)
                {
                    if (caseopen.Next(1, 4) == 1)
                    {
                        reel3.Image = GameTemplate.Properties.Resources.Galil_AR_Rocket_Pop;
                        reel3.Refresh();
                        Thread.Sleep(t);
                        image = "Galil AR";
                        animationnumber++;
                    }
                    else if (caseopen.Next(1, 4) == 2)
                    {
                        reel3.Image = GameTemplate.Properties.Resources.USP_S_Torque;
                        reel3.Refresh();
                        Thread.Sleep(t);
                        image = "UPS-S";
                        animationnumber++;
                    }
                    else
                    {
                        reel3.Image = GameTemplate.Properties.Resources.UMP_45_Riot;
                        reel3.Refresh();
                        Thread.Sleep(t);
                        image = "UMP 45";
                        animationnumber++;
                    }
                }
                else if (finditem >= 1)
                {
                    if (caseopen.Next(1, 4) == 1)
                    {
                        reel3.Image = GameTemplate.Properties.Resources.Glock_18_Bunsen_Burner;
                        reel3.Refresh();
                        Thread.Sleep(t);
                        image = "Glock-18";
                        animationnumber++;
                    }
                    else if (caseopen.Next(1, 4) == 2)
                    {
                        reel3.Image = GameTemplate.Properties.Resources.Nova_Ranger;
                        reel3.Refresh();
                        Thread.Sleep(t);
                        image = "Nova";
                        animationnumber++;
                    }
                    else
                    {
                        reel3.Image = GameTemplate.Properties.Resources.P90_Elite_Build;
                        reel3.Refresh();
                        Thread.Sleep(t);
                        image = "P90";
                        animationnumber++;
                    }
                }
            }
            //adding data to the inventory dictionary
            switch (image)
            {
                case "P90":
                    Form1.inventory["P90"] += 1;
                    break;
                case "Nova":
                    Form1.inventory["Nova"] += 1;
                    break;
                case "Glock-18":
                    Form1.inventory["Glock-18"] += 1;
                    break;
                case "UMP 45":
                    Form1.inventory["UMP 45"] += 1;
                    break;
                case "USP-S":
                    Form1.inventory["USP-S"] += 1;
                    break;
                case "Galil AR":
                    Form1.inventory["Galil-AR"] += 1;
                    break;
                case "MP9":
                    Form1.inventory["MP9"] += 1;
                    break;
                case "FAMAS":
                    Form1.inventory["FAMAS"] += 1;
                    break;
                case "M4A4":
                    Form1.inventory["M4A4"] += 1;
                    break;
                case "P2000":
                    Form1.inventory["P2000"] += 1;
                    break;
                case "Negev":
                    Form1.inventory["Negev"] += 1;
                    break;
                case "SG 553":
                    Form1.inventory["SG 553"] += 1;
                    break;
                case "MP7":
                    Form1.inventory["MP7"] += 1;
                    break;
                case "CZ75":
                    Form1.inventory["CZ75"] += 1;
                    break;
                case "AK-47":
                    Form1.inventory["AK-47"] += 1;
                    break;
                case "AWP":
                    Form1.inventory["AWP"] += 1;
                    break;
                case "Knife":
                    Form1.inventory["Knife"] += 1;
                    break;

            }
        }
    }
}
