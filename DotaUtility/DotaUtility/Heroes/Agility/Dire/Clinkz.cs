using System.Collections.Generic;

namespace DotaUtility.Heroes.Agility.Dire
{
    public class Clinkz : Hero
    {
        public Clinkz()
        {
            Abilities = new List<Ability>
            {
                new Ability
                {
                    IconNames = new List<string> { "clinkz_strafe" },
                    Value = " 4\n" +
                            " 6\n" +
                            " 8\n" +
                            "10"
                },
                new Ability
                {
                    IconNames = new List<string> { "clinkz_searing_arrows" },
                    Value = "30\n" +
                            "40\n" +
                            "50\n" +
                            "60"
                },
                new Ability
                {
                    IconNames = new List<string> { "clinkz_wind_walk" },
                    Value = "11\n" +
                            "22\n" +
                            "33\n" +
                            "44"
                },
                new Ability
                {
                    IconNames = new List<string> { "clinkz_death_pact" },
                    Value = "5.0 50\n" +
                            "6.5 65\n" +
                            "8.0 80"
                }
            };
        }
    }
}