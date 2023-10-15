using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WALL : MonoBehaviour
{
    private bool playerTriggered = false;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerTriggered = true;
            StartCoroutine(Die());

            SceneManager.LoadScene(0);
        }
    }

    IEnumerator Die()
    {
        yield return new WaitForSeconds(3f);

        SceneManager.LoadScene(0);
    }
}
