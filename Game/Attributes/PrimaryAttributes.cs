namespace RPG_Assignment_1.Game.Attributes
{
    public struct PrimaryAttributes
    {
        public int Vitality { get; set; }
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Inteligence { get; set; }
        public double DPS { get; set; }

        public PrimaryAttributes(int vitality, int strength, int dexterity, int inteligence, double dps)
        {
            Vitality = vitality;
            Strength = strength;
            Dexterity = dexterity;
            Inteligence = inteligence;
            DPS = dps;
        }

        public PrimaryAttributes Add(PrimaryAttributes attribute)
        {
            Vitality += attribute.Vitality;
            Strength += attribute.Strength;
            Dexterity += attribute.Dexterity;
            Inteligence += attribute.Inteligence;
            DPS = attribute.DPS;
            return this;
        }

        public PrimaryAttributes Add(int vitality, int strength, int dexterity, int inteligence, double dps)
        {
            Vitality += vitality;
            Strength += strength;
            Dexterity += dexterity;
            Inteligence += inteligence;
            DPS = dps;
            return this;
        }
        public PrimaryAttributes Upd(PrimaryAttributes attribute)
        {
            Vitality += attribute.Vitality;
            Strength += attribute.Strength;
            Dexterity += attribute.Dexterity;
            Inteligence += attribute.Inteligence;
            return this;
        }
        public PrimaryAttributes AddDPS(double dps)
        {
            DPS = dps;
            return this;
        }
    }
}
