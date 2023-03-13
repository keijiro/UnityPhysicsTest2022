using UnityEngine;
using Unity.Collections;

sealed class ImpulseOnContactEvent : MonoBehaviour
{
    void OnEnable()
      => Physics.ContactEvent += ContactCallback;

    void OnDisable()
      => Physics.ContactEvent -= ContactCallback;

    void ContactCallback
      (PhysicsScene scene, NativeArray<ContactPairHeader>.ReadOnly pairs)
    {
        foreach (var pair in pairs)
            pair.Body?.GetComponent<Rigidbody>().AddForce(Vector3.up * 10, ForceMode.Impulse);
    }
}
