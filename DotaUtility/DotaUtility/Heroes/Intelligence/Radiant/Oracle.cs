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
                    IconName = "oracle_fortunes_end",
                    Value = " 56 2.5\n" +
                            "112 2.5\n" +
                            "168 2.5\n" +
                            "225 2.5"
                },
                new Ability
                {
                    IconName = "oracle_fates_edict",
                    Value = "3\n" +
                            "4\n" +
                            "5\n" +
                            "6"
                },
                new Ability
                {
                    IconName = "oracle_purifying_flames",
                    Value = " 67  99\n" +
                            "135 198\n" +
                            "202 297\n" +
                            "270 396"
                },
                new Ability
                {
                    IconName = "oracle_false_promise",
                    Value = "7\n" +
                            "8\n" +
                            "9"
                }
            };
        }
    }
}