using System.Collections.Generic;

namespace DotaUtility.Heroes
{
	public class EmberSpirit : Hero
	{
		public EmberSpirit()
		{
			Abilities = new List<Ability>
			{
				new Ability
				{
					IconName = "ember_spirit_searing_chains",

					Value = @" 60 1
										 90 2
										180 2
										225 3"
				},
				new Ability
				{
					IconName = "ember_spirit_sleight_of_fist",
					Value = @"20
										40
										60
										80"
				},
				new Ability
				{
					IconName = "ember_spirit_flame_guard",

					Value = @"22  37
										30 150
										37 262
										45 375"
				},
				new Ability
				{
					IconName = "ember_spirit_fire_remnant",
					Value = @" 75
										112
										150"
				}
			};
		}
	}
}