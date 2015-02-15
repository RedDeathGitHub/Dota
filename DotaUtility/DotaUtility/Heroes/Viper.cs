using System.Collections.Generic;

namespace DotaUtility.Heroes
{
	public class Viper : Hero
	{
		public Viper()
		{
			Abilities = new List<Ability>
			{
				new Ability
				{
					IconName = "viper_poison_attack",

					Value = @"15 10
										24 20
										33 30
										42 40"
				},
				new Ability
				{
					IconName = "viper_nethertoxin",
					Value = @" 40
										 80
										120
										160"
				},
				new Ability
				{
					IconName = "viper_corrosive_skin",

					Value = @"30 32
										45 36
										60 40
										75 44"
				},
				new Ability
				{
					IconName = "viper_viper_strike",
					Value = @"225
										375
										543"
				}
			};
		}
	}
}