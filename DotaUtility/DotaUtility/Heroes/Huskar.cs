using System.Collections.Generic;

namespace DotaUtility.Heroes
{
	public class Huskar : Hero
	{
		public Huskar()
		{
			Abilities = new List<Ability>
			{
				new Ability
				{
					IconName = "huskar_inner_vitality",

					Value = @"40"
				},
				new Ability
				{
					IconName = "huskar_burning_spear",
					Value = @" 30 15
										 60 15
										 90 15
										120 15"
				},
				new Ability
				{
					IconName = "huskar_berserkers_blood",

					Value = @"196 56
										224 70
										252 84
										280 98"
				},
				new Ability
				{
					IconName = "huskar_life_break",
					Value = @"26 40 48
										26 50 48
										26 60 48"
				}
			};
		}
	}
}