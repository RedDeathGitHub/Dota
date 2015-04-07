using System.Collections.Generic;

namespace DotaUtility.Heroes.Intelligence.Radiant
{
    public class SkywrathMage : Hero
    {
        public SkywrathMage()
        {
            Abilities = new List<Ability>
            {
                new Ability
                {
                    IconName = "skywrath_mage_arcane_bolt",
                    Value = "45 1.2\n" +
                            "60 1.2\n" +
                            "75 1.2\n" +
                            "90 1.2"
                },
                new Ability
                {
                    IconName = "skywrath_mage_concussive_shot",
                    Value = " 45 30\n" +
                            " 90 35\n" +
                            "135 40\n" +
                            "180 45"
                },
                new Ability
                {
                    IconName = "skywrath_mage_ancient_seal",
                    Value = " 3 3\n" +
                            "-1 4\n" +
                            "-5 5\n" +
                            "-9 6"
                },
                new Ability
                {
                    IconName = "skywrath_mage_mystic_flare",
                    Value = " 450\n" +
                            " 750\n" +
                            "1050"
                }
            };
        }
    }
}