using System.Collections.Immutable;

namespace DotNetExercise3
{
    internal enum SwanSongBehavior
    {
        Never,
        Intermittently,
        OnlyAtDeath
    }

    internal static class SwanSongBehaviorTranslator
    {
        private static ImmutableDictionary<SwanSongBehavior, string> swedish = (new Dictionary<SwanSongBehavior, string> { { SwanSongBehavior.Never, "Aldrig" }, { SwanSongBehavior.Intermittently, "Sporadiskt" }, { SwanSongBehavior.OnlyAtDeath, "Bara vid döden" } }).ToImmutableDictionary();

        public static string Swedish(SwanSongBehavior behavior)
        { 
            return swedish[behavior];
        }
    }

    internal class Swan : Bird
    {
        private SwanSongBehavior songBehavior;

        public SwanSongBehavior SongBehavior
        {
            get { return songBehavior; }
            set { songBehavior = value; }
        }

        public Swan(string name, double weight, int age, double wingSpan, SwanSongBehavior songBehavior) : base(name, weight, age, wingSpan)
        {
            SongBehavior = songBehavior;
        }

        public override string Stats()
        {
            return base.Stats() + $"Sångbeteende: {SwanSongBehaviorTranslator.Swedish(SongBehavior)}\n";
        }
    }
}
