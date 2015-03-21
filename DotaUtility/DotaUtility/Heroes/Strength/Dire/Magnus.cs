using System.Collections.Generic;

namespace DotaUtility.Heroes.Strength.Dire
{
    public class Magnus : Hero
    {
        public Magnus()
        {
            Abilities = new List<Ability>
            {
                new Ability
                {
                    IconName = "magnataur_shockwave",
                    Value = " 56\n" +
                            "112\n" +
                            "168\n" +
                            "225"
                },
                new Ability
                {
                    IconName = "magnataur_empower",
                    Value = "20\n" +
                            "30\n" +
                            "40\n" +
                            "50"
                },
                new Ability
                {
                    IconName = "magnataur_skewer",
                    Value = " 52 40\n" +
                            "105 40\n" +
                            "157 40\n" +
                            "210 40"
                },
                new Ability
                {
                    IconName = "magnataur_reverse_polarity",
                    Value = " 37 2.2\n" +
                            " 93 3.0\n" +
                            "150 3.7"
                }
            };
        }
    }
}