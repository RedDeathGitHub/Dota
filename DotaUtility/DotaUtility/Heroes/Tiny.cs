using System.Collections.Generic;

namespace DotaUtility.Heroes
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
                    Value = " 75 1\n" +
                            "135 1\n" +
                            "195 1\n" +
                            "225 1"
                },
                new Ability
                {
                    IconName = "tiny_toss",
                    Value = " 56 101\n" +
                            "112 202\n" +
                            "168 303\n" +
                            "225 405"
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