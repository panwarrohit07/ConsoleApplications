using System;

namespace ConsoleGameApp
{
    public static class Tools
    {
        public static void ColorfulWriteLine(string message, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            System.Console.WriteLine(message);
            Console.ResetColor();
        }
        public static void TypeSpecificColorfulCW(string message, string type)
        {
            ConsoleColor color = ConsoleColor.White;

            switch(type)
            {
                case "ConsoleGameApp.Characters.Melee.Warrior":
                    color = ConsoleColor.DarkYellow;
                    break;
                case "ConsoleGameApp.Characters.Melee.Knight":
                    color = ConsoleColor.Yellow;
                    break;
                case "ConsoleGameApp.Characters.Melee.Assassin":
                    color = ConsoleColor.Gray;
                    break;
                case "ConsoleGameApp.Characters.Spellcasters.Mage":
                    color = ConsoleColor.Cyan;
                    break;
                case "ConsoleGameApp.Characters.Spellcasters.Druid":
                    color = ConsoleColor.DarkMagenta;
                    break;    
                case "ConsoleGameApp.Characters.Spellcasters.Necromancer":
                    color = ConsoleColor.Green;
                    break;
                default:
                    color = ConsoleColor.White;
                    break;
            }

            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}