using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace OSRS_Quests
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Username_Click(object sender, EventArgs e)
        {
            string userName = text_Username.Text;
            string jsons = new WebClient().DownloadString("https://secure.runescape.com/m=hiscore_oldschool/index_lite.ws?player=" + userName);
            string[] splitstring = jsons.Split('\n');

            string[] listOfSkills = { "Total", "Attack", "Defence", "Strength", "Hitpoints", "Ranged", "Prayer", "Magic", "Cooking", "Woodcutting", "Fletching", "Fishing", "Firemaking", "Crafting", "Smithing", "Mining", "Herblore", "Agility", "Thieving", "Slayer", "Farming", "Runecraft", "Hunter", "Construction" };
            TextBox[] listOfSkillTextboxes = { text_Attack, text_Defence, text_Strength, text_Hitpoints, text_Ranged, text_Prayer, text_Magic, text_Cooking, text_Woodcutting, text_Fletching, text_Fishing, text_Firemaking, text_Crafting, text_Smithing, text_Mining, text_Herblore, text_Agility, text_Thieving, text_Slayer, text_Farming, text_Runecrafting, text_Hunter, text_Construction };

            Player osrsPlayer = new Player();
            osrsPlayer.userID = userName;

            for (int i = 0; i < 24; i++)
            {
                string[] skillInfo = splitstring[i].Split(',');
                osrsPlayer.playerSkills.Add(new Skill(listOfSkills[i], Convert.ToInt32(skillInfo[0]), Convert.ToInt32(skillInfo[1]), Convert.ToInt32(skillInfo[2])));

                if ((Convert.ToInt32(skillInfo[1]) > 1) && (i >= 1))
                {
                    listOfSkillTextboxes[i - 1].Text = skillInfo[1];
                }

            }


        }
    }
}
