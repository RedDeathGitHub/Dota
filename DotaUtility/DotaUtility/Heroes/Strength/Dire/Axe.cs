using System.Collections.Generic;

namespace DotaUtility.Heroes.Strength.Dire
{
    public class Axe : Hero
    {
        public Axe()
        {
            Abilities = new List<Ability>
            {
                new Ability
                {
                    IconName = "axe_berserkers_call",
                    Value = "2.0 40\n" +
                            "2.4 40\n" +
                            "2.8 40\n" +
                            "3.2 40"
                },
                new Ability
                {
                    IconName = "axe_battle_hunger",
                    Value = "120 12\n" +
                            "180 12\n" +
                            "240 12\n" +
                            "300 12"
                },
                new Ability
                {
                    IconName = "axe_counter_helix",

                    Value = "100 20\n" +
                            "130 20\n" +
                            "170 20\n" +
                            "200 20"
                },
                new Ability
                {
                    IconName = "axe_culling_blade",
                    Value = "250 300\n" +
                            "320 420\n" +
                            "400 550"
                }
            };
        }
    }
}