using System.Collections.Generic;

namespace DotaUtility.Heroes.Intelligence.Radiant
{
    public class Tinker : Hero
    {
        public Tinker()
        {
            Abilities = new List<Ability>
            {
                new Ability
                {
                    IconNames = new List<string> { "tinker_laser" },
                    Value = " 80 3.0\n" +
                            "160 3.5\n" +
                            "240 4.0\n" +
                            "320 4.5"
                },
                new Ability
                {
                    IconNames = new List<string> { "tinker_heat_seeking_missile" },
                    Value = " 90\n" +
                            "150\n" +
                            "200\n" +
                            "260"
                },
                new Ability
                {
                    IconNames = new List<string>
                    {
                        "tinker_march_of_the_machines",
                       @"tinker\rollermawster\tinker_march_of_the_machines_1"
                    },
                    Value = "220\n" +
                            "320\n" +
                            "420\n" +
                            "520"
                },
                new Ability
                {
                    IconNames = new List<string> { "tinker_rearm" },
                    Value = "3\n" +
                            "2\n" +
                            "1"
                }
            };
        }
    }
}