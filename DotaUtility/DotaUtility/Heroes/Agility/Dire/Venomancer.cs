using System.Collections.Generic;

namespace DotaUtility.Heroes.Agility.Dire
{
    public class Venomancer : Hero
    {
        public Venomancer()
        {
            Abilities = new List<Ability>
            {
                new Ability
                {
                    IconName = "venomancer_venomous_gale",
                    Value = " 50 50\n" +
                            "180 50\n" +
                            "320 50\n" +
                            "450 50"
                },
                new Ability
                {
                    IconName = "venomancer_poison_sting",
                    Value = " 20 11\n" +
                            " 70 12\n" +
                            "140 13\n" +
                            "240 14"
                },
                new Ability
                {
                    IconName = "venomancer_plague_ward",
                    AdditionalIconNames = new List<string>
                    {
                        "venomancer_plague_ward_alt"
                    },
                    Value = "10  75\n" +
                            "19 200\n" +
                            "29 325\n" +
                            "38 450"
                },
                new Ability
                {
                    IconName = "venomancer_poison_nova",
                    Value = "350   650\n" +
                            "650  1000\n" +
                            "1000 1400"
                }
            };
        }
    }
}