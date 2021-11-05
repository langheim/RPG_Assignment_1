using RPG_Assignment_1.Game.Attributes;
using RPG_Assignment_1.Game.Enums;
using RPG_Assignment_1.Game.Functions;
using RPG_Assignment_1.Game.Interfaces;

namespace RPG_Assignment_1.Game.Character
{
    public class Rogue : ICreateHero
    {
        public int GetMainAttribute(PrimaryAttributes attribute)
        {
            return attribute.Dexterity;
        }
        public PrimaryAttributes SetBaseAttributes()
        {
            return new PrimaryAttributes(8, 2, 6, 1, 1);
        }
        public SecondaryAttributes SetBaseSecondaryAttributes(PrimaryAttributes attribute)
        {
            return new SecondaryAttributes(attribute.Vitality * 10, attribute.Strength + attribute.Dexterity, attribute.Inteligence);
        }
        public Armor NewBaseArmorAttributes()
        {
            return new Armor("No Armor", 0, SlotTypes.None, ArmorTypes.None);
        }
        public Weapon NewBaseWeaponAttributes()
        {
            return new Weapon("No Weapon", 0, SlotTypes.None, WeaponTypes.None);
        }
        public PrimaryAttributes LevelUpAttributes(PrimaryAttributes attribute)
        {
            return attribute.Add(3, 1, 4, 1, 0);
        }
        public SecondaryAttributes LevelUpSecAttributes(PrimaryAttributes attribute)
        {
            return new SecondaryAttributes(attribute.Vitality * 10, attribute.Strength + attribute.Dexterity, attribute.Inteligence);
        }
        public PrimaryAttributes CalculateDps(PrimaryAttributes attribute, Weapon BaseWeaponAttribute)
        {
            double mainAttribute = attribute.Dexterity;
            double Devider = 100;
            if (BaseWeaponAttribute.WeaponTypes != WeaponTypes.None)
            {
                double damage = BaseWeaponAttribute.WeaponAttributes.Damage * BaseWeaponAttribute.WeaponAttributes.AttackSpeed;
                double dps = damage * (1.0 + mainAttribute / 100.0);
                return attribute.AddDPS(dps);
            }
            else
            {
                double dps = (1 * (1 + mainAttribute / Devider));
                return attribute.AddDPS(dps);
            }
        }
    }
}

