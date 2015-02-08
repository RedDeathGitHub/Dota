using System.Collections.Generic;

namespace DotaUtility.Heroes
{
	public class Gyrocopter : Hero
	{
		public Gyrocopter()
		{
			Abilities = new List<Ability>
			{
				new Ability
				{
					IconName = "gyrocopter_rocket_barrage",

					Value = @"247
										337
										427
										517"
				},
				new Ability
				{
					IconName = "gyrocopter_homing_missile",
					Value = @" 93 2.2
										187 2.4
										281 2.6
										375 2.8"
				},
				new Ability
				{
					IconName = "gyrocopter_flak_cannon",

					Value = @"3
										4
										5
										6"
				},
				new Ability
				{
					IconName = "gyrocopter_call_down",
					Value = @"262 318
										337 393
										412 468"
				}
			};
		}
	}
}