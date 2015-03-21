using System.Collections.Generic;

namespace DotaUtility.Heroes.Intelligence.Radiant
{
    public class ShadowShaman : Hero
    {
        public ShadowShaman()
        {
            Abilities = new List<Ability>
            {
                new Ability
                {
                    IconName = "shadow_shaman_ether_shock",
                    Value = "105\n" +
                            "150\n" +
                            "195\n" +
                            "240"
                },
                new Ability
                {
                    IconName = "shadow_shaman_voodoo",
                    Value = "1.2\n" +
                            "2.0\n" +
                            "2.7\n" +
                            "3.5"
                },
                new Ability
                {
                    IconName = "shadow_shaman_shackles",
                    Value = " 84 2.7\n" +
                            "105 3.5\n" +
                            "129 4.2\n" +
                            "150 5.0"
                },
                new Ability
                {
                    IconName = "shadow_shaman_mass_serpent_ward",
                    Value = ""
                }
            };
        }
    }
}