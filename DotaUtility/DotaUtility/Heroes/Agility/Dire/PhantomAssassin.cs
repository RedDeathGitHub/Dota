using System.Collections.Generic;

namespace DotaUtility.Heroes.Agility.Dire
{
    public class PhantomAssassin : Hero
    {
        public PhantomAssassin()
        {
            Abilities = new List<Ability>
            {
                new Ability
                {
                    IconNames = new List<string>
                    {
                        "phantom_assassin_stifling_dagger",
                        "phantom_assassin_arcana_stifling_dagger",
                        @"phantom_assassin\ravening_ability_icons\phantom_assassin_stifling_dagger"
                    },
                    Value = "30\n" +
                            "50\n" +
                            "70\n" +
                            "90"
                },
                new Ability
                {
                    IconNames = new List<string>
                    {
                        "phantom_assassin_phantom_strike",
                        "phantom_assassin_arcana_phantom_strike",
                        @"phantom_assassin\ravening_ability_icons\phantom_assassin_phantom_strike"
                    },
                    Value = "14\n" +
                            "11\n" +
                            " 8\n" +
                            " 5"
                },
                new Ability
                {
                    IconNames = new List<string>
                    {
                        "phantom_assassin_blur",
                        "phantom_assassin_arcana_blur",
                        @"phantom_assassin\ravening_ability_icons\phantom_assassin_blur"
                    },
                    Value = "20\n" +
                            "30\n" +
                            "40\n" +
                            "50"
                },
                new Ability
                {
                    IconNames = new List<string>
                    {
                        "phantom_assassin_coup_de_grace",
                        "phantom_assassin_arcana_coup_de_grace",
                        @"phantom_assassin\ravening_ability_icons\phantom_assassin_coup_de_grace"
                    },
                    Value = "20\n" +
                            "36\n" +
                            "52"
                }
            };
        }
    }
}