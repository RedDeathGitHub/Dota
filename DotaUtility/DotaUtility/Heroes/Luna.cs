using System.Collections.Generic;

namespace DotaUtility.Heroes
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

                    Value = " 56 0.6\n" +
                            "112 0.6\n" +
                            "168 0.6\n" +
                            "225 0.6"
                },
                new Ability
                {
                    IconName = "luna_moon_glaive",
                    Value = " 65\n" +
                            "107\n" +
                            "135\n" +
                            "172"
                },
                new Ability
                {
                    IconName = "luna_lunar_blessing",

                    Value = "14\n" +
                            "22\n" +
                            "30\n" +
                            "38"
                },
                new Ability
                {
                    IconName = "luna_eclipse",
                    Value = "900 3150"
                }
            };
        }
    }
}