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

					Value = @"100 15
										150 15
										200 15
										250 15"
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

					Value = @" 4
										 8
										12
										16"
				},
				new Ability
				{
					IconName = "shredder_chakram",
					Value = @"100  50
										140  75
										180 100"
				}
			};
		}
	}
}