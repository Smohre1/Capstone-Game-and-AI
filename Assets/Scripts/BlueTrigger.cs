using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Blue Ball(Clone)")
        {
            GameController.instance.points += GameController.instance.positiveValue;
            Debug.Log("Blue");
        }
        else
        {
            GameController.instance.points += GameController.instance.negativeValue;
            Debug.Log("No Blue");
        }
        GameController.instance.canSpawn = true;
        Destroy(other.gameObject);
    }
}
