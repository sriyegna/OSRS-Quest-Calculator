﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSRS_Quests
{
    class Skill
    {
        [JsonProperty("skillName")]
        public string skillName { get; set; }
        [JsonProperty("rank")]
        public int rank { get; set; }
        [JsonProperty("level")]
        public int level { get; set; }
        [JsonProperty("experience")]
        public int experience { get; set; }
        [JsonProperty("boostlevel")]
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
