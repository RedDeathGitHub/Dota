using System.Collections.Generic;

namespace DotaUtility.Heroes.Intelligence.Dire
{
    public class Necrophos : Hero
    {
        public Necrophos()
        {
            Abilities = new List<Ability>
            {
                new Ability
                {
                    IconName = "necrolyte_death_pulse",
                    Value = " 50  70\n" +
                            " 90  90\n" +
                            "150 110\n" +
                            "200 130"
                },
                new Ability
                {
                    IconName = "necrolyte_heartstopper_aura",
                    Value = "170\n" +
                            "120\n" +
                            " 90\n" +
                            " 70"
                },
                new Ability
                {
                    IconName = "necrolyte_sadist",
                    Value = " 6 12\n" +
                            "12 24\n" +
                            "18 36\n" +
                            "24 60"
                },
                new Ability
                {
                    IconName = "necrolyte_reapers_scythe",
                    Value = "20 30\n" +
                            "30 40\n" +
                            "40 45"
                }
            };
        }
    }
}