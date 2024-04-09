# The Android template in C++ for Unreal Engine 5.*

### Table of content:
- [What is this?](what-is-this)
- [What does it contain?](what-does-it-contain?)
- - [Sky Atmosphere and Material info](sky-atmosphere-and-material-info)
- [Requirements](requirements)
- - [Basic](basic)
- - [Guide](guide)
- [How to install](how-to-install)

## What is this?

This is an Unreal Engine template ready to create Android games.
It was created with version 5.2 of Unreal, but it should also be compatible with later versions.

It is ready for the C++ language, with the source folder it already contains some folders and files ready to start an Android Game

## What does it contain?
The Game folder inside the Source folder with:
- Game Module
- GameMode
- HUD

The Content folder is filled with:
- Maps folder: that's an empty map with sky and lights
- Materials: contain just a SkySphere Material ready for Android
- BP folder:
  - Game folder (blueprints derived from the code above):
    - BP_GameMode
    - BP_HUD 

### Sky Atmosphere and Material info
The sky dome and material are used to avoid this error in game:

"On mobile the SkyAtmosphere component needs a mesh with a material tagged as IsSky and using the SkyAtmosphere nodes to visualize the Atmosphere."

## Requirements
### Basic
- [Unreal Engine](https://www.unrealengine.com/en-US?sessionInvalidated=true) 5.2
- [Android Studio](https://developer.android.com/studio/archive) 4.0 -> it should also work with the [latest version](https://developer.android.com/studio)
- [Java SDK](https://www.oracle.com/java/technologies/downloads/) latest version is ok
- [Java JRE 8](https://www.oracle.com/java/technologies/downloads/)

### Guide 
Follow [this](https://youtu.be/sXfbLx_3FII?si=WHVGY3BXzNQT6zIC) more in-depth guide to install all requirements to build in Android

Credits: [Future Dev](https://www.youtube.com/@Future-Developer)

## How to install
If you want to install the template, you need to extract and put the "TP_AndroidGame" folder inside the Templates folder of Unreal Engine,
all the templates are usually placed in this path: 

- Windows: "C:\Program Files\Epic Games\UE_[version]\Templates"
- macOS: "/Users/Shared/Epic Games/UE_[version]/Templates"

[GoUp](the-android-template-in-c++-for-unreal-engine-5.*)
