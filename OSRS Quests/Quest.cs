using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSRS_Quests
{
    class Quest
    {
        public double questNumber;
        public string questName { get; set; }
        public List<Skill> questSkills = new List<Skill>();
        public List<Quest> requiredQuests = new List<Quest>();
        public bool completed {get; set;}
        public int questPointValue { get; set; }

        public Quest(double num, string Name, List<Skill> questSkills, List<Quest> requiredQuests, int questPointValue)
        {
            this.questNumber = num;
            this.questName = Name;
            this.questSkills = questSkills;
            this.requiredQuests = requiredQuests;
            this.completed = false;
            this.questPointValue = questPointValue;
        }

        public Quest(string Name)
        {
            this.questName = Name;
        }

        public static Quest findQuest(List<Quest> quests, string questName)
        {
            Quest emptyQuest = new Quest("");
            foreach(Quest q in quests)
            {
                if (q.questName == questName)
                {
                    return q;
                }
            }
            return emptyQuest;
        }

        public static bool isQuestCompleted(List<Quest> questList, string questName)
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
    }
}
