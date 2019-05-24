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
            questList.Add(Quests.DruidicRitual());
            questList.Add(Quests.LostCity());
            questList.Add(Quests.MerlinsCrystal());
            questList.Add(Quests.HeroesQuest());

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

        private void whiteOutListView()
        {
            foreach (ListViewItem questListViewString in questListView.Items)
            {
                if (!(isQuestCompleted(questListViewString.Text)))
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

        private bool isQuestCompleted(string questName)
        {
            foreach (Quest q in questList)
            {
                if (q.questName == questName)
                {
                    return q.completed;
                }
            }
            return false;
        }

        private string determineSkillEligibility(Quest quest)
        {
            string eligible = "true";
            foreach (Skill s in quest.questSkills)
            {
                //Find the players skill Object
                foreach (Skill sk in osrsPlayer.playerSkills)
                {
                    if (sk.skillName == s.skillName)
                    {
                        //Console.WriteLine(s.skillName + " " + s.level + " sk " + sk.skillName + " " + sk.level);
                        if (sk.level < s.level)
                        {
                            if (s.boostlevel < s.level)
                            {
                                eligible = "false";
                            }
                            else
                            {
                                eligible = "boost";
                            }

                        }
                    }
                }
            }
            return eligible;
        }

        private bool determineQuestEligibility(Quest quest)
        {
            foreach (Quest q in quest.requiredQuests)
            {
                foreach (Quest qu in questList)
                {
                    // Console.WriteLine("Comparing " + q.questName + " and " + qu.questName);
                    if (q.questName == qu.questName)
                    {
                        if (qu.completed == false)
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }

        private void determineEligibleQuests()
        {
            foreach (ListViewItem questListViewString in questListView.Items)
            {
                //Console.WriteLine("TOString" + questListViewString.Text);
                //Find the Quest Object

                if (!(isQuestCompleted(questListViewString.Text))) {
                    Quest quest = new Quest(questListViewString.Text);
                    foreach (Quest q in questList)
                    {
                        if (q.questName == questListViewString.Text)
                        {
                            quest = q;
                        }
                    }

                    //Check levels
                    bool playerSkillEligible = true;
                    bool boostRequired = false;
                    string result = determineSkillEligibility(quest);
                    if (result == "false")
                    {
                        playerSkillEligible = false;
                    }
                    else if (result == "boost")
                    {
                        boostRequired = true;
                    }
                    


                    //Check quests
                    bool playerQuestEligible = determineQuestEligibility(quest);

                    if (playerSkillEligible && playerQuestEligible && boostRequired)
                    {
                        //set colour to orange
                        changeColour(questListViewString.Text, Color.Orange);
                    }
                    else if (playerSkillEligible && playerQuestEligible)
                    {
                        //set colour to yellow
                        changeColour(questListViewString.Text, Color.Yellow);
                    }
                    Console.WriteLine(questListViewString.Text + " " + playerSkillEligible + " boost: " + boostRequired + " quest elig " + playerQuestEligible);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Fix thsi with an update method to avoid duplicate skills
            osrsPlayer.playerSkills.Add( new Skill("QuestPoints", Convert.ToInt32(text_QuestPoints.Text)));

            whiteOutListView();

            determineEligibleQuests();
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

        private void text_Username_TextChanged(object sender, EventArgs e)
        {

        }

        private void questListView_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //MessageBox.Show(questListView.SelectedItem.ToString());

            if (questListView.SelectedItems.Count > 0)
            {
                var txt = questListView.SelectedItems[0].Text;
                Console.WriteLine(txt);

                foreach (Quest q in questList)
                {
                    if (q.questName == txt)
                    {
                        if (q.completed == false)
                        {
                            q.completed = true;
                            questListView.SelectedItems[0].BackColor = Color.Green;
                            Console.WriteLine("Mark as completed " + q.completed);
                        }
                        else
                        {
                            q.completed = false;
                            foreach(Quest qu in questList)
                            {
                                if (q.questName == qu.questName)
                                {
                                    //Check skills
                                    bool playerSkillEligible = true;
                                    bool boostRequired = false;
                                    string result = determineSkillEligibility(qu);
                                    if (result == "false")
                                    {
                                        playerSkillEligible = false;
                                    }
                                    else if (result == "boost")
                                    {
                                        boostRequired = true;
                                    }

                                    bool questEligible = determineQuestEligibility(qu);

                                    if (playerSkillEligible && boostRequired && questEligible)
                                    {
                                        questListView.SelectedItems[0].BackColor = Color.Orange;
                                    }
                                    else if (playerSkillEligible && questEligible)
                                    {
                                        questListView.SelectedItems[0].BackColor = Color.Yellow;
                                    }
                                    else
                                    {
                                        questListView.SelectedItems[0].BackColor = Color.Red;
                                    }
                                }
                            }
                        }
                    }
                }

            }
        }
    }
}
