using System.Collections.Generic;

namespace DotaUtility.Heroes.Strength.Dire
{
    public class Pudge : Hero
    {
        public Pudge()
        {
            Abilities = new List<Ability>
            {
                new Ability
                {
                    IconNames = new List<string>
                    {
                        "pudge_meat_hook",
                        "blackdeath_hookicon",
                        @"pudge\dotapit_s3_pudge\pudge_meat_hook",
                        @"pudge\scavenger_dragon_ability\pudge_meat_hook"
                    },
                    Value = " 90\n" +
                            "180\n" +
                            "270\n" +
                            "360"
                },
                new Ability
                {
                    IconNames = new List<string>
                    {
                        "pudge_rot",
                        "blackdeath_roticon",
                        @"pudge\dotapit_s3_pudge\pudge_rot",
                        @"pudge\scavenger_dragon_ability\pudge_rot"
                    },
                    Value = "25 20\n" +
                            "45 22\n" +
                            "60 24\n" +
                            "80 26"
                },
                new Ability
                {
                    IconNames = new List<string>
                    {
                        "pudge_flesh_heap",
                        "blackdeath_fleshheapicon",
                        @"pudge\dotapit_s3_pudge\pudge_flesh_heap",
                        @"pudge\scavenger_dragon_ability\pudge_flesh_heap"
                    },
                    Value = "1.0  6\n" +
                            "1.5  8\n" +
                            "2.0 10\n" +
                            "2.5 12"
                },
                new Ability
                {
                    IconNames = new List<string>
                    {
                        "pudge_dismember",
                        "blackdeath_dismembericon",
                        @"pudge\dotapit_s3_pudge\pudge_dismember",
                        @"pudge\scavenger_dragon_ability\pudge_dismember"
                    },
                    Value = "160 3\n" +
                            "280 3\n" +
                            "390 3"
                }
            };
        }
    }
}