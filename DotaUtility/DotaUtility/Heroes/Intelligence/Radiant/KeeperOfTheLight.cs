﻿using System.Collections.Generic;

namespace DotaUtility.Heroes.Intelligence.Radiant
{
    public class KeeperOfTheLight : Hero
    {
        public KeeperOfTheLight()
        {
            Abilities = new List<Ability>
            {
                new Ability
                {
                    IconNames = new List<string>
                    {
                        "keeper_of_the_light_illuminate",
                        "keeper_of_the_light_spirit_form_illuminate"
                    },
                    Value = "150\n" +
                            "220\n" +
                            "300\n" +
                            "370"
                },
                new Ability
                {
                    IconNames = new List<string> { "keeper_of_the_light_mana_leak" },
                    Value = "5 1.5\n" +
                            "6 2.0\n" +
                            "7 2.5\n" +
                            "8 3.0"
                },
                new Ability
                {
                    IconNames = new List<string> { "keeper_of_the_light_chakra_magic" },
                    Value = " 70 1\n" +
                            "150 2\n" +
                            "220 3\n" +
                            "300 4"
                },
                new Ability
                {
                    IconNames = new List<string> { "keeper_of_the_light_recall" },
                    Value = "5\n" +
                            "4\n" +
                            "3"
                },
                new Ability
                {
                    IconNames = new List<string> { "keeper_of_the_light_blinding_light" },
                    Value = "80"
                }
            };
        }
    }
}