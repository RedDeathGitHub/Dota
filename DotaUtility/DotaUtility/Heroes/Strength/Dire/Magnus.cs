using System.Collections.Generic;

namespace DotaUtility.Heroes.Strength.Dire
{
    public class Magnus : Hero
    {
        public Magnus()
        {
            Abilities = new List<Ability>
            {
                new Ability
                {
                    IconNames = new List<string>
                    {
                        "magnataur_shockwave",
                        @"magnataur\forgemaster_icons\magnataur_shockwave"
                    },
                    Value = " 50\n" +
                            "110\n" +
                            "160\n" +
                            "220"
                },
                new Ability
                {
                    IconNames = new List<string>
                    {
                        "magnataur_empower",
                        @"magnataur\forgemaster_icons\magnataur_empower"
                    },
                    Value = "20\n" +
                            "30\n" +
                            "40\n" +
                            "50"
                },
                new Ability
                {
                    IconNames = new List<string>
                    {
                        "magnataur_skewer",
                        @"magnataur\forgemaster_icons\magnataur_skewer"
                    },
                    Value = " 50 40\n" +
                            "100 40\n" +
                            "160 40\n" +
                            "210 40"
                },
                new Ability
                {
                    IconNames = new List<string>
                    {
                        "magnataur_reverse_polarity",
                        @"magnataur\forgemaster_icons\magnataur_reverse_polarity"
                    },
                    Value = " 40 2.2\n" +
                            " 90 3.0\n" +
                            "150 3.7"
                }
            };
        }
    }
}