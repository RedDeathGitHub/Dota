using System.Collections.Generic;

namespace DotaUtility.Heroes
{
	public class LegionCommander : Hero
	{
		public LegionCommander()
		{
			Abilities = new List<Ability>
			{
				new Ability
				{
					IconName = "legion_commander_overwhelming_odds",
					Value = @" 30 15 10
										 60 26 12
										 90 37 13
										120 48 15"
				},
				new Ability
				{
					IconName = "legion_commander_press_the_attack",
					Value = @" 60 30
										 80 40
										100 50
										120 60"
				},
				new Ability
				{
					IconName = "legion_commander_moment_of_courage",

					Value = @"16 20
										18 40
										20 60
										22 80"
				},
				new Ability
				{
					IconName = "legion_commander_duel",
					Value = @"10 4.0
										14 4.7
										18 5.5"
				}
			};
		}
	}
}