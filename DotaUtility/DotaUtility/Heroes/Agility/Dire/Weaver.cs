using System.Collections.Generic;

namespace DotaUtility.Heroes.Agility.Dire
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
                    Value = " 50\n" +
                            " 70\n" +
                            " 90\n" +
                            "110"
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