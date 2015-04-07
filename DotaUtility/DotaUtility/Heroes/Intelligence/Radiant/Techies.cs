using System.Collections.Generic;

namespace DotaUtility.Heroes.Intelligence.Radiant
{
    public class Techies : Hero
    {
        public Techies()
        {
            Abilities = new List<Ability>
            {
                new Ability
                {
                    IconName = "techies_land_mines",
                    Value = "300\n" +
                            "370\n" +
                            "450\n" +
                            "520"
                },
                new Ability
                {
                    IconName = "techies_stasis_trap",
                    Value = "2.5\n" +
                            "3.0\n" +
                            "3.5\n" +
                            "4.0"
                },
                new Ability
                {
                    IconName = "techies_suicide",
                    Value = " 500\n" +
                            " 600\n" +
                            " 900\n" +
                            "1200"
                },
                new Ability
                {
                    IconName = "techies_remote_mines",
                    Value = "220 340\n" +
                            "340 450\n" +
                            "450 560"
                }
            };
        }
    }
}