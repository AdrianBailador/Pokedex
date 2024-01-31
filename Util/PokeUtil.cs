using System.Globalization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pokedex.Util
{
    public static class PokeUtil
    {
        public const string Pokeball = "icons8-pokeball-96.png";
        public const string GreatBall = "icons8-superball-96.png";
        public const string UltraBall = "icons8-ultra-ball-96.png";
        public const string MasterBall = "icons8-mega-ball-96.png";
        public static string GetRandomBall()
        {
            var pokeballArray = new string[] { Pokeball, GreatBall, UltraBall, MasterBall };
            var rand = new Random();
            string randomBall = pokeballArray[rand.Next(pokeballArray.Length)];
            return randomBall;
        }
        public static double GetPokemonHeightInMeters(int height)
        {
            return Convert.ToDouble(height) / 10;
        }
        public static double GetPokemonWeightInKilograms(int weight)
        {
            return Convert.ToDouble(weight) / 10;
        }
    }
}