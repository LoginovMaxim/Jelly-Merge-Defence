namespace Level.Providers
{
    public sealed class LevelDataProvider : ILevelDataProvider
    {
        public ILevelViewsProvider LevelViewsProvider { get; }

        public LevelDataProvider(ILevelViewsProvider levelViewsProvider)
        {
            LevelViewsProvider = levelViewsProvider;
        }
    }
}