using System.Collections.Generic;

namespace DotaUtility.Heroes
{
	public class FacelessVoid : Hero
	{
		public FacelessVoid()
		{
			Abilities = new List<Ability>
			{
				new Ability
				{
					IconName = "faceless_void_time_walk",

					Value = @"20
										30
										40
										50"
				},
				new Ability
				{
					IconName = "faceless_void_backtrack",
					Value = @"10
										15
										20
										25"
				},
				new Ability
				{
					IconName = "faceless_void_time_lock",

					Value = @"10
										15
										20
										25"
				},
				new Ability
				{
					IconName = "faceless_void_chronosphere",
					Value = @"4.0 4
										4.5 5
										5.0 6"
				}
			};
		}
	}
}