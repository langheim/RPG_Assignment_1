using RPG_Assignment_1.Game.Enums;

namespace RPG_Assignment_1.Game.Functions
{
    public abstract class Items
    {
        public string Name { get; set; }
        public int RequiredLevel { get; set; }
        public SlotTypes SlotTypes { get; set; }
        public HeroTypes HeroTypes { get; init; }
    }
}
