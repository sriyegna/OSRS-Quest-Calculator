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
        Player osrsPlayer = new Player();
        List<Quest> questList = new List<Quest>();


        public Form1()
        {
            InitializeComponent();
            generateQuestList();
        }


        private void generateQuestList()
        {
            questList.Add(Quests.CooksAssisstant());
            questList.Add(Quests.DemonSlayer());
            questList.Add(Quests.TheRestlessGhost());
            questList.Add(Quests.RomeoAndJuliet());
            questList.Add(Quests.SheepShearer());
            questList.Add(Quests.ShieldOfArrav());
            questList.Add(Quests.ErnestTheChicken());
            questList.Add(Quests.VampireSlayer());
            questList.Add(Quests.ImpCatcher());
            questList.Add(Quests.PriceAliRescue());
            questList.Add(Quests.DoricsQuest());
            questList.Add(Quests.BlackKnightsFortress());
            questList.Add(Quests.WitchsPotion());
            questList.Add(Quests.TheKnightsSword());
            questList.Add(Quests.GoblinDiplomacy());
            questList.Add(Quests.PiratesTreasure());
            questList.Add(Quests.DragonSlayer());

            foreach (Quest q in questList)
            {
                questListBox.Items.Add(q.questName);
            }

        }

        private void btn_Username_Click(object sender, EventArgs e)
        {
            string userName = text_Username.Text;
            string jsons = new WebClient().DownloadString("https://secure.runescape.com/m=hiscore_oldschool/index_lite.ws?player=" + userName);
            string[] splitstring = jsons.Split('\n');

            string[] listOfSkills = { "Total", "Attack", "Defence", "Strength", "Hitpoints", "Ranged", "Prayer", "Magic", "Cooking", "Woodcutting", "Fletching", "Fishing", "Firemaking", "Crafting", "Smithing", "Mining", "Herblore", "Agility", "Thieving", "Slayer", "Farming", "Runecraft", "Hunter", "Construction" };
            TextBox[] listOfSkillTextboxes = { text_Attack, text_Defence, text_Strength, text_Hitpoints, text_Ranged, text_Prayer, text_Magic, text_Cooking, text_Woodcutting, text_Fletching, text_Fishing, text_Firemaking, text_Crafting, text_Smithing, text_Mining, text_Herblore, text_Agility, text_Thieving, text_Slayer, text_Farming, text_Runecrafting, text_Hunter, text_Construction };

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

        private void questListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (questListBox.SelectedItems != null)
            {
                MessageBox.Show(questListBox.SelectedItem.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            osrsPlayer.playerSkills.Add( new Skill("QuestPoints", Convert.ToInt32(text_QuestPoints.Text)));

            foreach (object questListBoxString in questListBox.Items)
            {
                Console.WriteLine(questListBoxString.ToString());
                //Find the Quest Object
                Quest quest = new Quest(questListBoxString.ToString());
                foreach (Quest q in questList)
                {
                    if (q.questName == questListBoxString.ToString())
                    {
                        quest = q;
                    }
                }

                //Check levels
                Boolean playerSkillEligible = true;
                foreach (Skill s in quest.questSkills)
                {
                    //Find the players skill Object
                    foreach (Skill sk in osrsPlayer.playerSkills)
                    {
                        if (sk.skillName == s.skillName)
                        {
                            Console.WriteLine(s.skillName + " " + s.level + " sk " + sk.skillName + " " + sk.level);
                            if (sk.level < s.level)
                            {
                                playerSkillEligible = false;
                            }
                        }
                    }
                }
                Console.WriteLine(questListBoxString.ToString() + " " + playerSkillEligible);

                //Check quests
            }
        }

        private void text_Attack_TextChanged(object sender, EventArgs e)
        {
            osrsPlayer.updateSkillLevel("Attack", Convert.ToInt32(text_Attack.Text));
        }

        private void text_Crafting_TextChanged(object sender, EventArgs e)
        {
            osrsPlayer.updateSkillLevel("Crafting", Convert.ToInt32(text_Crafting.Text));
        }

        private void text_Hitpoints_TextChanged(object sender, EventArgs e)
        {
            osrsPlayer.updateSkillLevel("Hitpoints", Convert.ToInt32(text_Hitpoints.Text));
        }
    }
}
