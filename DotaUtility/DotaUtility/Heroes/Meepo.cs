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

                    Value =
@"2"
                },
                new Ability
                {
                    IconName = "meepo_poof",
                    Value =
@"60
75
90
105"
                },
                new Ability
                {
                    IconName = "meepo_geostrike",

                    Value =
@"10
21
31
42"
                },
                new Ability
                {
                    IconName = "meepo_divided_we_stand",
                    Value =
@"1
2
3"
                }
            };
        }
    }
}