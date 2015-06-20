using System.Collections.Generic;

namespace DotaUtility.Heroes.Agility.Radiant
{
    public class Ursa : Hero
    {
        public Ursa()
        {
            Abilities = new List<Ability>
            {
                new Ability
                {
                    IconNames = new List<string> { "ursa_earthshock" },

                    Value = " 60 25\n" +
                            "100 35\n" +
                            "140 45\n" +
                            "180 55"
                },
                new Ability
                {
                    IconNames = new List<string> { "ursa_overpower" },
                    Value = "3\n" +
                            "4\n" +
                            "5\n" +
                            "6"
                },
                new Ability
                {
                    IconNames = new List<string> { "ursa_fury_swipes" },

                    Value = "15\n" +
                            "20\n" +
                            "25\n" +
                            "30"
                },
                new Ability
                {
                    IconNames = new List<string> { "ursa_enrage" },
                    Value = "1.5 80\n" +
                            "2.0 80\n" +
                            "2.5 80"
                }
            };
        }
    }
}