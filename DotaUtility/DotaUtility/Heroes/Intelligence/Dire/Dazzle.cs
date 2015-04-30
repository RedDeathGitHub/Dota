using System.Collections.Generic;

namespace DotaUtility.Heroes.Intelligence.Dire
{
    public class Dazzle : Hero
    {
        public Dazzle()
        {
            Abilities = new List<Ability>
            {
                new Ability
                {
                    IconName = "dazzle_poison_touch",
                    Value = "110\n" +
                            "160\n" +
                            "200\n" +
                            "260"
                },
                new Ability
                {
                    IconName = "dazzle_shallow_grave",
                    Value = "5"
                },
                new Ability
                {
                    IconName = "dazzle_shadow_wave",
                    Value = " 80 3\n" +
                            "100 4\n" +
                            "120 5\n" +
                            "140 6"
                },
                new Ability
                {
                    IconName = "dazzle_weave",
                    Value = "18 30\n" +
                            "24 36\n" +
                            "30 42"
                }
            };
        }
    }
}