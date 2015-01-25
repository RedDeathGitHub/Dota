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
					Value = @" 91 4
										121 4
										151 4
										181 4"
				},
				new Ability
				{
					IconName = "undying_soul_rip",
					Value = @"135 180
										198 264
										273 364
										360 480"
				},
				new Ability
				{
					IconName = "undying_tombstone",
					Value = @" 75
										100
										125
										150"
				},
				new Ability
				{
					IconName = "undying_flesh_golem",
					Value = @"15 25
										20 30
										25 35"
				}
			};
		}
	}
}