# The Maze-ry by Kristin Dragos

## About
This game is a project for the Udacity's VR Developer Nanodegree program. The goal is to create a maze game. Users need to use waypoints to navigate the world and progress through the game. Users collect coins as they work and must find a key to open the door to win the game. 

## Enhancements
This is still a work in progress. My ideas for enhancing this game include: 

- Procedurely generated walls, key spawn points, and collectibles to ensure that each time the game is played, the layout is different.
- Sound effects have been added when collecting an item, moving between waypoints, and interacting with (unlocking or opening) the door. 
- Animations for the coins, key, and door. Help text also has a scrolling annimation to prevent messages from overlapping. 
- A messaging system that provides helpful text about what items were picked up, game directions, and the status of the door. 
- A heads up display (HUD) containing: (1) a graphic for the key. A gray icon will indicate that the key isn't picked up yet. A gold key indicates it has been collected. (2) A place to track score (collected coins). (3) A total of all the coins that are on the board. 
- Added replay and quit buttons to the final win UI screen. 

## Challenges and Reflection
My biggest challenge so far has been the fact that when I run the game on my phone, the waypoints don't seem to work - the camera doesn't move. I've tried to find help from forums to move forward with debugging the isuse and finding a solution. This issue has been solved. The cause appears to be due to an issue of clashing versions of Google VR sdk. 

I'm really proud of how everything in my Maze game is procedurely generated. This allows for the game to be different each time it's played. 

## Potential Future Additions
- Adding a timer. Can you get through the maze quick enough? 
- Adding other levels. 
- Expanding the board to make it larger. 

## Screenshots
Pictures of the app are available here. https://goo.gl/photos/DxKyzoBbuBrRrkNk8

## Known Issues
- It is possible to click through walls to pick up coins and waypoints. This will be addressed at a later point.
