using System.Collections.Generic;

namespace DotaUtility.Heroes
{
    public class Sven : Hero
    {
        public Sven()
        {
            Abilities = new List<Ability>
            {
                new Ability
                {
                    IconName = "sven_storm_bolt",
                    Value = " 75 2\n" +
                            "131 2\n" +
                            "187 2\n" +
                            "243 2"
                },
                new Ability
                {
                    IconName = "sven_great_cleave",

                    Value = "20\n" +
                            "35\n" +
                            "50\n" +
                            "65"
                },
                new Ability
                {
                    IconName = "sven_warcry",
                    Value = " 4 12\n" +
                            " 8 12\n" +
                            "12 12\n" +
                            "16 12"
                },
                new Ability
                {
                    IconName = "sven_gods_strength",
                    Value = "100  50 25\n" +
                            "150  75 25\n" +
                            "200 100 25"
                }
            };
        }
    }
}