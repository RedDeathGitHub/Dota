using System.Collections.Generic;

namespace DotaUtility.Heroes
{
	public class Weaver : Hero
	{
		public Weaver()
		{
			Abilities = new List<Ability>
			{
				new Ability
				{
					IconName = "weaver_the_swarm",

					Value = @"15 1
										20 1
										25 1
										30 1"
				},
				new Ability
				{
					IconName = "weaver_shukuchi",
					Value = @" 56
										 75
										 93
										112"
				},
				new Ability
				{
					IconName = "weaver_geminate_attack",

					Value = @"6
										5
										4
										3"
				},
				new Ability
				{
					IconName = "weaver_time_lapse",
					Value = @""
				}
			};
		}
	}
}