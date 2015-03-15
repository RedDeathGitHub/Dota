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
                    Value =
@"40 60
50 60
60 60
70 60"
                },
                new Ability
                {
                    IconName = "terrorblade_conjure_image",
                    Value =
@"30 23
40 23
50 23
60 23"
                },
                new Ability
                {
                    IconName = "terrorblade_metamorphosis",
                    Value =
@"20 25
40 25
60 25
80 25"
                },
                new Ability
                {
                    IconName = "terrorblade_sunder",
                    Value =
@"20"
                }
            };
        }
    }
}