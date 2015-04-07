using System.Collections.Generic;

namespace DotaUtility.Heroes.Strength.Radiant
{
    public class Tiny : Hero
    {
        public Tiny()
        {
            Abilities = new List<Ability>
            {
                new Ability
                {
                    IconName = "tiny_avalanche",
                    Value = " 70 1\n" +
                            "130 1\n" +
                            "200 1\n" +
                            "220 1"
                },
                new Ability
                {
                    IconName = "tiny_toss",
                    Value = " 50 100\n" +
                            "110 200\n" +
                            "160 300\n" +
                            "220 400"
                },
                new Ability
                {
                    IconName = "tiny_craggy_exterior",

                    Value = "10 1.0 2\n" +
                            "15 1.2 3\n" +
                            "20 1.5 4\n" +
                            "25 1.7 5"
                },
                new Ability
                {
                    IconName = "tiny_grow",

                    Value = "20  50 40\n" +
                            "35 100 50\n" +
                            "50 150 60"
                }
            };
        }
    }
}