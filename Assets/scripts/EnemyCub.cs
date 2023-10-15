using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCub : MonoBehaviour
{
    public float moveSpeed = 2.0f;

    private int direction = 1;

    void Update()
    {
        transform.Translate(Vector3.right * direction * moveSpeed * Time.deltaTime);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
        {
            direction -= -1;
        }
    }
}
