using System.Collections.Generic;

namespace DotaUtility.Heroes.Strength.Radiant
{
    public class ElderTitan : Hero
    {
        public ElderTitan()
        {
            Abilities = new List<Ability>
            {
                new Ability
                {
                    IconName = "elder_titan_echo_stomp",
                    Value = "60 2\n" +
                            "67 3\n" +
                            "75 4\n" +
                            "82 5"
                },
                new Ability
                {
                    IconName = "elder_titan_ancestral_spirit",
                    Value = " 45 10  3\n" +
                            " 67 20  6\n" +
                            " 90 30  9\n" +
                            "112 40 12"
                },
                new Ability
                {
                    IconName = "elder_titan_natural_order",

                    Value = " 40 12\n" +
                             " 60 19\n" +
                            " 80 26\n" +
                            "100 33"
                },
                new Ability
                {
                    IconName = "elder_titan_earth_splitter",
                    Value = "30 30\n" +
                            "30 40\n" +
                            "30 50"
                }
            };
        }
    }
}