using System;

namespace ConsoleGameApp.Characters.Melee
{
    public abstract class Melee : Character
    {
        private int abilityPoints;
        public int AbilityPoints 
        { 
            get
            {
                return this.abilityPoints;
            } 
            set
            {
                if(value >= 0 && value <= 100)
                {
                    this.abilityPoints = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "Inappropriate value!");
                }
            } 
        }
    }
}