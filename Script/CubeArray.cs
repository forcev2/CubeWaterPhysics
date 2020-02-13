using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeArray : MonoBehaviour
{
    public WaterPhysics waterPhysics;
    public GenerateCubes generateCubes;
    public Chunk chunk;
    // Start is called before the first frame update
    void Start()
    {
        generateCubes = gameObject.GetComponent<GenerateCubes>();
        waterPhysics = gameObject.GetComponent<WaterPhysics>();
        chunk = gameObject.GetComponent<Chunk>();
    }

   
    void Update()
    {

        //generateCubes.cubeArray = waterPhysics.updateWater(generateCubes.cubeArray, generateCubes.numbersOf);

    }
}
