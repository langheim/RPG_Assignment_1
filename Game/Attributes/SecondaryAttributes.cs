namespace RPG_Assignment_1.Game.Attributes
{
    public struct SecondaryAttributes
    {
        public int Health { get; set; }
        public int ArmorRating { get; set; }
        public int ElementalResistance { get; set; }

        public SecondaryAttributes(int healt, int armorRating, int elementResistance)
        {
            Health = healt;
            ArmorRating = armorRating;
            ElementalResistance = elementResistance;
        }

        public SecondaryAttributes Add(PrimaryAttributes attributes)
        {
            Health += attributes.Vitality;
            ArmorRating += attributes.Strength + attributes.Dexterity;
            ElementalResistance += attributes.Inteligence;
            return this;
        }
    }
}
