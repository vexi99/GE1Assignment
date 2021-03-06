using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainGenerator : MonoBehaviour
{
    public int depth = 20;
    public int width = 256;
    public int height = 256; 

    public TreeGeneration Passtree;
    public bool hasStarted = true;

    //An array of 256x256 which holds each height at each point on terrain
    public float[,] heights = new float[256, 256];

    public float scale = 20f;
    public float offsetX = 100f;
    public float offsetY = 100f;

    void Start()
    {
        //Offset X and Y values given random float value between 0 and 99999 on startup
        offsetX = Random.Range(0f, 99999f);
        offsetY = Random.Range(0f, 99999f);
    }

    // Update is called once per frame
    void Update()
    {
        Terrain terrain = GetComponent<Terrain>();
        terrain.terrainData = GenerateTerrain(terrain.terrainData);

        if(hasStarted)
        {
            //Control code to ensure only runs once, cannot be put in Start() as terrainData is not available on start method.
            Passtree.TreeHeight(terrain.terrainData);
            hasStarted = false;
        }
        
    }

    TerrainData GenerateTerrain(TerrainData terrainData)
    {
        terrainData.heightmapResolution = width +1; //mesh resolution
        terrainData.size = new Vector3(width,depth,height);
        terrainData.SetHeights(0,0, GenerateHeights());
        return terrainData;
    }

    float[,] GenerateHeights()
    {  
        for (int x = 0; x < width; x++)
        {
            for(int y = 0; y < height; y++)
            {
                heights[x,y] = CalculateHeight(x,y);
            }
        }
        return heights;
    }

    float CalculateHeight(int x, int y)
    {
        float xCord = (float)x / width * scale + offsetX;
        float yCord = (float)y / height * scale + offsetY;

        return Mathf.PerlinNoise(xCord, yCord); //returns float between 0 and 1
    }

    public float getHeights(int x, int z)
    {
        
        return heights[x,z];
    }
    

}
