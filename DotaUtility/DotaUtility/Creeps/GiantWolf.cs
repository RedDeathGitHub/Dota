using System.Collections.Generic;

namespace DotaUtility.Creeps
{
    public class GiantWolf : Creep
    {
        public GiantWolf()
        {
            Abilities = new List<Ability>
            {
                new Ability
                {
                    IconNames = new List<string> { "giant_wolf_critical_strike" },
                    Value = "20"
                }
            };
        }
    }
}