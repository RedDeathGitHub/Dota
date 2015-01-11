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
					Passive = true,
					Value = @"40 16"
				},
				new Ability
				{
					IconName = "huskar_burning_spear",
					Value = @" 30 15 8
										 60 15 8
										 90 15 8
										120 15 8"
				},
				new Ability
				{
					IconName = "huskar_berserkers_blood",
					Passive = true,
					Value = @"14 4 87 7
										16 5 87 7
										18 6 87 7
										20 7 87 7"
				},
				new Ability
				{
					IconName = "huskar_life_break",
					Value = @"26 48 40 4
										26 48 50 5
										26 48 60 6"
				}
			};
		}
	}
}