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
                    IconNames = new List<string> { "elder_titan_echo_stomp" },
                    Value = "60 2\n" +
                            "65 3\n" +
                            "75 4\n" +
                            "80 5"
                },
                new Ability
                {
                    IconNames = new List<string> { "elder_titan_ancestral_spirit" },
                    Value = " 45 10  3\n" +
                            " 65 20  6\n" +
                            " 90 30  9\n" +
                            "110 40 12"
                },
                new Ability
                {
                    IconNames = new List<string> { "elder_titan_natural_order" },
                    Value = " 40 12\n" +
                            " 60 19\n" +
                            " 80 26\n" +
                            "100 33"
                },
                new Ability
                {
                    IconNames = new List<string> { "elder_titan_earth_splitter" },
                    Value = "30 30\n" +
                            "30 40\n" +
                            "30 50"
                }
            };
        }
    }
}