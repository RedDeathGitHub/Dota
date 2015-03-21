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
                    Value = " 82\n" +
                            "135\n" +
                            "187\n" +
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
                    Value = "120 15\n" +
                            "165 18\n" +
                            "210 21\n" +
                            "255 24"
                },
                new Ability
                {
                    IconName = "lina_laguna_blade",
                    Value = "337 450\n" +
                            "506 675\n" +
                            "712 950"
                }
            };
        }
    }
}