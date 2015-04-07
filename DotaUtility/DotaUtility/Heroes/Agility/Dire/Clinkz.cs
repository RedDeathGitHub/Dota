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
                    IconName = "clinkz_strafe",

                    Value = " 4\n" +
                            " 6\n" +
                            " 8\n" +
                            "10"
                },
                new Ability
                {
                    IconName = "clinkz_searing_arrows",
                    Value = "30\n" +
                            "40\n" +
                            "50\n" +
                            "60"
                },
                new Ability
                {
                    IconName = "clinkz_wind_walk",

                    Value = "10\n" +
                            "20\n" +
                            "30\n" +
                            "40"
                },
                new Ability
                {
                    IconName = "clinkz_death_pact",
                    Value = "5 50\n" +
                            "6 65\n" +
                            "8 80"
                }
            };
        }
    }
}