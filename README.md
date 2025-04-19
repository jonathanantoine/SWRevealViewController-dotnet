# Maui iOS binding for SWRevealViewController

[![NuGet version](https://badge.fury.io/nu/com.jonathanantoine.SWRevealViewController.svg)](https://badge.fury.io/nu/com.jonathanantoine.SWRevealViewController)

- Native library repository: [SWRevealViewController](https://github.com/John-Lluch/SWRevealViewController)

**Support Net 9.0 for iOS (works with Xcode 15 and iOS 17)**

## Nuget

* `Install-Package com.jonathanantoine.SWRevealViewController`
* <https://www.nuget.org/packages/com.jonathanantoine.SWRevealViewController>

## Compatibility
* Run on ios and ios simulator (arm64 + x86_64).

## Build
* Run the GitHub action to build the project


## Usage
Follow [this blog post to reference](https://medium.com/@jonathanantoine/how-to-add-a-local-nuget-nupkg-to-your-net-project-0254d222e2a6) it in your project if not yet published on Nuget.


```csharp
using SWRevealViewControllerMaui;

var pageController = new MyPageController();
pageController.ViewControllerSelected += pageControllerController_ViewControllerSelected;

var menuController = new MenuViewController();

var swRevealViewController = new SWRevealViewController(menuController, pageController);
```

## Contribution
Contribution to [ApiDefinition.cs](SWRevealViewController/ApiDefinition.cs) are welcome, just send PRs.




