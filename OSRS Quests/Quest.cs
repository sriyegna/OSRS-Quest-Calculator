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
        public List<Quest> requiredQuests = new List<Quest>();
        public bool completed {get; set;}

        public Quest(int num, string Name, List<Skill> questSkills, List<Quest> requiredQuests)
        {
            this.questNumber = num;
            this.questName = Name;
            this.questSkills = questSkills;
            this.requiredQuests = requiredQuests;
            this.completed = false;
        }

        public Quest(string Name)
        {
            this.questName = Name;
        }
    }
}
