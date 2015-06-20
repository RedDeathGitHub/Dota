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
                    IconNames = new List<string> { "undying_decay" },
                    Value = " 90 4\n" +
                            "120 4\n" +
                            "150 4\n" +
                            "180 4"
                },
                new Ability
                {
                    IconNames = new List<string> { "undying_soul_rip" },
                    Value = "130 180\n" +
                            "200 260\n" +
                            "270 360\n" +
                            "360 480"
                },
                new Ability
                {
                    IconNames = new List<string>
                    {
                        "undying_tombstone",
                        "undying_tombstone_alt",
                        "undying_tombstone_alt_gold"
                    },
                    Value = "175\n" +
                            "350\n" +
                            "525\n" +
                            "700"
                },
                new Ability
                {
                    IconNames = new List<string> { "undying_flesh_golem" },
                    Value = "20 30\n" +
                            "25 35\n" +
                            "30 40"
                }
            };
        }
    }
}