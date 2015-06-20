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
                    IconNames = new List<string> { "weaver_the_swarm" },
                    Value = "1.4\n" +
                            "1.2\n" +
                            "1.1\n" +
                            "1.0"
                },
                new Ability
                {
                    IconNames = new List<string> { "weaver_shukuchi" },
                    Value = " 50\n" +
                            " 70\n" +
                            " 90\n" +
                            "110"
                },
                new Ability
                {
                    IconNames = new List<string> { "weaver_geminate_attack" },
                    Value = "6\n" +
                            "5\n" +
                            "4\n" +
                            "3"
                },
                new Ability
                {
                    IconNames = new List<string> { "weaver_time_lapse" },
                    Value = ""
                }
            };
        }
    }
}