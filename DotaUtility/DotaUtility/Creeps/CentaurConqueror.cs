using System.Collections.Generic;

namespace DotaUtility.Creeps
{
    public class CentaurConqueror : Creep
    {
        public CentaurConqueror()
        {
            Abilities = new List<Ability>
            {
                new Ability
                {
                    IconName = "centaur_khan_war_stomp",

                    Value = "18 2"
                }
            };
        }
    }
}