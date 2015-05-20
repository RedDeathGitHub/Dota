﻿using System.Collections.Generic;

namespace DotaUtility.Heroes.Agility.Dire
{
    public class ShadowFiend : Hero
    {
        public ShadowFiend()
        {
            Abilities = new List<Ability>
            {
                new Ability
                {
                    IconName = "nevermore_shadowraze1",
                    AdditionalIconNames = new List<string>
                    {
                        "nevermore_shadowraze1_demon"
                    },
                    Value = " 70\n" +
                            "130\n" +
                            "180\n" +
                            "240"
                },
                new Ability
                {
                    IconName = "nevermore_necromastery",
                    AdditionalIconNames = new List<string>
                    {
                        "nevermore_necromastery_demon"
                    },
                    Value = "30\n" +
                            "44\n" +
                            "58\n" +
                            "72"
                },
                new Ability
                {
                    IconName = "nevermore_dark_lord",
                    AdditionalIconNames = new List<string>
                    {
                        "nevermore_dark_lord_demon"
                    },
                    Value = "3\n" +
                            "4\n" +
                            "5\n" +
                            "6"
                },
                new Ability
                {
                    IconName = "nevermore_requiem",
                    AdditionalIconNames = new List<string>
                    {
                        "nevermore_requiem_demon"
                    },
                    Value = "1000\n" +
                            "1600\n" +
                            "2200"
                }
            };
        }
    }
}