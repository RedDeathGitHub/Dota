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

                    Value = " 18 50\n" +
                            "135 50\n" +
                            "281 50\n" +
                            "412 50"
                },
                new Ability
                {
                    IconName = "venomancer_poison_sting",
                    Value = " 26 11\n" +
                            " 75 12\n" +
                            "146 13\n" +
                            "240 14"
                },
                new Ability
                {
                    IconName = "venomancer_plague_ward",

                    Value = "10  75\n" +
                            "19 200\n" +
                            "29 325\n" +
                            "38 450"
                },
                new Ability
                {
                    IconName = "venomancer_poison_nova",
                    Value = "351  652\n" +
                            "652  972\n" +
                            "972 1377"
                }
            };
        }
    }
}