using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SceneCreate : MonoBehaviour
{
    public Transform Plane;
    private Vector3 nextPlaneSpawn;
    public PlayerMovement playermovement;
    

    // Start is called before the first frame update
    void Start()
    {
        nextPlaneSpawn.z = 70;
        StartCoroutine(spawnPlane());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator spawnPlane()
    {
        yield return new WaitForSeconds(1);

        Instantiate(Plane, nextPlaneSpawn, Plane.rotation);
        nextPlaneSpawn.z += 20;
        StartCoroutine(spawnPlane());
    }


}
