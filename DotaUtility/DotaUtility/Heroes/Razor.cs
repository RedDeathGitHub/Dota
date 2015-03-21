using System.Collections.Generic;

namespace DotaUtility.Heroes
{
    public class Razor : Hero
    {
        public Razor()
        {
            Abilities = new List<Ability>
            {
                new Ability
                {
                    IconName = "razor_plasma_field",

                    Value = "120\n" +
                            "172\n" +
                            "225\n" +
                            "277"
                },
                new Ability
                {
                    IconName = "razor_static_link_alt",
                    Value = " 56\n" +
                            "112\n" +
                            "168\n" +
                            "224"
                },
                new Ability
                {
                    IconName = "razor_unstable_current",

                    Value = "30  4\n" +
                            "52  8\n" +
                            "75 12\n" +
                            "97 16"
                },
                new Ability
                {
                    IconName = "razor_eye_of_the_storm",
                    Value = "37\n" +
                            "50\n" +
                            "62"
                }
            };
        }
    }
}