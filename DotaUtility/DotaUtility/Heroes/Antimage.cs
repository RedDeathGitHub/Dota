using System.Collections.Generic;

namespace DotaUtility.Heroes
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
                    Value = "28 16\n" +
                            "40 24\n" +
                            "52 31\n" +
                            "64 38"
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
                    Value = "44\n" +
                            "50\n" +
                            "56\n" +
                            "62"
                },
                new Ability
                {
                    IconName = "antimage_mana_void",
                    Value = "45\n" +
                            "63\n" +
                            "82"
                }
            };
        }
    }
}