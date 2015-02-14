using System.Collections.Generic;

namespace DotaUtility.Heroes
{
	public class Axe : Hero
	{
		public Axe()
		{
			Abilities = new List<Ability>
			{
				new Ability
				{
					IconName = "axe_berserkers_call",
					Value = @"2.0 40
										2.4 40
										2.8 40
										3.2 40"
				},
				new Ability
				{
					IconName = "axe_battle_hunger",
					Value = @"120 12
										180 12
										240 12
										300 12"
				},
				new Ability
				{
					IconName = "axe_counter_helix",

					Value = @"100 20
										135 20
										170 20
										205 20"
				},
				new Ability
				{
					IconName = "axe_culling_blade",
					Value = @"250 300
										325 425
										400 550"
				}
			};
		}
	}
}