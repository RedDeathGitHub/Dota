using System.Collections.Generic;

namespace DotaUtility.Heroes.Intelligence.Radiant
{
    public class Lina : Hero
    {
        public Lina()
        {
            Abilities = new List<Ability>
            {
                new Ability
                {
                    IconName = "lina_dragon_slave",
                    AdditionalIconNames = new List<string>
                    {
                        "lina_dragon_slave_alt1"
                    },
                    Value = " 80\n" +
                            "130\n" +
                            "180\n" +
                            "240"
                },
                new Ability
                {
                    IconName = "lina_light_strike_array",
                    Value = " 90 1.6\n" +
                            "120 1.9\n" +
                            "150 2.2\n" +
                            "180 2.5"
                },
                new Ability
                {
                    IconName = "lina_fiery_soul",
                    AdditionalIconNames = new List<string>
                    {
                        "lina_fiery_soul_alt1"
                    },
                    Value = "120 15\n" +
                            "160 18\n" +
                            "210 21\n" +
                            "250 24"
                },
                new Ability
                {
                    IconName = "lina_laguna_blade",
                    Value = "330 450\n" +
                            "500 670\n" +
                            "710 950"
                }
            };
        }
    }
}