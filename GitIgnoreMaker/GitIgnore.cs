using System.Collections.Generic;
using System.Linq;
using System.Net.Http;

namespace GitIgnoreMaker
{
    public static class GitIgnore
    {
        public static IEnumerable<string> GetAvailableTemplateNames()
        {
            using var client = new HttpClient();
            var response = client.GetStringAsync("https://www.toptal.com/developers/gitignore/api/list");
            var list = response.Result.Split(',').Distinct().ToList();
            list.Sort();
            return list;
        }

        public static string CreateTemplate(params string[] titles)
        {
            if (titles == null || titles.Length == 0) return null;

            using var client = new HttpClient();
            var parameters = titles.Where(x => !string.IsNullOrEmpty(x)).Aggregate((x, y) => x + "," + y);
            var template = client.GetStringAsync("https://www.toptal.com/developers/gitignore/api/" + parameters).Result;
            return template;
        }



    }
}
