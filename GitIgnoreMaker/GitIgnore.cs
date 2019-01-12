using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace GitIgnoreMaker
{
    public static class GitIgnore
    {
        public static List<string> GetList()
        {
            var client = new WebClient();
            var text = client.DownloadString("https://www.gitignore.io/api/list");
            var list = text.Split(',').Distinct().ToList();
            list.Sort();
            return list;
        }
        public static string GetTemplate(params string[] titles)
        {
            if (titles == null || titles.Length == 0)
            {
                return null;
            }
            var client = new WebClient();
            var parameters = titles.Where(x => !string.IsNullOrEmpty(x)).Aggregate((x, y) => x + "," + y);
            var template = client.DownloadString("https://www.gitignore.io/api/" + parameters);
            return template;
        }
    }
}
