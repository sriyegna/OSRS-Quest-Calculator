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
            double number = 1;
            string name = "Cook's Assisstant";
            List<Skill> questSkills = new List<Skill>();
            List<Quest> requiredQuests = new List<Quest>();
            int questPointValue = 1;
            return new Quest(number, name, questSkills, requiredQuests, questPointValue);
        }

        static public Quest DemonSlayer()
        {
            double number = 2;
            string name = "Demon Slayer";
            List<Skill> questSkills = new List<Skill>();
            List<Quest> requiredQuests = new List<Quest>();
            int questPointValue = 3;
            return new Quest(number, name, questSkills, requiredQuests, questPointValue);
        }

        static public Quest TheRestlessGhost()
        {
            double number = 3;
            string name = "The Restless Ghost";
            List<Skill> questSkills = new List<Skill>();
            List<Quest> requiredQuests = new List<Quest>();
            int questPointValue = 1;
            return new Quest(number, name, questSkills, requiredQuests, questPointValue);
        }

        static public Quest RomeoAndJuliet()
        {
            double number = 4;
            string name = "Romeo And Juliet";
            List<Skill> questSkills = new List<Skill>();
            List<Quest> requiredQuests = new List<Quest>();
            int questPointValue = 5;
            return new Quest(number, name, questSkills, requiredQuests, questPointValue);
        }


        static public Quest SheepShearer()
        {
            double number = 5;
            string name = "Sheep Shearer";
            List<Skill> questSkills = new List<Skill>();
            List<Quest> requiredQuests = new List<Quest>();
            int questPointValue = 1;
            return new Quest(number, name, questSkills, requiredQuests, questPointValue);
        }

        static public Quest ShieldOfArrav()
        {
            double number = 6;
            string name = "Shield Of Arrav";
            List<Skill> questSkills = new List<Skill>();
            List<Quest> requiredQuests = new List<Quest>();
            int questPointValue = 1;
            return new Quest(number, name, questSkills, requiredQuests, questPointValue);
        }

        static public Quest ErnestTheChicken()
        {
            double number = 7;
            string name = "Ernest The Chicken";
            List<Skill> questSkills = new List<Skill>();
            List<Quest> requiredQuests = new List<Quest>();
            int questPointValue = 4;
            return new Quest(number, name, questSkills, requiredQuests, questPointValue);
        }

        static public Quest VampireSlayer()
        {
            double number = 8;
            string name = "Vampire Slayer";
            List<Skill> questSkills = new List<Skill>();
            List<Quest> requiredQuests = new List<Quest>();
            int questPointValue = 3;
            return new Quest(number, name, questSkills, requiredQuests, questPointValue);
        }


        static public Quest ImpCatcher()
        {
            double number = 9;
            string name = "Imp Catcher";
            List<Skill> questSkills = new List<Skill>();
            List<Quest> requiredQuests = new List<Quest>();
            int questPointValue = 1;
            return new Quest(number, name, questSkills, requiredQuests, questPointValue);
        }

        static public Quest PriceAliRescue()
        {
            double number = 10;
            string name = "Price Ali Rescue";
            List<Skill> questSkills = new List<Skill>();
            List<Quest> requiredQuests = new List<Quest>();
            int questPointValue = 3;
            return new Quest(number, name, questSkills, requiredQuests, questPointValue);
        }

        static public Quest DoricsQuest()
        {
            double number = 11;
            string name = "Doric's Quest";
            List<Skill> questSkills = new List<Skill>();
            List<Quest> requiredQuests = new List<Quest>();
            int questPointValue = 1;
            return new Quest(number, name, questSkills, requiredQuests, questPointValue);
        }

        static public Quest BlackKnightsFortress()
        {
            double number = 12;
            string name = "Black Knight's Fortress";
            List<Skill> questSkills = new List<Skill>()
            {
                new Skill("QuestPoints", 12)
            };
            //Need to add a check for quest points, and add a quest point value to each quest
            List<Quest> requiredQuests = new List<Quest>();
            int questPointValue = 3;
            return new Quest(number, name, questSkills, requiredQuests, questPointValue);
        }

        static public Quest WitchsPotion()
        {
            double number = 13;
            string name = "Witch's Potion";
            List<Skill> questSkills = new List<Skill>();
            List<Quest> requiredQuests = new List<Quest>();
            int questPointValue = 1;
            return new Quest(number, name, questSkills, requiredQuests, questPointValue);
        }

        static public Quest TheKnightsSword()
        {
            double number = 14;
            string name = "The Knight's Sword";
            List<Skill> questSkills = new List<Skill>()
            {
                new Skill("Mining", 10)
            };
            List<Quest> requiredQuests = new List<Quest>();
            int questPointValue = 1;
            return new Quest(number, name, questSkills, requiredQuests, questPointValue);
        }

        static public Quest GoblinDiplomacy()
        {
            double number = 15;
            string name = "GoblinDiplomacy";
            List<Skill> questSkills = new List<Skill>();
            List<Quest> requiredQuests = new List<Quest>();
            int questPointValue = 5;
            return new Quest(number, name, questSkills, requiredQuests, questPointValue);
        }

        static public Quest PiratesTreasure()
        {
            double number = 16;
            string name = "Pirate's Treasure";
            List<Skill> questSkills = new List<Skill>();
            List<Quest> requiredQuests = new List<Quest>();
            int questPointValue = 2;
            return new Quest(number, name, questSkills, requiredQuests, questPointValue);
        }

        static public Quest DragonSlayer()
        {
            double number = 17;
            string name = "Dragon Slayer";
            List<Skill> questSkills = new List<Skill>()
            {
                new Skill("QuestPoints", 32)
            };
            List<Quest> requiredQuests = new List<Quest>();
            int questPointValue = 2;
            return new Quest(number, name, questSkills, requiredQuests, questPointValue);
        }

        static public Quest DruidicRitual()
        {
            double number = 18;
            string name = "Druidic Ritual";
            List<Skill> questSkills = new List<Skill>();
            List<Quest> requiredQuests = new List<Quest>();
            int questPointValue = 4;
            return new Quest(number, name, questSkills, requiredQuests, questPointValue);
        }

        static public Quest LostCity()
        {
            double number = 19;
            string name = "Lost City";
            List<Skill> questSkills = new List<Skill>()
            {
                new Skill("Crafting", 31),
                new Skill("Woodcutting", 36)
            };
            List<Quest> requiredQuests = new List<Quest>();
            int questPointValue = 3;
            return new Quest(number, name, questSkills, requiredQuests, questPointValue);
        }

        static public Quest WitchsHouse()
        {
            double number = 18;
            string name = "Witch's House";
            List<Skill> questSkills = new List<Skill>();
            List<Quest> requiredQuests = new List<Quest>();
            int questPointValue = 4;
            return new Quest(number, name, questSkills, requiredQuests, questPointValue);
        }

        static public Quest MerlinsCrystal()
        {
            double number = 21;
            string name = "Merlin's Crystal";
            List<Skill> questSkills = new List<Skill>();
            List<Quest> requiredQuests = new List<Quest>();
            int questPointValue = 6;
            return new Quest(number, name, questSkills, requiredQuests, questPointValue);
        }

        static public Quest HeroesQuest()
        {
            double number = 22;
            string name = "Heroes' Quest";
            List<Skill> questSkills = new List<Skill>()
            {
                new Skill("QuestPoints", 55),
                new Skill("Cooking", 53, 48),
                new Skill("Fishing", 53, 48),
                new Skill("Herblore", 25, 20),
                new Skill("Mining", 50, 48),
            };
            List<Quest> requiredQuests = new List<Quest>()
            {
                new Quest("Shield Of Arrav"),
                new Quest("Lost City"),
                new Quest("Merlin's Crystal"),
                new Quest("Dragon Slayer"),
                new Quest("Druidic Ritual"),
            };
            int questPointValue = 1;
            return new Quest(number, name, questSkills, requiredQuests, questPointValue);
        }

        static public Quest ScorpionCatcher()
        {
            double number = 23;
            string name = "Scorpion Catcher";
            List<Skill> questSkills = new List<Skill>()
            {
                new Skill("Prayer", 31)
            };
            List<Quest> requiredQuests = new List<Quest>();
            int questPointValue = 1;
            return new Quest(number, name, questSkills, requiredQuests, questPointValue);
        }

        static public Quest FamilyCrest()
        {
            double number = 24;
            string name = "Family Crest";
            List<Skill> questSkills = new List<Skill>()
            {
                new Skill("Mining", 40),
                new Skill("Smithing", 40),
                new Skill("Magic", 59),
                new Skill("Crafting", 40)
            };
            List<Quest> requiredQuests = new List<Quest>();
            int questPointValue = 1;
            return new Quest(number, name, questSkills, requiredQuests, questPointValue);
        }

        static public Quest TribalTotem()
        {
            double number = 25;
            string name = "Tribal Totem";
            List<Skill> questSkills = new List<Skill>()
            {
                new Skill("Thieving", 21)
            };
            List<Quest> requiredQuests = new List<Quest>();
            int questPointValue = 1;
            return new Quest(number, name, questSkills, requiredQuests, questPointValue);
        }

        static public Quest FishingContest()
        {
            double number = 26;
            string name = "Fishing Contest";
            List<Skill> questSkills = new List<Skill>()
            {
                new Skill("Fishing", 10)
            };
            List<Quest> requiredQuests = new List<Quest>();
            int questPointValue = 1;
            return new Quest(number, name, questSkills, requiredQuests, questPointValue);
        }

        static public Quest MonksFriend()
        {
            double number = 27;
            string name = "Monk's Friend";
            List<Skill> questSkills = new List<Skill>();
            List<Quest> requiredQuests = new List<Quest>();
            int questPointValue = 1;
            return new Quest(number, name, questSkills, requiredQuests, questPointValue);
        }

        static public Quest TempleOfIkov()
        {
            double number = 28;
            string name = "Temple Of Ikov";
            List<Skill> questSkills = new List<Skill>()
            {
                new Skill("Thieving", 42, 37),
                new Skill("Ranged", 40)
            };
            List<Quest> requiredQuests = new List<Quest>();
            int questPointValue = 1;
            return new Quest(number, name, questSkills, requiredQuests, questPointValue);
        }

        static public Quest ClockTower()
        {
            double number = 29;
            string name = "Clock Tower";
            List<Skill> questSkills = new List<Skill>();
            List<Quest> requiredQuests = new List<Quest>();
            int questPointValue = 1;
            return new Quest(number, name, questSkills, requiredQuests, questPointValue);
        }

        static public Quest HolyGrail()
        {
            double number = 30;
            string name = "Holy Grail";
            List<Skill> questSkills = new List<Skill>()
            {
                new Skill("Attack", 20)
            };
            List<Quest> requiredQuests = new List<Quest>()
            {
                new Quest("Merlin's Crystal")
            };
            int questPointValue = 2;
            return new Quest(number, name, questSkills, requiredQuests, questPointValue);
        }

        static public Quest TreeGnomeVillage()
        {
            double number = 31;
            string name = "Tree Gnome Village";
            List<Skill> questSkills = new List<Skill>();
            List<Quest> requiredQuests = new List<Quest>();
            int questPointValue = 2;
            return new Quest(number, name, questSkills, requiredQuests, questPointValue);
        }

        static public Quest FightArena()
        {
            double number = 32;
            string name = "Fight Arena";
            List<Skill> questSkills = new List<Skill>();
            List<Quest> requiredQuests = new List<Quest>();
            int questPointValue = 2;
            return new Quest(number, name, questSkills, requiredQuests, questPointValue);
        }

        static public Quest HazeelCult()
        {
            double number = 33;
            string name = "Hazeel Cult";
            List<Skill> questSkills = new List<Skill>();
            List<Quest> requiredQuests = new List<Quest>();
            int questPointValue = 1;
            return new Quest(number, name, questSkills, requiredQuests, questPointValue);
        }

        static public Quest SheepHerder()
        {
            double number = 34;
            string name = "Sheep Herder";
            List<Skill> questSkills = new List<Skill>();
            List<Quest> requiredQuests = new List<Quest>();
            int questPointValue = 4;
            return new Quest(number, name, questSkills, requiredQuests, questPointValue);
        }

        static public Quest PlagueCity()
        {
            double number = 35;
            string name = "Plague City";
            List<Skill> questSkills = new List<Skill>();
            List<Quest> requiredQuests = new List<Quest>();
            int questPointValue = 1;
            return new Quest(number, name, questSkills, requiredQuests, questPointValue);
        }

        static public Quest SeaSlug()
        {
            double number = 36;
            string name = "Sea Slug";
            List<Skill> questSkills = new List<Skill>()
            {
                new Skill("Firemaking", 30)
            };
            List<Quest> requiredQuests = new List<Quest>();
            int questPointValue = 1;
            return new Quest(number, name, questSkills, requiredQuests, questPointValue);
        }

        static public Quest WaterfallQuest()
        {
            double number = 37;
            string name = "Waterfall Quest";
            List<Skill> questSkills = new List<Skill>();
            List<Quest> requiredQuests = new List<Quest>();
            int questPointValue = 1;
            return new Quest(number, name, questSkills, requiredQuests, questPointValue);
        }

        static public Quest Biohazard()
        {
            double number = 38;
            string name = "Biohazard";
            List<Skill> questSkills = new List<Skill>();
            List<Quest> requiredQuests = new List<Quest>()
            {
                new Quest("Plague City")
            };
            int questPointValue = 3;
            return new Quest(number, name, questSkills, requiredQuests, questPointValue);
        }

        static public Quest JunglePotion()
        {
            double number = 39;
            string name = "Jungle Potion";
            List<Skill> questSkills = new List<Skill>()
            {
                new Skill("Herblore", 3)
            };
            List<Quest> requiredQuests = new List<Quest>()
            {
                new Quest("Druidic Ritual")
            };
            int questPointValue = 1;
            return new Quest(number, name, questSkills, requiredQuests, questPointValue);
        }

        static public Quest TheGrandTree()
        {
            double number = 40;
            string name = "The Grand Tree";
            List<Skill> questSkills = new List<Skill>()
            {
                new Skill("Agility", 25, 20)
            };
            List<Quest> requiredQuests = new List<Quest>();
            int questPointValue = 5;
            return new Quest(number, name, questSkills, requiredQuests, questPointValue);
        }

        static public Quest ShiloVillage()
        {
            double number = 41;
            string name = "Shilo Village";
            List<Skill> questSkills = new List<Skill>()
            {
                new Skill("Crafting", 20),
                new Skill("Agility", 32, 27)
            };
            List<Quest> requiredQuests = new List<Quest>()
            {
                new Quest("Jungle Potion")
            };
            int questPointValue = 2;
            return new Quest(number, name, questSkills, requiredQuests, questPointValue);
        }

        static public Quest UndergroundPass()
        {
            double number = 42;
            string name = "Underground Pass";
            List<Skill> questSkills = new List<Skill>()
            {
                new Skill("Ranged", 25)
            };
            List<Quest> requiredQuests = new List<Quest>()
            {
                new Quest("Biohazard"),
                new Quest("Plague City")
            };
            int questPointValue = 5;
            return new Quest(number, name, questSkills, requiredQuests, questPointValue);
        }

        static public Quest ObservatoryQuest()
        {
            double number = 43;
            string name = "Observatory Quest";
            List<Skill> questSkills = new List<Skill>()
            {
                new Skill("Crafting", 10)
            };
            List<Quest> requiredQuests = new List<Quest>();
            int questPointValue = 2;
            return new Quest(number, name, questSkills, requiredQuests, questPointValue);
        }

        static public Quest TheTouristTrap()
        {
            double number = 44;
            string name = "The Tourist Trap";
            List<Skill> questSkills = new List<Skill>()
            {
                new Skill("Fletching", 10),
                new Skill("Smithing", 20)
            };
            List<Quest> requiredQuests = new List<Quest>();
            int questPointValue = 2;
            return new Quest(number, name, questSkills, requiredQuests, questPointValue);
        }

        static public Quest Watchtower()
        {
            double number = 45;
            string name = "Watchtower";
            List<Skill> questSkills = new List<Skill>()
            {
                new Skill("Magic", 15),
                new Skill("Thieving", 15),
                new Skill("Agility", 25),
                new Skill("Herblore", 14),
                new Skill("Mining", 40)
            };
            List<Quest> requiredQuests = new List<Quest>();
            int questPointValue = 4;
            return new Quest(number, name, questSkills, requiredQuests, questPointValue);
        }

        static public Quest DwarfCannon()
        {
            double number = 46;
            string name = "Dwarf Cannon";
            List<Skill> questSkills = new List<Skill>();
            List<Quest> requiredQuests = new List<Quest>();
            int questPointValue = 1;
            return new Quest(number, name, questSkills, requiredQuests, questPointValue);
        }

        static public Quest MurderMystery()
        {
            double number = 47;
            string name = "Murder Mystery";
            List<Skill> questSkills = new List<Skill>();
            List<Quest> requiredQuests = new List<Quest>();
            int questPointValue = 3;
            return new Quest(number, name, questSkills, requiredQuests, questPointValue);
        }

        static public Quest TheDigSite()
        {
            double number = 48;
            string name = "The Dig Site";
            List<Skill> questSkills = new List<Skill>()
            {
                new Skill("Agility", 10),
                new Skill("Herblore", 10),
                new Skill("Thieving", 25)
            };
            List<Quest> requiredQuests = new List<Quest>()
            {
                new Quest("Druidic Ritual")
            };
            int questPointValue = 2;
            return new Quest(number, name, questSkills, requiredQuests, questPointValue);
        }

        static public Quest GertrudesCat()
        {
            double number = 49;
            string name = "Gertrude's Cat";
            List<Skill> questSkills = new List<Skill>();
            List<Quest> requiredQuests = new List<Quest>();
            int questPointValue = 1;
            return new Quest(number, name, questSkills, requiredQuests, questPointValue);
        }

        static public Quest LegendsQuest()
        {
            double number = 50;
            string name = "Legends' Quest";
            List<Skill> questSkills = new List<Skill>()
            {
                new Skill("QuestPoints", 107),
                new Skill("Agility", 50, 45),
                new Skill("Crafting", 50),
                new Skill("Herblore", 45, 41),
                new Skill("Magic", 56),
                new Skill("Mining", 52, 47),
                new Skill("Prayer", 42, 37),
                new Skill("Smithing", 50, 5),
                new Skill("Strength", 50, 40),
                new Skill("Thieving", 50),
                new Skill("Woodcutting", 50, 45),
            };
            List<Quest> requiredQuests = new List<Quest>()
            {
                new Quest("Family Crest"),
                new Quest("Heroes' Quest"),
                new Quest("Shield Of Arrav"),
                new Quest("Lost City"),
                new Quest("Merlin's Crystal"),
                new Quest("Dragon Slayer"),
                new Quest("Shilo Village"),
                new Quest("Jungle Potion"),
                new Quest("Druidic Ritual"),
                new Quest("Underground Pass"),
                new Quest("Biohazard"),
                new Quest("Plague City"),
                new Quest("Waterfall Quest")
            };
            int questPointValue = 4;
            return new Quest(number, name, questSkills, requiredQuests, questPointValue);
        }

        static public Quest RuneMysteries()
        {
            double number = 51;
            string name = "Rune Mysteries";
            List<Skill> questSkills = new List<Skill>();
            List<Quest> requiredQuests = new List<Quest>();
            int questPointValue = 1;
            return new Quest(number, name, questSkills, requiredQuests, questPointValue);
        }

        static public Quest BigChompyBirdHunting()
        {
            double number = 52;
            string name = "Big Chompy Bird Hunting";
            List<Skill> questSkills = new List<Skill>()
            {
                new Skill("Fletching", 5),
                new Skill("Cooking", 30),
                new Skill("Ranged", 30)
            };
            List<Quest> requiredQuests = new List<Quest>();
            int questPointValue = 2;
            return new Quest(number, name, questSkills, requiredQuests, questPointValue);
        }

        static public Quest ElementalWorkshopI()
        {
            double number = 53;
            string name = "Elemental Workshop I";
            List<Skill> questSkills = new List<Skill>()
            {
                new Skill("Mining", 20),
                new Skill("Smithing", 20),
                new Skill("Crafting", 20)
            };
            List<Quest> requiredQuests = new List<Quest>();
            int questPointValue = 1;
            return new Quest(number, name, questSkills, requiredQuests, questPointValue);
        }

        static public Quest PriestInPeril()
        {
            double number = 54;
            string name = "Priest In Peril";
            List<Skill> questSkills = new List<Skill>();
            List<Quest> requiredQuests = new List<Quest>();
            int questPointValue = 1;
            return new Quest(number, name, questSkills, requiredQuests, questPointValue);
        }

        static public Quest NatureSpirit()
        {
            double number = 55;
            string name = "Nature Spirit";
            List<Skill> questSkills = new List<Skill>();
            List<Quest> requiredQuests = new List<Quest>()
            {
                new Quest("Priest In Peril"),
                new Quest("The Restless Ghost")
            };
            int questPointValue = 2;
            return new Quest(number, name, questSkills, requiredQuests, questPointValue);
        }

        static public Quest DeathPlateau()
        {
            double number = 56;
            string name = "Death Plateau";
            List<Skill> questSkills = new List<Skill>();
            List<Quest> requiredQuests = new List<Quest>();
            int questPointValue = 1;
            return new Quest(number, name, questSkills, requiredQuests, questPointValue);
        }

        static public Quest TrollStronghold()
        {
            double number = 57;
            string name = "Troll Stronghold";
            List<Skill> questSkills = new List<Skill>()
            {
                new Skill("Agility", 15)
            };
            List<Quest> requiredQuests = new List<Quest>()
            {
                new Quest("Death Plateau")
            };
            int questPointValue = 1;
            return new Quest(number, name, questSkills, requiredQuests, questPointValue);
        }

        static public Quest TaiBwoWannaiTrio()
        {
            double number = 58;
            string name = "Tai Bwo Wannai Trio";
            List<Skill> questSkills = new List<Skill>()
            {
                new Skill("Agility", 15),
                new Skill("Cooking", 30),
                new Skill("Fishing", 5)
            };
            List<Quest> requiredQuests = new List<Quest>()
            {
                new Quest("Jungle Potion")
            };
            int questPointValue = 2;
            return new Quest(number, name, questSkills, requiredQuests, questPointValue);
        }

        static public Quest Regicide()
        {
            double number = 59;
            string name = "Regicide";
            List<Skill> questSkills = new List<Skill>()
            {
                new Skill("Agility", 56, 51)
            };
            List<Quest> requiredQuests = new List<Quest>()
            {
                new Quest("Underground Pass"),
                new Quest("Biohazard"),
                new Quest("Plague City")
            };
            int questPointValue = 3;
            return new Quest(number, name, questSkills, requiredQuests, questPointValue);
        }

        static public Quest EadgarsRuse()
        {
            double number = 60;
            string name = "Eadgar's Ruse";
            List<Skill> questSkills = new List<Skill>()
            {
                new Skill("Herblore", 31, 26),
                new Skill("Agility", 44)
            };
            List<Quest> requiredQuests = new List<Quest>()
            {
                new Quest("Druidic Ritual"),
                new Quest("Troll Stronghold"),
                new Quest("Death Plateau")
            };
            int questPointValue = 1;
            return new Quest(number, name, questSkills, requiredQuests, questPointValue);
        }

        static public Quest ShadesOfMortton()
        {
            double number = 61;
            string name = "Shades Of Mort'ton";
            List<Skill> questSkills = new List<Skill>()
            {
                new Skill("Crafting", 20),
                new Skill("Herblore", 15),
                new Skill("Firemaking", 5)
            };
            List<Quest> requiredQuests = new List<Quest>()
            {
                new Quest("Priest In Peril")
            };
            int questPointValue = 3;
            return new Quest(number, name, questSkills, requiredQuests, questPointValue);
        }

        static public Quest TheFremennikTrials()
        {
            double number = 62;
            string name = "The Fremennik Trials";
            List<Skill> questSkills = new List<Skill>();
            List<Quest> requiredQuests = new List<Quest>();
            int questPointValue = 3;
            return new Quest(number, name, questSkills, requiredQuests, questPointValue);
        }

        static public Quest HorrorFromTheDeep()
        {
            double number = 63;
            string name = "Horror From The Deep";
            List<Skill> questSkills = new List<Skill>()
            {
                new Skill("Agility", 35, 30)
            };
            List<Quest> requiredQuests = new List<Quest>()
            {
                new Quest("")
            };
            int questPointValue = 2;
            return new Quest(number, name, questSkills, requiredQuests, questPointValue);
        }

        static public Quest ThroneOfMiscellania()
        {
            double number = 64;
            string name = "Throne Of Miscellania";
            List<Skill> questSkills = new List<Skill>()
            {
                new Skill("Woodcutting", 45),
                new Skill("Farming", 10),
                new Skill("Mining", 30),
                new Skill("Fishing", 35)
            };
            List<Quest> requiredQuests = new List<Quest>()
            {
                new Quest("Heroes' Quest"),
                new Quest("The Fremennik Trials")
            };
            int questPointValue = 1;
            return new Quest(number, name, questSkills, requiredQuests, questPointValue);
        }

        static public Quest MonkeyMadnessI()
        {
            double number = 65;
            string name = "Monkey Madness I";
            List<Skill> questSkills = new List<Skill>();
            List<Quest> requiredQuests = new List<Quest>()
            {
                new Quest("The Grand Tree"),
                new Quest("Tree Gnome Village")
            };
            int questPointValue = 3;
            return new Quest(number, name, questSkills, requiredQuests, questPointValue);
        }

        static public Quest HauntedMine()
        {
            double number = 66;
            string name = "Haunted Mine";
            List<Skill> questSkills = new List<Skill>()
            {
                new Skill("Agility", 15),
                new Skill("Crafting", 35)
            };
            List<Quest> requiredQuests = new List<Quest>()
            {
                new Quest("Priest In Peril")
            };
            int questPointValue = 2;
            return new Quest(number, name, questSkills, requiredQuests, questPointValue);
        }

        static public Quest TrollRomance()
        {
            double number = 67;
            string name = "Troll Romance";
            List<Skill> questSkills = new List<Skill>()
            {
                new Skill("Agility", 28)
            };
            List<Quest> requiredQuests = new List<Quest>()
            {
                new Quest("Troll Stronghold"),
                new Quest("Death Plateau")
            };
            int questPointValue = 2;
            return new Quest(number, name, questSkills, requiredQuests, questPointValue);
        }

        static public Quest InSearchOfTheMyreque()
        {
            double number = 68;
            string name = "In Search Of The Myreque";
            List<Skill> questSkills = new List<Skill>()
            {
                new Skill("Agility", 25)
            };
            List<Quest> requiredQuests = new List<Quest>()
            {
                new Quest("Nature Spirit"),
                new Quest("Priest In Peril"),
                new Quest("The Restless Ghost")
            };
            int questPointValue = 2;
            return new Quest(number, name, questSkills, requiredQuests, questPointValue);
        }

        static public Quest CreatureOfFenkenstrain()
        {
            double number = 69;
            string name = "Creature Of Fenkenstrain";
            List<Skill> questSkills = new List<Skill>()
            {
                new Skill("Crafting", 20),
                new Skill("Thieving", 25)
            };
            List<Quest> requiredQuests = new List<Quest>()
            {
                new Quest("Priest In Peril"),
                new Quest("The Restless Ghost")
            };
            int questPointValue = 2;
            return new Quest(number, name, questSkills, requiredQuests, questPointValue);
        }

        static public Quest RovingElves()
        {
            double number = 70;
            string name = "Roving Elves";
            List<Skill> questSkills = new List<Skill>();
            List<Quest> requiredQuests = new List<Quest>()
            {
                new Quest("Regicide"),
                new Quest("Underground Pass"),
                new Quest("Biohazard"),
                new Quest("Plague City"),
                new Quest("Waterfall Quest")
            };
            int questPointValue = 1;
            return new Quest(number, name, questSkills, requiredQuests, questPointValue);
        }

        static public Quest GhostsAhoy()
        {
            double number = 71;
            string name = "Ghosts Ahoy";
            List<Skill> questSkills = new List<Skill>()
            {
                new Skill("Agility", 25, 20),
                new Skill("Cooking", 20),
            };
            List<Quest> requiredQuests = new List<Quest>()
            {
                new Quest("Priest In Peril"),
                new Quest("The Restless Ghost")
            };
            int questPointValue = 2;
            return new Quest(number, name, questSkills, requiredQuests, questPointValue);
        }

        static public Quest OneSmallFavour()
        {
            double number = 72;
            string name = "One Small Favour";
            List<Skill> questSkills = new List<Skill>()
            {
                new Skill("Agility", 36, 31),
                new Skill("Crafting", 25),
                new Skill("Herblore", 18, 13),
                new Skill("Smithing", 30, 25)
            };
            List<Quest> requiredQuests = new List<Quest>()
            {
                new Quest("Rune Mysteries"),
                new Quest("Shilo Village"),
                new Quest("Jungle Potion"),
                new Quest("Druidic Ritual")
            };
            int questPointValue = 2;
            return new Quest(number, name, questSkills, requiredQuests, questPointValue);
        }

        static public Quest MountainDaughter()
        {
            double number = 73;
            string name = "Mountain Daughter";
            List<Skill> questSkills = new List<Skill>()
            {
                new Skill("Agility", 20)
            };
            List<Quest> requiredQuests = new List<Quest>();
            int questPointValue = 2;
            return new Quest(number, name, questSkills, requiredQuests, questPointValue);
        }

        static public Quest BetweenARock()
        {
            double number = 74;
            string name = "Between A Rock...";
            List<Skill> questSkills = new List<Skill>()
            {
                new Skill("Defence", 30),
                new Skill("Mining", 40, 35),
                new Skill("Smithing", 50, 45),
            };
            List<Quest> requiredQuests = new List<Quest>()
            {
                new Quest("Dwarf Cannon"),
                new Quest("Fishing Contest")
            };
            int questPointValue = 2;
            return new Quest(number, name, questSkills, requiredQuests, questPointValue);
        }

        static public Quest TheFeud()
        {
            double number = 75;
            string name = "The Feud";
            List<Skill> questSkills = new List<Skill>()
            {
                new Skill("Thieving", 30)
            };
            List<Quest> requiredQuests = new List<Quest>();
            int questPointValue = 1;
            return new Quest(number, name, questSkills, requiredQuests, questPointValue);
        }

        static public Quest TheGolem()
        {
            double number = 76;
            string name = "The Golem";
            List<Skill> questSkills = new List<Skill>()
            {
                new Skill("Crafting", 20),
                new Skill("Thieving", 25)
            };
            List<Quest> requiredQuests = new List<Quest>();
            int questPointValue = 1;
            return new Quest(number, name, questSkills, requiredQuests, questPointValue);
        }

        static public Quest DesertTreasure()
        {
            double number = 77;
            string name = "Desert Treasure";
            List<Skill> questSkills = new List<Skill>()
            {
                new Skill("Thieving", 53),
                new Skill("Firemaking", 50),
                new Skill("Magic", 50),
            };
            List<Quest> requiredQuests = new List<Quest>()
            {
                new Quest("The Dig Site"),
                new Quest("Druidic Ritual"),
                new Quest("Temple Of Ikov"),
                new Quest("The Tourist Trap"),
                new Quest("Troll Stronghold"),
                new Quest("Death Plateau"),
                new Quest("Priest In Peril"),
                new Quest("Waterfall Quest")
            };
            int questPointValue = 3;
            return new Quest(number, name, questSkills, requiredQuests, questPointValue);
        }

        static public Quest IcthlarinsLittleHelper()
        {
            double number = 78;
            string name = "Icthlarin's Little Helper";
            List<Skill> questSkills = new List<Skill>();
            List<Quest> requiredQuests = new List<Quest>()
            {
                new Quest("Gertrude's Cat")
            };
            int questPointValue = 2;
            return new Quest(number, name, questSkills, requiredQuests, questPointValue);
        }

        static public Quest TearsOfGuthix()
        {
            double number = 79;
            string name = "Tears Of Guthix";
            List<Skill> questSkills = new List<Skill>()
            {
                new Skill("QuestPoints", 43),
                new Skill("Firemaking", 49),
                new Skill("Crafting", 20),
                new Skill("Mining", 20)
            };
            List<Quest> requiredQuests = new List<Quest>();
            int questPointValue = 1;
            return new Quest(number, name, questSkills, requiredQuests, questPointValue);
        }

        static public Quest ZogreFleshEaters()
        {
            double number = 80;
            string name = "Zogre Flesh Eaters";
            List<Skill> questSkills = new List<Skill>()
            {
                new Skill("Smithing", 4),
                new Skill("Herblore", 8),
                new Skill("Ranged", 30)
            };
            List<Quest> requiredQuests = new List<Quest>()
            {
                new Quest("Big Chompy Bird Hunting"),
                new Quest("Jungle Potion"),
                new Quest("Druidic Ritual")
            };
            int questPointValue = 1;
            return new Quest(number, name, questSkills, requiredQuests, questPointValue);
        }

        static public Quest TheLostTribe()
        {
            double number = 81;
            string name = "The Lost Tribe";
            List<Skill> questSkills = new List<Skill>()
            {
                new Skill("Agility", 13),
                new Skill("Thieving", 13),
                new Skill("Mining", 17)
            };
            List<Quest> requiredQuests = new List<Quest>()
            {
                new Quest("Goblin Diplomacy"),
                new Quest("Rune Mysteries")
            };
            int questPointValue = 1;
            return new Quest(number, name, questSkills, requiredQuests, questPointValue);
        }

        static public Quest TheGiantDwarf()
        {
            double number = 82;
            string name = "The Giant Dwarf";
            List<Skill> questSkills = new List<Skill>()
            {
                new Skill("Crafting", 12),
                new Skill("Firemaking", 16),
                new Skill("Magic", 33),
                new Skill("Thieving", 14)
            };
            List<Quest> requiredQuests = new List<Quest>();
            int questPointValue = 2;
            return new Quest(number, name, questSkills, requiredQuests, questPointValue);
        }

        static public Quest RecruitmentDrive()
        {
            double number = 83;
            string name = "Recruitment Drive";
            List<Skill> questSkills = new List<Skill>()
            {
                new Skill("QuestPoints", 12)
            };
            List<Quest> requiredQuests = new List<Quest>()
            {
                new Quest("Black Knights' Fortress"),
                new Quest("Druidic Ritual")
            };
            int questPointValue = 1;
            return new Quest(number, name, questSkills, requiredQuests, questPointValue);
        }

        static public Quest MourningsEndsPartI()
        {
            double number = 84;
            string name = "Mourning's Ends Part I";
            List<Skill> questSkills = new List<Skill>()
            {
                new Skill("Ranged", 60),
                new Skill("Thieving", 50, 45)
            };
            List<Quest> requiredQuests = new List<Quest>()
            {
                new Quest("Roving Elves"),
                new Quest("Regicide"),
                new Quest("Underground Pass"),
                new Quest("Biohazard"),
                new Quest("Plague City"),
                new Quest("Waterfall Quest"),
                new Quest("Big Chompy Bird Hunting"),
                new Quest("Sheep Herder")
            };
            int questPointValue = 2;
            return new Quest(number, name, questSkills, requiredQuests, questPointValue);
        }

        static public Quest ForgettableTale()
        {
            double number = 85;
            string name = "Forgettable Tale...";
            List<Skill> questSkills = new List<Skill>()
            {
                new Skill("Cooking", 22),
                new Skill("Farming", 17)
            };
            List<Quest> requiredQuests = new List<Quest>()
            {
                new Quest("The Giant Dwarf"),
                new Quest("Fishing Contest")
            };
            int questPointValue = 2;
            return new Quest(number, name, questSkills, requiredQuests, questPointValue);
        }

        static public Quest GardenOfTranquillity()
        {
            double number = 86;
            string name = "Garden Of Tranquillity";
            List<Skill> questSkills = new List<Skill>()
            {
                new Skill("Farming", 25)
            };
            List<Quest> requiredQuests = new List<Quest>()
            {
                new Quest("Creature Of Fenkenstrain"),
                new Quest("Priest In Peril"),
                new Quest("The Restless Ghost")
            };
            int questPointValue = 2;
            return new Quest(number, name, questSkills, requiredQuests, questPointValue);
        }

        static public Quest ATailOfTwoCats()
        {
            double number = 87;
            string name = "A Tail Of Two Cats";
            List<Skill> questSkills = new List<Skill>();
            List<Quest> requiredQuests = new List<Quest>()
            {
                new Quest("Icthlarin's Little Helper"),
                new Quest("Gertrude's Cat")
            };
            int questPointValue = 2;
            return new Quest(number, name, questSkills, requiredQuests, questPointValue);
        }

        static public Quest Wanted()
        {
            double number = 88;
            string name = "Wanted!";
            List<Skill> questSkills = new List<Skill>()
            {
                new Skill("QuestPoints", 32)
            };
            List<Quest> requiredQuests = new List<Quest>()
            {
                new Quest("Recruitment Drive"),
                new Quest("Black Knights' Fortress"),
                new Quest("Druidic Ritual"),
                new Quest("The Lost Tribe"),
                new Quest("Rune Mysteries"),
                new Quest("Goblin Diplomacy"),
                new Quest("Priest In Peril")
            };
            int questPointValue = 1;
            return new Quest(number, name, questSkills, requiredQuests, questPointValue);
        }

        static public Quest MourningsEndsPartII()
        {
            double number = 89;
            string name = "Mourning's Ends Part II";
            List<Skill> questSkills = new List<Skill>();
            List<Quest> requiredQuests = new List<Quest>()
            {
                new Quest("Mourning's End Part I")
            };
            int questPointValue = 2;
            return new Quest(number, name, questSkills, requiredQuests, questPointValue);
        }

        static public Quest RumDeal()
        {
            double number = 90;
            string name = "Rum Deal";
            List<Skill> questSkills = new List<Skill>()
            {
                new Skill("Crafting", 42),
                new Skill("Fishing", 50, 45),
                new Skill("Farming", 40, 35),
                new Skill("Prayer", 47, 42),
                new Skill("Slayer", 42)
            };
            List<Quest> requiredQuests = new List<Quest>()
            {
                new Quest("Zogre Flesh Eaters"),
                new Quest("Big Chompy Bird Hunting"),
                new Quest("Jungle Potion"),
                new Quest("Druidic Ritual")
            };
            int questPointValue = 2;
            return new Quest(number, name, questSkills, requiredQuests, questPointValue);
        }

        static public Quest ShadowOfTheStorm()
        {
            double number = 91;
            string name = "Shadow Of The Storm";
            List<Skill> questSkills = new List<Skill>()
            {
                new Skill("Crafting", 30, 25)
            };
            List<Quest> requiredQuests = new List<Quest>()
            {
                new Quest("The Golem"),
                new Quest("Demon Slayer"),
            };
            int questPointValue = 1;
            return new Quest(number, name, questSkills, requiredQuests, questPointValue);
        }

        static public Quest MakingHistory()
        {
            double number = 92;
            string name = "Making History";
            List<Skill> questSkills = new List<Skill>();
            List<Quest> requiredQuests = new List<Quest>()
            {
                new Quest("Priest In Peril"),
                new Quest("The Restless Ghost")
            };
            int questPointValue = 3;
            return new Quest(number, name, questSkills, requiredQuests, questPointValue);
        }

        static public Quest Ratcatchers()
        {
            double number = 93;
            string name = "Ratcatchers";
            List<Skill> questSkills = new List<Skill>();
            List<Quest> requiredQuests = new List<Quest>()
            {
                new Quest("Icthlarin's Little Helper"),
                new Quest("Gertrude's Cat")
            };
            int questPointValue = 2;
            return new Quest(number, name, questSkills, requiredQuests, questPointValue);
        }

        static public Quest SpiritsOfTheElid()
        {
            double number = 94;
            string name = "Spirits Of The Elid";
            List<Skill> questSkills = new List<Skill>()
            {
                new Skill("Magic", 33, 25),
                new Skill("Ranged", 37, 28),
                new Skill("Mining", 37),
                new Skill("Thieving", 37, 32),
            };
            List<Quest> requiredQuests = new List<Quest>();
            int questPointValue = 2;
            return new Quest(number, name, questSkills, requiredQuests, questPointValue);
        }

        static public Quest DeviousMinds()
        {
            double number = 95;
            string name = "Devious Minds";
            List<Skill> questSkills = new List<Skill>()
            {
                new Skill("Smithing", 65, 60),
                new Skill("Runecraft", 50),
                new Skill("Fletching", 50)
            };
            List<Quest> requiredQuests = new List<Quest>()
            {
                new Quest("Wanted!"),
                new Quest("Recruitment Drive"),
                new Quest("Black Knights' Fortress"),
                new Quest("Druidic Ritual"),
                new Quest("Rune Mysteries"),
                new Quest("The Lost Tribe"),
                new Quest("Goblin Diplomacy"),
                new Quest("Priest In Peril"),
                new Quest("Troll Stronghold"),
                new Quest("Death Plateau"),
                new Quest("Doric's Quest")
            };
            int questPointValue = 1;
            return new Quest(number, name, questSkills, requiredQuests, questPointValue);
        }

        static public Quest TheHandInTheSand()
        {
            double number = 96;
            string name = "The Hand In The Sand";
            List<Skill> questSkills = new List<Skill>()
            {
                new Skill("Thieving", 17),
                new Skill("Crafting", 49)
            };
            List<Quest> requiredQuests = new List<Quest>();
            int questPointValue = 1;
            return new Quest(number, name, questSkills, requiredQuests, questPointValue);
        }

        static public Quest EnakhrasLament()
        {
            double number = 97;
            string name = "Enakhra's Lament";
            List<Skill> questSkills = new List<Skill>()
            {
                new Skill("Crafting", 50),
                new Skill("Firemaking", 45),
                new Skill("Prayer", 43),
                new Skill("Magic", 39)
            };
            List<Quest> requiredQuests = new List<Quest>();
            int questPointValue = 2;
            return new Quest(number, name, questSkills, requiredQuests, questPointValue);
        }

        static public Quest CabinFever()
        {
            double number = 98;
            string name = "Cabin Fever";
            List<Skill> questSkills = new List<Skill>()
            {
                new Skill("Agility", 42),
                new Skill("Crafting", 45),
                new Skill("Smithing", 50),
                new Skill("Ranged", 40)
            };
            List<Quest> requiredQuests = new List<Quest>()
            {
                new Quest("Pirate's Treasure"),
                new Quest("Rum Deal"),
                new Quest("Zogre Flesh Eaters"),
                new Quest("Big Chompy Bird Hunting"),
                new Quest("Jungle Potion"),
                new Quest("Druidic Ritual"),
                new Quest("Priest In Peril")
            };
            int questPointValue = 2;
            return new Quest(number, name, questSkills, requiredQuests, questPointValue);
        }

        static public Quest FairyTaleIGrowingPains()
        {
            double number = 99;
            string name = "Fairy Tale I - Growing Pains";
            List<Skill> questSkills = new List<Skill>();
            List<Quest> requiredQuests = new List<Quest>()
            {
                new Quest("Lost City"),
                new Quest("Nature Spirit"),
                new Quest("The Restless Ghost"),
                new Quest("Priest In Peril"),
                new Quest("Jungle Potion")
            };
            int questPointValue = 2;
            return new Quest(number, name, questSkills, requiredQuests, questPointValue);
        }

        static public Quest RecipeForDisaster()
        {
            double number = 100;
            string name = "Recipe For Disaster";
            List<Skill> questSkills = new List<Skill>()
            {
                new Skill("QuestPoints", 167),
                new Skill("Cooking", 70, 65),
                new Skill("Agility", 48),
                new Skill("Fishing", 53, 48),
                new Skill("Thieving", 53),
                new Skill("Herblore", 25, 20),
                new Skill("Magic", 59, 47),
                new Skill("Smithing", 40),
                new Skill("Firemaking", 50),
                new Skill("Ranged", 40),
                new Skill("Crafting", 40),
                new Skill("Fletching", 10),
                new Skill("Woodcutting", 36)
            };
            List<Quest> requiredQuests = new List<Quest>()
            {
                new Quest("Cook's Assistant"),
                new Quest("Fishing Contest"),
                new Quest("Goblin Diplomacy"),
                new Quest("Big Chompy Bird Hunting"),
                new Quest("Murder Mystery"),
                new Quest("Nature Spirit"),
                new Quest("Priest In Peril"),
                new Quest("The Restless Ghost"),
                new Quest("Witch's House"),
                new Quest("Gertrude's Cat"),
                new Quest("Shadow Of The Storm"),
                new Quest("Demon Slayer"),
                new Quest("The Golem"),
                new Quest("Family Crest"),
                new Quest("Heroes' Quest"),
                new Quest("Shield Of Arrav"),
                new Quest("Lost City"),
                new Quest("Merlin's Crystal"),
                new Quest("Dragon Slayer"),
                new Quest("Druidic Ritual"),
                new Quest("Shilo Village"),
                new Quest("Jungle Potion"),
                new Quest("Underground Pass"),
                new Quest("Biohazard"),
                new Quest("Plague City"),
                new Quest("Monkey Madness I"),
                new Quest("The Grand Tree"),
                new Quest("Tree Gnome Village"),
                new Quest("Desert Treasure"),
                new Quest("The Dig Site"),
                new Quest("Temple Of Ikov"),
                new Quest("The Tourist Trap"),
                new Quest("Troll Stronghold"),
                new Quest("Death Plateau"),
                new Quest("Waterfall Quest"),
                new Quest("Horror From The Deep"),
                new Quest("Recipe For Disaster - Freeing The Goblin Generals"),
                new Quest("Recipe For Disaster - Another Cook's Quest"),
                new Quest("Recipe For Disaster - Freeing The Mountain Dwarf"),
                new Quest("Recipe For Disaster - Freeing Evil Dave"),
                new Quest("Recipe For Disaster - Freeing The Lumbridge Guide"),
                new Quest("Recipe For Disaster - Freeing Pirate Pete"),
                new Quest("Recipe For Disaster - Freeing Sir Amik Varze"),
                new Quest("Recipe For Disaster - Freeing King Awowogei"),
                new Quest("Recipe For Disaster - Freeing Skrach Uglogwee"),
                new Quest("Recipe For Disaster - Defeating The Culinaromancer")
            };
            int questPointValue = 0;
            return new Quest(number, name, questSkills, requiredQuests, questPointValue);
        }

        static public Quest RFD_AnotherCooksQuest()
        {
            double number = 100.1;
            string name = "Recipe For Disaster - Another Cook's Quest";
            List<Skill> questSkills = new List<Skill>()
            {
                new Skill("Cooking", 10)
            };
            List<Quest> requiredQuests = new List<Quest>()
            {
                new Quest("Cook's Assistant")
            };
            int questPointValue = 1;
            return new Quest(number, name, questSkills, requiredQuests, questPointValue);
        }

        static public Quest RFD_FreeingTheMountainDwarf()
        {
            double number = 100.2;
            string name = "Recipe For Disaster - Freeing The Mountain Dwarf";
            List<Skill> questSkills = new List<Skill>();
            List<Quest> requiredQuests = new List<Quest>()
            {
                new Quest("Fishing Contest")
            };
            int questPointValue = 1;
            return new Quest(number, name, questSkills, requiredQuests, questPointValue);
        }

        static public Quest RFD_FreeingTheGoblinGenerals()
        {
            double number = 100.3;
            string name = "Recipe For Disaster - Freeing The Goblin Generals";
            List<Skill> questSkills = new List<Skill>();
            List<Quest> requiredQuests = new List<Quest>()
            {
                new Quest("Goblin Diplomacy")
            };
            int questPointValue = 1;
            return new Quest(number, name, questSkills, requiredQuests, questPointValue);
        }

        static public Quest RFD_FreeingPiratePete()
        {
            double number = 100.4;
            string name = "Recipe For Disaster - Freeing Pirate Pete";
            List<Skill> questSkills = new List<Skill>()
            {
                new Skill("Cooking", 31)
            };
            List<Quest> requiredQuests = new List<Quest>();
            int questPointValue = 1;
            return new Quest(number, name, questSkills, requiredQuests, questPointValue);
        }

        static public Quest RFD_FreeingTheLumbridgeGuide()
        {
            double number = 100.5;
            string name = "Recipe For Disaster - Freeing The Lumbridge Guide";
            List<Skill> questSkills = new List<Skill>()
            {
                new Skill("Cooking", 40)
            };
            List<Quest> requiredQuests = new List<Quest>()
            {
                new Quest("Big Chompy Bird Hunting"),
                new Quest("Biohazard"),
                new Quest("Plague City"),
                new Quest("Demon Slayer"),
                new Quest("Murder Mystery"),
                new Quest("Nature Spirit"),
                new Quest("Priest In Peril"),
                new Quest("The Restless Ghost"),
                new Quest("Witch's House")
            };
            int questPointValue = 1;
            return new Quest(number, name, questSkills, requiredQuests, questPointValue);
        }

        static public Quest RFD_FreeingEvilDave()
        {
            double number = 100.6;
            string name = "Recipe For Disaster - Freeing Evil Dave";
            List<Skill> questSkills = new List<Skill>()
            {
                new Skill("Cooking", 25)
            };
            List<Quest> requiredQuests = new List<Quest>()
            {
                new Quest("Gertrude's Cat"),
                new Quest("Shadow Of The Storm"),
                new Quest("Demon Slayer"),
                new Quest("The Golem")
            };
            int questPointValue = 1;
            return new Quest(number, name, questSkills, requiredQuests, questPointValue);
        }

        static public Quest RFD_FreeingKingAwowogei()
        {
            double number = 100.7;
            string name = "Recipe For Disaster - Freeing King Awowogei";
            List<Skill> questSkills = new List<Skill>()
            {
                new Skill("Cooking", 70, 65),
                new Skill("Agility", 48)
            };
            List<Quest> requiredQuests = new List<Quest>()
            {
                new Quest("Monkey Madness I"),
                new Quest("The Grand Tree"),
                new Quest("Tree Gnome Village")
            };
            int questPointValue = 1;
            return new Quest(number, name, questSkills, requiredQuests, questPointValue);
        }

        static public Quest RFD_FreeingSirAmikVarze()
        {
            double number = 100.8;
            string name = "Recipe For Disaster - Freeing Sir Amik Varze";
            List<Skill> questSkills = new List<Skill>()
            {
                new Skill("QuestPoints", 107)
            };
            List<Quest> requiredQuests = new List<Quest>()
            {
                new Quest("Family Crest"),
                new Quest("Heroes' Quest"),
                new Quest("Shield Of Arrav"),
                new Quest("Lost City"),
                new Quest("Merlin's Crystal"),
                new Quest("Dragon Slayer"),
                new Quest("Shilo Village"),
                new Quest("Jungle Potion"),
                new Quest("Druidic Ritual"),
                new Quest("Underground Pass"),
                new Quest("Biohazard"),
                new Quest("Plague City"),
                new Quest("Waterfall Quest")
            };
            int questPointValue = 1;
            return new Quest(number, name, questSkills, requiredQuests, questPointValue);
        }

        static public Quest RFD_FreeingSkrachUglogwee()
        {
            double number = 100.9;
            string name = "Recipe For Disaster - Freeing Skrach Uglogwee";
            List<Skill> questSkills = new List<Skill>()
            {
                new Skill("Cooking", 41),
                new Skill("Firemaking", 20)
            };
            List<Quest> requiredQuests = new List<Quest>()
            {
                new Quest("Big Chompy Bird Hunting")
            };
            int questPointValue = 1;
            return new Quest(number, name, questSkills, requiredQuests, questPointValue);
        }

        static public Quest RFD_DefeatingTheCulinaromancer()
        {
            double number = 100.10;
            string name = "Recipe For Disaster - Defeating The Culinaromancer";
            List<Skill> questSkills = new List<Skill>()
            {
                new Skill("QuestPoints", 175)
            };
            List<Quest> requiredQuests = new List<Quest>()
            {
                new Quest("Desert Treasure"),
                new Quest("The Dig Site"),
                new Quest("Druidic Ritual"),
                new Quest("Temple Of Ikov"),
                new Quest("Troll Stronghold"),
                new Quest("Death Plateau"),
                new Quest("Priest In Peril"),
                new Quest("Waterfall Quest"),
                new Quest("Horror From The Deep"),
                new Quest("Recipe For Disaster - Freeing The Goblin Generals"),
                new Quest("Recipe For Disaster - Another Cook's Quest"),
                new Quest("Recipe For Disaster - Freeing The Mountain Dwarf"),
                new Quest("Recipe For Disaster - Freeing Evil Dave"),
                new Quest("Recipe For Disaster - Freeing The Lumbridge Guide"),
                new Quest("Recipe For Disaster - Freeing Pirate Pete"),
                new Quest("Recipe For Disaster - Freeing Sir Amik Varze"),
                new Quest("Recipe For Disaster - Freeing King Awowogei"),
                new Quest("Recipe For Disaster - Freeing Skrach Uglogwee")
            };
            int questPointValue = 1;
            return new Quest(number, name, questSkills, requiredQuests, questPointValue);
        }

        static public Quest InAidOfTheMyreque()
        {
            double number = 101;
            string name = "In Aid Of The Myreque";
            List<Skill> questSkills = new List<Skill>()
            {
                new Skill("Crafting", 25),
                new Skill("Mining", 15),
                new Skill("Magic", 7)
            };
            List<Quest> requiredQuests = new List<Quest>()
            {
                new Quest("In Search Of The Myreque"),
                new Quest("Nature Spirit"),
                new Quest("Priest In Peril"),
                new Quest("The Restless Ghost")
            };
            int questPointValue = 2;
            return new Quest(number, name, questSkills, requiredQuests, questPointValue);
        }

        static public Quest ASoulsBane()
        {
            double number = 102;
            string name = "A Soul's Bane";
            List<Skill> questSkills = new List<Skill>();
            List<Quest> requiredQuests = new List<Quest>();
            int questPointValue = 1;
            return new Quest(number, name, questSkills, requiredQuests, questPointValue);
        }

        static public Quest RagAndBoneMan()
        {
            double number = 103;
            string name = "Rag And Bone Man";
            List<Skill> questSkills = new List<Skill>();
            List<Quest> requiredQuests = new List<Quest>();
            int questPointValue = 1;
            return new Quest(number, name, questSkills, requiredQuests, questPointValue);
        }

        static public Quest RagAndBoneManII()
        {
            double number = 104;
            string name = "Rag And Bone Man II";
            List<Skill> questSkills = new List<Skill>()
            {
                new Skill("Slayer", 40)
            };
            List<Quest> requiredQuests = new List<Quest>()
            {
                new Quest("Rag And Bone Man"),
                new Quest("The Fremennik Trials"),
                new Quest("Horror From The Deep")
            };
            int questPointValue = 1;
            return new Quest(number, name, questSkills, requiredQuests, questPointValue);
        }

        static public Quest SwanSong()
        {
            double number = 105;
            string name = "Swan Song";
            List<Skill> questSkills = new List<Skill>()
            {
                new Skill("QuestPoints", 100),
                new Skill("Magic", 66, 54),
                new Skill("Cooking", 62, 57),
                new Skill("Fishing", 62, 57),
                new Skill("Smithing", 45, 40),
                new Skill("Firemaking", 42, 37),
                new Skill("Crafting", 40)
            };
            List<Quest> requiredQuests = new List<Quest>()
            {
                new Quest("One Small Favour"),
                new Quest("Rune Mysteries"),
                new Quest("Shilo Village"),
                new Quest("Jungle Potion"),
                new Quest("Druidic Ritual"),
                new Quest("Garden of Tranquility"),
                new Quest("Creature Of Fenkenstrain"),
                new Quest("Priest In Peril"),
                new Quest("The Restless Ghost")
            };
            int questPointValue = 2;
            return new Quest(number, name, questSkills, requiredQuests, questPointValue);
        }

        static public Quest RoyalTrouble()
        {
            double number = 106;
            string name = "Royal Trouble";
            List<Skill> questSkills = new List<Skill>()
            {
                new Skill("Agility", 40, 35),
                new Skill("Slayer", 40, 35)
            };
            List<Quest> requiredQuests = new List<Quest>()
            {
                new Quest("Throne Of Miscellania")
            };
            int questPointValue = 1;
            return new Quest(number, name, questSkills, requiredQuests, questPointValue);
        }

        static public Quest DeathToTheDorgeshuun()
        {
            double number = 107;
            string name = "Death To The Dorgeshuun";
            List<Skill> questSkills = new List<Skill>()
            {
                new Skill("Agility", 23),
                new Skill("Thieving", 23)
            };
            List<Quest> requiredQuests = new List<Quest>()
            {
                new Quest("The Lost Tribe"),
                new Quest("Goblin Diplomacy"),
                new Quest("Rune Mysteries")
            };
            int questPointValue = 1;
            return new Quest(number, name, questSkills, requiredQuests, questPointValue);
        }

        static public Quest FairyTaleIICureAQueen()
        {
            double number = 108;
            string name = "Fairy Tale II - Cure A Queen";
            List<Skill> questSkills = new List<Skill>()
            {
                new Skill("Thieving", 40),
                new Skill("Farming", 49, 46),
                new Skill("Herblore", 57, 53)
            };
            List<Quest> requiredQuests = new List<Quest>()
            {
                new Quest("Fairy Tale I - Growing Pains"),
                new Quest("Lost City"),
                new Quest("Nature Spirit"),
                new Quest("The Restless Ghost"),
                new Quest("Priest In Peril")
            };
            int questPointValue = 2;
            return new Quest(number, name, questSkills, requiredQuests, questPointValue);
        }

        static public Quest LunarDiplomacy()
        {
            double number = 109;
            string name = "Lunar Diplomacy";
            List<Skill> questSkills = new List<Skill>()
            {
                new Skill("Crafting", 61),
                new Skill("Defence", 40),
                new Skill("Firemaking", 49),
                new Skill("Magic", 65),
                new Skill("Mining", 60),
                new Skill("Woodcutting", 55)
            };
            List<Quest> requiredQuests = new List<Quest>()
            {
                new Quest("The Fremennik Trials"),
                new Quest("Lost City"),
                new Quest("Rune Mysteries"),
                new Quest("Shilo Village"),
                new Quest("Jungle Potion"),
                new Quest("Druidic Ritual")
            };
            int questPointValue = 2;
            return new Quest(number, name, questSkills, requiredQuests, questPointValue);
        }

        static public Quest TheEyesOfGlouphrie()
        {
            double number = 110;
            string name = "The Eyes Of Glouphrie";
            List<Skill> questSkills = new List<Skill>()
            {
                new Skill("Construction", 5),
                new Skill("Magic", 46)
            };
            List<Quest> requiredQuests = new List<Quest>()
            {
                new Quest("The Grand Tree")
            };
            int questPointValue = 2;
            return new Quest(number, name, questSkills, requiredQuests, questPointValue);
        }

        static public Quest DarknessOfHallowvale()
        {
            double number = 111;
            string name = "Darkness Of Hallowvale";
            List<Skill> questSkills = new List<Skill>()
            {
                new Skill("Construction", 5),
                new Skill("Mining", 20),
                new Skill("Thieving", 22),
                new Skill("Agility", 26),
                new Skill("Crafting", 32),
                new Skill("Magic", 33),
                new Skill("Strength", 40)
            };
            List<Quest> requiredQuests = new List<Quest>()
            {
                new Quest("In Aid Of The Myreque"),
                new Quest("In Search Of The Myreque"),
                new Quest("Nature Spirit"),
                new Quest("Priest In Peril"),
                new Quest("The Restless Ghost")
            };
            int questPointValue = 2;
            return new Quest(number, name, questSkills, requiredQuests, questPointValue);
        }

        static public Quest TheSlugMenace()
        {
            double number = 112;
            string name = "The Slug Menace";
            List<Skill> questSkills = new List<Skill>()
            {
                new Skill("Crafting", 30),
                new Skill("Runecraft", 30),
                new Skill("Slayer", 30),
                new Skill("Thieving", 30)
            };
            List<Quest> requiredQuests = new List<Quest>()
            {
                new Quest("Wanted!"),
                new Quest("Recruitment Drive"),
                new Quest("Black Knights' Fortress"),
                new Quest("Druidic Ritual"),
                new Quest("The Lost Tribe"),
                new Quest("Rune Mysteries"),
                new Quest("Goblin Diplomacy"),
                new Quest("Priest In Peril"),
                new Quest("Sea Slug")
            };
            int questPointValue = 1;
            return new Quest(number, name, questSkills, requiredQuests, questPointValue);
        }

        static public Quest ElementalWorkshopII()
        {
            double number = 113;
            string name = "Elemental Workshop II";
            List<Skill> questSkills = new List<Skill>()
            {
                new Skill("Magic", 20),
                new Skill("Smithing", 30)
            };
            List<Quest> requiredQuests = new List<Quest>()
            {
                new Quest("Elemental Workshop I")
            };
            int questPointValue = 1;
            return new Quest(number, name, questSkills, requiredQuests, questPointValue);
        }

        static public Quest MyArmsBigAdventure()
        {
            double number = 114;
            string name = "My Arm's Big Adventure";
            List<Skill> questSkills = new List<Skill>()
            {
                new Skill("Woodcutting", 10),
                new Skill("Farming", 29, 24)
            };
            List<Quest> requiredQuests = new List<Quest>()
            {
                new Quest("Eadgar's Ruse"),
                new Quest("Troll Stronghold"),
                new Quest("Death Plateau"),
                new Quest("The Feud"),
                new Quest("Jungle Potion"),
                new Quest("Druidic Ritual")
            };
            int questPointValue = 1;
            return new Quest(number, name, questSkills, requiredQuests, questPointValue);
        }

        static public Quest EnlightenedJourney()
        {
            double number = 115;
            string name = "Enlightened Journey";
            List<Skill> questSkills = new List<Skill>()
            {
                new Skill("QuestPoints", 20),
                new Skill("Firemaking", 20),
                new Skill("Farming", 30),
                new Skill("Crafting", 36)
            };
            List<Quest> requiredQuests = new List<Quest>();
            int questPointValue = 1;
            return new Quest(number, name, questSkills, requiredQuests, questPointValue);
        }

        static public Quest EaglesPeak()
        {
            double number = 116;
            string name = "Eagles' Peak";
            List<Skill> questSkills = new List<Skill>()
            {
                new Skill("Hunter", 27, 22)
            };
            List<Quest> requiredQuests = new List<Quest>();
            int questPointValue = 2;
            return new Quest(number, name, questSkills, requiredQuests, questPointValue);
        }

        static public Quest AnimalMagnetism()
        {
            double number = 117;
            string name = "Animal Magnetism";
            List<Skill> questSkills = new List<Skill>()
            {
                new Skill("Slayer", 18),
                new Skill("Crafting", 19),
                new Skill("Ranged", 30),
                new Skill("Woodcutting", 35)
            };
            List<Quest> requiredQuests = new List<Quest>()
            {
                new Quest("The Restless Ghost"),
                new Quest("Priest In Peril"),
                new Quest("Ernest The Chicken")
            };
            int questPointValue = 1;
            return new Quest(number, name, questSkills, requiredQuests, questPointValue);
        }

        static public Quest Contact()
        {
            double number = 118;
            string name = "Contact!";
            List<Skill> questSkills = new List<Skill>();
            List<Quest> requiredQuests = new List<Quest>()
            {
                new Quest("Prince Ali Rescue"),
                new Quest("Icthlarin's Little Helper"),
                new Quest("Gertrude's Cat")
            };
            int questPointValue = 1;
            return new Quest(number, name, questSkills, requiredQuests, questPointValue);
        }

        static public Quest ColdWar()
        {
            double number = 119;
            string name = "Cold War";
            List<Skill> questSkills = new List<Skill>()
            {
                new Skill("Hunter", 10),
                new Skill("Agility", 30),
                new Skill("Crafting", 30),
                new Skill("Construction", 34),
                new Skill("Thieving", 15)
            };
            List<Quest> requiredQuests = new List<Quest>();
            int questPointValue = 1;
            return new Quest(number, name, questSkills, requiredQuests, questPointValue);
        }

        static public Quest TheFremennikIsles()
        {
            double number = 120;
            string name = "The Fremennik Isles";
            List<Skill> questSkills = new List<Skill>()
            {
                new Skill("Construction", 20),
                new Skill("Agility", 40, 35)
            };
            List<Quest> requiredQuests = new List<Quest>()
            {
                new Quest("The Fremennik Trials")
            };
            int questPointValue = 1;
            return new Quest(number, name, questSkills, requiredQuests, questPointValue);
        }

        static public Quest TowerOfLife()
        {
            double number = 121;
            string name = "Tower Of Life";
            List<Skill> questSkills = new List<Skill>()
            {
                new Skill("Construction", 10)
            };
            List<Quest> requiredQuests = new List<Quest>();
            int questPointValue = 2;
            return new Quest(number, name, questSkills, requiredQuests, questPointValue);
        }

        static public Quest TheGreatBrainRobbery()
        {
            double number = 122;
            string name = "The Great Brain Robbery";
            List<Skill> questSkills = new List<Skill>()
            {
                new Skill("Crafting", 16),
                new Skill("Construction", 30),
                new Skill("Prayer", 50)
            };
            List<Quest> requiredQuests = new List<Quest>()
            {
                new Quest("Creature Of Fenkenstrain"),
                new Quest("Cabin Fever"),
                new Quest("Pirate's Treasure"),
                new Quest("Priest In Peril"),
                new Quest("Rum Deal"),
                new Quest("Zogre Flesh Eaters"),
                new Quest("Big Chompy Bird Hunting"),
                new Quest("Jungle Potion"),
                new Quest("Druidic Ritual"),
                new Quest("Recipe For Disaster - Freeing Pirate Pete")
            };
            int questPointValue = 2;
            return new Quest(number, name, questSkills, requiredQuests, questPointValue);
        }

        static public Quest WhatLiesBelow()
        {
            double number = 123;
            string name = "What Lies Below";
            List<Skill> questSkills = new List<Skill>()
            {
                new Skill("Runecraft", 35),
            };
            List<Quest> requiredQuests = new List<Quest>()
            {
                new Quest("Rune Mysteries")
            };
            int questPointValue = 1;
            return new Quest(number, name, questSkills, requiredQuests, questPointValue);
        }

        static public Quest OlafsQuest()
        {
            double number = 124;
            string name = "Olaf's Quest";
            List<Skill> questSkills = new List<Skill>()
            {
                new Skill("Firemaking", 40),
                new Skill("Woodcutting", 40, 45),
            };
            List<Quest> requiredQuests = new List<Quest>()
            {
                new Quest("The Fremennik Trials")
            };
            int questPointValue = 1;
            return new Quest(number, name, questSkills, requiredQuests, questPointValue);
        }

        static public Quest AnotherSliceOfHAM()
        {
            double number = 125;
            string name = "Another Slice Of H.A.M.";
            List<Skill> questSkills = new List<Skill>()
            {
                new Skill("Attack", 15),
                new Skill("Prayer", 25)
            };
            List<Quest> requiredQuests = new List<Quest>()
            {
                new Quest("Death To The Dorgeshuun"),
                new Quest("The Lost Tribe"),
                new Quest("Goblin Diplomacy"),
                new Quest("Rune Mysteries"),
                new Quest("The Giant Dwarf"),
                new Quest("The Dig Site"),
                new Quest("Druidic Ritual")
            };
            int questPointValue = 1;
            return new Quest(number, name, questSkills, requiredQuests, questPointValue);
        }

        static public Quest DreamMentor()
        {
            double number = 126;
            string name = "Dream Mentor";
            List<Skill> questSkills = new List<Skill>()
            {
                new Skill("Combat", 85)
            };
            List<Quest> requiredQuests = new List<Quest>()
            {
                new Quest("Lunar Diplomacy"),
                new Quest("The Fremennik Trials"),
                new Quest("Lost City"),
                new Quest("Rune Mysteries"),
                new Quest("Shilo Village"),
                new Quest("Jungle Potion"),
                new Quest("Eadgar's Ruse"),
                new Quest("Troll Stronghold"),
                new Quest("Death Plateau"),
                new Quest("Druidic Ritual")
            };
            int questPointValue = 2;
            return new Quest(number, name, questSkills, requiredQuests, questPointValue);
        }

        static public Quest GrimTales()
        {
            double number = 127;
            string name = "Grim Tales";
            List<Skill> questSkills = new List<Skill>()
            {
                new Skill("Farming", 45, 40),
                new Skill("Herblore", 52, 47),
                new Skill("Thieving", 58, 53),
                new Skill("Agility", 59, 54),
                new Skill("Woodcutting", 71, 66),
            };
            List<Quest> requiredQuests = new List<Quest>()
            {
                new Quest("Witch's House")
            };
            int questPointValue = 1;
            return new Quest(number, name, questSkills, requiredQuests, questPointValue);
        }

        static public Quest KingsRansom()
        {
            double number = 128;
            string name = "King's Ransom";
            List<Skill> questSkills = new List<Skill>()
            {
                new Skill("Magic", 45, 40),
                new Skill("Defence", 65)
            };
            List<Quest> requiredQuests = new List<Quest>()
            {
                new Quest("Black Knights' Fortress"),
                new Quest("Holy Grail"),
                new Quest("Merlin's Crystal"),
                new Quest("One Small Favour"),
                new Quest("Rune Mysteries"),
                new Quest("Shilo Village"),
                new Quest("Jungle Potion"),
                new Quest("Druidic Ritual")
            };
            int questPointValue = 1;
            return new Quest(number, name, questSkills, requiredQuests, questPointValue);
        }

        static public Quest MonkeyMadnessII()
        {
            double number = 129;
            string name = "Monkey Madness II";
            List<Skill> questSkills = new List<Skill>()
            {
                new Skill("Slayer", 69),
                new Skill("Crafting", 70),
                new Skill("Hunter", 60),
                new Skill("Agility", 55),
                new Skill("Thieving", 55),
                new Skill("Firemaking", 60)
            };
            List<Quest> requiredQuests = new List<Quest>()
            {
                new Quest("Enlightened Journey"),
                new Quest("The Eyes Of Glouphrie"),
                new Quest("The Grand Tree"),
                new Quest("Recipe For Disaster - Freeing King Awowogei"),
                new Quest("Monkey Madness I"),
                new Quest("Tree Gnome Village"),
                new Quest("Troll Stronghold"),
                new Quest("Death Plateau"),
                new Quest("Watchtower")
            };
            int questPointValue = 4;
            return new Quest(number, name, questSkills, requiredQuests, questPointValue);
        }

        static public Quest MisthalinMystery()
        {
            double number = 130;
            string name = "Misthalin Mystery";
            List<Skill> questSkills = new List<Skill>();
            List<Quest> requiredQuests = new List<Quest>();
            int questPointValue = 1;
            return new Quest(number, name, questSkills, requiredQuests, questPointValue);
        }

        static public Quest ClientOfKourend()
        {
            double number = 131;
            string name = "Client Of Kourend";
            List<Skill> questSkills = new List<Skill>();
            List<Quest> requiredQuests = new List<Quest>();
            int questPointValue = 1;
            return new Quest(number, name, questSkills, requiredQuests, questPointValue);
        }

        static public Quest BoneVoyage()
        {
            double number = 132;
            string name = "Bone Voyage";
            List<Skill> questSkills = new List<Skill>();
            List<Quest> requiredQuests = new List<Quest>()
            {
                new Quest("The Dig Site"),
                new Quest("Druidic Ritual")
            };
            int questPointValue = 1;
            return new Quest(number, name, questSkills, requiredQuests, questPointValue);
        }

        static public Quest TheQueenOfThieves()
        {
            double number = 133;
            string name = "The Queen Of Thieves";
            List<Skill> questSkills = new List<Skill>()
            {
                new Skill("Thieving", 20)
            };
            List<Quest> requiredQuests = new List<Quest>()
            {
                new Quest("Client Of Kourend")
            };
            int questPointValue = 1;
            return new Quest(number, name, questSkills, requiredQuests, questPointValue);
        }

        static public Quest TheDepthsOfDespair()
        {
            double number = 134;
            string name = "The Depths Of Despair";
            List<Skill> questSkills = new List<Skill>()
            {
                new Skill("Agility", 18)
            };
            List<Quest> requiredQuests = new List<Quest>()
            {
                new Quest("Client Of Kourend")
            };
            int questPointValue = 1;
            return new Quest(number, name, questSkills, requiredQuests, questPointValue);
        }

        static public Quest TheCorsairCurse()
        {
            double number = 135;
            string name = "The Corsair Curse";
            List<Skill> questSkills = new List<Skill>();
            List<Quest> requiredQuests = new List<Quest>();
            int questPointValue = 2;
            return new Quest(number, name, questSkills, requiredQuests, questPointValue);
        }

        static public Quest DragonSlayerII()
        {
            double number = 136;
            string name = "Dragon Slayer II";
            List<Skill> questSkills = new List<Skill>()
            {
                new Skill("QuestPoints", 200),
                new Skill("Magic", 75),
                new Skill("Smithing", 70),
                new Skill("Mining", 68),
                new Skill("Crafting", 62),
                new Skill("Agility", 60),
                new Skill("Thieving", 60),
                new Skill("Construction", 50),
                new Skill("Hitpoints", 50)
            };
            List<Quest> requiredQuests = new List<Quest>()
            {
                new Quest("Legend's Quest"),
                new Quest("Family Crest"),
                new Quest("Heroes' Quest"),
                new Quest("Shield Of Arrav"),
                new Quest("Lost City"),
                new Quest("Merlin's Crystal"),
                new Quest("Dragon Slayer"),
                new Quest("Druidic Ritual"),
                new Quest("Underground Pass"),
                new Quest("Biohazard"),
                new Quest("Plague City"),
                new Quest("Waterfall Quest"),
                new Quest("Dream Mentor"),
                new Quest("Lunar Diplomacy"),
                new Quest("The Fremennik Trials"),
                new Quest("Lost City"),
                new Quest("Rune Mysteries"),
                new Quest("Shilo Village"),
                new Quest("Jungle Potion"),
                new Quest("Eadgar's Ruse"),
                new Quest("Troll Stronghold"),
                new Quest("Death Plateau"),
                new Quest("A Tail Of Two Cats"),
                new Quest("Icthlarin's Little Helper"),
                new Quest("Gertude's Cat"),
                new Quest("Animal Magnetism"),
                new Quest("Ernest The Chicken"),
                new Quest("Priest In Peril"),
                new Quest("The Restless Ghost"),
                new Quest("Bone Voyage"),
                new Quest("The Dig Site"),
                new Quest("Client Of Kourend")
            };
            int questPointValue = 5;
            return new Quest(number, name, questSkills, requiredQuests, questPointValue);
        }

        static public Quest TaleOfTheRighteous()
        {
            double number = 137;
            string name = "Tale Of The Righteous";
            List<Skill> questSkills = new List<Skill>()
            {
                new Skill("Strength", 16),
                new Skill("Mining", 10)
            };
            List<Quest> requiredQuests = new List<Quest>()
            {
                new Quest("Client Of Kourend")
            };
            int questPointValue = 1;
            return new Quest(number, name, questSkills, requiredQuests, questPointValue);
        }

        static public Quest ATasteOfHope()
        {
            double number = 138;
            string name = "A Taste Of Hope";
            List<Skill> questSkills = new List<Skill>()
            {
                new Skill("Crafting", 48),
                new Skill("Agility", 45),
                new Skill("Attack", 40),
                new Skill("Herblore", 40),
                new Skill("Slayer", 38),
            };
            List<Quest> requiredQuests = new List<Quest>()
            {
                new Quest("Darkness Of Hallowvale"),
                new Quest("In Aid Of The Myreque"),
                new Quest("In Search Of The Myreque"),
                new Quest("Nature Spirit"),
                new Quest("Priest In Peril"),
                new Quest("The Restless Ghost")
            };
            int questPointValue = 1;
            return new Quest(number, name, questSkills, requiredQuests, questPointValue);
        }

        static public Quest MakingFriendsWithMyArm()
        {
            double number = 139;
            string name = "Making Friends With My Arm";
            List<Skill> questSkills = new List<Skill>()
            {
                new Skill("Firemaking", 66),
                new Skill("Mining", 72, 70),
                new Skill("Construction", 35, 30),
                new Skill("Agility", 68, 63),
            };
            List<Quest> requiredQuests = new List<Quest>()
            {
                new Quest("My Arm's Big Adventure"),
                new Quest("Eadgar's Ruse"),
                new Quest("Troll Stronghold"),
                new Quest("Death Plateau"),
                new Quest("Druidic Ritual"),
                new Quest("The Feud"),
                new Quest("Jungle Potion"),
                new Quest("Swan Song"),
                new Quest("One Small Favour"),
                new Quest("Rune Mysteries"),
                new Quest("Shilo Village"),
                new Quest("Garden Of Tranquillity"),
                new Quest("Creature Of Fenkenstrain"),
                new Quest("Priest In Peril"),
                new Quest("The Restless Ghost"),
                new Quest("Cold War"),
                new Quest("Romeo And Juliet")
            };
            int questPointValue = 2;
            return new Quest(number, name, questSkills, requiredQuests, questPointValue);
        }

        static public Quest TheForsakenTower()
        {
            double number = 140;
            string name = "The Forsaken Tower";
            List<Skill> questSkills = new List<Skill>();
            List<Quest> requiredQuests = new List<Quest>()
            {
                new Quest("Client Of Kourend")
            };
            int questPointValue = 1;
            return new Quest(number, name, questSkills, requiredQuests, questPointValue);
        }

        static public Quest TheAscentOfArceuus()
        {
            double number = 141;
            string name = "The Ascent Of Arceuus";
            List<Skill> questSkills = new List<Skill>()
            {
                new Skill("Hunter", 12)
            };
            List<Quest> requiredQuests = new List<Quest>()
            {
                new Quest("Client Of Kourend")
            };
            int questPointValue = 1;
            return new Quest(number, name, questSkills, requiredQuests, questPointValue);
        }

        static public Quest XMarksTheSpot()
        {
            double number = 142;
            string name = "X Marks The Spot";
            List<Skill> questSkills = new List<Skill>();
            List<Quest> requiredQuests = new List<Quest>();
            int questPointValue = 1;
            return new Quest(number, name, questSkills, requiredQuests, questPointValue);
        }


    }
}