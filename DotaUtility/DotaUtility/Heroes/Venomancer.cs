using System.Collections.Generic;

namespace DotaUtility.Heroes
{
	public class Venomancer : Hero
	{
		public Venomancer()
		{
			Abilities = new List<Ability>
			{
				new Ability
				{
					IconName = "venomancer_venomous_gale",

					Value = @" 18 50
										135 50
										281 50
										412 50"
				},
				new Ability
				{
					IconName = "venomancer_poison_sting",
					Value = @" 26 11
										 75 12
										146 13
										240 14"
				},
				new Ability
				{
					IconName = "venomancer_plague_ward",

					Value = @"10  75
										19 200
										29 325
										38 450"
				},
				new Ability
				{
					IconName = "venomancer_poison_nova",
					Value = @"351  652
										652  972
										972 1377"
				}
			};
		}
	}
}