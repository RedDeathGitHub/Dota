using System.Collections.Generic;

namespace DotaUtility.Heroes.Intelligence.Radiant
{
    public class OgreMagi : Hero
    {
        public OgreMagi()
        {
            Abilities = new List<Ability>
            {
                new Ability
                {
                    IconName = "ogre_magi_fireblast",
                    Value = " 41 1.5\n" +
                            " 82 1.5\n" +
                            "123 1.5\n" +
                            "165 1.5"
                },
                new Ability
                {
                    IconName = "ogre_magi_ignite",
                    Value = " 97 20\n" +
                            "153 22\n" +
                            "220 24\n" +
                            "300 26"
                },
                new Ability
                {
                    IconName = "ogre_magi_bloodlust",
                    Value = "20 10\n" +
                            "30 12\n" +
                            "40 14\n" +
                            "50 16"
                },
                new Ability
                {
                    IconName = "ogre_magi_multicast",
                    Value = "60\n" +
                            "25\n" +
                            "12"
                },
                new Ability
                {
                    IconName = "ogre_magi_unrefined_fireblast",
                    Value = "206 1.5"
                },
            };
        }
    }
}