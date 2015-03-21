using System.Collections.Generic;

namespace DotaUtility.Heroes
{
    public class NightStalker : Hero
    {
        public NightStalker()
        {
            Abilities = new List<Ability>
            {
                new Ability
                {
                    IconName = "night_stalker_void",
                    Value = " 67 50 35\n" +
                            "120 50 35\n" +
                            "191 50 35\n" +
                            "251 50 35"
                },
                new Ability
                {
                    IconName = "night_stalker_crippling_fear",
                    Value = "50 5\n" +
                            "50 6\n" +
                            "50 7\n" +
                            "50 8"
                },
                new Ability
                {
                    IconName = "night_stalker_hunter_in_the_night",

                    Value = "20 45\n" +
                            "25 60\n" +
                            "30 75\n" +
                            "35 90"
                },
                new Ability
                {
                    IconName = "night_stalker_darkness",
                    Value = "50"
                }
            };
        }
    }
}