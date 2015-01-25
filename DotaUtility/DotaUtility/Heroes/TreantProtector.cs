using System.Collections.Generic;

namespace DotaUtility.Heroes
{
	public class TreantProtector : Hero
	{
		public TreantProtector()
		{
			Abilities = new List<Ability>
			{
				new Ability
				{
					IconName = "treant_natures_guise",
					Value = @"2 10 15
										2 10 30
										2 10 45
										2 10 60"
				},
				new Ability
				{
					IconName = "treant_leech_seed",
					Value = @" 67 28
										135 28
										202 28
										270 28"
				},
				new Ability
				{
					IconName = "treant_living_armor",
					Value = @" 80  60
										200 105
										360 150
										560 195"
				},
				new Ability
				{
					IconName = "treant_overgrowth",
					Value = @"3.0 393
										3.7 525
										4.5 656"
				}
			};
		}
	}
}