using System.Collections.Generic;

namespace DotaUtility.Heroes.Agility.Radiant
{
    public class BountyHunter : Hero
    {
        public BountyHunter()
        {
            Abilities = new List<Ability>
            {
                new Ability
                {
                    IconName = "bounty_hunter_shuriken_toss",

                    Value = " 70\n" +
                            "150\n" +
                            "180\n" +
                            "240"
                },
                new Ability
                {
                    IconName = "bounty_hunter_jinada",
                    Value = "150 25\n" +
                            "170 25\n" +
                            "200 25\n" +
                            "220 25"
                },
                new Ability
                {
                    IconName = "bounty_hunter_wind_walk",

                    Value = " 30 1.0\n" +
                            " 60 0.7\n" +
                            " 90 0.5\n" +
                            "120 0.3"
                },
                new Ability
                {
                    IconName = "bounty_hunter_track",
                    Value = "200  50\n" +
                            "270 100\n" +
                            "350 150"
                }
            };
        }
    }
}