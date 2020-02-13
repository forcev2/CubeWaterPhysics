using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterPhysics : MonoBehaviour
{
    // Start is called before the first frame update


    void Start()
    {
        
    }

    // Update is called once per frame
    public List<List<List<GameObject>>> updateWater(List<List<List<GameObject>>> cubeArray, int numOf)
    {
        //Debug.Log(numOf);
        for (int y = 0; y < numOf; y++)
            for (int x = 0; x < numOf; x++)
                for (int z = 0; z < numOf; z++)
                {
                    //Debug.Log(cubeArray);
                    if (cubeArray[x][y][z] != null)
                    {
                       // Debug.Log("log");
                        if (cubeArray[x][y][z].tag == "Water")
                        {
                            if (y != 0)
                            {
                                if (cubeArray[x][y - 1][z] == null)
                                {
                                    //sDebug.Log("WaterFalls");
                                    cubeArray[x][y - 1][z] = cubeArray[x][y][z];
                                    cubeArray[x][y][z] = null;
                                }
                                else
                                {

                                        int f = Random.Range(0, 4);
                                        switch (f) {
                                        case 0:
                                                if (z != 0)
                                                {
                                                    if (cubeArray[x][y][z - 1] == null)
                                                    {
                                                        cubeArray[x][y][z - 1] = cubeArray[x][y][z];
                                                        cubeArray[x][y][z] = null;
                                                    }
                                                }
                                                break;
                                        case 1:
                                                if (z < numOf - 1)
                                                {
                                                    if (cubeArray[x][y][z + 1] == null)
                                                    {
                                                        cubeArray[x][y][z + 1] = cubeArray[x][y][z];
                                                        cubeArray[x][y][z] = null;
                                                    }
                                                }
                                                break;
                                         case 2:
                                                if (x != 0)
                                                {
                                                    if (cubeArray[x - 1][y][z] == null)
                                                    {
                                                        cubeArray[x - 1][y][z] = cubeArray[x][y][z];
                                                        cubeArray[x][y][z] = null;
                                                    }
                                                    
                                                }
                                                break;
                                        case 3:
                                                if (x < numOf - 1)
                                                {
                                                    if (cubeArray[x + 1][y][z] == null)
                                                    {
                                                        cubeArray[x + 1][y][z] = cubeArray[x][y][z];
                                                        cubeArray[x][y][z] = null;
                                                    }

                                                }
                                                break;
                                        }
                                    
                                }
                            }
                        }
                    }
                }
        return cubeArray;
    }
    
}
