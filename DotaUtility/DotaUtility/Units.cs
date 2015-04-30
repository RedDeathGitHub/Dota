using System.Collections.Generic;
using System.Linq;

using DotaUtility.Creeps;
using DotaUtility.Heroes.Agility.Dire;
using DotaUtility.Heroes.Agility.Radiant;
using DotaUtility.Heroes.Intelligence.Dire;
using DotaUtility.Heroes.Intelligence.Radiant;
using DotaUtility.Heroes.Strength.Dire;
using DotaUtility.Heroes.Strength.Radiant;

namespace DotaUtility
{
    public static class Units
    {
        public static List<Unit> All
        {
            get
            {
                return Heroes.Concat<Unit>(Creeps).ToList();
            }
        }

        public static List<Hero> Heroes
        {
            get
            {
                return StrengthHeroes
                .Concat(AgilityHeroes)
                .Concat(IntelligenceHeroes)
                .ToList();
            }
        }

        public static List<Hero> StrengthHeroes
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
                    new Brewmaster(),
                    new TreantProtector(),
                    new Io(),
                    new CentaurWarrunner(),
                    new Timbersaw(),
                    new Bristleback(),
                    new Tusk(),
                    new ElderTitan(),
                    new LegionCommander(),
                    new EarthSpirit(),
                    new Phoenix(),

                    new Axe(),
                    new Pudge(),
                    new SandKing(),
                    new Slardar(),
                    new Tidehunter(),
                    new WraithKing(),
                    new Lifestealer(),
                    new NightStalker(),
                    new Doom(),
                    new SpiritBreaker(),
                    new Lycan(),
                    new ChaosKnight(),
                    new Undying(),
                    new Magnus(),
                    new Abaddon()
                };
            }
        }

        public static List<Hero> AgilityHeroes
        {
            get
            {
                return new List<Hero>
                {
                    new Antimage(),
                    new DrowRanger(),
                    new Juggernaut(),
                    new Mirana(),
                    new Morphling(),
                    new PhantomLancer(),
                    new VengefulSpirit(),
                    new Riki(),
                    new Sniper(),
                    new TemplarAssassin(),
                    new Luna(),
                    new BountyHunter(),
                    new Ursa(),
                    new LoneDruid(),
                    new NagaSiren(),
                    new TrollWarlord(),
                    new EmberSpirit(),

                    new Bloodseeker(),
                    new ShadowFiend(),
                    new Razor(),
                    new Venomancer(),
                    new FacelessVoid(),
                    new PhantomAssassin(),
                    new Viper(),
                    new Clinkz(),
                    new Broodmother(),
                    new Weaver(),
                    new Spectre(),
                    new Meepo(),
                    new NyxAssassin(),
                    new Slark(),
                    new Medusa(),
                    new Terrorblade()
                };
            }
        }

        public static List<Hero> IntelligenceHeroes
        {
            get
            {
                return new List<Hero>
                {
                    new CrystalMaiden(),
                    new Puck(),
                    new StormSpirit(),
                    new Windranger(),
                    new Zeus(),
                    new Lina(),
                    new ShadowShaman(),
                    new Tinker(),
                    new NaturesProphet(),
                    new Enchantress(),
                    new Jakiro(),
                    new Chen(),
                    new Silencer(),
                    new OgreMagi(),
                    new Rubick(),
                    new Disruptor(),
                    new KeeperOfTheLight(),
                    new SkywrathMage(),
                    new Oracle(),
                    new Techies(),

                    new Bane(),
                    new Lich(),
                    new Lion(),
                    new WitchDoctor(),
                    new Enigma(),
                    new Necrophos(),
                    new Warlock(),
                    new QueenOfPain(),
                    new DeathProphet(),
                    new Pugna(),
                    new Dazzle(),
                    new Leshrac(),
                    new DarkSeer(),
                };
            }
        }

        public static List<Creep> Creeps
        {
            get
            {
                return new List<Creep>
                {
                    new CentaurConqueror(),
                    new HellbearSmasher(),
                    new GiantWolf(),
                    new AlphaWolf(),
                };
            }
        }
    }
}