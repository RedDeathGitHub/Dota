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
                    IconName = "disruptor_thunder_strike",
                    Value = "120\n" +
                            "180\n" +
                            "240\n" +
                            "300"
                },
                new Ability
                {
                    IconName = "disruptor_glimpse",
                    Value = " 600\n" +
                            "1000\n" +
                            "1400\n" +
                            "1800"
                },
                new Ability
                {
                    IconName = "disruptor_kinetic_field",
                    Value = "2.5\n" +
                            "3.0\n" +
                            "3.5\n" +
                            "4.0"
                },
                new Ability
                {
                    IconName = "disruptor_static_storm",
                    Value = "390  750\n" +
                            "490  940\n" +
                            "590 1130"
                }
            };
        }
    }
}