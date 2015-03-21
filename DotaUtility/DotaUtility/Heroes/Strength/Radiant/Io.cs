using System.Collections.Generic;

namespace DotaUtility.Heroes.Strength.Radiant
{
    public class Io : Hero
    {
        public Io()
        {
            Abilities = new List<Ability>
            {
                new Ability
                {
                    IconName = "wisp_tether",
                    Value = "100 17\n" +
                            "100 17\n" +
                            "100 17\n" +
                            "100 17"
                },
                new Ability
                {
                    IconName = "wisp_spirits",
                    Value = "125\n" +
                            "187\n" +
                            "281\n" +
                            "375"
                },
                new Ability
                {
                    IconName = "wisp_overcharge",
                    Value = "40  5 4.5\n" +
                            "50 10 4.5\n" +
                            "60 15 4.5\n" +
                            "70 20 4.5"
                },
                new Ability
                {
                    IconName = "wisp_relocate",
                    Value = "2.5 12\n" +
                            "2.2 12\n" +
                            "2.0 12"
                }
            };
        }
    }
}