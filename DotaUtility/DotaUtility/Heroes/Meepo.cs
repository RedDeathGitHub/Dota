using System.Collections.Generic;

namespace DotaUtility.Heroes
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
                            "75\n" +
                            "90\n" +
                            "105"
                },
                new Ability
                {
                    IconName = "meepo_geostrike",
                    Value = "10\n" +
                            "21\n" +
                            "31\n" +
                            "42"
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