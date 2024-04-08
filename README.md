# The Android template in C++ for Unreal Engine

## Requirements
### Basic
- Unreal Engine 5.2
- Android Studio 4.0
- Java SDK (latest version)
- Java JRE 8

### Guide 
Follow this more in-depth [guide](https://youtu.be/sXfbLx_3FII?si=WHVGY3BXzNQT6zIC) (not made by me) to install all requirements to build in Android

Credits: [Future Dev](https://www.youtube.com/@Future-Developer)

## What is this?

This is an Unreal Engine 5.2 template ready to create Android games.
It is ready for the C++ language, with the source folder it already contains some folders and files ready to start an Android Game

## What does it contain?
The Game folder inside the Source folder with:
- Game Module
- GameMode
- HUD

The Content folder is filled with:
- Maps folder: that's an empty map with sky** and lights
- Materials: contain just a SkySphere Material** ready for Android
- BP folder:
  - Game folder (blueprints derived from the code above):
    - BP_GameMode
    - BP_HUD 

### Sky Atmosphere and Material info
** The sky dome and material are used to avoid this error in game:
"On mobile the SkyAtmosphere component needs a mesh with a material tagged as IsSky and using the SkyAtmosphere nodes to visualize the Atmosphere."

## How to install
If you want to install the template, you need to extract and put the "TP_AndroidGame" folder inside the Templates folder of Unreal Engine,
all the templates are usually placed in this path: "C:\Program Files\Epic Games\UE_5.2\Templates"
