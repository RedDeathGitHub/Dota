using System.Collections.Generic;

namespace DotaUtility.Heroes.Strength.Radiant
{
    public class Beastmaster : Hero
    {
        public Beastmaster()
        {
            Abilities = new List<Ability>
            {
                new Ability
                {
                    IconName = "beastmaster_wild_axes",
                    Value = "140\n" +
                            "200\n" +
                            "230\n" +
                            "320"
                },
                new Ability
                {
                    IconName = "beastmaster_call_of_the_wild_hawk",
                    Value = "4 30\n" +
                            "4 40\n" +
                            "4 50\n" +
                            "4 60"
                },
                new Ability
                {
                    IconName = "beastmaster_call_of_the_wild_boar",
                    Value = "10 3 32\n" +
                            "20 3 32\n" +
                            "30 3 32\n" +
                            "40 3 32"
                },
                new Ability
                {
                    IconName = "beastmaster_inner_beast",

                    Value = "15\n" +
                            "25\n" +
                            "35\n" +
                            "45"
                },
                new Ability
                {
                    IconName = "beastmaster_primal_roar",
                    Value = "150 3.0 50\n" +
                            "187 3.5 50\n" +
                            "225 4.0 50"
                }
            };
        }
    }
}