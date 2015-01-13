using System.Collections.Generic;

namespace DotaUtility.Heroes
{
	public class Tidehunter : Hero
	{
		public Tidehunter()
		{
			Abilities = new List<Ability>
			{
				new Ability
				{
					IconName = "tidehunter_gush",
					Value = @" 82 2 40 4
										120 3 40 4
										157 4 40 4
										195 5 40 4"
				},
				new Ability
				{
					IconName = "tidehunter_kraken_shell",

					Value = @"10 600 6
										20 550 6
										30 500 6
										40 450 6"
				},
				new Ability
				{
					IconName = "tidehunter_anchor_smash",
					Value = @" 75 45 6
										125 50 6
										175 55 6
										225 60 6"
				},
				new Ability
				{
					IconName = "tidehunter_ravage",
					Value = @"150 2.0
										217 2.3
										285 2.7"
				}
			};
		}
	}
}