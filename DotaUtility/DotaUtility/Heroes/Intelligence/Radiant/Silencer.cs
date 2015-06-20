using System.Collections.Generic;

namespace DotaUtility.Heroes.Intelligence.Radiant
{
    public class Silencer : Hero
    {
        public Silencer()
        {
            Abilities = new List<Ability>
            {
                new Ability
                {
                    IconNames = new List<string>
                    {
                        "silencer_curse_of_the_silent",
                        @"silencer\bts_silencer_ability\silencer_curse_of_the_silent"
                    },
                    Value = " 90  50\n" +
                            "150 100\n" +
                            "220 150\n" +
                            "290 200"
                },
                new Ability
                {
                    IconNames = new List<string>
                    {
                        "silencer_glaives_of_wisdom",
                        @"silencer\bts_silencer_ability\silencer_glaives_of_wisdom"
                    },
                    Value = "30\n" +
                            "50\n" +
                            "70\n" +
                            "90"
                },
                new Ability
                {
                    IconNames = new List<string>
                    {
                        "silencer_last_word",
                        @"silencer\bts_silencer_ability\silencer_last_word"
                    },
                    Value = "110 14\n" +
                            "150 16\n" +
                            "180 18\n" +
                            "220 20"
                },
                new Ability
                {
                    IconNames = new List<string>
                    {
                        "silencer_global_silence",
                        @"silencer\bts_silencer_ability\silencer_global_silence"
                    },
                    Value = "4\n" +
                            "5\n" +
                            "6"
                }
            };
        }
    }
}