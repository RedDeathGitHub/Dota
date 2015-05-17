using System.Collections.Generic;

namespace DotaUtility.Heroes.Strength.Radiant
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
                    Value = " 30 0.7\n" +
                            " 70 1.2\n" +
                            "110 1.7\n" +
                            "150 2.2"
                },
                new Ability
                {
                    IconName = "earth_spirit_rolling_boulder",
                    Value = @"75 80"
                },
                new Ability
                {
                    IconName = "earth_spirit_geomagnetic_grip",
                    Value = " 30 2.5\n" +
                            " 70 3.0\n" +
                            "110 3.5\n" +
                            "150 4.0"
                },
                new Ability
                {
                    IconName = "earth_spirit_magnetize",
                    Value = "220 220\n" +
                            "330 220\n" +
                            "450 220"
                }
            };
        }
    }
}