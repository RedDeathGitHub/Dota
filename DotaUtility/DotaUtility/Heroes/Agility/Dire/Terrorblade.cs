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
                    IconName = "terrorblade_reflection",
                    AdditionalIconNames = new List<string>
                    {
                        "terrorblade_reflection_alt1"
                    },
                    Value = " 40 60\n" +
                            " 60 60\n" +
                            " 80 60\n" +
                            "100 60"
                },
                new Ability
                {
                    IconName = "terrorblade_conjure_image",
                    AdditionalIconNames = new List<string>
                    {
                        "terrorblade_conjure_image_alt1"
                    },
                    Value = "30 20\n" +
                            "40 20\n" +
                            "50 20\n" +
                            "60 20"
                },
                new Ability
                {
                    IconName = "terrorblade_metamorphosis",
                    AdditionalIconNames = new List<string>
                    {
                        "terrorblade_metamorphosis_alt1"
                    },
                    Value = "20 25\n" +
                            "40 25\n" +
                            "60 25\n" +
                            "80 25"
                },
                new Ability
                {
                    IconName = "terrorblade_sunder",
                    AdditionalIconNames = new List<string>
                    {
                        "terrorblade_sunder_alt1"
                    },
                    Value = "20"
                }
            };
        }
    }
}