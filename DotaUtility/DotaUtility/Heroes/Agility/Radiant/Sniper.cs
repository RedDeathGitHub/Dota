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
                    IconNames = new List<string>
                    {
                        "sniper_shrapnel",
                        "sniper_shrapnel_muh_keen_gun"
                    },
                    Value = "100 15\n" +
                            "200 20\n" +
                            "300 25\n" +
                            "400 30"
                },
                new Ability
                {
                    IconNames = new List<string> { "sniper_headshot" },
                    Value = " 6\n" +
                            "16\n" +
                            "26\n" +
                            "36"
                },
                new Ability
                {
                    IconNames = new List<string> { "sniper_take_aim" },
                    Value = ""
                },
                new Ability
                {
                    IconNames = new List<string>
                    {
                        "sniper_assassinate",
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