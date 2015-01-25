using System.Collections.Generic;

namespace DotaUtility.Heroes
{
	public class Morphling : Hero
	{
		public Morphling()
		{
			Abilities = new List<Ability>
			{
				new Ability
				{
					IconName = "morphling_waveform",

					Value = @" 75
										131
										187
										243"
				},
				new Ability
				{
					IconName = "morphling_adaptive_strike",
					AdditionalIconNames = new List<string>
					{
						"morphling_adaptive_strike_ethereal_blade"
					},
					Value = @"15 0.5
										30 1.0
										45 1.5
										60 2.0"
				},
				new Ability
				{
					IconName = "morphling_morph_agi",

					Value = @"3  2
										4  4
										5  6
										6 10"
				},
				new Ability
				{
					IconName = "morphling_replicate",
					Value = @"50 100"
				}
			};
		}
	}
}