using System;
using ConsoleGameApp.Equipment.Interfaces;

namespace ConsoleGameApp.Equipment.Weapons.Blunt
{
    public class Staff : Blunt, IBuff
    {
        private const int DEFAULT_DAMAGE_POINTS = 10;
        public Staff()
            : this(DEFAULT_DAMAGE_POINTS)
        {
        }
        public Staff(int damagePoints)
        {
            this.DamagePoints = damagePoints;
        }
        public void Empower()
        {
            throw new NotImplementedException();
        }
        public void Buff()
        {
            this.Empower();
        }

        public override void SpecialAbility()
        {
            this.Buff();
        }
    }
}