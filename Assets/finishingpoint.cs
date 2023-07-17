using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finishingpoint : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            scenecontroller.instance.nextlevel();
        }
    }
}
