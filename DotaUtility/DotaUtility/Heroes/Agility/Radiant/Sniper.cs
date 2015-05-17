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

                    Value = "100 15\n" +
                            "200 20\n" +
                            "300 25\n" +
                            "400 30"
                },
                new Ability
                {
                    IconName = "sniper_headshot",
                    Value = " 5\n" +
                            "15\n" +
                            "25\n" +
                            "35"
                },
                new Ability
                {
                    IconName = "sniper_take_aim",

                    Value = ""
                },
                new Ability
                {
                    IconName = "sniper_assassinate",
                    Value = "240\n" +
                            "360\n" +
                            "480"
                }
            };
        }
    }
}