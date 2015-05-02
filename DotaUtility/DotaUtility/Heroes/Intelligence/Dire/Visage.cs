using System.Collections.Generic;

namespace DotaUtility.Heroes.Intelligence.Dire
{
    public class Visage : Hero
    {
        public Visage()
        {
            Abilities = new List<Ability>
            {
                new Ability
                {
                    IconName = "visage_grave_chill",
                    Value = "3 60\n" +
                            "4 60\n" +
                            "5 60\n" +
                            "6 60"
                },
                new Ability
                {
                    IconName = "visage_soul_assumption",
                    Value = " 15 160\n" +
                            " 60 210\n" +
                            "110 260\n" +
                            "300"
                },
                new Ability
                {
                    IconName = "visage_gravekeepers_cloak",
                    Value = " 4 20\n" +
                            " 8 30\n" +
                            "16 50\n" +
                            "20 65"
                },
                new Ability
                {
                    IconName = "visage_summon_familiars",
                    Value = "300 1.0\n" +
                            "450 1.2\n" +
                            "700 1.5"
                }
            };
        }
    }
}