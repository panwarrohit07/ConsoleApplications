using System;
using ConsoleGameApp.Equipment.Interfaces;

namespace ConsoleGameApp.Equipment.Weapons.Blunt
{
    public class Hammer : Blunt, ISpecialItemAbility
    {
        private const int DEFAULT_DAMAGE_POINTS = 10;
        public Hammer()
            : this(DEFAULT_DAMAGE_POINTS)
        {
            
        }
        public Hammer(int damagePoints)
        {
            this.DamagePoints = damagePoints;
        }
        public override void SpecialAbility()
        {
            this.Stun();
        }
        public void Stun()
        {
            throw new NotImplementedException();
        }
    }
}