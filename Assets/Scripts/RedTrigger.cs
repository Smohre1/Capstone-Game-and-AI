using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "Red Ball(Clone)")
        {
            GameController.instance.points += GameController.instance.positiveValue;
            Debug.Log("Red");
        }
        else
        {
            GameController.instance.points += GameController.instance.negativeValue;
            Debug.Log("No Red");
        }
        GameController.instance.canSpawn = true;
        Destroy(other.gameObject);
    }
}
