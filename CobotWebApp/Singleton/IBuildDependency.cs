using System.Reflection;

namespace CobotWebApp.Singleton
{
    public interface IBuildDependency
    {
        string GetBuildNumber();
    }
}
