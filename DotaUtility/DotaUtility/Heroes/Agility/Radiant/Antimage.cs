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
                    IconNames = new List<string> { "antimage_mana_break" },
                    Value = "28 16\n" +
                            "40 24\n" +
                            "52 31\n" +
                            "64 38"
                },
                new Ability
                {
                    IconNames = new List<string> { "antimage_blink" },
                    Value = "12\n" +
                            " 9\n" +
                            " 7\n" +
                            " 5"
                },
                new Ability
                {
                    IconNames = new List<string> { "antimage_spell_shield" },
                    Value = "26\n" +
                            "34\n" +
                            "42\n" +
                            "50"
                },
                new Ability
                {
                    IconNames = new List<string> { "antimage_mana_void" },
                    Value = "40\n" +
                            "60\n" +
                            "80"
                }
            };
        }
    }
}