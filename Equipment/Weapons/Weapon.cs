using System;
namespace ConsoleGameApp.Equipment.Weapons
{
    public abstract class Weapon
    {
        private int damagePoints;
        public int DamagePoints 
        {
            get
            {
                return damagePoints;
            }
            set
            {
                if(value >= 0)
                {
                    this.damagePoints = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(
                        string.Empty, "Damage Points should be positive");
                }
            } 
        }
        public abstract void SpecialAbility();
    }
}