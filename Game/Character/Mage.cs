using RPG_Assignment_1.Game.Attributes;
using RPG_Assignment_1.Game.Enums;
using RPG_Assignment_1.Game.Functions;
using RPG_Assignment_1.Game.Interfaces;
using RPG_Assignment_1.Game.Items;

namespace RPG_Assignment_1.Game.Character
{
    public class Mage : ICreateHero
    {
        public int GetMainAttribute(PrimaryAttributes attribute)
        {
            return attribute.Inteligence;
        }
        public PrimaryAttributes SetBaseAttributes()
        {
            return new PrimaryAttributes(5, 1, 1, 8, 1);
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
            return attribute.Add(3, 1, 1, 5, 0);
        }
        public SecondaryAttributes LevelUpSecAttributes(PrimaryAttributes attribute)
        {
            return new SecondaryAttributes(attribute.Vitality * 10, attribute.Strength + attribute.Dexterity, attribute.Inteligence);
        }
        public PrimaryAttributes CalculateDps(PrimaryAttributes attribute, Weapon BaseWeaponAttribute)
        {
            double mainAttribute = attribute.Inteligence;
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

        public ArmorLists SetArmorReq()
        {
            ArmorLists armorList = new ArmorLists();
            armorList.ArmorReq.Add(ArmorTypes.Cloth);
            return armorList;
        }

        public WeaponLists SetWeaponReq()
        {
            WeaponLists weaponList = new WeaponLists();
            weaponList.WeaponReq.Add(WeaponTypes.Staff);
            weaponList.WeaponReq.Add(WeaponTypes.Wand);
            return weaponList;
        }
    }
}

