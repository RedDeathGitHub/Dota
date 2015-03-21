﻿using System.Collections.Generic;

namespace DotaUtility.Heroes.Agility.Dire
{
    public class Slark : Hero
    {
        public Slark()
        {
            Abilities = new List<Ability>
            {
                new Ability
                {
                    IconName = "slark_dark_pact",
                    Value = " 56  28\n" +
                            "112  56\n" +
                            "168  84\n" +
                            "225 112"
                },
                new Ability
                {
                    IconName = "slark_pounce",
                    Value = " 37\n" +
                            " 75\n" +
                            "112\n" +
                            "150"
                },
                new Ability
                {
                    IconName = "slark_essence_shift",
                    Value = " 15\n" +
                            " 30\n" +
                            " 60\n" +
                            "120"
                },
                new Ability
                {
                    IconName = "slark_shadow_dance",
                    Value = "3 30\n" +
                            "5 35\n" +
                            "7 40"
                }
            };
        }
    }
}