using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class COin : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
}
