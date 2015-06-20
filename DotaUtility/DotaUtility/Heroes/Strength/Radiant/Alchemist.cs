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
                    IconNames = new List<string> { "alchemist_acid_spray" },
                    Value = "200 4\n" +
                            "250 5\n" +
                            "320 6\n" +
                            "380 7"
                },
                new Ability
                {
                    IconNames = new List<string> { "alchemist_unstable_concoction" },
                    Value = "150 1.7\n" +
                            "220 2.5\n" +
                            "290 3.2\n" +
                            "360 4.0"
                },
                new Ability
                {
                    IconNames = new List<string> { "alchemist_goblins_greed" },

                    Value = " 6 12\n" +
                            " 8 20\n" +
                            "10 28\n" +
                            "12 36"
                },
                new Ability
                {
                    IconNames = new List<string> { "alchemist_chemical_rage" },
                    Value = " 50  20\n" +
                            " 70  80\n" +
                            "100 150"
                }
            };
        }
    }
}