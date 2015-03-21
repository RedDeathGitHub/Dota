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
                    Value = " 93 1.0\n" +
                            "131 1.2\n" +
                            "168 1.5\n" +
                            "206 1.7"
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

                    Value = "37 0.6\n" +
                            "56 0.9\n" +
                            "75 1.2\n" +
                            "93 1.5"
                },
                new Ability
                {
                    IconName = "earthshaker_echo_slam",
                    Value = "120 30\n" +
                            "157 41\n" +
                            "202 52"
                }
            };
        }
    }
}