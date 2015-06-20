using System.Collections.Generic;

namespace DotaUtility.Creeps
{
    public class AlphaWolf : Creep
    {
        public AlphaWolf()
        {
            Abilities = new List<Ability>
            {
                new Ability
                {
                    IconNames = new List<string> { "alpha_wolf_critical_strike" },
                    Value = "20"
                },
                new Ability
                {
                    IconNames = new List<string> { "alpha_wolf_command_aura" },
                    Value = "30"
                }
            };
        }
    }
}