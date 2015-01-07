using System.Collections.Generic;

namespace DotaUtility.Heroes
{
	public class Antimage : Hero
	{
		public Antimage()
		{
			Abilities = new List<Ability>
			{
				new Ability
				{
					Name = "antimage_mana_break",
					Passive = true,
					Value = @"28 16
										40 24
										52 31
										64 38"
				},
				new Ability
				{
					Name = "antimage_blink",
					Value = @"12
										 9
										 7
										 5"
				},
				new Ability
				{
					Name = "antimage_spell_shield",
					Passive = true,
					Value = @"44
										50
										56
										62"
				},
				new Ability
				{
					Name = "antimage_mana_void",
					Value = @"45
										63
										82"
				}
			};
		}
	}
}