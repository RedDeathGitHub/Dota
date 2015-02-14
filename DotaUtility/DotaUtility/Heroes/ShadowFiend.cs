using System.Collections.Generic;

namespace DotaUtility.Heroes
{
	public class ShadowFiend : Hero
	{
		public ShadowFiend()
		{
			Abilities = new List<Ability>
			{
				new Ability
				{
					IconName = "nevermore_shadowraze1",

					Value = @" 75
										131
										187
										243"
				},
				new Ability
				{
					IconName = "nevermore_necromastery",
					Value = @"30
										44
										58
										72"
				},
				new Ability
				{
					IconName = "nevermore_dark_lord",

					Value = @"3
										4
										5
										6"
				},
				new Ability
				{
					IconName = "nevermore_requiem",
					Value = @"1080
										1620
										2160"
				}
			};
		}
	}
}