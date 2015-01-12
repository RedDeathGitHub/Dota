using System.Collections.Generic;

namespace DotaUtility.Heroes
{
	public class Undying : Hero
	{
		public Undying()
		{
			Abilities = new List<Ability>
			{
				new Ability
				{
					IconName = "undying_decay",
					Value = @" 91 4 40
										121 4 40
										151 4 40
										181 4 40"
				},
				new Ability
				{
					IconName = "undying_soul_rip",
					Value = @"135 180 10
										198 264 12
										273 364 14
										360 480 16"
				},
				new Ability
				{
					IconName = "undying_tombstone",
					Value = @"15 3  75
										20 3 100
										25 3 125
										30 3 150"
				},
				new Ability
				{
					IconName = "undying_flesh_golem",
					Value = @"15 25  6 10
										20 30  2  3
										25 35 10 30"
				}
			};
		}
	}
}