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


# List of classes/assets in the project and whether made yourself or modified or if its from a source, please give the reference

| Class/asset | Source |
|-----------|-----------|
| TerrainGenerator.cs | Self written |
| TreeGeneration.cs | Self written |
| Movement.cs | Self written |
| CloudGeneration.cs | Self written |

# References

# What I am most proud of in the assignment

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

## This is how to markdown text:

This is *emphasis*

This is a bulleted list

- Item
- Item

This is a numbered list

1. Item
1. Item

This is a [hyperlink](http://bryanduggan.org)

# Headings
## Headings
#### Headings
##### Headings

This is code:

```Java
public void render()
{
	ui.noFill();
	ui.stroke(255);
	ui.rect(x, y, width, height);
	ui.textAlign(PApplet.CENTER, PApplet.CENTER);
	ui.text(text, x + width * 0.5f, y + height * 0.5f);
}
```

So is this without specifying the language:

```
public void render()
{
	ui.noFill();
	ui.stroke(255);
	ui.rect(x, y, width, height);
	ui.textAlign(PApplet.CENTER, PApplet.CENTER);
	ui.text(text, x + width * 0.5f, y + height * 0.5f);
}
```

This is an image using a relative URL:

![An image](images/p8.png)

This is an image using an absolute URL:

![A different image](https://bryanduggandotorg.files.wordpress.com/2019/02/infinite-forms-00045.png?w=595&h=&zoom=2)

This is a youtube video:

[![YouTube](http://img.youtube.com/vi/J2kHSSFA4NU/0.jpg)](https://www.youtube.com/watch?v=J2kHSSFA4NU)

This is a table:

| Heading 1 | Heading 2 |
|-----------|-----------|
|Some stuff | Some more stuff in this column |
|Some stuff | Some more stuff in this column |
|Some stuff | Some more stuff in this column |
|Some stuff | Some more stuff in this column |



