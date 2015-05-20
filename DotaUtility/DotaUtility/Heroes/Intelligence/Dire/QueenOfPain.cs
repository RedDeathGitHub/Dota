using System.Collections.Generic;

namespace DotaUtility.Heroes.Intelligence.Dire
{
    public class QueenOfPain : Hero
    {
        public QueenOfPain()
        {
            Abilities = new List<Ability>
            {
                new Ability
                {
                    IconName = "queenofpain_shadow_strike",
                    AdditionalIconNames = new List<string>
                    {
                        "queenofpain_sanguine_shadow_strike"
                    },
                    Value = "150 20\n" +
                            "200 30\n" +
                            "260 40\n" +
                            "320 50"
                },
                new Ability
                {
                    IconName = "queenofpain_blink",
                    AdditionalIconNames = new List<string>
                    {
                        "queenofpain_sanguine_blink"
                    },
                    Value = "15\n" +
                            "12\n" +
                            " 9\n" +
                            " 6"
                },
                new Ability
                {
                    IconName = "queenofpain_scream_of_pain",
                    AdditionalIconNames = new List<string>
                    {
                        "queenofpain_sanguine_scream_of_pain"
                    },
                    Value = " 60\n" +
                            "120\n" +
                            "160\n" +
                            "220"
                },
                new Ability
                {
                    IconName = "queenofpain_sonic_wave",
                    Value = "290 320\n" +
                            "390 450\n" +
                            "490 570"
                }
            };
        }
    }
}