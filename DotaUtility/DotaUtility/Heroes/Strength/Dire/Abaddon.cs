using System.Collections.Generic;

namespace DotaUtility.Heroes.Strength.Dire
{
    public class Abaddon : Hero
    {
        public Abaddon()
        {
            Abilities = new List<Ability>
            {
                new Ability
                {
                    IconNames = new List<string>
                    {
                        "abaddon_death_coil",
                        "abaddon_death_coil_alliance"
                    },
                    Value = " 70  70\n" +
                            "110 100\n" +
                            "150 120\n" +
                            "180 150"
                },
                new Ability
                {
                    IconNames = new List<string>
                    {
                        "abaddon_aphotic_shield",
                        "abaddon_aphotic_shield_alliance"
                    },
                    Value = " 80 110\n" +
                            "100 140\n" +
                            "120 170\n" +
                            "150 200"
                },
                new Ability
                {
                    IconNames = new List<string>
                    {
                        "abaddon_frostmourne",
                        "abaddon_frostmourne_alliance"
                    },
                    Value = " 5 10\n" +
                            "10 20\n" +
                            "15 30\n" +
                            "20 40"
                },
                new Ability
                {
                    IconNames = new List<string>
                    {
                        "abaddon_borrowed_time",
                        "abaddon_borrowed_time_alliance"
                    },
                    Value = "4 400 5\n" +
                            "5 400 6\n" +
                            "6 400 7"
                }
            };
        }
    }
}