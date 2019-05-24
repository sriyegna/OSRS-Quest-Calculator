using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSRS_Quests
{
    class Player
    {
        public string userID;
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
    }
}
