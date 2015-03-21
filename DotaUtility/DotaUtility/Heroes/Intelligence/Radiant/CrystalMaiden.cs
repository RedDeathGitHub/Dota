using System.Collections.Generic;

namespace DotaUtility.Heroes.Intelligence.Radiant
{
    public class CrystalMaiden : Hero
    {
        public CrystalMaiden()
        {
            Abilities = new List<Ability>
            {
                new Ability
                {
                    IconName = "crystal_maiden_crystal_nova",
                    Value = " 75 30\n" +
                            "112 30\n" +
                            "150 30\n" +
                            "187 30"
                },
                new Ability
                {
                    IconName = "crystal_maiden_frostbite",
                    Value = "112 1.5\n" +
                            "150 2.0\n" +
                            "187 2.5\n" +
                            "225 3.0"
                },
                new Ability
                {
                    IconName = "crystal_maiden_brilliance_aura",
                    Value = "1.0 2\n" +
                            "1.5 3\n" +
                            "2.0 4\n" +
                            "2.5 5"
                },
                new Ability
                {
                    IconName = "crystal_maiden_freezing_field",
                    Value = "1500 2475\n" +
                            "2475 3600\n" +
                            "3600 4500"
                }
            };
        }
    }
}