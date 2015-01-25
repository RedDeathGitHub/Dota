using System.Collections.Generic;

namespace DotaUtility.Heroes
{
	public class VengefulSpirit : Hero
	{
		public VengefulSpirit()
		{
			Abilities = new List<Ability>
			{
				new Ability
				{
					IconName = "vengefulspirit_magic_missile",

					Value = @" 75 1.4
										131 1.5
										187 1.6
										243 1.7"
				},
				new Ability
				{
					IconName = "vengefulspirit_wave_of_terror",
					Value = @"30 3
										50 4
										70 5
										90 6"
				},
				new Ability
				{
					IconName = "vengefulspirit_command_aura",

					Value = @"12
										20
										28
										36"
				},
				new Ability
				{
					IconName = "vengefulspirit_nether_swap",
					Value = @""
				}
			};
		}
	}
}