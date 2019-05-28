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
        List<Quest> questList = Quests.generateQuestList();
        bool loginCompleted = false;


        public Form1()
        {
            InitializeComponent();
            addQuestsToListView();
        }

        public void addQuestsToListView()
        {
            foreach (Quest q in questList)
            {
                questListView.Items.Add(q.questName);
            }
        }
        

        private void btn_Username_Click(object sender, EventArgs e)
        {
            string userName = text_Username.Text;
            //string jsons = new WebClient().DownloadString("https://secure.runescape.com/m=hiscore_oldschool/index_lite.ws?player=" + userName);
            string jsons = "342793,1575,20842879\n453964,76,1441578\n426128,76,1363199\n459881,85,3420041\n571975,81,2323144\n642308,78,1702374\n270235,70,805726\n643569,75,1285777\n607804,70,743706\n635058,66,518159\n357146,75,1248070\n573522,65,479622\n467415,66,505405\n346822,70,746261\n256403,70,770502\n288972,70,771095\n429146,57,213085\n423140,66,533771\n298486,61,312060\n474357,69,714890\n355338,61,312989\n219924,58,235335\n406201,60,291332\n493355,50,104758\n-1,-1\n-1,-1\n-1,-1\n394806,20\n-1,-1\n-1,-1\n-1,-1\n234290,20\n-1,-1\n-1,-1";
            //Console.WriteLine(jsons);
            string[] splitstring = jsons.Split('\n');

            string[] listOfSkills = { "Total", "Attack", "Defence", "Strength", "Hitpoints", "Ranged", "Prayer", "Magic", "Cooking", "Woodcutting", "Fletching", "Fishing", "Firemaking", "Crafting", "Smithing", "Mining", "Herblore", "Agility", "Thieving", "Slayer", "Farming", "Runecraft", "Hunter", "Construction" };
            NumericUpDown[] listOfSkillNumericBoxes = { UpDown_Attack, UpDown_Defence, UpDown_Strength, UpDown_Hitpoints, UpDown_Ranged, UpDown_Prayer, UpDown_Magic, UpDown_Cooking, UpDown_Woodcutting, UpDown_Fletching, UpDown_Fishing, UpDown_Firemaking, UpDown_Crafting, UpDown_Smithing, UpDown_Mining, UpDown_Herblore, UpDown_Agility, UpDown_Thieving, UpDown_Slayer, UpDown_Farming, UpDown_Runecrafting, UpDown_Hunter, UpDown_Construction };
            osrsPlayer.userID = userName;

            for (int i = 0; i < 24; i++)
            {
                string[] skillInfo = splitstring[i].Split(',');
                osrsPlayer.playerSkills.Add(new Skill(listOfSkills[i], Convert.ToInt32(skillInfo[0]), Convert.ToInt32(skillInfo[1]), Convert.ToInt32(skillInfo[2])));

                if ((Convert.ToInt32(skillInfo[1]) > 1) && (i >= 1))
                {
                    listOfSkillNumericBoxes[i - 1].Value = Convert.ToInt32(skillInfo[1]);
                }

            }

            //Add questpoints skill
            osrsPlayer.playerSkills.Add(new Skill("QuestPoints", Convert.ToInt32(UpDown_QuestPoints.Value)));
            //Add combat skill
            osrsPlayer.playerSkills.Add(new Skill("Combat", osrsPlayer.calculateCombatLevel(textBox_Combat)));


            loginCompleted = true;
            osrsPlayer.calculateCombatLevel(textBox_Combat);
        }


        private void whiteOutListView()
        {
            foreach (ListViewItem questListViewString in questListView.Items)
            {
                if (!(Quest.isQuestCompleted(questList, questListViewString.Text)))
                {
                    questListViewString.BackColor = Color.White;
                }
            }
        }


        private void changeColour(string questName, Color colour)
        {
            foreach (ListViewItem questListViewString in questListView.Items)
            {
                if (questListViewString.Text == questName)
                {
                    questListViewString.BackColor = colour;
                }
            }
        }

        

        private bool determineQuestEligibility(Quest quest)
        {
            foreach (Quest q in quest.requiredQuests)
            {
                if (!(Quest.isQuestCompleted(questList, q.questName)))
                {
                    return false;
                }
            }
            return true;
        }


        private void updateQuestColours()
        {
            foreach (ListViewItem questListViewString in questListView.Items)
            {
                Quest q = Quest.findQuest(questList, questListViewString.Text);

                if (q.completed)
                {
                    //Mark it green
                    changeColour(q.questName, Color.Green);
                }
                else
                {
                    bool questEligibility = determineQuestEligibility(q);
                    if (questEligibility)
                    {
                        string skillEligibility = Player.determineSkillEligibility(q, osrsPlayer);
                        if (skillEligibility == "false")
                        {
                            //Set it to white
                            changeColour(q.questName, Color.White);
                        }
                        else if (skillEligibility == "boost")
                        {
                            //Set it to Orange
                            changeColour(q.questName, Color.Orange);
                        }
                        else if (skillEligibility == "true")
                        {
                            changeColour(q.questName, Color.Yellow);
                        }
                    }
                    else
                    {
                        //Quest not eligible, set white
                        changeColour(q.questName, Color.White);
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loginCompleted = true;

            //Fix thsi with an update method to avoid duplicate skills

            whiteOutListView();

            //determineEligibleQuests();

            updateQuestColours();
        }

        private void questListView_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //MessageBox.Show(questListView.SelectedItem.ToString());

            if (questListView.SelectedItems.Count > 0)
            {
                var txt = questListView.SelectedItems[0].Text;

                Quest q = Quest.findQuest(questList, questListView.SelectedItems[0].Text);

                if (q.completed == false)
                {
                    q.completed = true;
                    //Activate all the prerequisites
                    foreach(Quest qu in q.requiredQuests)
                    {
                        Quest.findQuest(questList, qu.questName).completed = true;
                    }
                }
                else
                {
                    q.completed = false;
                }
            }

            //Calculate and update quest points if needed
            int minimumQuestPoints = osrsPlayer.calculateMinimumQuestPoints(questList);
            if (UpDown_QuestPoints.Value < minimumQuestPoints)
            {
                UpDown_QuestPoints.Value = minimumQuestPoints;
            }



            //Remove highlighting
            for (int i = questListView.SelectedItems.Count - 1; i >= 0; --i)
            {
                questListView.SelectedItems[i].Selected = false;
            }


            updateQuestColours();
        }

        private void updateAfterLogin()
        {
            if (loginCompleted)
            {
                updateQuestColours();
            }
        }

        private void UpDown_Attack_ValueChanged(object sender, EventArgs e)
        {
            osrsPlayer.updateSkillLevel("Attack", Convert.ToInt32(UpDown_Attack.Value));
            osrsPlayer.updateSkillLevel("Combat", osrsPlayer.calculateCombatLevel(textBox_Combat));
            updateAfterLogin();
        }

        private void UpDown_Hitpoints_ValueChanged(object sender, EventArgs e)
        {
            osrsPlayer.updateSkillLevel("Hitpoints", Convert.ToInt32(UpDown_Hitpoints.Value));
            osrsPlayer.updateSkillLevel("Combat", osrsPlayer.calculateCombatLevel(textBox_Combat));
            updateAfterLogin();
        }


        private void UpDown_Mining_ValueChanged(object sender, EventArgs e)
        {
            osrsPlayer.updateSkillLevel("Mining", Convert.ToInt32(UpDown_Mining.Value));
            updateAfterLogin();
        }

        private void UpDown_Strength_ValueChanged(object sender, EventArgs e)
        {
            osrsPlayer.updateSkillLevel("Strength", Convert.ToInt32(UpDown_Strength.Value));
            osrsPlayer.updateSkillLevel("Combat", osrsPlayer.calculateCombatLevel(textBox_Combat));
            updateAfterLogin();
        }

        private void UpDown_Agility_ValueChanged(object sender, EventArgs e)
        {
            osrsPlayer.updateSkillLevel("Agility", Convert.ToInt32(UpDown_Agility.Value));
            updateAfterLogin();
        }

        private void UpDown_Smithing_ValueChanged(object sender, EventArgs e)
        {
            osrsPlayer.updateSkillLevel("Smithing", Convert.ToInt32(UpDown_Smithing.Value));
            updateAfterLogin();
        }

        private void UpDown_Defence_ValueChanged(object sender, EventArgs e)
        {
            osrsPlayer.updateSkillLevel("Defence", Convert.ToInt32(UpDown_Defence.Value));
            osrsPlayer.updateSkillLevel("Combat", osrsPlayer.calculateCombatLevel(textBox_Combat));
            updateAfterLogin();
        }

        private void UpDown_Herblore_ValueChanged(object sender, EventArgs e)
        {
            osrsPlayer.updateSkillLevel("Herblore", Convert.ToInt32(UpDown_Herblore.Value));
            updateAfterLogin();
        }

        private void UpDown_Fishing_ValueChanged(object sender, EventArgs e)
        {
            osrsPlayer.updateSkillLevel("Fishing", Convert.ToInt32(UpDown_Fishing.Value));
            updateAfterLogin();
        }

        private void UpDown_Ranged_ValueChanged(object sender, EventArgs e)
        {
            osrsPlayer.updateSkillLevel("Ranged", Convert.ToInt32(UpDown_Ranged.Value));
            osrsPlayer.updateSkillLevel("Combat", osrsPlayer.calculateCombatLevel(textBox_Combat));
            updateAfterLogin();
        }

        private void UpDown_Thieving_ValueChanged(object sender, EventArgs e)
        {
            osrsPlayer.updateSkillLevel("Thieving", Convert.ToInt32(UpDown_Thieving.Value));
            updateAfterLogin();
        }

        private void UpDown_Cooking_ValueChanged(object sender, EventArgs e)
        {
            osrsPlayer.updateSkillLevel("Cooking", Convert.ToInt32(UpDown_Cooking.Value));
            updateAfterLogin();
        }

        private void UpDown_Prayer_ValueChanged(object sender, EventArgs e)
        {
            osrsPlayer.updateSkillLevel("Prayer", Convert.ToInt32(UpDown_Prayer.Value));
            osrsPlayer.updateSkillLevel("Combat", osrsPlayer.calculateCombatLevel(textBox_Combat));
            updateAfterLogin();
        }

        private void UpDown_Crafting_ValueChanged(object sender, EventArgs e)
        {
            osrsPlayer.updateSkillLevel("Crafting", Convert.ToInt32(UpDown_Crafting.Value));
            updateAfterLogin();
        }

        private void UpDown_Firemaking_ValueChanged(object sender, EventArgs e)
        {
            osrsPlayer.updateSkillLevel("Firemaking", Convert.ToInt32(UpDown_Firemaking.Value));
            updateAfterLogin();
        }

        private void UpDown_Magic_ValueChanged(object sender, EventArgs e)
        {
            osrsPlayer.updateSkillLevel("Magic", Convert.ToInt32(UpDown_Magic.Value));
            osrsPlayer.updateSkillLevel("Combat", osrsPlayer.calculateCombatLevel(textBox_Combat));
            updateAfterLogin();
        }

        private void UpDown_Fletching_ValueChanged(object sender, EventArgs e)
        {
            osrsPlayer.updateSkillLevel("Fletching", Convert.ToInt32(UpDown_Fletching.Value));
            updateAfterLogin();
        }

        private void UpDown_Woodcutting_ValueChanged(object sender, EventArgs e)
        {
            osrsPlayer.updateSkillLevel("Woodcutting", Convert.ToInt32(UpDown_Woodcutting.Value));
            updateAfterLogin();
        }

        private void UpDown_Runecrafting_ValueChanged(object sender, EventArgs e)
        {
            osrsPlayer.updateSkillLevel("Runecrafting", Convert.ToInt32(UpDown_Runecrafting.Value));
            updateAfterLogin();
        }

        private void UpDown_Slayer_ValueChanged(object sender, EventArgs e)
        {
            osrsPlayer.updateSkillLevel("Slayer", Convert.ToInt32(UpDown_Slayer.Value));
            updateAfterLogin();
        }

        private void UpDown_Farming_ValueChanged(object sender, EventArgs e)
        {
            osrsPlayer.updateSkillLevel("Farming", Convert.ToInt32(UpDown_Farming.Value));
            updateAfterLogin();
        }

        private void UpDown_Construction_ValueChanged(object sender, EventArgs e)
        {
            osrsPlayer.updateSkillLevel("Construction", Convert.ToInt32(UpDown_Construction.Value));
            updateAfterLogin();
        }

        private void UpDown_Hunter_ValueChanged(object sender, EventArgs e)
        {
            osrsPlayer.updateSkillLevel("Hunter", Convert.ToInt32(UpDown_Hunter.Value));
            updateAfterLogin();
        }

        private void UpDown_QuestPoints_ValueChanged(object sender, EventArgs e)
        {
            osrsPlayer.updateSkillLevel("QuestPoints", Convert.ToInt32(UpDown_QuestPoints.Value));
            updateAfterLogin();
        }


        private void text_Username_TextChanged(object sender, EventArgs e)
        {
            osrsPlayer.userID = text_Username.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
