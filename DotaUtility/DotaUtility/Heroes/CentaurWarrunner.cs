using System.Collections.Generic;

namespace DotaUtility.Heroes
{
    public class CentaurWarrunner : Hero
    {
        public CentaurWarrunner()
        {
            Abilities = new List<Ability>
            {
                new Ability
                {
                    IconName = "centaur_hoof_stomp",
                    Value = " 75 2.0\n" +
                            "112 2.2\n" +
                            "150 2.5\n" +
                            "187 2.7"
                },
                new Ability
                {
                    IconName = "centaur_double_edge",
                    Value = "175\n" +
                            "187\n" +
                            "243\n" +
                            "300"
                },
                new Ability
                {
                    IconName = "centaur_return",

                    Value = "16 26\n" +
                            "18 34\n" +
                            "20 42\n" +
                            "22 50"
                },
                new Ability
                {
                    IconName = "centaur_stampede",
                    Value = "100 1.5\n" +
                            "200 1.5\n" +
                            "300 1.5"
                }
            };
        }
    }
}