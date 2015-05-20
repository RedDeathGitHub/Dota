using System.Collections.Generic;

namespace DotaUtility.Heroes.Agility.Radiant
{
    public class Sniper : Hero
    {
        public Sniper()
        {
            Abilities = new List<Ability>
            {
                new Ability
                {
                    IconName = "sniper_shrapnel",
                    AdditionalIconNames = new List<string>
                    {
                        "sniper_shrapnel_muh_keen_gun"
                    },
                    Value = "100 15\n" +
                            "200 20\n" +
                            "300 25\n" +
                            "400 30"
                },
                new Ability
                {
                    IconName = "sniper_headshot",
                    Value = " 6\n" +
                            "16\n" +
                            "26\n" +
                            "36"
                },
                new Ability
                {
                    IconName = "sniper_take_aim",
                    Value = ""
                },
                new Ability
                {
                    IconName = "sniper_assassinate",
                    AdditionalIconNames = new List<string>
                    {
                        "sniper_assassinate_muh_keen_gun"
                    },
                    Value = "240\n" +
                            "360\n" +
                            "480"
                }
            };
        }
    }
}