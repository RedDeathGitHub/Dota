using System.Collections.Generic;

namespace DotaUtility.Heroes
{
	public class Beastmaster : Hero
	{
		public Beastmaster()
		{
			Abilities = new List<Ability>
			{
				new Ability
				{
					IconName = "beastmaster_wild_axes",
					Value = @"140
										200
										230
										320"
				},
				new Ability
				{
					IconName = "beastmaster_call_of_the_wild_hawk",
					Value = @"4 60 30
												 40
												 50
												 60"
				},
				new Ability
				{
					IconName = "beastmaster_call_of_the_wild_boar",
					Value = @"10 3 60 32
										20 3 60 32
										30 3 60 32
										40 3 60 32"
				},
				new Ability
				{
					IconName = "beastmaster_inner_beast",
					Passive = true,
					Value = @"15
										25
										35
										45"
				},
				new Ability
				{
					IconName = "beastmaster_primal_roar",
					Value = @"150 3.0 50
										187 3.5 50
										225 4.0 50"
				}
			};
		}
	}
}