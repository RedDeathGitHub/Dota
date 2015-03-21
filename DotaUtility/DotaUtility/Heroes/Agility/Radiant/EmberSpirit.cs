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
                    IconName = "ember_spirit_searing_chains",

                    Value = " 60 1\n" +
                            " 90 2\n" +
                            "180 2\n" +
                            "225 3"
                },
                new Ability
                {
                    IconName = "ember_spirit_sleight_of_fist",
                    Value = "20\n" +
                            "40\n" +
                            "60\n" +
                            "80"
                },
                new Ability
                {
                    IconName = "ember_spirit_flame_guard",

                    Value = "22  37\n" +
                            "30 150\n" +
                            "37 262\n" +
                            "45 375"
                },
                new Ability
                {
                    IconName = "ember_spirit_fire_remnant",
                    Value = " 75\n" +
                            "112\n" +
                            "150"
                }
            };
        }
    }
}