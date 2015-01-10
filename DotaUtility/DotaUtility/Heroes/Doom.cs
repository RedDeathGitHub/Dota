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
					Value = @" 90 120 16
										162 216 16
										252 336 16
										360 480 16"
				},
				new Ability
				{
					IconName = "doom_bringer_lvl_death",
					Value = @" 93 6 15
										131 5 15
										168 4 15
										206 3 15"
				},
				new Ability
				{
					IconName = "doom_bringer_doom",
					Value = @"300 15  640
										525 15  960
										750 15 1280"
				}
			};
		}
	}
}