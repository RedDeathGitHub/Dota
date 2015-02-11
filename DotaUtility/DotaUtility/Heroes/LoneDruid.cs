using System.Collections.Generic;

namespace DotaUtility.Heroes
{
	public class LoneDruid : Hero
	{
		public LoneDruid()
		{
			Abilities = new List<Ability>
			{
				new Ability
				{
					IconName = "lone_druid_rabid",
					Value = @"10  5
										20 10
										30 15
										40 20"
				},
				new Ability
				{
					IconName = "lone_druid_synergy",

					Value = @"10
										20
										30
										40"
				},
				new Ability
				{
					IconName = "lone_druid_true_form",
					AdditionalIconNames = new List<string> {"lone_druid_true_form_druid" },
					Value = @" 650 4
										 800 6
										1000 8"
				},
				new Ability
				{
					IconName = "lone_druid_true_form_battle_cry",

					Value = @" 50  5
										 75 10
										100 15"
				},
			};
		}
	}
}