using System.Collections.Generic;

namespace DotaUtility.Heroes.Intelligence.Radiant
{
    public class Enchantress : Hero
    {
        public Enchantress()
        {
            Abilities = new List<Ability>
            {
                new Ability
                {
                    IconNames = new List<string> { "enchantress_untouchable" },
                    Value = " 40\n" +
                            " 70\n" +
                            "100\n" +
                            "130"
                },
                new Ability
                {
                    IconNames = new List<string> { "enchantress_enchant" },
                    Value = "20\n" +
                            "30\n" +
                            "40\n" +
                            "50"
                },
                new Ability
                {
                    IconNames = new List<string> { "enchantress_natures_attendants" },
                    Value = "300\n" +
                            "500\n" +
                            "700\n" +
                            "900"
                },
                new Ability
                {
                    IconNames = new List<string> { "enchantress_impetus" },
                    Value = "15\n" +
                            "20\n" +
                            "25"
                }
            };
        }
    }
}