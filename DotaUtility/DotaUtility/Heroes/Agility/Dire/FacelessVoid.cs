using System.Collections.Generic;

namespace DotaUtility.Heroes.Agility.Dire
{
    public class FacelessVoid : Hero
    {
        public FacelessVoid()
        {
            Abilities = new List<Ability>
            {
                new Ability
                {
                    IconNames = new List<string>
                    {
                        "faceless_void_time_walk",
                        @"faceless_void\jewelofaeons\faceless_void_time_walk_1"
                    },
                    Value = "20\n" +
                            "30\n" +
                            "40\n" +
                            "50"
                },
                new Ability
                {
                    IconNames = new List<string> { "faceless_void_backtrack" },
                    Value = "10\n" +
                            "15\n" +
                            "20\n" +
                            "25"
                },
                new Ability
                {
                    IconNames = new List<string> { "faceless_void_time_lock" },
                    Value = "10\n" +
                            "15\n" +
                            "20\n" +
                            "25"
                },
                new Ability
                {
                    IconNames = new List<string> { "faceless_void_chronosphere" },
                    Value = "4.0 4\n" +
                            "4.5 5\n" +
                            "5.0 6"
                }
            };
        }
    }
}