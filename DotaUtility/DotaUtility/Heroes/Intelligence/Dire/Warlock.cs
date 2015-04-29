using System.Collections.Generic;

namespace DotaUtility.Heroes.Intelligence.Dire
{
    public class Warlock : Hero
    {
        public Warlock()
        {
            Abilities = new List<Ability>
            {
                new Ability
                {
                    IconName = "warlock_fatal_bonds",
                    Value = "3 25\n" +
                            "4 25\n" +
                            "5 25\n" +
                            "6 25"
                },
                new Ability
                {
                    IconName = "warlock_shadow_word",
                    Value = "120 160\n" +
                            "200 270\n" +
                            "280 380\n" +
                            "370 500"
                },
                new Ability
                {
                    IconName = "warlock_upheaval",
                    Value = "12\n" +
                            " 7\n" +
                            " 5\n" +
                            " 4"
                },
                new Ability
                {
                    IconName = "warlock_rain_of_chaos",
                    Value = "1"
                }
            };
        }
    }
}