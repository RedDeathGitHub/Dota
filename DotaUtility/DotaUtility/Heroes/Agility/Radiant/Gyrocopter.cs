using System.Collections.Generic;

namespace DotaUtility.Heroes.Agility.Radiant
{
    public class Gyrocopter : Hero
    {
        public Gyrocopter()
        {
            Abilities = new List<Ability>
            {
                new Ability
                {
                    IconName = "gyrocopter_rocket_barrage",
                    AdditionalIconNames = new List<string>
                    {
                        "gyrocopter_skyhigh_rocket_barrage"
                    },
                    Value = "180\n" +
                            "290\n" +
                            "400\n" +
                            "510"
                },
                new Ability
                {
                    IconName = "gyrocopter_homing_missile",
                    AdditionalIconNames = new List<string>
                    {
                        "gyrocopter_skyhigh_homing_missile"
                    },
                    Value = " 90 2.2\n" +
                            "180 2.4\n" +
                            "280 2.6\n" +
                            "370 2.8"
                },
                new Ability
                {
                    IconName = "gyrocopter_flak_cannon",
                    AdditionalIconNames = new List<string>
                    {
                        "gyrocopter_skyhigh_flak_cannon"
                    },
                    Value = "3\n" +
                            "4\n" +
                            "5\n" +
                            "6"
                },
                new Ability
                {
                    IconName = "gyrocopter_call_down",
                    AdditionalIconNames = new List<string>
                    {
                        "gyrocopter_skyhigh_call_down"
                    },
                    Value = "260 320\n" +
                            "340 400\n" +
                            "410 460"
                }
            };
        }
    }
}