using System.Collections.Generic;

namespace DotaUtility.Heroes.Intelligence.Radiant
{
    public class Disruptor : Hero
    {
        public Disruptor()
        {
            Abilities = new List<Ability>
            {
                new Ability
                {
                    IconNames = new List<string> { "disruptor_thunder_strike" },
                    Value = "120\n" +
                            "180\n" +
                            "240\n" +
                            "300"
                },
                new Ability
                {
                    IconNames = new List<string> { "disruptor_glimpse" },
                    Value = " 600\n" +
                            "1000\n" +
                            "1400\n" +
                            "1800"
                },
                new Ability
                {
                    IconNames = new List<string>
                    {
                        "disruptor_kinetic_field",
                        @"disruptor\resistive_pinfold\disruptor_kinetic_field"
                    },
                    Value = "2.6\n" +
                            "3.2\n" +
                            "3.8\n" +
                            "4.4"
                },
                new Ability
                {
                    IconNames = new List<string> { "disruptor_static_storm" },
                    Value = "400  700\n" +
                            "500  900\n" +
                            "600 1100"
                }
            };
        }
    }
}