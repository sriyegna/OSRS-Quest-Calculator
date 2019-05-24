using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSRS_Quests
{
    class Quest
    {
        public int questNumber;
        public string questName { get; set; }
        public List<Skill> questSkills = new List<Skill>();
        public List<Boolean> boostsAllowed = new List<Boolean>();
        public List<String> requiredQuests = new List<String>();

        public Quest(int num, string Name, List<Skill> questSkills, List<Boolean> boostsAllowed, List<String> requiredQuests)
        {
            this.questNumber = num;
            this.questName = Name;
            this.questSkills = questSkills;
            this.boostsAllowed = boostsAllowed;
            this.requiredQuests = requiredQuests;
        }

        public Quest(string Name)
        {
            this.questName = Name;
        }
    }
}
