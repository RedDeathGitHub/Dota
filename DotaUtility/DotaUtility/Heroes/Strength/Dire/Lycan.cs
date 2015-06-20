using System.Collections.Generic;

namespace DotaUtility.Heroes.Strength.Dire
{
    public class Lycan : Hero
    {
        public Lycan()
        {
            Abilities = new List<Ability>
            {
                new Ability
                {
                    IconNames = new List<string>
                    {
                        "lycan_summon_wolves",
                        @"lycan\hunter_of_kings_ability_icons\lycan_summon_wolves"
                    },
                    Value = @"55"
                },
                new Ability
                {
                    IconNames = new List<string>
                    {
                        "lycan_howl",
                        @"lycan\hunter_of_kings_ability_icons\lycan_howl"
                    },
                    Value = "14  5\n" +
                            "26 10\n" +
                            "38 15\n" +
                            "50 20"
                },
                new Ability
                {
                    IconNames = new List<string>
                    {
                        "lycan_feral_impulse",
                        @"lycan\hunter_of_kings_ability_icons\lycan_feral_impulse"
                    },
                    Value = "15\n" +
                            "20\n" +
                            "25\n" +
                            "30"
                },
                new Ability
                {
                    IconNames = new List<string>
                    {
                        "lycan_shapeshift",
                        @"lycan\hunter_of_kings_ability_icons\lycan_shapeshift"
                    },
                    Value = "20"
                }
            };
        }
    }
}