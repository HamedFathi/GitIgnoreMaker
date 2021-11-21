using GitIgnoreMaker;

namespace GitIgnoreMakerSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var gitIgnoreTemplateNames = GitIgnore.GetAvailableTemplateNames();
            var gitIgnoreTemplate = GitIgnore.CreateTemplate("visualstudio", "visualstudiocode", "rider");
        }
    }
}
