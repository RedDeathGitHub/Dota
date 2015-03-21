using System.Collections.Generic;

namespace DotaUtility.Heroes
{
    public class Omniknight : Hero
    {
        public Omniknight()
        {
            Abilities = new List<Ability>
            {
                new Ability
                {
                    IconName = "omniknight_purification",
                    Value = " 90\n" +
                            "180\n" +
                            "270\n" +
                            "360"
                },
                new Ability
                {
                    IconName = "omniknight_repel",
                    Value = " 6\n" +
                            " 8\n" +
                            "10\n" +
                            "12"
                },
                new Ability
                {
                    IconName = "omniknight_degen_aura",

                    Value = "10\n" +
                            "18\n" +
                            "26\n" +
                            "34"
                },
                new Ability
                {
                    IconName = "omniknight_guardian_angel",
                    Value = "6  8\n" +
                            "7  9\n" +
                            "8 10"
                }
            };
        }
    }
}