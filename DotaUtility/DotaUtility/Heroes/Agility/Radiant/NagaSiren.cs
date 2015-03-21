using System.Collections.Generic;

namespace DotaUtility.Heroes.Agility.Radiant
{
    public class NagaSiren : Hero
    {
        public NagaSiren()
        {
            Abilities = new List<Ability>
            {
                new Ability
                {
                    IconName = "naga_siren_mirror_image",

                    Value = "20 16\n" +
                            "25 20\n" +
                            "30 25\n" +
                            "35 33"
                },
                new Ability
                {
                    IconName = "naga_siren_ensnare",
                    Value = "2\n" +
                            "3\n" +
                            "4\n" +
                            "5"
                },
                new Ability
                {
                    IconName = "naga_siren_rip_tide",

                    Value = " 97 2\n" +
                            "120 3\n" +
                            "142 4\n" +
                            "165 5"
                },
                new Ability
                {
                    IconName = "naga_siren_song_of_the_siren",
                    Value = "7"
                }
            };
        }
    }
}