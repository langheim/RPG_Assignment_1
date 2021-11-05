using RPG_Assignment_1.Game.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Assignment_1.Game.Character
{
    public class ArmorList
    {
        public HeroTypes HeroTypes { get; init; }
        public ArmorTypes ArmorTypes1 { get; set; }
        public ArmorTypes ArmorTypes2 { get; set; }
        public ArmorTypes ArmorTypes3 { get; set; }
        public ArmorTypes ArmorTypes4 { get; set; }
        public ArmorTypes ArmorTypes5 { get; set; }

        public ArmorList()
        {
        }
    }
}
