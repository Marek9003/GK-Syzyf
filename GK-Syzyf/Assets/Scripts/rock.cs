using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rock : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        string collisionObjectName = collision.collider.gameObject.tag;
        if (collisionObjectName == "Finish")
        {
            Time.timeScale = 0;
        }
    }
}
