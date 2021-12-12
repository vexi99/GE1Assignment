using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeGeneration : MonoBehaviour
{

    public GameObject tree;
    public GameObject[] treeArray;
    public TerrainGenerator terrain;
    private int numTrees = 10; 

    void GenerateTrees()
    {
        treeArray = new GameObject[numTrees];
        for(int i = 0; i<numTrees; i++)
        {
            GameObject newTree = Instantiate(tree, new Vector3(120 + i * 10 , 15, 130), Quaternion.identity);
            treeArray[i] = newTree;
        }

        
    }

    public void DestroyTree()
    {
        //DestroyImmediate(treeArray[i], true);
    }
    // Start is called before the first frame update
    void Start()
    {
        GenerateTrees();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
