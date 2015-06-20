using System.Collections.Generic;

namespace DotaUtility.Heroes.Intelligence.Dire
{
    public class DeathProphet : Hero
    {
        public DeathProphet()
        {
            Abilities = new List<Ability>
            {
                new Ability
                {
                    IconNames = new List<string>
                    {
                        "death_prophet_carrion_swarm",
                        "death_prophet_carrion_swarm_moth"
                    },
                    Value = " 50\n" +
                            "110\n" +
                            "160\n" +
                            "220"
                },
                new Ability
                {
                    IconNames = new List<string> { "death_prophet_silence" },
                    Value = "3\n" +
                            "4\n" +
                            "5\n" +
                            "6"
                },
                new Ability
                {
                    IconNames = new List<string> { "death_prophet_witchcraft" },
                    Value = " 5 3\n" +
                            "10 4\n" +
                            "15 5\n" +
                            "20 6"
                },
                new Ability
                {
                    IconNames = new List<string>
                    {
                        "death_prophet_exorcism",
                        @"death_prophet\awakened_thirst_ult_bat_icon\death_prophet_exorcism"
                    },
                    Value = " 6\n" +
                            "13\n" +
                            "21"
                }
            };
        }
    }
}