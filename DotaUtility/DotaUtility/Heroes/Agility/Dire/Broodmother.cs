﻿using System.Collections.Generic;

namespace DotaUtility.Heroes.Agility.Dire
{
    public class Broodmother : Hero
    {
        public Broodmother()
        {
            Abilities = new List<Ability>
            {
                new Ability
                {
                    IconNames = new List<string>
                    {
                        "broodmother_spawn_spiderlings",
                        @"broodmother\virulent_matriarch\broodmother_spawn_spiderlings"
                    },    
                        

                    Value = " 50 1\n" +
                            "110 2\n" +
                            "170 3\n" +
                            "220 4"
                },
                new Ability
                {
                    IconNames = new List<string>
                    {
                        "broodmother_spin_web",
                        @"broodmother\virulent_matriarch\broodmother_spin_web"
                    },
                    Value = "2 40\n" +
                            "4 50\n" +
                            "6 60\n" +
                            "8 70"
                },
                new Ability
                {
                    IconNames = new List<string>
                    {
                        "broodmother_incapacitating_bite",
                        @"broodmother\virulent_matriarch\broodmother_incapacitating_bite"
                    },
                    Value = "30 10\n" +
                            "40 20\n" +
                            "50 30\n" +
                            "60 40"
                },
                new Ability
                {
                    IconNames = new List<string>
                    {
                        "broodmother_insatiable_hunger",
                        @"broodmother\virulent_matriarch\broodmother_insatiable_hunger"
                    },
                    Value = " 60\n" +
                            " 90\n" +
                            "120"
                }
            };
        }
    }
}