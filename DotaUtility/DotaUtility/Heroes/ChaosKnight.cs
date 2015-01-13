using System.Collections.Generic;

namespace DotaUtility.Heroes
{
	public class ChaosKnight : Hero
	{
		public ChaosKnight()
		{
			Abilities = new List<Ability>
			{
				new Ability
				{
					IconName = "chaos_knight_chaos_bolt",
					Value = @" 1 150 1 2
										37 168 1 3
										56 187 1 4
										75 206 2 4"
				},
				new Ability
				{
					IconName = "chaos_knight_reality_rift",
					Value = @" 60
										 80
										100
										120"
				},
				new Ability
				{
					IconName = "chaos_knight_chaos_strike",

					Value = @" 5
										10
										15
										20"
				},
				new Ability
				{
					IconName = "chaos_knight_phantasm",
					Value = @"1 100 50 42
										2 100 50 42
										3 100 50 42"
				}
			};
		}
	}
}