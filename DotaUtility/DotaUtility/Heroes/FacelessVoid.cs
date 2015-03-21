using System.Collections.Generic;

namespace DotaUtility.Heroes
{
    public class FacelessVoid : Hero
    {
        public FacelessVoid()
        {
            Abilities = new List<Ability>
            {
                new Ability
                {
                    IconName = "faceless_void_time_walk",

                    Value = "20\n" +
                            "30\n" +
                            "40\n" +
                            "50"
                },
                new Ability
                {
                    IconName = "faceless_void_backtrack",
                    Value = "10\n" +
                            "15\n" +
                            "20\n" +
                            "25"
                },
                new Ability
                {
                    IconName = "faceless_void_time_lock",

                    Value = "10\n" +
                            "15\n" +
                            "20\n" +
                            "25"
                },
                new Ability
                {
                    IconName = "faceless_void_chronosphere",
                    Value = "4.0 4\n" +
                            "4.5 5\n" +
                            "5.0 6"
                }
            };
        }
    }
}