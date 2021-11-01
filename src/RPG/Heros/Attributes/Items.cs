using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Assignment_1
{
    public class Items
    {
        public string Name { get; set; }
        public int RequiredLevel { get; set; }
        public SlotTypes SlotTypes { get; set; }
        public PrimaryAttributes PrimaryAttributes { get; set; }

    }
}
