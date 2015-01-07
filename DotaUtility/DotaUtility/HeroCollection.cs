using System.Collections.Generic;

using DotaUtility.Heroes;

namespace DotaUtility
{
	public static class HeroCollection
	{
		public static List<Hero> All
		{
			get
			{
				return new List<Hero>
				{
					new Earthshaker(),
					new Sven(),
					new Tiny(),
					new Kunkka(),
					new Beastmaster(),
					new DragonKnight(),
					new Clockwerk(),
					new Omniknight(),
					new Huskar(),
					new Alchemist(),

					new Abaddon(),
					new Antimage()
				};
			}
		}
	}
}