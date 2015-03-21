using System.Collections.Generic;

namespace DotaUtility.Heroes.Agility.Radiant
{
    public class LoneDruid : Hero
    {
        public LoneDruid()
        {
            Abilities = new List<Ability>
            {
                new Ability
                {
                    IconName = "lone_druid_rabid",
                    Value = "10  5\n" +
                            "20 10\n" +
                            "30 15\n" +
                            "40 20"
                },
                new Ability
                {
                    IconName = "lone_druid_synergy",

                    Value = "10\n" +
                            "20\n" +
                            "30\n" +
                            "40"
                },
                new Ability
                {
                    IconName = "lone_druid_true_form",
                    AdditionalIconNames = new List<string> {"lone_druid_true_form_druid" },
                    Value = " 650 4\n" +
                            " 800 6\n" +
                            "1000 8"
                },
                new Ability
                {
                    IconName = "lone_druid_true_form_battle_cry",

                    Value = " 50  5\n" +
                            " 75 10\n" +
                            "100 15"
                },
            };
        }
    }
}