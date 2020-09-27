using System;
using ConsoleGameApp.Enums;
using ConsoleGameApp.Equipment.Armors.Leather;
using ConsoleGameApp.Equipment.Weapons.Blunt;
namespace ConsoleGameApp.Characters.Spellcasters
{
    public class Druid : Spellcaster
    {
        private readonly LeatherVest DEFAULT_BODY_ARMOR = new LeatherVest();
        private readonly Staff DEFAULT_WEAPON = new Staff();
        Random rng = new Random();

        public Druid()
            : this(Consts.Druid.NAME, 1)
        {
        }

        public Druid(string name, int level)
            : this(name, level, Consts.Druid.HEALTH_POINTS)
        {
        }

        public Druid(string name, int level, int healthPoints)
        {
            this.Name = name;
            this.Level = level;
            this.HealthPoints = healthPoints;
            this.ManaPoints = Consts.Druid.MANA_POINTS;
            this.BodyArmor = DEFAULT_BODY_ARMOR;
            this.Weapon = DEFAULT_WEAPON;
            this.Faction = Faction.Spellcaster;
            base.IsAlive = true;
            base.Scores = 0;
        }

        public int Moonfire()
        {
            return base.Weapon.DamagePoints + rng.Next(0,10);
        }

        public int Starburst()
        {
            throw new NotImplementedException();
        }

        public int OneWithTheNature()
        {
            return base.BodyArmor.ArmorPoints + rng.Next(0,5);
        }

        public override int Attack()
        {
            return this.Moonfire();
        }

        public override int SpecialAttack()
        {
            return this.Starburst();
        }

        public override int Defend()
        {
            return this.OneWithTheNature();
        }
    }
}