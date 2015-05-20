using System.Collections.Generic;

namespace DotaUtility.Heroes.Agility.Dire
{
    public class Meepo : Hero
    {
        public Meepo()
        {
            Abilities = new List<Ability>
            {
                new Ability
                {
                    IconName = "meepo_earthbind",
                    Value = "2"
                },
                new Ability
                {
                    IconName = "meepo_poof",
                    AdditionalIconNames = new List<string>
                    {
                        "meepo_poof_scavenger"
                    },
                    Value = "60\n" +
                            "70\n" +
                            "90\n" +
                            "100"
                },
                new Ability
                {
                    IconName = "meepo_geostrike",
                    AdditionalIconNames = new List<string>
                    {
                        "meepo_geostrike_scavenger"
                    },
                    Value = "10\n" +
                            "20\n" +
                            "30\n" +
                            "50"
                },
                new Ability
                {
                    IconName = "meepo_divided_we_stand",
                    AdditionalIconNames = new List<string>
                    {
                        "meepo_divided_we_stand_scavenger"
                    },
                    Value = "1\n" +
                            "2\n" +
                            "3"
                }
            };
        }
    }
}