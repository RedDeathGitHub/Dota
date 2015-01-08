using System.Collections.Generic;

namespace DotaUtility.Heroes
{
	public class Timbersaw : Hero
	{
		public Timbersaw()
		{
			Abilities = new List<Ability>
			{
				new Ability
				{
					IconName = "shredder_whirling_death",
					Passive = true,
					Value = @"100 15 7
										150 15 7
										200 15 7
										250 15 7"
				},
				new Ability
				{
					IconName = "shredder_timber_chain",
					Value = @"100
										140
										180
										220"
				},
				new Ability
				{
					IconName = "shredder_reactive_armor",
					Passive = true,
					Value = @" 4 16
										 8 16
										12 16
										16 16"
				},
				new Ability
				{
					IconName = "shredder_chakram",
					Value = @"100  50 20
										140  75 25
										180 100 30"
				}
			};
		}
	}
}