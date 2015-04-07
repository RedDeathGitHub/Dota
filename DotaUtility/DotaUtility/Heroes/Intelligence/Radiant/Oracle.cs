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
                    Value = " 50 2.5\n" +
                            "110 2.5\n" +
                            "160 2.5\n" +
                            "220 2.5"
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
                    Value = " 60  99\n" +
                            "130 198\n" +
                            "200 297\n" +
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