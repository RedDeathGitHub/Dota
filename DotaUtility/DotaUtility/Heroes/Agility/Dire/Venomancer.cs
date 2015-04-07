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

                    Value = " 20 50\n" +
                            "130 50\n" +
                            "280 50\n" +
                            "410 50"
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

                    Value = "10  70\n" +
                            "20 200\n" +
                            "30 320\n" +
                            "40 450"
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