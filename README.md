![git](https://user-images.githubusercontent.com/8418700/142907799-033929a7-f48a-4052-b235-7bdff33a6f33.png)

This library works based on [gitignore](https://www.toptal.com/developers/gitignore) REST APIs.

### [Nuget](https://www.nuget.org/packages/GitIgnoreMaker/)

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

![1](https://user-images.githubusercontent.com/8418700/142764009-aa9a52b6-6720-4234-a03e-14308be43a74.png)

![2](https://user-images.githubusercontent.com/8418700/142763957-277875ee-fa87-49a7-8cf0-e469a17ddaf4.png)

<hr/>
<div>Icons made by <a href="" title="riajulislam">riajulislam</a> from <a href="https://www.flaticon.com/" title="Flaticon">www.flaticon.com</a></div>
