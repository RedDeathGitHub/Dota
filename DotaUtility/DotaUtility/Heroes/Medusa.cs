using System.Collections.Generic;

namespace DotaUtility.Heroes
{
    public class Medusa : Hero
    {
        public Medusa()
        {
            Abilities = new List<Ability>
            {
                new Ability
                {
                    IconName = "medusa_split_shot",
                    Value = "2\n" +
                            "3\n" +
                            "4\n" +
                            "5"
                },
                new Ability
                {
                    IconName = "medusa_mystic_snake",
                    Value = "3  90\n" +
                            "4 157\n" +
                            "5 240\n" +
                            "6 337"
                },
                new Ability
                {
                    IconName = "medusa_mana_shield",
                    Value = "1.6\n" +
                            "1.9\n" +
                            "2.2\n" +
                            "2.5"
                },
                new Ability
                {
                    IconName = "medusa_stone_gaze",
                    Value = "50 30\n" +
                            "50 40\n" +
                            "50 50"
                }
            };
        }
    }
}