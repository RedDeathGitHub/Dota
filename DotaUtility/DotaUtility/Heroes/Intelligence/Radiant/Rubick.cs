using System.Collections.Generic;

namespace DotaUtility.Heroes.Intelligence.Radiant
{
    public class Rubick : Hero
    {
        public Rubick()
        {
            Abilities = new List<Ability>
            {
                new Ability
                {
                    IconNames = new List<string>
                    {
                        "rubick_telekinesis",
                        @"rubick\harlequin_icons\rubick_telekinesis"
                    },
                    Value = "1.5 1.0\n" +
                            "1.7 1.2\n" +
                            "2.0 1.5\n" +
                            "2.2 1.7"
                },
                new Ability
                {
                    IconNames = new List<string>
                    {
                        "rubick_fade_bolt",
                        @"rubick\harlequin_icons\rubick_fade_bolt"
                    },
                    Value = " 50 4 14\n" +
                            "100 4 20\n" +
                            "150 4 26\n" +
                            "210 4 32"
                },
                new Ability
                {
                    IconNames = new List<string>
                    {
                        "rubick_null_field",
                        @"rubick\harlequin_icons\rubick_null_field"
                    },
                    Value = " 5\n" +
                            "10\n" +
                            "15\n" +
                            "20"
                },
                new Ability
                {
                    IconNames = new List<string>
                    {
                        "rubick_spell_steal",
                        @"rubick\harlequin_icons\rubick_spell_steal"
                    },
                    Value = "3\n" +
                            "4\n" +
                            "5"
                }
            };
        }
    }
}