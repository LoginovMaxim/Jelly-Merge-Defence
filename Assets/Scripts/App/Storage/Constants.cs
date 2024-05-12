namespace App.Storage
{
    public static class Constants
    {
        public static class LoadingSplashBundleKeys
        {
            public const string LoadingSplashKey = "LoadingSplash";
        }
        
        public static class MetaBundleKeys
        {
            public const string MetaSceneKey = "Meta";
        }
        
        public static class MatchBundleKeys
        {
            public const string MatchSceneKey = "Match";
        }
        
        public static class LevelBundleKeys
        {
            public const string LevelSceneKeyFormat = "Level-{0}";
        }
        
        public static class Scenes
        {
            public const string MetaScenePath = "Scenes/Meta";
            public const string MatchScenePath = "Scenes/Match";
            public const string LevelScenePath = "Scenes/Levels/Level-{0}/Level-{0}";
        }
    }
}