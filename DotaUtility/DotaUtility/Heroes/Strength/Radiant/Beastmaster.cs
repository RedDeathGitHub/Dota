﻿using System.Collections.Generic;

namespace DotaUtility.Heroes.Strength.Radiant
{
    public class Beastmaster : Hero
    {
        public Beastmaster()
        {
            Abilities = new List<Ability>
            {
                new Ability
                {
                    IconNames = new List<string> { "beastmaster_wild_axes" },
                    Value = "140\n" +
                            "200\n" +
                            "230\n" +
                            "320"
                },
                new Ability
                {
                    IconNames = new List<string> { "beastmaster_call_of_the_wild_hawk" },
                    Value = "4 30\n" +
                            "4 40\n" +
                            "4 50\n" +
                            "4 60"
                },
                new Ability
                {
                    IconNames = new List<string> { "beastmaster_call_of_the_wild_boar" },
                    Value = "10 3 30\n" +
                            "20 3 30\n" +
                            "30 3 30\n" +
                            "40 3 30"
                },
                new Ability
                {
                    IconNames = new List<string> { "beastmaster_inner_beast" },

                    Value = "15\n" +
                            "25\n" +
                            "35\n" +
                            "45"
                },
                new Ability
                {
                    IconNames = new List<string> { "beastmaster_primal_roar" },
                    Value = "150 3.0 50\n" +
                            "180 3.5 50\n" +
                            "220 4.0 50"
                }
            };
        }
    }
}