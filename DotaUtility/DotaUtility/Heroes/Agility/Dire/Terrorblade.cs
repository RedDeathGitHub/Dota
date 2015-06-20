using System.Collections.Generic;

namespace DotaUtility.Heroes.Agility.Dire
{
    public class Terrorblade : Hero
    {
        public Terrorblade()
        {
            Abilities = new List<Ability>
            {
                new Ability
                {
                    IconNames = new List<string>
                    {
                        "terrorblade_reflection",
                        "terrorblade_reflection_alt1"
                    },
                    Value = " 40 60\n" +
                            " 60 60\n" +
                            " 80 60\n" +
                            "100 60"
                },
                new Ability
                {
                    IconNames = new List<string>
                    {
                        "terrorblade_conjure_image",
                        "terrorblade_conjure_image_alt1"
                    },
                    Value = "30 20\n" +
                            "40 20\n" +
                            "50 20\n" +
                            "60 20"
                },
                new Ability
                {
                    IconNames = new List<string>
                    {
                        "terrorblade_metamorphosis",
                        "terrorblade_metamorphosis_alt1"
                    },
                    Value = "20 25\n" +
                            "40 25\n" +
                            "60 25\n" +
                            "80 25"
                },
                new Ability
                {
                    IconNames = new List<string>
                    {
                        "terrorblade_sunder",
                        "terrorblade_sunder_alt1"
                    },
                    Value = "20"
                }
            };
        }
    }
}