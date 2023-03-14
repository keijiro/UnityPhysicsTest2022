using UnityEngine;

sealed class CameraController : MonoBehaviour
{
    [SerializeField] Transform _target = null;
    [SerializeField] float _smoothTime = 0.3f;

    Vector3 _velocity;

    void Update()
      => transform.position = Vector3.SmoothDamp
           (transform.position, _target.position, ref _velocity, _smoothTime);
}
