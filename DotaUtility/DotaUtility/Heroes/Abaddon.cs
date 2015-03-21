using System.Collections.Generic;

namespace DotaUtility.Heroes
{
    public class Abaddon : Hero
    {
        public Abaddon()
        {
            Abilities = new List<Ability>
            {
                new Ability
                {
                    IconName = "abaddon_death_coil",
                    Value = " 75  75\n" +
                            "112 100\n" +
                            "150 125\n" +
                            "187 150"
                },
                new Ability
                {
                    IconName = "abaddon_aphotic_shield",
                    Value = " 82 110\n" +
                            "105 140\n" +
                            "127 170\n" +
                            "150 200"
                },
                new Ability
                {
                    IconName = "abaddon_frostmourne",

                    Value = " 5 10\n" +
                            "10 20\n" +
                            "15 30\n" +
                            "20 40"
                },
                new Ability
                {
                    IconName = "abaddon_borrowed_time",
                    Value = "4 400 5\n" +
                            "5 400 6\n" +
                            "6 400 7"
                }
            };
        }
    }
}