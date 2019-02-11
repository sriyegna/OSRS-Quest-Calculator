using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSRS_Quests
{
    class Quest
    {
        public string questName { get; set; }
        public List<Skill> questSkills = new List<Skill>();
        public List<Quest> requiredQuests = new List<Quest>();
    }
}
