![git](https://user-images.githubusercontent.com/8418700/141340397-ba46ceee-ffee-4e02-a33e-372967fce97e.png)


This library works based on [gitignore](https://www.toptal.com/developers/gitignore) REST APIs.

### [Nuget]()

[![Open Source Love](https://badges.frapsoft.com/os/mit/mit.svg?v=102)](https://opensource.org/licenses/MIT)
![Nuget](https://img.shields.io/nuget/v/GitIgnoreMaker)
![Nuget](https://img.shields.io/nuget/dt/GitIgnoreMaker)

```
Install-Package GitIgnoreMaker

dotnet add package GitIgnoreMaker
```

### Usage

```cs
using GitIgnoreMaker;

// Returns whole available template names for making a '.gitignore' file. 
// e.g. 'visualstudio', 'visualstudiocode', 'rider', ...
IEnumerable<string> gitIgnoreTemplateNames = GitIgnore.GetAvailableTemplateNames();

// Create your '.gitignore' file based on titles of above list.
string gitIgnoreTemplate = GitIgnore.CreateTemplate("visualstudio", "visualstudiocode", "rider");
```

<hr/>
<div>Icons made by <a href="" title="riajulislam">riajulislam</a> from <a href="https://www.flaticon.com/" title="Flaticon">www.flaticon.com</a></div>
