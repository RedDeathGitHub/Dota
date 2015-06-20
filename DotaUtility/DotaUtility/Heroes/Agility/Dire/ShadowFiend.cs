using System.Collections.Generic;

namespace DotaUtility.Heroes.Agility.Dire
{
    public class ShadowFiend : Hero
    {
        public ShadowFiend()
        {
            Abilities = new List<Ability>
            {
                new Ability
                {
                    IconNames = new List<string>
                    {
                        "nevermore_shadowraze1",
                        "nevermore_shadowraze1_demon"
                    },
                    Value = " 70\n" +
                            "130\n" +
                            "180\n" +
                            "240"
                },
                new Ability
                {
                    IconNames = new List<string>
                    {
                        "nevermore_necromastery",
                        "nevermore_necromastery_demon"
                    },
                    Value = "30\n" +
                            "44\n" +
                            "58\n" +
                            "72"
                },
                new Ability
                {
                    IconNames = new List<string>
                    {
                        "nevermore_dark_lord",
                        "nevermore_dark_lord_demon"
                    },
                    Value = "3\n" +
                            "4\n" +
                            "5\n" +
                            "6"
                },
                new Ability
                {
                    IconNames = new List<string>
                    {
                        "nevermore_requiem",
                        "nevermore_requiem_demon"
                    },
                    Value = "1000\n" +
                            "1600\n" +
                            "2200"
                }
            };
        }
    }
}