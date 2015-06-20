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
                    IconNames = new List<string>
                    {
                        "ogre_magi_fireblast",
                        @"ogre_magi\antipodeanabilityicons\ogre_magi_fireblast"
                    },
                    Value = " 40 1.5\n" +
                            " 80 1.5\n" +
                            "120 1.5\n" +
                            "160 1.5"
                },
                new Ability
                {
                    IconNames = new List<string>
                    {
                        "ogre_magi_ignite",
                        @"ogre_magi\antipodeanabilityicons\ogre_magi_ignite"
                    },
                    Value = "100 20\n" +
                            "150 22\n" +
                            "220 24\n" +
                            "300 26"
                },
                new Ability
                {
                    IconNames = new List<string>
                    {
                        "ogre_magi_bloodlust",
                        @"ogre_magi\antipodeanabilityicons\ogre_magi_bloodlust"
                    },
                    Value = "20 10\n" +
                            "30 12\n" +
                            "40 14\n" +
                            "50 16"
                },
                new Ability
                {
                    IconNames = new List<string>
                    {
                        "ogre_magi_multicast",
                        @"ogre_magi\antipodeanabilityicons\ogre_magi_multicast"
                    },
                    Value = "60\n" +
                            "25\n" +
                            "12"
                },
                new Ability
                {
                    IconNames = new List<string>
                    {
                        "ogre_magi_unrefined_fireblast",
                        @"ogre_magi\antipodeanabilityicons\ogre_magi_unrefined_fireblast"
                    },
                    Value = "200 1.5"
                },
            };
        }
    }
}