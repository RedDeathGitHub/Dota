using System.Collections.Generic;

namespace DotaUtility.Heroes
{
	public class SpiritBreaker : Hero
	{
		public SpiritBreaker()
		{
			Abilities = new List<Ability>
			{
				new Ability
				{
					IconName = "spirit_breaker_charge_of_darkness",
					Value = @"1.2
										1.6
										2.0
										2.4"
				},
				new Ability
				{
					IconName = "spirit_breaker_empowering_haste",
					Value = @" 6
										10
										14
										18"
				},
				new Ability
				{
					IconName = "spirit_breaker_greater_bash",

					Value = @"17 1.0
										17 1.2
										17 1.4
										17 1.6"
				},
				new Ability
				{
					IconName = "spirit_breaker_nether_strike",
					Value = @"112
										187
										262"
				}
			};
		}
	}
}