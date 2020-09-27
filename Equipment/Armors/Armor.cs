using System;

namespace ConsoleGameApp.Equipment.Armors
{
    public abstract class Armor
    {
        private int armorPoints;
        public int ArmorPoints 
        { 
            get
            {
                return armorPoints;
            } 
            set
            {
                if(value>=0)
                {
                    this.armorPoints = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(
                        string.Empty, "Armor Points Value should be positive");
                }
            } 
        }
    }
}