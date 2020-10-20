# unity3dGame
![alt text](https://i.imgur.com/vanXfE2.png)
![alt text](https://i.imgur.com/GupWj2x.png)
![alt text](https://i.imgur.com/fqXj8XD.png)


# Features:

  Collision detection and response:
  - The character can't leave the restricted area which is surrounded by walls, can’t walk into objects like buildings, containers, abandoned cars and so on.
  Score is increased whenever the character walks into a pandora box + box opening animation is played.
  - The character dies whenever it comees to close to the fire. Gameplay is restarted.

  Physics:
  - Character can interact with the in-game objects that move or fall when walked into. Barrels can be pushed around the map.

  Animation:
  - The character can freely walk around the map. When no button is pressed the animation switches into the idle mode in which the movement is very subtle and represents a person standing still.
  - An animation of opening the pandora box is played whenever the character walks into the object. Box breaks into pieces.

  Animation Controller:
  - Switching between character’s walking and idle mode.
  - UI animations for level completion.

  Dynamic lights:
  - A dynamic light source of a headlamp (spotlight) was attached to the character's forehead in order to help the player to find the collectable item.

  Default lights in Unity (realtime):
  - Default lighting was placed in the game.

  Bump/Normal maps:
  - A real-world graffiti wall was 3D scanned and imported into the scene with an additional normal map for surface's roughness.

  Effects with particle systems:
  - Rain particle system over entire map.
  - Fire particle system was introduced in various places in the scene (burning cars and burning barrels).
  - Smoke/fog particle system was added to the pandora box in order to attract player’s attention as well as to add a surreal look to it.

  Live Statistics:
  - Built-in fps meter.
  
  Procedural content generation:
  - Collectable items are spawned in the restricted area.

  Additional features:
  - Game Start and finish menus.
  - Score counter.

Audio:

The audio manager script enables to easily call different samples playback methods from other scripts inside the game. 
Only one instance of the manager can be created, therefore allowing the sound to continuously play when switching between levels.
Sounds were either recorded, synthesized or obtained from http://bbcsfx.acropolis.org.uk/.

The following audio sources and sounds were added into the game:

Rain, thunderstorm ambience, burning cars sound, burning barrels sound, footsteps sound, death of the character sound (Wilhelm Scream), sound for the collectable item to help the player to localize the object, collectable item pickup sound, start menu background music and button click sound, quit menu background  music and button click sound. A reverberation section placed inside of a disintegrating metal hangar.

Contact: michalchrul@gmail.com
