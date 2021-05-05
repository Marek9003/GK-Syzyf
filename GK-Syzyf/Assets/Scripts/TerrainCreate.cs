using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainCreate : MonoBehaviour
{
    public Transform Terrain;
    private Vector3 nextTerrain;

    // Start is called before the first frame update
    void Start()
    {
        nextTerrain.x = -50;
        nextTerrain.y = -0.02f;
        nextTerrain.z = 70;
        StartCoroutine(spawnTerrein());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator spawnTerrein()
    {
        yield return new WaitForSeconds(1);

        Instantiate(Terrain, nextTerrain, Terrain.rotation);
        nextTerrain.x = -50;
        nextTerrain.y = -0.02f;
        nextTerrain.z += 20;
        StartCoroutine(spawnTerrein());
    }

}
