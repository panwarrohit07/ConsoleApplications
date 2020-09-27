using System;
using ConsoleGameApp.Enums;
using ConsoleGameApp.Equipment.Armors.Heavy;
using ConsoleGameApp.Equipment.Weapons.Sharp;

namespace ConsoleGameApp.Characters.Melee
{
    public class Warrior : Melee
    {
        private readonly Chainlink DEFAULT_BODY_ARMOR = new Chainlink();
        private readonly Axe DEFAULT_WEAPON = new Axe();

        Random rng = new Random();

        public Warrior()
            : this(Consts.Warrior.NAME, 1)
        {
        }
        public Warrior(string name, int level)
            : this(name,level, Consts.Warrior.HEALTH_POINTS)
        {
        }
        public Warrior(string name, int level, int healthPoints)
        {
            base.Name = name;
            base.Level = level;
            base.HealthPoints = healthPoints;
            base.AbilityPoints = Consts.Warrior.ABILITY_POINTS;
            base.BodyArmor = DEFAULT_BODY_ARMOR;
            base.Weapon = DEFAULT_WEAPON;
            base.Faction = Faction.Melee;
            base.IsAlive = true;
            base.Scores = 0;
        }

        public int Strike()
        {
            return base.Weapon.DamagePoints + rng.Next(0,10);
        }
        public int Execute()
        {
            throw new NotImplementedException();
        }
        public int SkinHarden()
        {
            return base.BodyArmor.ArmorPoints + rng.Next(0,5);
        }

        public override int Attack()
        {
            return this.Strike();
        }

        public override int Defend()
        {
            return this.SkinHarden();
        }

        public override int SpecialAttack()
        {
            return this.Execute();
        }
    }
}