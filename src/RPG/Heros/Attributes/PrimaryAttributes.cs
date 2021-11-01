namespace RPG_Assignment_1
{
    public struct PrimaryAttributes
    {
        public int Level { get; private set; }
        public int Vitality { get; set; }
        public int Strengt { get; set; }
        public int Dexterity { get; set; }
        public int Inteligence { get; set; }
        public double DPS { get; set; }

        public PrimaryAttributes(int vitality, int strength, int dexterity, int inteligence, double dps, int level)
        {
            Vitality = vitality;
            Strengt = strength;
            Dexterity = dexterity;
            Inteligence = inteligence;
            DPS = dps;
            Level = level;
        }

        public PrimaryAttributes Add(PrimaryAttributes attribute)
        {
            Vitality += attribute.Vitality;
            Strengt += attribute.Strengt;
            Dexterity += attribute.Dexterity;
            Inteligence += attribute.Inteligence;
            DPS += attribute.DPS;
            Level += Level;
            return this;
        }

        public PrimaryAttributes Add(int vitality, int strengt, int dexterity, int inteligence, double dps, int level)
        {
            Vitality += vitality;
            Strengt += strengt;
            Dexterity += dexterity;
            Inteligence += inteligence;
            DPS += dps;
            Level += level;
            return this;
        }
        public PrimaryAttributes AddDPS(double dps)
        {
            DPS = dps;
            return this;
        }
    }
}
