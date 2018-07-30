using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LegendaryOnline.Data.Heroes
{
    public class Hero
    {
        public int ID { get; internal set; }
        public string Name { get; internal set; }

        public List<HeroCard> HeroCards { get; internal set; }
    }
}
