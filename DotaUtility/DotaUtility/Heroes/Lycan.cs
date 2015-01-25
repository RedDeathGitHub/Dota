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
					Value = @"55"
				},
				new Ability
				{
					IconName = "lycan_howl",
					Value = @"14  5
										26 10
										38 15
										50 20"
				},
				new Ability
				{
					IconName = "lycan_feral_impulse",

					Value = @"15
										20
										25
										30"
				},
				new Ability
				{
					IconName = "lycan_shapeshift",
					Value = @"21 18"
				}
			};
		}
	}
}