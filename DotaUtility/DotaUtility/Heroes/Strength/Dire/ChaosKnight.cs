using System.Collections.Generic;

namespace DotaUtility.Heroes.Strength.Dire
{
    public class ChaosKnight : Hero
    {
        public ChaosKnight()
        {
            Abilities = new List<Ability>
            {
                new Ability
                {
                    IconName = "chaos_knight_chaos_bolt",
                    Value = "100 1 2\n" +
                            "120 1 3\n" +
                            "140 1 4\n" +
                            "160 2 4"
                },
                new Ability
                {
                    IconName = "chaos_knight_reality_rift",
                    Value = " 60\n" +
                            " 80\n" +
                            "100\n" +
                            "120"
                },
                new Ability
                {
                    IconName = "chaos_knight_chaos_strike",

                    Value = " 5\n" +
                            "10\n" +
                            "15\n" +
                            "20"
                },
                new Ability
                {
                    IconName = "chaos_knight_phantasm",
                    Value = "1 100 50\n" +
                            "2 100 50\n" +
                            "3 100 50"
                }
            };
        }
    }
}