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
					Name = "treant_natures_guise",
					Value = @"2 10 15
										2 10 30
										2 10 45
										2 10 60"
				},
				new Ability
				{
					Name = "treant_leech_seed",
					Value = @" 67 28  90
										135 28 180
										202 28 270
										270 28 360"
				},
				new Ability
				{
					Name = "treant_living_armor",
					Value = @" 80 4  60
										200 5 105
										360 6 150
										560 7 195"
				},
				new Ability
				{
					Name = "treant_overgrowth",
					Value = @"3   393
										3.7 525
										4.5 656"
				}
			};
		}
	}
}