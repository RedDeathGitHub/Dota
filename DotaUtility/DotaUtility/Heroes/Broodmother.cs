using System.Collections.Generic;

namespace DotaUtility.Heroes
{
	public class Broodmother : Hero
	{
		public Broodmother()
		{
			Abilities = new List<Ability>
			{
				new Ability
				{
					IconName = "broodmother_spawn_spiderlings",

					Value = @" 56 1
										112 2
										168 3
										225 4"
				},
				new Ability
				{
					IconName = "broodmother_spin_web",
					Value = @"2 40
										4 50
										6 60
										8 70"
				},
				new Ability
				{
					IconName = "broodmother_incapacitating_bite",

					Value = @"30 10
										40 20
										50 30
										60 40"
				},
				new Ability
				{
					IconName = "broodmother_insatiable_hunger",
					Value = @" 60
										 80
										100"
				}
			};
		}
	}
}