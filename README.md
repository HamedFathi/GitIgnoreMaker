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

![1](https://user-images.githubusercontent.com/8418700/142763950-47e4af8a-7714-44fb-a209-461c758be44a.png)

![2](https://user-images.githubusercontent.com/8418700/142763957-277875ee-fa87-49a7-8cf0-e469a17ddaf4.png)

<hr/>
<div>Icons made by <a href="" title="riajulislam">riajulislam</a> from <a href="https://www.flaticon.com/" title="Flaticon">www.flaticon.com</a></div>
