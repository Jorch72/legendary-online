using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LegendaryOnline.Data.Heroes
{
    public class HeroCard
    {
        public int ID { get; internal set; }
        public string Name { get; internal set; }
        public int Cost { get; internal set; }
        public int BaseRecruit { get; internal set; }
        public int BaseAttack { get; internal set; }
        public HeroClass Class { get; internal set; }
        public HeroTeam Team { get; internal set; }

        public string ImagePath { get; internal set; }

        public Hero Hero { get; internal set; }
    }
}
