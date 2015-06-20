using System.Collections.Generic;

namespace DotaUtility.Heroes.Intelligence.Dire
{
    public class ShadowDemon : Hero
    {
        public ShadowDemon()
        {
            Abilities = new List<Ability>
            {
                new Ability
                {
                    IconNames = new List<string> { "shadow_demon_disruption" },
                    Value = "30 2.5\n" +
                            "40 2.5\n" +
                            "50 2.5\n" +
                            "60 2.5"
                },
                new Ability
                {
                    IconNames = new List<string> { "shadow_demon_soul_catcher" },
                    Value = "20\n" +
                            "30\n" +
                            "40\n" +
                            "50"
                },
                new Ability
                {
                    IconNames = new List<string> { "shadow_demon_shadow_poison" },
                    Value = "15 - 240\n" +
                            "25 - 420\n" +
                            "35 - 600\n" +
                            "50 - 780"
                },
                new Ability
                {
                    IconNames = new List<string> { "shadow_demon_demonic_purge" },
                    Value = "150 100\n" +
                            "220 100\n" +
                            "300 100"
                }
            };
        }
    }
}