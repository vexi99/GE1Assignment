using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeGeneration : MonoBehaviour
{

    public GameObject tree, newTree;
    public GameObject[] treeArray;
    public TerrainGenerator terrain;
    public int numTrees = 10; 
    public float[] treeX; //clone Trees X coords
    public float[] treeZ; //clone Trees Z coords

    void Start()
    {
        GenerateTrees();
    }

    void GenerateTrees()
    {

        treeArray = new GameObject[numTrees];
        treeX = new float[numTrees];
        treeZ = new float[numTrees];
        /*  For loop for each number of numTrees.
            Two random X and Z coords */
        for(int i = 0; i<numTrees; i++)
        {
            treeX[i] = Random.Range(0f,256f);
            treeZ[i] = Random.Range(0f,256f);
            newTree = Instantiate(tree, new Vector3(treeX[i] , 30, treeZ[i]), Quaternion.identity);
            treeArray[i] = newTree;
        }
    }

    public void DestroyTree()
    {
        //DestroyImmediate(treeArray[i], true); TODO
    }

    // Update is called once per frame
    void Update()
    {
        TreeMovement();
    }

    public void TreeHeight(TerrainData terrainData)
    {
        for(int i =0;i<numTrees; i++)
        {
            Vector3 newTreePos = new Vector3(treeArray[i].transform.position.x, terrainData.GetHeight((int)treeX[i],(int)treeZ[i]), treeArray[i].transform.position.z);
            treeArray[i].transform.position = newTreePos;
        }
           
    }

    void TreeMovement()
    {
        //Movement here is 0.2 instead of usual 0.02 as array is split into 10 pieces.
        //Workaround here is to multiply speed by amount of elements in array.
        Vector3 xChange = new Vector3(0.18f,0,0);
        Vector3 zChange = new Vector3(0,0,0.18f);

        for (int i = 0; i < numTrees; i++)
        {
            treeArray[i].transform.position -= zChange;
            if (Input.GetKey(KeyCode.W))
            {
                treeArray[i].transform.position -= zChange;
            }
            if (Input.GetKey(KeyCode.A))
            {
                treeArray[i].transform.position += xChange;
            }
            if (Input.GetKey(KeyCode.S))
            {
                treeArray[i].transform.position += zChange;
            }
            if (Input.GetKey(KeyCode.D))
            {
                treeArray[i].transform.position -= xChange;
            }
        }
        
    }
}
