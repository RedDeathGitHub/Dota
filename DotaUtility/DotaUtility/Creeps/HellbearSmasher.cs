﻿using System.Collections.Generic;

namespace DotaUtility.Creeps
{
	public class HellbearSmasher : Creep
	{
		public HellbearSmasher()
		{
			Abilities = new List<Ability>
			{
				new Ability
				{
					IconName = "centaur_khan_endurance_aura",
					Passive = true,
					Value = @"15"
				},
				new Ability
				{
					IconName = "polar_furbolg_ursa_warrior_thunder_clap",
					Passive = true,
					Value = @"112 25 3"
				}
			};
		}
	}
}