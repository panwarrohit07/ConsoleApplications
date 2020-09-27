namespace ConsoleGameApp.Equipment.Armors.Leather
{
    public class LeatherVest : Leather
    {
        private const int DEFAULT_ARMOR_POINT = 10;
        public LeatherVest()
            : this(DEFAULT_ARMOR_POINT)
        {
            
        }
        public LeatherVest(int armorPoints)
        {
            this.ArmorPoints = armorPoints;
        }
    }
}