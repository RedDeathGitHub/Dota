using System.Collections.Generic;

namespace DotaUtility.Heroes.Strength.Dire
{
    public class NightStalker : Hero
    {
        public NightStalker()
        {
            Abilities = new List<Ability>
            {
                new Ability
                {
                    IconNames = new List<string>
                    {
                        "night_stalker_void",
                        "night_stalker_void_alt"
                    },
                    Value = " 60 50\n" +
                            "120 50\n" +
                            "190 50\n" +
                            "250 50"
                },
                new Ability
                {
                    IconNames = new List<string> { "night_stalker_crippling_fear" },
                    Value = "50 5\n" +
                            "50 6\n" +
                            "50 7\n" +
                            "50 8"
                },
                new Ability
                {
                    IconNames = new List<string> { "night_stalker_hunter_in_the_night" },
                    Value = "20 45\n" +
                            "25 60\n" +
                            "30 75\n" +
                            "35 90"
                },
                new Ability
                {
                    IconNames = new List<string> { "night_stalker_darkness" },
                    Value = "50"
                }
            };
        }
    }
}