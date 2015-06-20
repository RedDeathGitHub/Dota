using System.Collections.Generic;

namespace DotaUtility.Heroes.Intelligence.Radiant
{
    public class Oracle : Hero
    {
        public Oracle()
        {
            Abilities = new List<Ability>
            {
                new Ability
                {
                    IconNames = new List<string> { "oracle_fortunes_end" },
                    Value = " 50 2.5\n" +
                            "110 2.5\n" +
                            "160 2.5\n" +
                            "220 2.5"
                },
                new Ability
                {
                    IconNames = new List<string> { "oracle_fates_edict" },
                    Value = "3\n" +
                            "4\n" +
                            "5\n" +
                            "6"
                },
                new Ability
                {
                    IconNames = new List<string> { "oracle_purifying_flames" },
                    Value = " 60 100\n" +
                            "130 200\n" +
                            "200 300\n" +
                            "270 400"
                },
                new Ability
                {
                    IconNames = new List<string> { "oracle_false_promise" },
                    Value = "6\n" +
                            "7\n" +
                            "8"
                }
            };
        }
    }
}