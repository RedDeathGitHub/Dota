using System.Collections.Generic;

namespace DotaUtility.Heroes
{
    public class Weaver : Hero
    {
        public Weaver()
        {
            Abilities = new List<Ability>
            {
                new Ability
                {
                    IconName = "weaver_the_swarm",

                    Value = "15 1\n" +
                            "20 1\n" +
                            "25 1\n" +
                            "30 1"
                },
                new Ability
                {
                    IconName = "weaver_shukuchi",
                    Value = " 56\n" +
                            " 75\n" +
                            " 93\n" +
                            "112"
                },
                new Ability
                {
                    IconName = "weaver_geminate_attack",

                    Value = "6\n" +
                            "5\n" +
                            "4\n" +
                            "3"
                },
                new Ability
                {
                    IconName = "weaver_time_lapse",
                    Value = ""
                }
            };
        }
    }
}