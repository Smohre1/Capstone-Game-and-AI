using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Yellow Ball(Clone)")
        {
            GameController.instance.points += GameController.instance.positiveValue;
            Debug.Log("Yellow");
        }
        else
        {
            GameController.instance.points += GameController.instance.negativeValue;
            Debug.Log("No Yellow");
        }
        GameController.instance.canSpawn = true;
        Destroy(other.gameObject);
    }
}
