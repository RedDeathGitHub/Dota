using System.Collections.Generic;

namespace DotaUtility.Heroes
{
    public class EarthSpirit : Hero
    {
        public EarthSpirit()
        {
            Abilities = new List<Ability>
            {
                new Ability
                {
                    IconName = "earth_spirit_boulder_smash",
                    Value = "93 0.7\n" +
                            "93 1.2\n" +
                            "93 1.7\n" +
                            "93 2.2"
                },
                new Ability
                {
                    IconName = "earth_spirit_rolling_boulder",
                    Value = @"75 80"
                },
                new Ability
                {
                    IconName = "earth_spirit_geomagnetic_grip",
                    Value = " 37 2.5\n" +
                            " 93 3.0\n" +
                            "150 3.5\n" +
                            "206 4.0"
                },
                new Ability
                {
                    IconName = "earth_spirit_magnetize",
                    Value = "225 225\n" +
                            "337 225\n" +
                            "450 225"
                }
            };
        }
    }
}