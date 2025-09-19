using UnityEngine;

public class PusherController : MonoBehaviour
{
    public float pushForce = 0.5f;

    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        Rigidbody hitRigidbody = hit.collider.attachedRigidbody;
        Vector3 pushDirection = hit.moveDirection;
        pushDirection.y = 0;
        pushDirection.Normalize();

        hitRigidbody.AddForce(pushDirection * pushForce, ForceMode.Impulse);

    }
}
