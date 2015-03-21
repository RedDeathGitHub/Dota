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
                    Value = " 91 4\n" +
                            "121 4\n" +
                            "151 4\n" +
                            "181 4"
                },
                new Ability
                {
                    IconName = "undying_soul_rip",
                    Value = "135 180\n" +
                            "198 264\n" +
                            "273 364\n" +
                            "360 480"
                },
                new Ability
                {
                    IconName = "undying_tombstone",
                    Value = " 75\n" +
                            "100\n" +
                            "125\n" +
                            "150"
                },
                new Ability
                {
                    IconName = "undying_flesh_golem",
                    Value = "15 25\n" +
                            "20 30\n" +
                            "25 35"
                }
            };
        }
    }
}