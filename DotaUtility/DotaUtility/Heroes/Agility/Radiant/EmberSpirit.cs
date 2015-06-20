using System.Collections.Generic;

namespace DotaUtility.Heroes.Agility.Radiant
{
    public class EmberSpirit : Hero
    {
        public EmberSpirit()
        {
            Abilities = new List<Ability>
            {
                new Ability
                {
                    IconNames = new List<string> { "ember_spirit_searing_chains" },
                    Value = " 60 1\n" +
                            " 90 2\n" +
                            "180 2\n" +
                            "220 3"
                },
                new Ability
                {
                    IconNames = new List<string> { "ember_spirit_sleight_of_fist" },
                    Value = "20\n" +
                            "40\n" +
                            "60\n" +
                            "80"
                },
                new Ability
                {
                    IconNames = new List<string> { "ember_spirit_flame_guard" },
                    Value = "180  40\n" +
                            "360 150\n" +
                            "600 260\n" +
                            "900 370"
                },
                new Ability
                {
                    IconNames = new List<string> { "ember_spirit_fire_remnant" },
                    Value = " 70\n" +
                            "110\n" +
                            "150"
                }
            };
        }
    }
}