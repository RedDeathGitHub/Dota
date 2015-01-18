using System.Collections.Generic;

namespace DotaUtility.Heroes
{
	public class Doom : Hero
	{
		public Doom()
		{
			Abilities = new List<Ability>
			{
				new Ability
				{
					IconName = "doom_bringer_devour",
					Value = @" 25
										 50
										 75
										100"
				},
				new Ability
				{
					IconName = "doom_bringer_scorched_earth",
					Value = @" 90
										162
										252
										360"
				},
				new Ability
				{
					IconName = "doom_bringer_lvl_death",
					Value = @" 93
										131
										168
										206"
				},
				new Ability
				{
					IconName = "doom_bringer_doom",
					Value = @"300
										525
										750"
				}
			};
		}
	}
}