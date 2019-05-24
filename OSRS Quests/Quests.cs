using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSRS_Quests
{
    static class Quests
    {
        static public Quest CooksAssisstant()
        {
            int number = 1;
            string name = "Cook's Assisstant";
            List<Skill> questSkills = new List<Skill>();
            List<Boolean> boostsAllowed = new List<Boolean>();
            List<String> requiredQuests = new List<String>();
            return new Quest(number, name, questSkills, boostsAllowed, requiredQuests);
        }

        static public Quest DemonSlayer()
        {
            int number = 2;
            string name = "Demon Slayer";
            List<Skill> questSkills = new List<Skill>();
            List<Boolean> boostsAllowed = new List<Boolean>();
            List<String> requiredQuests = new List<String>();
            return new Quest(number, name, questSkills, boostsAllowed, requiredQuests);
        }

        static public Quest TheRestlessGhost()
        {
            int number = 3;
            string name = "The Restless Ghost";
            List<Skill> questSkills = new List<Skill>();
            List<Boolean> boostsAllowed = new List<Boolean>();
            List<String> requiredQuests = new List<String>();
            return new Quest(number, name, questSkills, boostsAllowed, requiredQuests);
        }

        static public Quest RomeoAndJuliet()
        {
            int number = 4;
            string name = "Romeo And Juliet";
            List<Skill> questSkills = new List<Skill>();
            List<Boolean> boostsAllowed = new List<Boolean>();
            List<String> requiredQuests = new List<String>();
            return new Quest(number, name, questSkills, boostsAllowed, requiredQuests);
        }


        static public Quest SheepShearer()
        {
            int number = 5;
            string name = "Sheep Shearer";
            List<Skill> questSkills = new List<Skill>();
            List<Boolean> boostsAllowed = new List<Boolean>();
            List<String> requiredQuests = new List<String>();
            return new Quest(number, name, questSkills, boostsAllowed, requiredQuests);
        }

        static public Quest ShieldOfArrav()
        {
            int number = 6;
            string name = "Shield Of Arrav";
            List<Skill> questSkills = new List<Skill>();
            List<Boolean> boostsAllowed = new List<Boolean>();
            List<String> requiredQuests = new List<String>();
            return new Quest(number, name, questSkills, boostsAllowed, requiredQuests);
        }

        static public Quest ErnestTheChicken()
        {
            int number = 7;
            string name = "Ernest The Chicken";
            List<Skill> questSkills = new List<Skill>();
            List<Boolean> boostsAllowed = new List<Boolean>();
            List<String> requiredQuests = new List<String>();
            return new Quest(number, name, questSkills, boostsAllowed, requiredQuests);
        }

        static public Quest VampireSlayer()
        {
            int number = 8;
            string name = "Vampire Slayer";
            List<Skill> questSkills = new List<Skill>();
            List<Boolean> boostsAllowed = new List<Boolean>();
            List<String> requiredQuests = new List<String>();
            return new Quest(number, name, questSkills, boostsAllowed, requiredQuests);
        }


        static public Quest ImpCatcher()
        {
            int number = 9;
            string name = "Imp Catcher";
            List<Skill> questSkills = new List<Skill>();
            List<Boolean> boostsAllowed = new List<Boolean>();
            List<String> requiredQuests = new List<String>();
            return new Quest(number, name, questSkills, boostsAllowed, requiredQuests);
        }

        static public Quest PriceAliRescue()
        {
            int number = 10;
            string name = "Price Ali Rescue";
            List<Skill> questSkills = new List<Skill>();
            List<Boolean> boostsAllowed = new List<Boolean>();
            List<String> requiredQuests = new List<String>();
            return new Quest(number, name, questSkills, boostsAllowed, requiredQuests);
        }

        static public Quest DoricsQuest()
        {
            int number = 11;
            string name = "Doric's Quest";
            List<Skill> questSkills = new List<Skill>();
            List<Boolean> boostsAllowed = new List<Boolean>();
            List<String> requiredQuests = new List<String>();
            return new Quest(number, name, questSkills, boostsAllowed, requiredQuests);
        }

        static public Quest BlackKnightsFortress()
        {
            int number = 12;
            string name = "Black Knight's Fortress";
            List<Skill> questSkills = new List<Skill>()
            {
                new Skill("QuestPoints", 20)
            };
                 //Need to add a check for quest points, and add a quest point value to each quest
            List<Boolean> boostsAllowed = new List<Boolean>();
            List<String> requiredQuests = new List<String>();
            return new Quest(number, name, questSkills, boostsAllowed, requiredQuests);
        }

        static public Quest WitchsPotion()
        {
            int number = 13;
            string name = "Witch's Potion";
            List<Skill> questSkills = new List<Skill>();
            List<Boolean> boostsAllowed = new List<Boolean>();
            List<String> requiredQuests = new List<String>();
            return new Quest(number, name, questSkills, boostsAllowed, requiredQuests);
        }

        static public Quest TheKnightsSword()
        {
            int number = 14;
            string name = "The Knight's Sword";
            List<Skill> questSkills = new List<Skill>()
            {
                new Skill("Mining", 20)
            };
            List<Boolean> boostsAllowed = new List<Boolean>();
            List<String> requiredQuests = new List<String>();
            return new Quest(number, name, questSkills, boostsAllowed, requiredQuests);
        }

        static public Quest GoblinDiplomacy()
        {
            int number = 15;
            string name = "GoblinDiplomacy";
            List<Skill> questSkills = new List<Skill>();
            List<Boolean> boostsAllowed = new List<Boolean>();
            List<String> requiredQuests = new List<String>();
            return new Quest(number, name, questSkills, boostsAllowed, requiredQuests);
        }

        static public Quest PiratesTreasure()
        {
            int number = 16;
            string name = "Pirate's Treasure";
            List<Skill> questSkills = new List<Skill>();
            List<Boolean> boostsAllowed = new List<Boolean>();
            List<String> requiredQuests = new List<String>();
            return new Quest(number, name, questSkills, boostsAllowed, requiredQuests);
        }

        static public Quest DragonSlayer()
        {
            int number = 17;
            string name = "Dragon Slayer";
            List<Skill> questSkills = new List<Skill>()
            {
                new Skill("QuestPoints", 32),
                new Skill("Crafting", 8)
            };
            List<Boolean> boostsAllowed = new List<Boolean>();
            List<String> requiredQuests = new List<String>();
            return new Quest(number, name, questSkills, boostsAllowed, requiredQuests);
        }
    }
}
