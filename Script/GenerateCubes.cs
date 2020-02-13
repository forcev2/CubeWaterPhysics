using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateCubes : MonoBehaviour
{
    // Start is called before the first frame update
    float individualSize;
    public float size;
    public int numbersOf;
    public List<List<List<GameObject>>> cubeArray;
    List<List<List<GameObject>>> cubeArrayPre;
    public GameObject blockPrefWater;
    public GameObject blockPrefGround;
    Transform parentPos;
    public WaterPhysics waterPhysics;

    void Start()
    {
        waterPhysics = gameObject.GetComponent<WaterPhysics>();
        parentPos = transform;
        initArray();
        cubeArrayPre = cubeArray;
        //fillArray();
        arrayChange();
        positionCubes();
    }

    void Update()
    {
        cubeArrayPre = waterPhysics.updateWater(cubeArray, numbersOf);
        positionCubes();
    }

    void initArray()
    {
        individualSize = size / numbersOf;
        cubeArray = new List<List<List<GameObject>>>();
        for (int i = 0; i < numbersOf; i++)
        {
            Debug.Log(i);
            cubeArray.Add(new List<List<GameObject>>());
            for(int j = 0; j < numbersOf; j++)
            {
                cubeArray[i].Add(new List<GameObject>());
                for(int y = 0; y < numbersOf; y++)
                {
                    cubeArray[i][j].Add(null);
                }
            }
        }
    }

    void fillArray()
    {
        for(int i = 0; i < numbersOf; i++)
        {
            for (int j = 0; j < cubeArray.Count; j++)
            {
                for (int y = 0; y < cubeArray.Count; y++)
                {
                    cubeArray[i][j][y] = Instantiate(blockPrefGround, parentPos);
                }
            }
        }
    }

    void arrayChange()
    {


        for (int i = 0; i < numbersOf; i++)
            for (int j = 0; j < numbersOf; j++)
            {
                cubeArray[i][11][j] = Instantiate(blockPrefWater, parentPos);
                cubeArray[i][12][j] = Instantiate(blockPrefWater, parentPos);
                cubeArray[i][13][j] = Instantiate(blockPrefWater, parentPos);
                cubeArray[i][14][j] = Instantiate(blockPrefWater, parentPos);
                cubeArray[i][0][j] = Instantiate(blockPrefGround, parentPos);
                cubeArray[i][10][j] = Instantiate(blockPrefGround, parentPos);
            }

    }

    void positionCubes()
    {
        for (int i = 0; i < numbersOf; i++)
        {
            for (int j = 0; j < numbersOf; j++)
            {
                for (int y = 0; y < numbersOf; y++)
                {
                    if (cubeArray[i][j][y] != null)
                    {
                        //if (cubeArray[i][j][y] != cubeArrayPre[i][j][y])
                        //{
                            cubeArray[i][j][y].transform.position = new Vector3(parentPos.position.x + (i * individualSize), parentPos.position.y + (j * individualSize), parentPos.position.z + (y * individualSize));
                            cubeArray[i][j][y].transform.localScale = new Vector3(individualSize, individualSize, individualSize);
                       // }
                        //cubeArray[i][j][y].GetComponent<MeshRenderer>().enabled = false;
                    }
                }
            }
        }
    }

    public List<List<List<GameObject>>> getCubeArray()
    {
        return cubeArray;
    }

    // Update is called once per frame

}
