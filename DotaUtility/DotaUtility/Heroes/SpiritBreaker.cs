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
					Value = @"1.2 600
										1.6 650
										2.0 700
										2.4 750"
				},
				new Ability
				{
					IconName = "spirit_breaker_empowering_haste",
					Value = @" 6 6 10
										10 6 10
										14 6 10
										18 6 10"
				},
				new Ability
				{
					IconName = "spirit_breaker_greater_bash",
					Passive = true,
					Value = @"17 1.0 22 15
										17 1.2 28 15
										17 1.4 34 15
										17 1.6 40 15"
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