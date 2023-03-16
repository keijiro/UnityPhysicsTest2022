using UnityEngine;

sealed class SimpleRotation : MonoBehaviour
{
    [SerializeField] Vector3 _angularVelocity = Vector3.one;

    void Update()
    {
        transform.eulerAngles += _angularVelocity * Time.deltaTime;
    }
}
