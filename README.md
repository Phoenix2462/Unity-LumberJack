# Unity-LumberJack
A simple code I created that allows you to create a LumberJack that destroys objects in 2 hit
# Customization
### Repeat Rate
You can change the repeat rate of the spawner by changing the number in the brackets.
![repeatRate](https://user-images.githubusercontent.com/68500648/153716711-2a99fda9-491a-4017-9c2c-1e3ce891a574.png)<br/> <br>
(file: SpawnerScript.cs line: 22) <br/><br>
### Spawned Object Position
You can change the position of the objects that spawns by changing the numbers in the brackets (1st parameter: min X, 2nd parameter: max X, 3rd parameter: min Y, 4th parameter: max Y)
![image](https://user-images.githubusercontent.com/68500648/153717015-96873720-497a-4bbb-b6cb-57d632667ca6.png)<br/><br>
(file: SpawnerScript.cs line: 13) <br/><br>
### LumberJack Speed
You can change the speed of the lumberjack by changing the _speed variable
![image](https://user-images.githubusercontent.com/68500648/153717164-4138f3b9-457a-4114-9b3a-c1ba4665037e.png)<br/><br>
(file: LumberJackAI.cs line: 12) <br/><br>
# Setup
Add a sprite into your game (this is going to be the lumberjack)\
Add LumberJackAI.cs to your player\
Create an empty GameObject (this is going to be your spawner)\
Add SpawnerScript.cs to your spawner\
Create a sprite prefab (this is going to be the prefab that the spawner spawns)\
Add Rigidbody2D and Collider 2D (which collider you should use is based on the sprite shape) to both the lumberjack and the object prefab\
Set the Gravity Scale of the Rigidbody2D to 0
### Animation Setup (Optional)
Create an animation and trigger it instead of printing animation in the console (if you dont want to make a animation you can simply delete the print functions <br/> <br>
![image](https://user-images.githubusercontent.com/68500648/153717790-001968f0-88aa-4567-a25b-2286b2b34825.png) <br/><br>
(file: LumberJackAI.cs line: 33 and 36)
