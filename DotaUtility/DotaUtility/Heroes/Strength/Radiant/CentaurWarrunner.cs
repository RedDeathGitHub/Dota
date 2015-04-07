using System.Collections.Generic;

namespace DotaUtility.Heroes.Strength.Radiant
{
    public class CentaurWarrunner : Hero
    {
        public CentaurWarrunner()
        {
            Abilities = new List<Ability>
            {
                new Ability
                {
                    IconName = "centaur_hoof_stomp",
                    Value = " 70 2.0\n" +
                            "110 2.2\n" +
                            "150 2.5\n" +
                            "180 2.7"
                },
                new Ability
                {
                    IconName = "centaur_double_edge",
                    Value = "170\n" +
                            "180\n" +
                            "240\n" +
                            "300"
                },
                new Ability
                {
                    IconName = "centaur_return",

                    Value = "16 25\n" +
                            "18 35\n" +
                            "20 40\n" +
                            "22 50"
                },
                new Ability
                {
                    IconName = "centaur_stampede",
                    Value = "100 1.5\n" +
                            "200 1.5\n" +
                            "300 1.5"
                }
            };
        }
    }
}