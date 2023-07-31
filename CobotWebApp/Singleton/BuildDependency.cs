using System.Globalization;
using System.Reflection;

namespace CobotWebApp.Singleton
{
    public class BuildDependency : IBuildDependency
    {
        public string GetBuildNumber()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            const string BuildVersionMetadataPrefix = "+build";

            var attribute = assembly.GetCustomAttribute<AssemblyInformationalVersionAttribute>();
            if (attribute?.InformationalVersion != null)
            {
                var value = attribute.InformationalVersion;
                var index = value.IndexOf(BuildVersionMetadataPrefix);
                if (index > 0)
                {
                    value = value.Substring(index + BuildVersionMetadataPrefix.Length);
                    if (DateTime.TryParseExact(value, "yyyyMMddHHmmss", CultureInfo.InvariantCulture, DateTimeStyles.None, out var timeStamp))
                    {
                        return $"{timeStamp.Year}{timeStamp.Month}{timeStamp.Day}{timeStamp.Hour + 1}{timeStamp.Minute}{timeStamp.Second}{timeStamp.Millisecond}"; ;
                    }
                }
            }
            return  $"Error Retrieving Build Number ";
        }
    }
}