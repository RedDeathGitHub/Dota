using System.Collections.Generic;

namespace DotaUtility.Heroes.Intelligence.Dire
{
    public class WitchDoctor : Hero
    {
        public WitchDoctor()
        {
            Abilities = new List<Ability>
            {
                new Ability
                {
                    IconName = "witch_doctor_paralyzing_cask",
                    Value = "110 3\n" +
                            "180 5\n" +
                            "260 7\n" +
                            "330 9"
                },
                new Ability
                {
                    IconName = "witch_doctor_voodoo_restoration",
                    Value = "16\n" +
                            "24\n" +
                            "32\n" +
                            "40"
                },
                new Ability
                {
                    IconName = "witch_doctor_maledict",
                    Value = " 40\n" +
                            " 60\n" +
                            " 90\n" +
                            "120"
                },
                new Ability
                {
                    IconName = "witch_doctor_death_ward",
                    Value = "2000 3000\n" +
                            "3000 4000\n" +
                            "4000 5000"
                }
            };
        }
    }
}