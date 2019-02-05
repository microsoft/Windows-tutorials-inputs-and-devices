---
topic: sample
languages:
- csharp
products:
- windows
- windows-uwp
statusNotificationTargets:
- codefirst
---

# Get Started Tutorial: Support the Surface Dial (and other wheel devices) in your UWP app

This is the complete sample code for the [Get Started Tutorial: Support the Surface Dial (and other wheel devices) in your UWP app](https://docs.microsoft.com/windows/uwp/get-started/radialcontroller-walkthrough) on [Windows Dev Center](https://developer.microsoft.com/en-us/windows).

The Surface Dial is a secondary input device that helps users to be more productive when using a primary input device (such as pen, touch, or mouse) intended for a single, dominant hand. As a secondary input device, the Dial is typically used with the non-dominant hand to provide access to both system commands and other, more contextual, tools and functionality. 

The Dial supports three basic gestures: 
- Press and hold to display the built-in menu of commands
- Rotate to highlight a menu item (if the menu is active) or to modify the current action in the app (if the menu is not active)
- Click to select the highlighted menu item (if the menu is active) or to invoke a command in the app (if the menu is not active)

In this topic, we step through how to use the RadialController APIs to customize the Dial experience in a sample app.

We focus on the following:
* Specifying which built-in tools are displayed on the menu
* Adding a custom tool
* Controlling haptic feedback
* Custom click interactions
* Custom rotate interactions

For more detail on implementing these features, see our [Surface Dial interactions in UWP apps](https://docs.microsoft.com/en-us/windows/uwp/input-and-devices/windows-wheel-interactions) topic)
