using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSRS_Quests
{
    class Player
    {
        public string userID { get; set; }
        public List<Skill> playerSkills = new List<Skill>();
        public List<Quest> playerQuests = new List<Quest>();
        public int questPoints = 0;

        public void updateSkillLevel(string skillName, int level)
        {
            foreach (Skill s in this.playerSkills)
            {
                if (s.skillName == skillName)
                {
                    s.level = level;
                }
            }

        }
        
        public int calculateCombatLevel()
        {
            double defence = Skill.getLevel(playerSkills, "Defence");
            double hitpoints = Skill.getLevel(playerSkills, "Hitpoints");
            double prayer = Skill.getLevel(playerSkills, "Prayer");
            double attack = Skill.getLevel(playerSkills, "Attack");
            double strength = Skill.getLevel(playerSkills, "Strength");
            double ranged = Skill.getLevel(playerSkills, "Ranged");
            double magic = Skill.getLevel(playerSkills, "Magic");
            double baseLevel = 0.25 * (defence + hitpoints + Math.Floor(prayer/2));
            double melee = 0.325 * (attack + strength);
            double range = 0.325 * (Math.Floor(3 * ranged / 2));
            double mage = 0.325 * (Math.Floor(3 * magic / 2));
            int final = Convert.ToInt32(Math.Floor(baseLevel + Math.Max(melee, Math.Max(range, mage))));
            return final;
        }

        public int calculateMinimumQuestPoints(List<Quest> questList)
        {
            int sum = 0;
            foreach(Quest q in questList)
            {
                if (q.completed)
                {
                    sum += q.questPointValue;
                }
            }
            return sum;
        }

        public static string determineSkillEligibility(Quest quest, Player osrsPlayer)
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


    }
}
