using System.Collections.Generic;

namespace DotaUtility.Heroes.Strength.Radiant
{
    public class Sven : Hero
    {
        public Sven()
        {
            Abilities = new List<Ability>
            {
                new Ability
                {
                    IconNames = new List<string>
                    {
                        "sven_storm_bolt",
                        @"sven\cyclopean_marauder_ability_icons\sven_storm_bolt",
                        @"sven\fiend_cleaver_icons\sven_storm_bolt"
                    },
                    Value = " 70 2\n" +
                            "130 2\n" +
                            "180 2\n" +
                            "240 2"
                },
                new Ability
                {
                    IconNames = new List<string>
                    {
                        "sven_great_cleave",
                        @"sven\cyclopean_marauder_ability_icons\sven_great_cleave",
                        @"sven\fiend_cleaver_icons\sven_great_cleave"
                    },
                    Value = "20\n" +
                            "35\n" +
                            "50\n" +
                            "65"
                },
                new Ability
                {
                    IconNames = new List<string>
                    {
                        "sven_warcry",
                        @"sven\cyclopean_marauder_ability_icons\sven_warcry",
                        @"sven\fiend_cleaver_icons\sven_warcry"
                    },
                    Value = " 5 12\n" +
                            "10 12\n" +
                            "15 12\n" +
                            "20 12"
                },
                new Ability
                {
                    IconNames = new List<string>
                    {
                        "sven_gods_strength",
                        @"sven\cyclopean_marauder_ability_icons\sven_gods_strength",
                        @"sven\fiend_cleaver_icons\sven_gods_strength"
                    },
                    Value = "100  50 25\n" +
                            "150  75 25\n" +
                            "200 100 25"
                }
            };
        }
    }
}