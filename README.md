Create useful .gitignore files for your project

This library works based on https://www.gitignore.io REST APIs.

**Examples :**

```cs
using GitIgnoreMaker;

var gitIgnoreList = GitIgnore.GetList();
var gitIgnoreTemplate = GitIgnore.GetTemplate("visualstudio", "visualstudiocode", "rider");
```
