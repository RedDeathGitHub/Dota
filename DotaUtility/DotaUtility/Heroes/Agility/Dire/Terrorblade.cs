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
                    Value = "40 60\n" +
                            "50 60\n" +
                            "60 60\n" +
                            "70 60"
                },
                new Ability
                {
                    IconName = "terrorblade_conjure_image",
                    Value = "30 20\n" +
                            "40 20\n" +
                            "50 20\n" +
                            "60 20"
                },
                new Ability
                {
                    IconName = "terrorblade_metamorphosis",
                    Value = "20 25\n" +
                            "40 25\n" +
                            "60 25\n" +
                            "80 25"
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