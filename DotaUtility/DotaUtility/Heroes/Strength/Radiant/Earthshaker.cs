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
                    Value = " 90 1.0\n" +
                            "130 1.2\n" +
                            "160 1.5\n" +
                            "200 1.7"
                },
                new Ability
                {
                    IconName = "earthshaker_enchant_totem",
                    Value = "100\n" +
                            "200\n" +
                            "300\n" +
                            "400"
                },
                new Ability
                {
                    IconName = "earthshaker_aftershock",

                    Value = "40 0.6\n" +
                            "55 0.9\n" +
                            "75 1.2\n" +
                            "90 1.5"
                },
                new Ability
                {
                    IconName = "earthshaker_echo_slam",
                    Value = "120 30\n" +
                            "160 40\n" +
                            "200 50"
                }
            };
        }
    }
}