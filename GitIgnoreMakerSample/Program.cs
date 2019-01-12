using System;
using GitIgnoreMaker;

namespace GitIgnoreMakerSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var gitIgnoreList = GitIgnore.GetList();

            var gitIgnoreTemplate = GitIgnore.GetTemplate("visualstudio", "visualstudiocode", "rider");
        }
    }
}
