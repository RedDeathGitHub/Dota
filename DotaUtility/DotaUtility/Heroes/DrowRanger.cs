using System.Collections.Generic;

namespace DotaUtility.Heroes
{
	public class DrowRanger : Hero
	{
		public DrowRanger()
		{
			Abilities = new List<Ability>
			{
				new Ability
				{
					IconName = "drow_ranger_frost_arrows",
					Value = @"15 1.5
										30 1.5
										45 1.5
										60 1.5"
				},
				new Ability
				{
					IconName = "drow_ranger_wave_of_silence",
					Value = @"0.6 3
										0.7 4
										0.8 5
										0.9 6"
				},
				new Ability
				{
					IconName = "drow_ranger_trueshot",
					Value = @"18 30
										24 30
										30 30
										36 30"
				},
				new Ability
				{
					IconName = "drow_ranger_marksmanship",
					Passive = true,
					Value = @"40 14
										60 22
										80 29"
				}
			};
		}
	}
}