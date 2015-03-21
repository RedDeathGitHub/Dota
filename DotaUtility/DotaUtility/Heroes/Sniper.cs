using System.Collections.Generic;

namespace DotaUtility.Heroes
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

                    Value = " 99 15\n" +
                            "198 20\n" +
                            "297 25\n" +
                            "396 30"
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
                    Value = "266\n" +
                            "378\n" +
                            "491"
                }
            };
        }
    }
}