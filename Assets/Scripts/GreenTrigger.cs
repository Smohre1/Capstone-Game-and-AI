using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Green Ball(Clone)")
        {
            GameController.instance.points += GameController.instance.positiveValue;
            Debug.Log("Green");
        }
        else
        {
            GameController.instance.points += GameController.instance.negativeValue;
            Debug.Log("No Green");
        }
        GameController.instance.canSpawn = true;
        Destroy(other.gameObject);
    }
}
