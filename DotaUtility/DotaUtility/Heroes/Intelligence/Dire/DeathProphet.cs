using System.Collections.Generic;

namespace DotaUtility.Heroes.Intelligence.Dire
{
    public class DeathProphet : Hero
    {
        public DeathProphet()
        {
            Abilities = new List<Ability>
            {
                new Ability
                {
                    IconName = "death_prophet_carrion_swarm",
                    Value = " 50\n" +
                            "110\n" +
                            "160\n" +
                            "220"
                },
                new Ability
                {
                    IconName = "death_prophet_silence",
                    Value = "3\n" +
                            "4\n" +
                            "5\n" +
                            "6"
                },
                new Ability
                {
                    IconName = "death_prophet_witchcraft",
                    Value = " 5 3\n" +
                            "10 4\n" +
                            "15 5\n" +
                            "20 6"
                },
                new Ability
                {
                    IconName = "death_prophet_exorcism",
                    Value = " 6\n" +
                            "13\n" +
                            "21"
                }
            };
        }
    }
}