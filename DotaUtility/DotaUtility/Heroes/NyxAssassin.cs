using System.Collections.Generic;

namespace DotaUtility.Heroes
{
    public class NyxAssassin : Hero
    {
        public NyxAssassin()
        {
            Abilities = new List<Ability>
            {
                new Ability
                {
                    IconName = "nyx_assassin_impale",
                    Value =
@" 60 1.3
105 1.8
150 2.3
195 2.8"
                },
                new Ability
                {
                    IconName = "nyx_assassin_mana_burn",
                    Value =
@"3.5
4.0
4.5
5.0"
                },
                new Ability
                {
                    IconName = "nyx_assassin_spiked_carapace",

                    Value =
@"0.6
1.2
1.8
2.4"
                },
                new Ability
                {
                    IconName = "nyx_assassin_vendetta",
                    Value =
@"250 16
400 18
550 20"
                }
            };
        }
    }
}