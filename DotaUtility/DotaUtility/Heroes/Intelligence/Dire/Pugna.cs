using System.Collections.Generic;

namespace DotaUtility.Heroes.Intelligence.Dire
{
    public class Pugna : Hero
    {
        public Pugna()
        {
            Abilities = new List<Ability>
            {
                new Ability
                {
                    IconName = "pugna_nether_blast",
                    Value = " 70\n" +
                            "130\n" +
                            "180\n" +
                            "240"
                },
                new Ability
                {
                    IconName = "pugna_decrepify",
                    Value = "30\n" +
                            "40\n" +
                            "50\n" +
                            "60"
                },
                new Ability
                {
                    IconName = "pugna_nether_ward",
                    Value = "0.7\n" +
                            "0.9\n" +
                            "1.1\n" +
                            "1.3"
                },
                new Ability
                {
                    IconName = "pugna_life_drain",
                    Value = " 900 1300\n" +
                            "1200 1800\n" +
                            "1500 2200"
                }
            };
        }
    }
}