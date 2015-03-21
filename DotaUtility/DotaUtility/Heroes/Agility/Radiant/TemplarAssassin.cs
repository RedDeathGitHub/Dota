using System.Collections.Generic;

namespace DotaUtility.Heroes.Agility.Radiant
{
    public class TemplarAssassin : Hero
    {
        public TemplarAssassin()
        {
            Abilities = new List<Ability>
            {
                new Ability
                {
                    IconName = "templar_assassin_refraction",

                    Value = "3 20\n" +
                            "4 40\n" +
                            "5 60\n" +
                            "6 80"
                },
                new Ability
                {
                    IconName = "templar_assassin_meld",
                    Value = " 50 2\n" +
                            "100 4\n" +
                            "150 6\n" +
                            "200 8"
                },
                new Ability
                {
                    IconName = "templar_assassin_psi_blades",

                    Value = ""
                },
                new Ability
                {
                    IconName = "templar_assassin_psionic_trap",
                    Value = " 5 50\n" +
                            " 8 50\n" +
                            "11 50"
                }
            };
        }
    }
}