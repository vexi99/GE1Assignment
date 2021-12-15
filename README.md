# Project Title

Name: David Tilson

Student Number: C17448206

Class Group: TU856/4

# Description of the project
My project was originally supposed to be a procedurally generated world, similar to google earth. However I ran into issues doing this so i decided to switch to a birds eye view of the world being generated. Terrain, trees and clouds are generated randomly using random and perlin noise functions. The steepness of the worlds peaks are randomised, along with the amount of trees and clouds.

# Instructions for use
Users can sit back and relax while watching as you fly through the ever changing terrain. If a user would like to skip ahead they can use WASD controls to accelerate the terrains movement.

# How it works
Link to my [![YouTube]](https://youtu.be/VnNHkofNsgo) video demo.

The terrain is given random Y coordinates using a PerlinNoise function. This is what gives the world its natural looking hills, flatlands and mountains. This is done through the use of a random scale integer which is set on runtime. 

I made my own cloud and tree prefabs for the assignment:

![image](https://user-images.githubusercontent.com/47209067/146196225-ac536957-18be-4ed6-a1be-85ecdbc696e7.png)

![image](https://user-images.githubusercontent.com/47209067/146196244-6108fcb7-66e7-4c5e-ab8e-a0d40b76a6a6.png)

These prefabs are instanciated a random number of times, at randomly set points throughout the terrain upon start():
```
treeX[i] = Random.Range(0f,256f);
treeZ[i] = Random.Range(0f,256f);
newTree = Instantiate(tree, new Vector3(treeX[i] , 30, treeZ[i]), Quaternion.identity);
```

The cloud prefab is given a random colour upon creation. This is done by assigning a random number between 1-3 to a variable, and setting the clouds colour to either white, grey or black depending on which random number was given.
```
void SetCloudColour(int i)
    {

        /* Array number i sent from GenerateCloud(), random integer between 0 and 4 exclusive chosen */
        int randColour = Random.Range(0,4);

        if(randColour == 1)
        {
            cloudArr[i].GetComponent<MeshRenderer>().material.SetColor("_Color",Color.white);
        }
        else if(randColour == 2)
        {
            cloudArr[i].GetComponent<MeshRenderer>().material.SetColor("_Color",Color.black);
        }
        else if (randColour == 3)
        {
            cloudArr[i].GetComponent<MeshRenderer>().material.SetColor("_Color",Color.grey);
        }
    }
```

The terrain is constantly moving, allowing the user to be able to sit back and enjoy watching the rolling terrain to move. This is done by constantly updating the offsetX variable.
```
terrain.offsetX = terrain.offsetX + 0.011f;
```

Similarly, both clouds and trees are being constantly moved to keep pace with the terrain.

# List of classes/assets in the project and whether made yourself or modified or if its from a source, please give the reference

| Class/asset | Source |
|-----------|-----------|
| TerrainGenerator.cs | Self written |
| TreeGeneration.cs | Self written |
| Movement.cs | Self written |
| CloudGeneration.cs | Self written |
| TreePrefab | Self made |
| CloudPrefab | Self made |

# What I am most proud of in the assignment
I have struggled with Unity so far this semester. Doing this assignment helped me out massively with my understanding as it forced me to think outside of the box.
I'm quite proud of both my terrain generation, which gives a randomized terrain each time, and my cloud generation which gives each cloud a random position, size and colour.

# Proposal submitted earlier can go here:
# GE1Assignment
Games Engines 1 Assignment Repo:

### Description
For my Games Engines 1 project, I plan on creating a beautiful, procedurally generated planet. The user will be able to use sliders to affect the size characteristics of the planet, however it will be fully procedurally generated. The planet will be shown from a zoomed out angle, similar to google earth. User's will then be able to drag the planet around to view different areas and zoom in and out of the planet. 

### Requirements
- Various biomes on the planet
- Accurately structured terrain generation
- User input characteristics affects planets generation

### Tools Used
- Unity
- Visual Studio Code
- MagicaVoxel 3D Modelling Software

### Research:
https://youtu.be/lctXaT9pxA0

