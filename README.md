# Useful Unity Systems


> [!NOTE]
> - This is a repository with useful assets and code examples for Unity, written and frequently used by me. 
> - I admit the possibility of improving the written code and changing my mechanics for your needs. 


## Assets list
- **AndroidFeatures** - useful features for Android games.

- **ARRaycastAimController** - this script allows you to control the game object attached to the scanned AR plane through the movements of the device (for AR games only).

- **AutoDeviceSimulator** - this script automatically creates a XR Device Simulator object on your game scene only in Unity editor mode (for AR/MR/VR games).

- **ControllerVibration** - this script allows you to use the controller vibration in the game (also for VR controllers).

- **Converter** - useful methods for converting different values.

- **Following** - with this script, you can make one game object repeat the position and rotation of another game object.

- **GraphicRaycasterWithLock** - using this script instead of the standard GraphicRaycaster component on World Space type Canvases allows you to disable unnecessary mouse processing if it's disabled in the game. This is especially useful in VR games, where interaction takes place through the rays of the controllers.

- **LanguageText** - this script allows you to create a simple text translation system for other languages in your game.

- **ObjectPool** - a class for managing an objects pool. Supports working with component classes only.

- **ObjectsConcealer** - contains the **SetRenderingForGameObjectsByLayerIndex** which sets the rendering ability of a game object with a specified layer index.

- **RandomValue** - containes TryGetUnique method which tries to minimize duplication of a random int value from the range [minValue, maxValue).

- **ServiceContainer** - the service container that provides access to work with game services. Addition to the DI architecture of the project.

- **SliderSoundSystem** - this system allows you to control the volume of each type of game sounds. Each type of game sound can contain multiple AudioSources.

- **SmoothMovementWithRotation** - this script allows you to create a flying game object from one point to another (the original game object also performs a smooth rotation to the target point).

- **StringTimer** - converter from integer format to "string time" format (you can use this methods for timers or clocks in your game).

- **VRCameraOffsetFix** - this script allows you to quickly solve the problem with the incorrect VR camera offset in the game build (this problem was noticed on Oculus Quest 2 due to incorrect settings of the play zone) (for VR games).


## Examples list
- **FPSCount** - a FPS counter.

- **ForUI** - useful methods for game's UI.

- **NearestPointOfHit** - this is how to track the contact point when one object hits another object.

- **SimpleShooting** - this is the code for a simple physical shooting system for your game.

- **XRGrabInteractableExtra** - use this script instead of the original "XR Grab Interactable" component to control the "grab/drop" and "HoverEnter/HoverExit" processes (for VR games).


## Contact me
- [Telegram Channel](https://telegram.me/enfity_games) 
- [Donation](https://dalink.to/enfity) 
- [YouTube](https://www.youtube.com/@enfity) 
- [Itch.io](https://enfity.itch.io/) 
- enfity.games@gmail.com 
- [GitHub](https://github.com/EnfityBro) 
