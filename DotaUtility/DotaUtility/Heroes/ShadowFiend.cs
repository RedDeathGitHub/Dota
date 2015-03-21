using System.Collections.Generic;

namespace DotaUtility.Heroes
{
    public class ShadowFiend : Hero
    {
        public ShadowFiend()
        {
            Abilities = new List<Ability>
            {
                new Ability
                {
                    IconName = "nevermore_shadowraze1",

                    Value = " 75\n" +
                            "131\n" +
                            "187\n" +
                            "243"
                },
                new Ability
                {
                    IconName = "nevermore_necromastery",
                    Value = "30\n" +
                            "44\n" +
                            "58\n" +
                            "72"
                },
                new Ability
                {
                    IconName = "nevermore_dark_lord",

                    Value = "3\n" +
                            "4\n" +
                            "5\n" +
                            "6"
                },
                new Ability
                {
                    IconName = "nevermore_requiem",
                    Value = "1080\n" +
                            "1620\n" +
                            "2160"
                }
            };
        }
    }
}