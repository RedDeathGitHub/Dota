using System.Collections.Generic;

namespace DotaUtility.Heroes.Agility.Dire
{
    public class Spectre : Hero
    {
        public Spectre()
        {
            Abilities = new List<Ability>
            {
                new Ability
                {
                    IconName = "spectre_spectral_dagger",

                    Value = " 37  8\n" +
                            " 75 12\n" +
                            "112 16\n" +
                            "150 20"
                },
                new Ability
                {
                    IconName = "spectre_desolate",
                    Value = "20\n" +
                            "35\n" +
                            "50\n" +
                            "65"
                },
                new Ability
                {
                    IconName = "spectre_dispersion",

                    Value = "10\n" +
                            "14\n" +
                            "18\n" +
                            "22"
                },
                new Ability
                {
                    IconName = "spectre_haunt",
                    Value = "30 50"
                }
            };
        }
    }
}