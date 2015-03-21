using System.Collections.Generic;

namespace DotaUtility.Heroes.Strength.Radiant
{
    public class TreantProtector : Hero
    {
        public TreantProtector()
        {
            Abilities = new List<Ability>
            {
                new Ability
                {
                    IconName = "treant_natures_guise",
                    Value = "2 10 15\n" +
                            "2 10 30\n" +
                            "2 10 45\n" +
                            "2 10 60"
                },
                new Ability
                {
                    IconName = "treant_leech_seed",
                    Value = " 67 28\n" +
                            "135 28\n" +
                            "202 28\n" +
                            "270 28"
                },
                new Ability
                {
                    IconName = "treant_living_armor",
                    Value = " 80  60\n" +
                            "200 105\n" +
                            "360 150\n" +
                            "560 195"
                },
                new Ability
                {
                    IconName = "treant_overgrowth",
                    Value = "3.0 393\n" +
                            "3.7 525\n" +
                            "4.5 656"
                }
            };
        }
    }
}