using System.Collections.Generic;

namespace DotaUtility.Heroes
{
	public class CentaurWarrunner : Hero
	{
		public CentaurWarrunner()
		{
			Abilities = new List<Ability>
			{
				new Ability
				{
					IconName = "centaur_hoof_stomp",
					Value = @" 75 2.0
										112 2.2
										150 2.5
										187 2.7"
				},
				new Ability
				{
					IconName = "centaur_double_edge",
					Value = @"175
										187
										243
										300"
				},
				new Ability
				{
					IconName = "centaur_return",
					Passive = true,
					Value = @"16 26
										18 34
										20 42
										22 50"
				},
				new Ability
				{
					IconName = "centaur_stampede",
					Value = @"100 1.5 3.75
										200 1.5 3.75
										300 1.5 3.75"
				}
			};
		}
	}
}