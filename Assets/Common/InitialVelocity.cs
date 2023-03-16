using UnityEngine;

sealed class InitialVelocity : MonoBehaviour
{
    [SerializeField] Vector3 _velocity = Vector3.zero;
    [SerializeField] Vector3 _angularVelocity = Vector3.zero;

    void Start()
    {
        var rb = GetComponent<Rigidbody>();
        rb.AddRelativeForce(_velocity, ForceMode.VelocityChange);
        rb.AddRelativeTorque(_angularVelocity, ForceMode.VelocityChange);
    }
}
