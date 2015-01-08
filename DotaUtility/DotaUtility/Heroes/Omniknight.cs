using System.Collections.Generic;

namespace DotaUtility.Heroes
{
	public class Omniknight : Hero
	{
		public Omniknight()
		{
			Abilities = new List<Ability>
			{
				new Ability
				{
					IconName = "omniknight_purification",
					Value = @" 90
										180
										270
										360"
				},
				new Ability
				{
					IconName = "omniknight_repel",
					Value = @" 6
										 8
										10
										12"
				},
				new Ability
				{
					IconName = "omniknight_degen_aura",
					Passive = true,
					Value = @"10
										18
										26
										34"
				},
				new Ability
				{
					IconName = "omniknight_guardian_angel",
					Value = @"6  8
										7  9
										8 10"
				}
			};
		}
	}
}