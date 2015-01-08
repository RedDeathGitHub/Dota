using System.Collections.Generic;

namespace DotaUtility.Heroes
{
	public class Earthshaker : Hero
	{
		public Earthshaker()
		{
			Abilities = new List<Ability>
			{
				new Ability
				{
					IconName = "earthshaker_fissure",
					Value = @" 93 1   8
										131 1.2 8
										168 1.5 8
										206 1.7 8"
				},
				new Ability
				{
					IconName = "earthshaker_enchant_totem",
					Value = @"100
										200
										300
										400"
				},
				new Ability
				{
					IconName = "earthshaker_aftershock",
					Passive = true,
					Value = @"37 0.6
										56 0.9
										75 1.2
										93 1.5"
				},
				new Ability
				{
					IconName = "earthshaker_echo_slam",
					Value = @"120 30
										157 41
										202 52"
				}
			};
		}
	}
}