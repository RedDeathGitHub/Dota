using System.Collections.Generic;

namespace DotaUtility.Heroes.Strength.Dire
{
    public class Undying : Hero
    {
        public Undying()
        {
            Abilities = new List<Ability>
            {
                new Ability
                {
                    IconName = "undying_decay",
                    Value = " 90 4\n" +
                            "120 4\n" +
                            "150 4\n" +
                            "180 4"
                },
                new Ability
                {
                    IconName = "undying_soul_rip",
                    Value = "130 180\n" +
                            "200 260\n" +
                            "270 360\n" +
                            "360 480"
                },
                new Ability
                {
                    IconName = "undying_tombstone",
                    Value = " 70\n" +
                            "100\n" +
                            "120\n" +
                            "150"
                },
                new Ability
                {
                    IconName = "undying_flesh_golem",
                    Value = "20 30\n" +
                            "25 35\n" +
                            "30 40"
                }
            };
        }
    }
}