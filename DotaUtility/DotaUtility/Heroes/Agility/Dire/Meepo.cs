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
                    Value = "60\n" +
                            "70\n" +
                            "90\n" +
                            "100"
                },
                new Ability
                {
                    IconName = "meepo_geostrike",
                    Value = "10\n" +
                            "20\n" +
                            "30\n" +
                            "40"
                },
                new Ability
                {
                    IconName = "meepo_divided_we_stand",
                    Value = "1\n" +
                            "2\n" +
                            "3"
                }
            };
        }
    }
}