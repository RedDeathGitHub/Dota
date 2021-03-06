﻿using System.Collections.Generic;

namespace DotaUtility.Heroes.Intelligence.Dire
{
    public class Invoker : Hero
    {
        public Invoker()
        {
            Abilities = new List<Ability>
            {
                new Ability
                {
                    IconNames = new List<string>
                    {
                        "invoker_quas",
                        @"invoker\magus_apex\invoker_quas"
                    },
                    Value = "1"
                },
                new Ability
                {
                    IconNames = new List<string>
                    {
                        "invoker_wex",
                        @"invoker\magus_apex\invoker_wex"
                    },
                    Value = "2 1"
                },
                new Ability
                {
                    IconNames = new List<string>
                    {
                        "invoker_exort",
                        @"invoker\magus_apex\invoker_exort"
                    },
                    Value = "3"
                },
                new Ability
                {
                    IconNames = new List<string> { "invoker_cold_snap" },
                    Value = "20 150\n" +
                            "50 210\n" +
                            "90 280\n" +
                            "360"
                },
                new Ability
                {
                    IconNames = new List<string> { "invoker_ghost_walk" },
                    Value = "20 - 50\n" +
                            "-30 - 30\n"
                },
                new Ability
                {
                    IconNames = new List<string> { "invoker_ice_wall" },
                    Value = "14 - 370\n" +
                            "20 - 140\n" +
                            " 3 -  12\n"
                },
                new Ability
                {
                    IconNames = new List<string> { "invoker_emp" },
                    Value = "100 325\n" +
                            "175 400\n" +
                            "250 475\n" +
                            "550"
                },
                new Ability
                {
                    IconNames = new List<string> { "invoker_tornado" },
                    Value = " 80 - 290\n" +
                            "0.8 - 2.5\n"
                },
                new Ability
                {
                    IconNames = new List<string> { "invoker_alacrity" },
                    Value = "20 50\n" +
                            "30 60\n" +
                            "40 70\n" +
                            "80"
                },
                new Ability
                {
                    IconNames = new List<string>
                    {
                        "invoker_sun_strike",
                        @"invoker\magus_apex\invoker_sun_strike"
                    },
                    Value = "100 280\n" +
                            "160 350\n" +
                            "220 410\n" +
                            "470"
                },
                new Ability
                {
                    IconNames = new List<string> { "invoker_forge_spirit" },
                    Value = "1 2\n" +
                            "1 2\n" +
                            "1 2\n" +
                            "2"
                },
                new Ability
                {
                    IconNames = new List<string> { "invoker_chaos_meteor" },
                    Value = "80 - 240\n" +
                            "10 -  24\n"
                },
                new Ability
                {
                    IconNames = new List<string> { "invoker_deafening_blast" },
                    Value = "30 - 210\n" +
                            "0.2 - 1.7\n" +
                            "1.0 - 4.0"
                }
            };
        }
    }
}