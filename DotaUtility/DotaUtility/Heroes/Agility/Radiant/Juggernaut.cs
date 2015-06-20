using System.Collections.Generic;

namespace DotaUtility.Heroes.Agility.Radiant
{
    public class Juggernaut : Hero
    {
        public Juggernaut()
        {
            Abilities = new List<Ability>
            {
                new Ability
                {
                    IconNames = new List<string>
                    {
                        "juggernaut_blade_fury",
                        @"juggernaut\bladekeeper\juggernaut_blade_fury"
                    },
                    Value = "300\n" +
                            "370\n" +
                            "450\n" +
                            "520"
                },
                new Ability
                {
                    IconNames = new List<string>
                    {
                        "juggernaut_healing_ward",
                        @"juggernaut\bladekeeper\juggernaut_healing_ward"
                    },
                    Value = " 55\n" +
                            " 80\n" +
                            "110\n" +
                            "140"
                },
                new Ability
                {
                    IconNames = new List<string>
                    {
                        "juggernaut_blade_dance",
                        @"juggernaut\bladekeeper\juggernaut_blade_dance"
                    },
                    Value = "20\n" +
                            "25\n" +
                            "30\n" +
                            "35"
                },
                new Ability
                {
                    IconNames = new List<string>
                    {
                        "juggernaut_omni_slash",
                        @"juggernaut\bladekeeper\juggernaut_omni_slash"
                    },
                    Value = " 600 1300\n" +
                            "1300 1900\n" +
                            "1900 2600"
                }
            };
        }
    }
}