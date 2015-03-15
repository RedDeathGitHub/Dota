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
                    Value =
@"2
3
4
5"
                },
                new Ability
                {
                    IconName = "medusa_mystic_snake",
                    Value =
@"3  90
4 157
5 240
6 337"
                },
                new Ability
                {
                    IconName = "medusa_mana_shield",
                    Value =
@"1.6
1.9
2.2
2.5"
                },
                new Ability
                {
                    IconName = "medusa_stone_gaze",
                    Value =
@"50 30
50 40
50 50"
                }
            };
        }
    }
}