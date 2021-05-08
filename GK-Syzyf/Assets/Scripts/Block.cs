using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Data;

public class Block : MonoBehaviour
{
    public Transform BlockPrototype;
    private Vector3 nextBlockPrototype;
    public PlayerMovement playermovement;

   
    // Start is called before the first frame update
    void Start()
    {
        nextBlockPrototype.x = 5;
        nextBlockPrototype.z = 60;


        StartCoroutine(spawnCube());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    

    IEnumerator spawnCube()
    {
        yield return new WaitForSeconds(3);
        Instantiate(BlockPrototype, nextBlockPrototype, BlockPrototype.rotation);

        //var position = new Vector3(Random.Range(-10.0f, 10.0f), 0, Random.Range(-10.0f, 10.0f));


        nextBlockPrototype.x += Random.Range(-10.0f, 10.0f);

        if(nextBlockPrototype.x >10)
        {
            nextBlockPrototype.x = 10;
        }

        if (nextBlockPrototype.x < -10)
        {
            nextBlockPrototype.x = -10;
        }

        nextBlockPrototype.z += Random.Range(0.0f, 50.0f);

        //nextBlockPrototype = position;

        

        StartCoroutine(spawnCube());


        

    
}
}
