using System.Collections.Generic;

namespace DotaUtility.Heroes.Agility.Radiant
{
    public class Antimage : Hero
    {
        public Antimage()
        {
            Abilities = new List<Ability>
            {
                new Ability
                {
                    IconName = "antimage_mana_break",
                    Value = "30 15\n" +
                            "40 25\n" +
                            "50 30\n" +
                            "65 40"
                },
                new Ability
                {
                    IconName = "antimage_blink",
                    Value = "12\n" +
                            " 9\n" +
                            " 7\n" +
                            " 5"
                },
                new Ability
                {
                    IconName = "antimage_spell_shield",
                    Value = "20\n" +
                            "30\n" +
                            "40\n" +
                            "50"
                },
                new Ability
                {
                    IconName = "antimage_mana_void",
                    Value = "40\n" +
                            "60\n" +
                            "80"
                }
            };
        }
    }
}