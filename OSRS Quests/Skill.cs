using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSRS_Quests
{
    class Skill
    {
        public string skillName { get; set; }
        public int rank { get; set; }
        public int level { get; set; }
        public int experience { get; set; }
        public int boostlevel = 99;

        public Skill(string skillName, int rank, int level, int experience)
        {
            this.skillName = skillName;
            this.rank = rank;
            this.level = level;
            this.experience = experience;
        }

        public Skill(string skillName, int level)
        {
            this.skillName = skillName;
            this.level = level;
        }

        public Skill(string skillName, int level, int boostlevel)
        {
            this.skillName = skillName;
            this.level = level;
            this.boostlevel = boostlevel;
        }

        public static int getLevel(List<Skill> skills, string skillName)
        {
            foreach(Skill s in skills)
            {
                if (s.skillName == skillName)
                {
                    return s.level;
                }
            }
            return 0;
        }
    }
}
