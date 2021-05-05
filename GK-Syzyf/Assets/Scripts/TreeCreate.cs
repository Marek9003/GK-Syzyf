using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeCreate : MonoBehaviour
{
    public Transform Broadleaf;
    private Vector3 nextBroadleadSpawn;
    private Vector3 nextBroadleadSpawn2;
    // Start is called before the first frame update
    void Start()
    {
        nextBroadleadSpawn.x = -27;
        nextBroadleadSpawn.z = 30;

        nextBroadleadSpawn2.x = 27;
        nextBroadleadSpawn2.z = 30;
        StartCoroutine(spawnTree());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator spawnTree()
    {
        yield return new WaitForSeconds(1);
        Instantiate(Broadleaf, nextBroadleadSpawn, Broadleaf.rotation);
        Instantiate(Broadleaf, nextBroadleadSpawn2, Broadleaf.rotation);
        nextBroadleadSpawn.z += 20;
        nextBroadleadSpawn2.z += 20;
        StartCoroutine(spawnTree());
    }

}
