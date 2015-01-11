using System.Collections.Generic;

namespace DotaUtility.Heroes
{
	public class Lycan : Hero
	{
		public Lycan()
		{
			Abilities = new List<Ability>
			{
				new Ability
				{
					IconName = "lycan_summon_wolves",
					Value = @"21 1.7 15 55"
				},
				new Ability
				{
					IconName = "lycan_howl",
					Value = @"14  5 10
										26 10 10
										38 15 10
										50 20 10"
				},
				new Ability
				{
					IconName = "lycan_feral_impulse",
					Passive = true,
					Value = @"15
										20
										25
										30"
				},
				new Ability
				{
					IconName = "lycan_shapeshift",
					Value = @"21 650 18"
				}
			};
		}
	}
}