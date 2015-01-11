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
					IconName = "alpha_wolf_critical_strike",
					Passive = true,
					Value = @"20"
				},
				new Ability
				{
					IconName = "alpha_wolf_command_aura",
					Passive = true,
					Value = @"30"
				}
			};
		}
	}
}