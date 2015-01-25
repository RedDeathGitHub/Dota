using System.Collections.Generic;

namespace DotaUtility.Heroes
{
	public class Pudge : Hero
	{
		public Pudge()
		{
			Abilities = new List<Ability>
			{
				new Ability
				{
					IconName = "pudge_meat_hook",
					Value = @" 90
										180
										270
										360"
				},
				new Ability
				{
					IconName = "pudge_rot",
					Value = @"26 20
										45 20
										63 20
										82 20"
				},
				new Ability
				{
					IconName = "pudge_flesh_heap",

					Value = @"29 1.0
										31 1.5
										32 2.0
										34 2.5"
				},
				new Ability
				{
					IconName = "pudge_dismember",
					Value = @"168 3
										281 3
										393 3"
				}
			};
		}
	}
}