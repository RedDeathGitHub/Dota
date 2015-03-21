using System.Collections.Generic;

namespace DotaUtility.Heroes.Intelligence.Radiant
{
    public class Zeus : Hero
    {
        public Zeus()
        {
            Abilities = new List<Ability>
            {
                new Ability
                {
                    IconName = "zuus_arc_lightning",
                    Value = " 64\n" +
                            " 75\n" +
                            " 86\n" +
                            "109"
                },
                new Ability
                {
                    IconName = "zuus_lightning_bolt",
                    Value = " 75\n" +
                            "131\n" +
                            "206\n" +
                            "262"
                },
                new Ability
                {
                    IconName = "zuus_static_field",
                    Value = " 5\n" +
                            " 7\n" +
                            " 9\n" +
                            "11"
                },
                new Ability
                {
                    IconName = "zuus_thundergods_wrath",
                    Value = "168 330\n" +
                            "262 405\n" +
                            "356 480"
                }
            };
        }
    }
}