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
        bool loginCompleted = false;


        public Form1()
        {
            InitializeComponent();
            generateQuestList();
        }


        private void generateQuestList()
        {
            questList.Add(Quests.CooksAssisstant()); //1
            questList.Add(Quests.DemonSlayer()); //2
            questList.Add(Quests.TheRestlessGhost()); //3
            questList.Add(Quests.RomeoAndJuliet()); //4
            questList.Add(Quests.SheepShearer()); //5
            questList.Add(Quests.ShieldOfArrav()); //6
            questList.Add(Quests.ErnestTheChicken()); //7
            questList.Add(Quests.VampireSlayer()); //8
            questList.Add(Quests.ImpCatcher()); //9
            questList.Add(Quests.PriceAliRescue()); //10
            questList.Add(Quests.DoricsQuest()); //11
            questList.Add(Quests.BlackKnightsFortress()); //12
            questList.Add(Quests.WitchsPotion()); //13
            questList.Add(Quests.TheKnightsSword()); //14
            questList.Add(Quests.GoblinDiplomacy()); //15
            questList.Add(Quests.PiratesTreasure()); //16
            questList.Add(Quests.DragonSlayer()); //17
            questList.Add(Quests.DruidicRitual()); //18
            questList.Add(Quests.LostCity()); //19
            questList.Add(Quests.WitchsHouse()); //20
            questList.Add(Quests.MerlinsCrystal()); //21
            questList.Add(Quests.HeroesQuest()); //22
            questList.Add(Quests.ScorpionCatcher()); //23
            questList.Add(Quests.FamilyCrest()); //24
            questList.Add(Quests.TribalTotem()); //25
            questList.Add(Quests.FishingContest()); //26
            questList.Add(Quests.MonksFriend()); //27
            questList.Add(Quests.TempleOfIkov()); //28
            questList.Add(Quests.ClockTower()); //29
            questList.Add(Quests.HolyGrail()); //30
            questList.Add(Quests.TreeGnomeVillage()); //31
            questList.Add(Quests.FightArena()); //32
            questList.Add(Quests.HazeelCult()); //33
            questList.Add(Quests.SheepHerder()); //34
            questList.Add(Quests.PlagueCity()); //35
            questList.Add(Quests.SeaSlug()); //36
            questList.Add(Quests.WaterfallQuest()); //37
            questList.Add(Quests.Biohazard()); //38
            questList.Add(Quests.JunglePotion()); //39
            questList.Add(Quests.TheGrandTree()); //40
            questList.Add(Quests.ShiloVillage()); //41
            questList.Add(Quests.UndergroundPass()); //42
            questList.Add(Quests.ObservatoryQuest()); //43
            questList.Add(Quests.TheTouristTrap()); //44
            questList.Add(Quests.Watchtower()); //45
            questList.Add(Quests.DwarfCannon()); //46
            questList.Add(Quests.MurderMystery()); //47
            questList.Add(Quests.TheDigSite()); //48
            questList.Add(Quests.GertrudesCat()); //49
            questList.Add(Quests.LegendsQuest()); //50
            questList.Add(Quests.RuneMysteries()); //51
            questList.Add(Quests.BigChompyBirdHunting()); //52
            questList.Add(Quests.ElementalWorkshopI()); //53
            questList.Add(Quests.PriestInPeril()); //54
            questList.Add(Quests.NatureSpirit()); //55
            questList.Add(Quests.DeathPlateau()); //56
            questList.Add(Quests.TrollStronghold()); //57
            questList.Add(Quests.TaiBwoWannaiTrio()); //58
            questList.Add(Quests.Regicide()); //59
            questList.Add(Quests.EadgarsRuse()); //60
            questList.Add(Quests.ShadesOfMortton()); //61
            questList.Add(Quests.TheFremennikTrials()); //62
            questList.Add(Quests.HorrorFromTheDeep()); //63
            questList.Add(Quests.ThroneOfMiscellania()); //64
            questList.Add(Quests.MonkeyMadnessI()); //65
            questList.Add(Quests.HauntedMine()); //66
            questList.Add(Quests.TrollRomance()); //67
            questList.Add(Quests.InSearchOfTheMyreque()); //68
            questList.Add(Quests.CreatureOfFenkenstrain()); //69
            questList.Add(Quests.RovingElves()); //70
            questList.Add(Quests.GhostsAhoy()); //71
            questList.Add(Quests.OneSmallFavour()); //72
            questList.Add(Quests.MountainDaughter()); //73
            questList.Add(Quests.BetweenARock()); //74
            questList.Add(Quests.TheFeud()); //75
            questList.Add(Quests.TheGolem()); //76
            questList.Add(Quests.DesertTreasure()); //77
            questList.Add(Quests.IcthlarinsLittleHelper()); //78
            questList.Add(Quests.TearsOfGuthix()); //79
            questList.Add(Quests.ZogreFleshEaters()); //80
            questList.Add(Quests.TheLostTribe()); //81
            questList.Add(Quests.TheGiantDwarf()); //82
            questList.Add(Quests.RecruitmentDrive()); //83
            questList.Add(Quests.MourningsEndsPartI()); //84
            questList.Add(Quests.ForgettableTale()); //85
            questList.Add(Quests.GardenOfTranquillity()); //86
            questList.Add(Quests.ATailOfTwoCats()); //87
            questList.Add(Quests.Wanted()); //88
            questList.Add(Quests.MourningsEndsPartII()); //89
            questList.Add(Quests.RumDeal()); //90
            questList.Add(Quests.ShadowOfTheStorm()); //91
            questList.Add(Quests.MakingHistory()); //92
            questList.Add(Quests.Ratcatchers()); //93
            questList.Add(Quests.SpiritsOfTheElid()); //94
            questList.Add(Quests.DeviousMinds()); //95
            questList.Add(Quests.TheHandInTheSand()); //96
            questList.Add(Quests.EnakhrasLament()); //97
            questList.Add(Quests.CabinFever()); //98
            questList.Add(Quests.FairyTaleIGrowingPains()); //99
            questList.Add(Quests.RecipeForDisaster()); //100
            questList.Add(Quests.RFD_AnotherCooksQuest()); //100.1
            questList.Add(Quests.RFD_FreeingTheMountainDwarf()); //100.2
            questList.Add(Quests.RFD_FreeingTheGoblinGenerals()); //100.3
            questList.Add(Quests.RFD_FreeingPiratePete()); //100.4
            questList.Add(Quests.RFD_FreeingTheLumbridgeGuide()); //100.5
            questList.Add(Quests.RFD_FreeingEvilDave()); //100.6
            questList.Add(Quests.RFD_FreeingKingAwowogei()); //100.7
            questList.Add(Quests.RFD_FreeingSirAmikVarze()); //100.8
            questList.Add(Quests.RFD_FreeingSkrachUglogwee()); //100.9
            questList.Add(Quests.RFD_DefeatingTheCulinaromancer()); //100.10
            questList.Add(Quests.InAidOfTheMyreque()); //101
            questList.Add(Quests.ASoulsBane()); //102
            questList.Add(Quests.RagAndBoneMan()); //103
            questList.Add(Quests.RagAndBoneManII()); //104
            questList.Add(Quests.SwanSong()); //105
            questList.Add(Quests.RoyalTrouble()); //106
            questList.Add(Quests.DeathToTheDorgeshuun()); //107
            questList.Add(Quests.FairyTaleIICureAQueen()); //108
            questList.Add(Quests.LunarDiplomacy()); //109
            questList.Add(Quests.TheEyesOfGlouphrie()); //110
            questList.Add(Quests.DarknessOfHallowvale()); //111
            questList.Add(Quests.TheSlugMenace()); //112
            questList.Add(Quests.ElementalWorkshopII()); //113
            questList.Add(Quests.MyArmsBigAdventure()); //114
            questList.Add(Quests.EnlightenedJourney()); //115
            questList.Add(Quests.EaglesPeak()); //116
            questList.Add(Quests.AnimalMagnetism()); //117
            questList.Add(Quests.Contact()); //118
            questList.Add(Quests.ColdWar()); //119
            questList.Add(Quests.TheFremennikIsles()); //120
            questList.Add(Quests.TowerOfLife()); //121
            questList.Add(Quests.TheGreatBrainRobbery()); //122
            questList.Add(Quests.WhatLiesBelow()); //123
            questList.Add(Quests.OlafsQuest()); //124
            questList.Add(Quests.AnotherSliceOfHAM()); //125
            questList.Add(Quests.DreamMentor()); //126
            questList.Add(Quests.GrimTales()); //127
            questList.Add(Quests.KingsRansom()); //128
            questList.Add(Quests.MonkeyMadnessII()); //129
            questList.Add(Quests.MisthalinMystery()); //130
            questList.Add(Quests.ClientOfKourend()); //131
            questList.Add(Quests.BoneVoyage()); //132
            questList.Add(Quests.TheQueenOfThieves()); //133
            questList.Add(Quests.TheDepthsOfDespair()); //134
            questList.Add(Quests.DragonSlayerII()); //135
            questList.Add(Quests.TheCorsairCurse()); //136
            questList.Add(Quests.TaleOfTheRighteous()); //137
            questList.Add(Quests.ATasteOfHope()); //138
            questList.Add(Quests.MakingFriendsWithMyArm()); //139
            questList.Add(Quests.TheForsakenTower()); //140
            questList.Add(Quests.TheAscentOfArceuus()); //141
            questList.Add(Quests.XMarksTheSpot()); //142


            foreach (Quest q in questList)
            {
                questListView.Items.Add(q.questName);
            }

            //questListView.Columns[0].ListView.Font = new Font(questListView.Columns[0].ListView.Font, FontStyle.Bold);

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
            osrsPlayer.playerSkills.Add(new Skill("Combat", osrsPlayer.calculateCombatLevel()));


            loginCompleted = true;
            osrsPlayer.calculateCombatLevel();
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

        private string determineSkillEligibility(Quest quest)
        {


            string eligible = "true";
            Console.WriteLine(quest.questName);
            foreach (Skill s in quest.questSkills)
            {
                int skillLevel = (Skill.getLevel(osrsPlayer.playerSkills, s.skillName));
                Console.WriteLine(s.skillName + " Level : " + skillLevel);
                if (skillLevel < s.level)
                {
                    if (skillLevel < s.boostlevel)
                    {
                        eligible = "false";
                    }
                    else
                    {
                        eligible = "boost";
                    }
                }
            }
            
            return eligible;
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
                        string skillEligibility = determineSkillEligibility(q);
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
                Console.WriteLine(txt);

                Quest q = Quest.findQuest(questList, questListView.SelectedItems[0].Text);

                if (q.completed == false)
                {
                    q.completed = true;
                    Console.WriteLine("Mark as Completed");
                    //Activate all the prerequisites
                    foreach(Quest qu in q.requiredQuests)
                    {
                        Quest.findQuest(questList, qu.questName).completed = true;
                    }
                }
                else
                {
                    q.completed = false;
                    Console.WriteLine("Mark as NOT Completed");
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
            osrsPlayer.updateSkillLevel("Combat", osrsPlayer.calculateCombatLevel());
            updateAfterLogin();
        }

        private void UpDown_Hitpoints_ValueChanged(object sender, EventArgs e)
        {
            osrsPlayer.updateSkillLevel("Hitpoints", Convert.ToInt32(UpDown_Hitpoints.Value));
            osrsPlayer.updateSkillLevel("Combat", osrsPlayer.calculateCombatLevel());
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
            osrsPlayer.updateSkillLevel("Combat", osrsPlayer.calculateCombatLevel());
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
            osrsPlayer.updateSkillLevel("Combat", osrsPlayer.calculateCombatLevel());
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
            osrsPlayer.updateSkillLevel("Combat", osrsPlayer.calculateCombatLevel());
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
            osrsPlayer.updateSkillLevel("Combat", osrsPlayer.calculateCombatLevel());
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
            osrsPlayer.updateSkillLevel("Combat", osrsPlayer.calculateCombatLevel());
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
    }
}
