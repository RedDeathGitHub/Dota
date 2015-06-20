using System.Collections.Generic;

namespace DotaUtility.Heroes.Strength.Radiant
{
    public class Earthshaker : Hero
    {
        public Earthshaker()
        {
            Abilities = new List<Ability>
            {
                new Ability
                {
                    IconNames = new List<string>
                    {
                        "earthshaker_fissure",
                        "earthshaker_fissure_alt",
                        "earthshaker_fissure_alt_gold",
                        "earthshaker_fissure_egset",
                        @"earthshaker\sltv__earthshaker_ability_icons\earthshaker_fissure"
                    },
                    Value = " 90 1.0\n" +
                            "130 1.2\n" +
                            "160 1.5\n" +
                            "200 1.7"
                },
                new Ability
                {
                    IconNames = new List<string>
                    {
                        "earthshaker_enchant_totem",
                        "earthshaker_enchant_totem_egset",
                        @"earthshaker\sltv__earthshaker_ability_icons\earthshaker_enchant_totem"
                    },
                    Value = "100\n" +
                            "200\n" +
                            "300\n" +
                            "400"
                },
                new Ability
                {
                    IconNames = new List<string>
                    {
                        "earthshaker_aftershock",
                        "earthshaker_aftershock_egset",
                        @"earthshaker\sltv__earthshaker_ability_icons\earthshaker_aftershock"
                    },
                    Value = "40 0.6\n" +
                            "55 0.9\n" +
                            "75 1.2\n" +
                            "90 1.5"
                },
                new Ability
                {
                    IconNames = new List<string>
                    {
                        "earthshaker_echo_slam",
                        "earthshaker_echo_slam_egset",
                        @"earthshaker\sltv__earthshaker_ability_icons\earthshaker_echo_slam"
                    },
                    Value = "120 30\n" +
                            "160 40\n" +
                            "200 50"
                }
            };
        }
    }
}