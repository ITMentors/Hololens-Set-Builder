# Hololens-Set-Builder
This is an early-stage (outdated) version of the HoloLens Set Builder.  
It was built originally in a HoloLens-specific beta version of Unity and as such, in Unity 2017.3 there are quite a few issues present.

[![HoloLensSetBuilderIMG](http://www.nycoc.org/wp-content/uploads/2018/01/hololens-diorama.png)](https://vimeo.com/243945301)
Click this image to watch a quick recorded demo of this codebase.

## Scripts of Interest
### TapToPlace.cs (HoloToolKit script)
This is an incredibly useful script that is supplied by the HoloToolKit (now MixedRealityToolkit - https://github.com/Microsoft/MixedRealityToolkit-Unity)
It handles most of the movement and placement of objects in the HoloLens and provides a quick and easy way to implement simple gestures.

### VoiceCommands.cs (custom-built)
This script includes implementation details for all of the VoiceCommands supported by this version of the program.
The Unity project has a few broken APIs as it has updated numerous times since this project was built and as such some of the implementation details around voice commands.
The voice commands originally were built directly in the editor as an implement of the "KeywordManager.cs" script - unfortunately, this script is no longer working so some of the implementation details are missing.
If your team needs further explanation of this, @ me (@Zach) on slack and I can schedule a time to walk you through this.

### KeepYPos.cs (custom-built)
This script is incredibly simple but powerful when developing for the HoloLens - it keeps the height the same on an object even throughout a movement gesture.
I wrote this script for the diorama-view scenes and it was helpful for keeping props that should stay on the ground, on the ground!

