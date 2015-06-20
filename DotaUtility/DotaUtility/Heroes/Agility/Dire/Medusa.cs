using System.Collections.Generic;

namespace DotaUtility.Heroes.Agility.Dire
{
    public class Medusa : Hero
    {
        public Medusa()
        {
            Abilities = new List<Ability>
            {
                new Ability
                {
                    IconNames = new List<string>
                    {
                        "medusa_split_shot",
                        @"medusa\blueice_abilityicons\medusa_split_shot"
                    },
                    Value = "2\n" +
                            "3\n" +
                            "4\n" +
                            "5"
                },
                new Ability
                {
                    IconNames = new List<string>
                    {
                        "medusa_mystic_snake",
                        @"medusa\blueice_abilityicons\medusa_mystic_snake"
                    },
                    Value = "3  90\n" +
                            "4 150\n" +
                            "5 240\n" +
                            "6 330"
                },
                new Ability
                {
                    IconNames = new List<string>
                    {
                        "medusa_mana_shield",
                        @"medusa\blueice_abilityicons\medusa_mana_shield"
                    },
                    Value = "1.6\n" +
                            "1.9\n" +
                            "2.2\n" +
                            "2.5"
                },
                new Ability
                {
                    IconNames = new List<string>
                    {
                        "medusa_stone_gaze",
                        @"medusa\blueice_abilityicons\medusa_stone_gaze"
                    },
                    Value = "50 30\n" +
                            "50 40\n" +
                            "50 50"
                }
            };
        }
    }
}