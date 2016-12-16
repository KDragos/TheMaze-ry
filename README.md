# The Maze-ry by Kristin Dragos

## About
This game is a project for the Udacity's VR Developer Nanodegree program. The goal is to create a maze game. Users need to use waypoints to navigate the world and progress through the game. Users collect coins as they work and must find a key to open the door to win the game. 

## Enhancements
This is still a work in progress. My ideas for enhancing this game include: 

- Procedurely generated walls, key spawn points, and collectibles to ensure that each time the game is played, the layout is different.
- Sound effects have been added when collecting an item, moving between waypoints, and interacting with (unlocking or opening) the door. 
- Animations for the coins, key, and door. 
- A messaging system that provides helpful text about what items were picked up and the status of the door. 
- A heads up display (HUD) containing: (1) a graphic for the key. A gray icon will indicate that the key isn't picked up yet. A gold key indicates it has been collected. (2) a place to track score (collected coins). (3) A total of all the coins that are on the board. 

## Challenges and Reflection
My biggest challenge so far has been the fact that when I run the game on my phone, the waypoints don't seem to work - the camera doesn't move. I'm trying to find help from forums to move forward with debugging the isuse and finding a solution. 

I'm also unable to remove the GoogleVR and Plugins folder, per the requirements in the project rubric. When I attempt this, the scene refuses to build. When I try to reimport the GoogleVR sdk, I'm getting a message saying that it already exists and can't be reimported. I'm hoping to find help regarding this issue as well. This could be tied to the first issue/challenge.

I'm really proud of how everything in my Maze game is procedurely generated. This allows for the game to be different each time it's played. I was hoping to expand this to include a number of times played, or a running total of how many coins have been collected. 
