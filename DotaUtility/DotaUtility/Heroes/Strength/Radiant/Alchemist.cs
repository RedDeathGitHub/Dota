using System.Collections.Generic;

namespace DotaUtility.Heroes.Strength.Radiant
{
    public class Alchemist : Hero
    {
        public Alchemist()
        {
            Abilities = new List<Ability>
            {
                new Ability
                {
                    IconName = "alchemist_acid_spray",
                    Value = "12 4\n" +
                            "16 5\n" +
                            "20 6\n" +
                            "24 7"
                },
                new Ability
                {
                    IconName = "alchemist_unstable_concoction",
                    Value = "150 1.7\n" +
                            "220 2.5\n" +
                            "290 3.2\n" +
                            "360 4.0"
                },
                new Ability
                {
                    IconName = "alchemist_goblins_greed",

                    Value = " 6 12\n" +
                            " 8 20\n" +
                            "10 28\n" +
                            "12 36"
                },
                new Ability
                {
                    IconName = "alchemist_chemical_rage",
                    Value = " 50  25\n" +
                            " 75  87\n" +
                            "100 150"
                }
            };
        }
    }
}