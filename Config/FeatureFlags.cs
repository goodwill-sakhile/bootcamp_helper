// File: Config/FeatureFlags.cs
namespace BootcampHelper.Config
{
    public static class FeatureFlags
    {
        public static bool EnableReports => true;
        public static bool EnableHelpMenu => true;
        public static bool EnableConsoleStyling => true;

        public static bool IsEnabled(string featureName)
        {
            return featureName.ToLower() switch
            {
                "reports" => EnableReports,
                "help" => EnableHelpMenu,
                "styling" => EnableConsoleStyling,
                _ => false
            };
        }
    }
}
