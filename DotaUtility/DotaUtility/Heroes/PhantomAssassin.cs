using System.Collections.Generic;

namespace DotaUtility.Heroes
{
    public class PhantomAssassin : Hero
    {
        public PhantomAssassin()
        {
            Abilities = new List<Ability>
            {
                new Ability
                {
                    IconName = "phantom_assassin_stifling_dagger",
                    Value = "30\n" +
                            "50\n" +
                            "70\n" +
                            "90"
                },
                new Ability
                {
                    IconName = "phantom_assassin_phantom_strike",
                    Value = "130 4"
                },
                new Ability
                {
                    IconName = "phantom_assassin_blur",

                    Value = "20\n" +
                            "30\n" +
                            "40\n" +
                            "50"
                },
                new Ability
                {
                    IconName = "phantom_assassin_coup_de_grace",

                    Value = "20\n" +
                            "36\n" +
                            "52"
                }
            };
        }
    }
}