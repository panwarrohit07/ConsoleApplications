using System;

namespace ConsoleGameApp.Characters.Spellcasters
{
    public abstract class Spellcaster : Character
    {   
        private int manaPoints;
        public int ManaPoints 
        { 
            get
            {
                return this.manaPoints;
            }
            set
            {
                if(value >= 0 && value <= 100)
                {
                    this.manaPoints = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(
                        string.Empty, "Inappropriate value!"
                    );
                }
            } 
        }
    }
}