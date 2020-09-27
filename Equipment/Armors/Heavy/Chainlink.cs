namespace ConsoleGameApp.Equipment.Armors.Heavy
{
    public class Chainlink : Heavy
    {
        private const int DEFAULT_ARMOR_POINT = 10;
        public Chainlink()
            : this(DEFAULT_ARMOR_POINT)
        {
            
        }
        public Chainlink(int armorPoints)
        {
            this.ArmorPoints = armorPoints;
        }
    }
}