using System.Collections.Generic;

namespace DotaUtility.Heroes
{
	public class Clinkz : Hero
	{
		public Clinkz()
		{
			Abilities = new List<Ability>
			{
				new Ability
				{
					IconName = "clinkz_strafe",

					Value = @" 4
										 6
										 8
										10"
				},
				new Ability
				{
					IconName = "clinkz_searing_arrows",
					Value = @"30
										40
										50
										60"
				},
				new Ability
				{
					IconName = "clinkz_wind_walk",

					Value = @"11
										22
										33
										44"
				},
				new Ability
				{
					IconName = "clinkz_death_pact",
					Value = @"5.0 50
										6.5 65
										8.0 80"
				}
			};
		}
	}
}