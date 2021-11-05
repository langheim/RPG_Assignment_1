using RPG_Assignment_1.Game.Functions;

namespace RPG_Assignment_1.Game.Attributes
{
    public class WeaponAttributes
    {
        public double Damage { get; set; }
        public double AttackSpeed { get; set; }


        public WeaponAttributes Add(WeaponAttributes weaponAttributes)
        {
            Damage += weaponAttributes.Damage ;
            AttackSpeed += weaponAttributes.AttackSpeed;
            return this;
        }


        public WeaponAttributes Add(double damage, double attackSpeed)
        {
            Damage += damage;
            AttackSpeed += attackSpeed;
            return this;
        }
    }
}
