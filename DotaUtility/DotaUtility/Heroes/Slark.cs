using System.Collections.Generic;

namespace DotaUtility.Heroes
{
    public class Slark : Hero
    {
        public Slark()
        {
            Abilities = new List<Ability>
            {
                new Ability
                {
                    IconName = "slark_dark_pact",
                    Value =
@" 56  28
112  56
168  84
225 112"
                },
                new Ability
                {
                    IconName = "slark_pounce",
                    Value =
@" 37
 75
112
150"
                },
                new Ability
                {
                    IconName = "slark_essence_shift",
                    Value =
@" 15
 30
 60
120"
                },
                new Ability
                {
                    IconName = "slark_shadow_dance",
                    Value =
@"3 30
5 35
7 40"
                }
            };
        }
    }
}