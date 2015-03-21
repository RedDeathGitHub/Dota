using System.Collections.Generic;

namespace DotaUtility.Heroes
{
    public class Terrorblade : Hero
    {
        public Terrorblade()
        {
            Abilities = new List<Ability>
            {
                new Ability
                {
                    IconName = "terrorblade_reflection",
                    Value = "40 60\n" +
                            "50 60\n" +
                            "60 60\n" +
                            "70 60"
                },
                new Ability
                {
                    IconName = "terrorblade_conjure_image",
                    Value = "30 23\n" +
                            "40 23\n" +
                            "50 23\n" +
                            "60 23"
                },
                new Ability
                {
                    IconName = "terrorblade_metamorphosis",
                    Value = "20 25\n" +
                            "40 25\n" +
                            "60 25\n" +
                            "q80 25"
                },
                new Ability
                {
                    IconName = "terrorblade_sunder",
                    Value = "20"
                }
            };
        }
    }
}