using System.Collections.Generic;

namespace DotaUtility.Heroes
{
	public class Bloodseeker : Hero
	{
		public Bloodseeker()
		{
			Abilities = new List<Ability>
			{
				new Ability
				{
					IconName = "bloodseeker_bloodrage",

					Value = @"25
										30
										35
										40"
				},
				new Ability
				{
					IconName = "bloodseeker_blood_bath",
					Value = @"120 3
										160 4
										200 5
										240 6"
				},
				new Ability
				{
					IconName = "bloodseeker_thirst",

					Value = @"10
										20
										30
										40"
				},
				new Ability
				{
					IconName = "bloodseeker_rupture",
					Value = @"20
										40
										60"
				}
			};
		}
	}
}