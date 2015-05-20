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
                    IconName = "earthshaker_fissure",
                    AdditionalIconNames = new List<string>
                    {
                        "earthshaker_fissure_alt",
                        "earthshaker_fissure_alt_gold",
                        "earthshaker_fissure_egset"
                    },
                    Value = " 90 1.0\n" +
                            "130 1.2\n" +
                            "160 1.5\n" +
                            "200 1.7"
                },
                new Ability
                {
                    IconName = "earthshaker_enchant_totem",
                    AdditionalIconNames = new List<string>
                    {
                        "earthshaker_enchant_totem_egset"
                    },
                    Value = "100\n" +
                            "200\n" +
                            "300\n" +
                            "400"
                },
                new Ability
                {
                    IconName = "earthshaker_aftershock",
                    AdditionalIconNames = new List<string>
                    {
                        "earthshaker_aftershock_egset"
                    },
                    Value = "40 0.6\n" +
                            "55 0.9\n" +
                            "75 1.2\n" +
                            "90 1.5"
                },
                new Ability
                {
                    IconName = "earthshaker_echo_slam",
                    AdditionalIconNames = new List<string>
                    {
                        "earthshaker_echo_slam_egset"
                    },
                    Value = "120 30\n" +
                            "160 40\n" +
                            "200 50"
                }
            };
        }
    }
}