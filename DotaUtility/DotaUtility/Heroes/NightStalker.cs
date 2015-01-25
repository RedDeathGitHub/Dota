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
					Value = @" 67 50 35
										120 50 35
										191 50 35
										251 50 35"
				},
				new Ability
				{
					IconName = "night_stalker_crippling_fear",
					Value = @"50 5
										50 6
										50 7
										50 8"
				},
				new Ability
				{
					IconName = "night_stalker_hunter_in_the_night",

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