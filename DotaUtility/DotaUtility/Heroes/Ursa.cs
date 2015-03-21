using System.Collections.Generic;

namespace DotaUtility.Heroes
{
    public class Ursa : Hero
    {
        public Ursa()
        {
            Abilities = new List<Ability>
            {
                new Ability
                {
                    IconName = "ursa_earthshock",

                    Value = " 67 25\n" +
                            "105 35\n" +
                            "142 45\n" +
                            "180 55"
                },
                new Ability
                {
                    IconName = "ursa_overpower",
                    Value = "3\n" +
                            "4\n" +
                            "5\n" +
                            "6"
                },
                new Ability
                {
                    IconName = "ursa_fury_swipes",

                    Value = "15\n" +
                            "20\n" +
                            "25\n" +
                            "30"
                },
                new Ability
                {
                    IconName = "ursa_enrage",
                    Value = "5\n" +
                            "6\n" +
                            "7"
                }
            };
        }
    }
}