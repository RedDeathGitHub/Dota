using System.Collections.Generic;

namespace DotaUtility.Heroes
{
    public class TrollWarlord : Hero
    {
        public TrollWarlord()
        {
            Abilities = new List<Ability>
            {
                new Ability
                {
                    IconName = "troll_warlord_berserkers_rage",
                    AdditionalIconNames = new List<string> { "troll_warlord_berserkers_rage_active"},
                    Value = "0.8 10\n" +
                            "1.2 20\n" +
                            "1.6 30\n" +
                            "2.0 40"
                },
                new Ability
                {
                    IconName = "troll_warlord_whirling_axes_ranged",
                    Value = @"56 30"
                },
                new Ability
                {
                    IconName = "troll_warlord_whirling_axes_melee",
                    Value = " 56 60\n" +
                            " 93 60\n" +
                            "131 60\n" +
                            "168 60"
                },
                new Ability
                {
                    IconName = "troll_warlord_fervor",

                    Value = "16\n" +
                            "22\n" +
                            "28\n" +
                            "34"
                },
                new Ability
                {
                    IconName = "troll_warlord_battle_trance",
                    Value = " 60\n" +
                            "120\n" +
                            "180"
                }
            };
        }
    }
}