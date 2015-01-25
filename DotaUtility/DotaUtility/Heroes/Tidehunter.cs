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
					Value = @" 82 2 40
										120 3 40
										157 4 40
										195 5 40"
				},
				new Ability
				{
					IconName = "tidehunter_kraken_shell",

					Value = @"10 600
										20 550
										30 500
										40 450"
				},
				new Ability
				{
					IconName = "tidehunter_anchor_smash",
					Value = @" 75 45
										125 50
										175 55
										225 60"
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