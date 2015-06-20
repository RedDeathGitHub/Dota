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
                    IconNames = new List<string>
                    {
                        "gyrocopter_rocket_barrage",
                        "gyrocopter_skyhigh_rocket_barrage"
                    },
                    Value = "180\n" +
                            "290\n" +
                            "400\n" +
                            "510"
                },
                new Ability
                {
                    IconNames = new List<string>
                    {
                        "gyrocopter_homing_missile",
                        "gyrocopter_skyhigh_homing_missile"
                    },
                    Value = " 90 2.2\n" +
                            "180 2.4\n" +
                            "280 2.6\n" +
                            "370 2.8"
                },
                new Ability
                {
                    IconNames = new List<string>
                    {
                        "gyrocopter_flak_cannon",
                        "gyrocopter_skyhigh_flak_cannon"
                    },
                    Value = "3\n" +
                            "4\n" +
                            "5\n" +
                            "6"
                },
                new Ability
                {
                    IconNames = new List<string>
                    {
                        "gyrocopter_call_down",
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