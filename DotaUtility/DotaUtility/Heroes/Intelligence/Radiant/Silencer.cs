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
                    IconName = "silencer_curse_of_the_silent",
                    Value = " 90  48\n" +
                            "157  96\n" +
                            "225 144\n" +
                            "292 192"
                },
                new Ability
                {
                    IconName = "silencer_glaives_of_wisdom",
                    Value = "30\n" +
                            "50\n" +
                            "70\n" +
                            "90"
                },
                new Ability
                {
                    IconName = "silencer_last_word",
                    Value = "112 3\n" +
                            "150 4\n" +
                            "187 5\n" +
                            "225 6"
                },
                new Ability
                {
                    IconName = "silencer_global_silence",
                    Value = "4\n" +
                            "5\n" +
                            "6"
                }
            };
        }
    }
}