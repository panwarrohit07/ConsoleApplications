using System;
using ConsoleGameApp.Equipment.Interfaces;

namespace ConsoleGameApp.Equipment.Weapons.Sharp
{
    public class Sword : Sharp, IBuff
    {
        private const int DEFAULT_DAMAGE_POINTS = 10;
        public Sword()
            : this(DEFAULT_DAMAGE_POINTS)
        {
        }
        public Sword(int damagePoints)
        {
            this.DamagePoints = damagePoints;
        }
        public void Bloodthirst()
        {
            throw new NotImplementedException();
        }

        public void Buff()
        {
            this.Bloodthirst();
        }

        public override void SpecialAbility()
        {
            this.Buff();
        }
    }
}