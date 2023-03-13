using UnityEngine;

sealed class ImpulseOnContact : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
      => collision.body?.GetComponent<Rigidbody>().AddForce(Vector3.up * 10, ForceMode.Impulse);

    void OnCollisionStay(Collision collision)
      => OnCollisionEnter(collision);
}
