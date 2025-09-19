using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bounds : MonoBehaviour
{
    // When player/ball falls into zone
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

        if (other.gameObject.CompareTag("Ball"))
        {
            GameController.instance.canSpawn = true;
            Destroy(other.gameObject);
        }

    }
}
