using System.Collections.Generic;

namespace DotaUtility.Heroes.Intelligence.Radiant
{
    public class Windranger : Hero
    {
        public Windranger()
        {
            Abilities = new List<Ability>
            {
                new Ability
                {
                    IconNames = new List<string> { "windrunner_shackleshot" },
                    Value = "1.5\n" +
                            "2.2\n" +
                            "3.0\n" +
                            "3.7"
                },
                new Ability
                {
                    IconNames = new List<string> { "windrunner_powershot" },
                    Value = " 90\n" +
                            "150\n" +
                            "210\n" +
                            "270"
                },
                new Ability
                {
                    IconNames= new List<string>
                    {
                         "windrunner_windrun",
                        "windrunner_windrun_sylvan"
                    },
                    Value = " 8 50\n" +
                            "16 50\n" +
                            "24 50\n" +
                            "30 50"
                },
                new Ability
                {
                    IconNames = new List<string> { "windrunner_focusfire" },
                    Value = "50 30\n" +
                            "40 15\n" +
                            "30  0"
                }
            };
        }
    }
}