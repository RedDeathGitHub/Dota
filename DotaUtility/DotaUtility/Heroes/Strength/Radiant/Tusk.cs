using System.Collections.Generic;

namespace DotaUtility.Heroes.Strength.Radiant
{
    public class Tusk : Hero
    {
        public Tusk()
        {
            Abilities = new List<Ability>
            {
                new Ability
                {
                    IconNames = new List<string> { "tusk_ice_shards" },
                    Value = " 50\n" +
                            "100\n" +
                            "150\n" +
                            "210"
                },
                new Ability
                {
                    IconNames = new List<string> { "tusk_snowball" },
                    Value = " 60 15 0.5\n" +
                            " 90 20 0.7\n" +
                            "120 30 1.0\n" +
                            "150 35 1.2"
                },
                new Ability
                {
                    IconNames = new List<string> { "tusk_frozen_sigil" },
                    Value = "30 10\n" +
                            "40 15\n" +
                            "50 20\n" +
                            "60 25"
                },
                new Ability
                {
                    IconNames = new List<string> { "tusk_walrus_punch" },
                    Value = "350 1 40\n" +
                            "350 1 40\n" +
                            "350 1 40"
                }
            };
        }
    }
}