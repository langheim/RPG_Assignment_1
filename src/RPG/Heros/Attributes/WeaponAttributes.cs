namespace RPG_Assignment_1
{
    public class WeaponAttributes : Items
    {
        public WeaponTypes WeaponTypes { get; private set; }
        public double Damage { get; set; }
        public double AttackSpeed { get; set; }

        public WeaponAttributes(string name, WeaponTypes weaponTypes, int requiredLevel, SlotTypes slotTypes, double damage, double attackSpeed)
        {
            Name = name;
            WeaponTypes = weaponTypes;
            RequiredLevel = requiredLevel;
            SlotTypes = slotTypes;
            Damage = damage;
            AttackSpeed = attackSpeed;
        }
        public WeaponAttributes Add(WeaponAttributes weaponAttribute)
        {
            Name = weaponAttribute.Name;
            WeaponTypes = weaponAttribute.WeaponTypes;
            RequiredLevel = weaponAttribute.RequiredLevel;
            SlotTypes = weaponAttribute.SlotTypes;
            Damage = weaponAttribute.Damage;
            AttackSpeed = weaponAttribute.AttackSpeed;
            return this;
        }
        public WeaponAttributes Add(string name, WeaponTypes weaponTypes, int requiredLevel, SlotTypes slotTypes, double damage, double attackSpeed)
        {
            Name = name;
            WeaponTypes = weaponTypes;
            RequiredLevel = requiredLevel;
            SlotTypes = slotTypes;
            Damage = damage;
            AttackSpeed = attackSpeed;
            return this;
        }
    }
}