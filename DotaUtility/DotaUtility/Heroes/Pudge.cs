using System.Collections.Generic;

namespace DotaUtility.Heroes
{
    public class Pudge : Hero
    {
        public Pudge()
        {
            Abilities = new List<Ability>
            {
                new Ability
                {
                    IconName = "pudge_meat_hook",
                    Value = " 90\n" +
                            "180\n" +
                            "270\n" +
                            "360"
                },
                new Ability
                {
                    IconName = "pudge_rot",
                    Value = "26 20\n" +
                            "45 20\n" +
                            "63 20\n" +
                            "82 20"
                },
                new Ability
                {
                    IconName = "pudge_flesh_heap",

                    Value = "29 1.0\n" +
                            "31 1.5\n" +
                            "32 2.0\n" +
                            "34 2.5"
                },
                new Ability
                {
                    IconName = "pudge_dismember",
                    Value = "168 3\n" +
                            "281 3\n" +
                            "393 3"
                }
            };
        }
    }
}