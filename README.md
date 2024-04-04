# An Unreal Engine C++ template

## What is this?

This is an Unreal Engine 5.2 template ready to create Android games.
It is ready for the C++ language, with the source folder it already contains a some folders and files ready to start an Android Game

## What does it contain?
It's ready with a Game folder inside the Source folder with:
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
** The sky dome and material are used to avoid this error:
"On mobile the SkyAtmosphere component needs a mesh with a material tagged as IsSky and using the SkyAtmosphere nodes to visualize the Atmosphere."

## How to install
If you want to install the template, you need to extract and put the TP_AndroidGame folder inside the Templates folder of Unreal Engine,
all the templates are usually placed in this path: "C:\Program Files\Epic Games\UE_5.2\Templates"
