using System.Collections.Generic;

namespace DotaUtility.Heroes
{
	public class NightStalker : Hero
	{
		public NightStalker()
		{
			Abilities = new List<Ability>
			{
				new Ability
				{
					IconName = "night_stalker_void",
					Value = @" 67 50 35 4
										120 50 35 4
										191 50 35 4
										251 50 35 4"
				},
				new Ability
				{
					IconName = "night_stalker_crippling_fear",
					Value = @"50 5 10 3
										50 6 10 3
										50 7 10 3
										50 8 10 3"
				},
				new Ability
				{
					IconName = "night_stalker_hunter_in_the_night",
					Passive = true,
					Value = @"20 45
										25 60
										30 75
										35 90"
				},
				new Ability
				{
					IconName = "night_stalker_darkness",
					Value = @"50"
				}
			};
		}
	}
}