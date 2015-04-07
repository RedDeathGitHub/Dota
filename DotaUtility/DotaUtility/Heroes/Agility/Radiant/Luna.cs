using System.Collections.Generic;

namespace DotaUtility.Heroes.Agility.Radiant
{
    public class Luna : Hero
    {
        public Luna()
        {
            Abilities = new List<Ability>
            {
                new Ability
                {
                    IconName = "luna_lucent_beam",

                    Value = " 50 0.6\n" +
                            "110 0.6\n" +
                            "160 0.6\n" +
                            "220 0.6"
                },
                new Ability
                {
                    IconName = "luna_moon_glaive",
                    Value = " 605\n" +
                            "110\n" +
                            "140\n" +
                            "170"
                },
                new Ability
                {
                    IconName = "luna_lunar_blessing",

                    Value = "15\n" +
                            "20\n" +
                            "30\n" +
                            "40"
                },
                new Ability
                {
                    IconName = "luna_eclipse",
                    Value = "900 3200"
                }
            };
        }
    }
}