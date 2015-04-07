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
                    IconName = "pudge_meat_hook",
                    Value = " 90\n" +
                            "180\n" +
                            "270\n" +
                            "360"
                },
                new Ability
                {
                    IconName = "pudge_rot",
                    Value = "25 20\n" +
                            "45 20\n" +
                            "60 20\n" +
                            "80 20"
                },
                new Ability
                {
                    IconName = "pudge_flesh_heap",

                    Value = "30 1.0\n" +
                            "30 1.5\n" +
                            "30 2.0\n" +
                            "35 2.5"
                },
                new Ability
                {
                    IconName = "pudge_dismember",
                    Value = "160 3\n" +
                            "280 3\n" +
                            "390 3"
                }
            };
        }
    }
}