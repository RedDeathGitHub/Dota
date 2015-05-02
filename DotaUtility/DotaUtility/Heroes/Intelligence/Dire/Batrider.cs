using System.Collections.Generic;

namespace DotaUtility.Heroes.Intelligence.Dire
{
    public class Batrider : Hero
    {
        public Batrider()
        {
            Abilities = new List<Ability>
            {
                new Ability
                {
                    IconName = "batrider_sticky_napalm",
                    Value = " 7 3\n" +
                            "11 5\n" +
                            "15 7\n" +
                            "19 9"
                },
                new Ability
                {
                    IconName = "batrider_flamebreak",
                    Value = " 30 1\n" +
                            " 70 2\n" +
                            "110 3\n" +
                            "150 4"
                },
                new Ability
                {
                    IconName = "batrider_firefly",
                    Value = " 5 2\n" +
                            "20 2\n" +
                            "35 2\n" +
                            "50 2"
                },
                new Ability
                {
                    IconName = "batrider_flaming_lasso",
                    Value = "3.0\n" +
                            "3.5\n" +
                            "4.0"
                }
            };
        }
    }
}