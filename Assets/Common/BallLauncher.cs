using UnityEngine;

sealed class BallLauncher : MonoBehaviour
{
    [SerializeField] Rigidbody _prefab = null;
    [SerializeField] float _speed = 10;

    void Launch()
    {
        var rb = Instantiate(_prefab, transform.position, transform.rotation);
        rb.linearVelocity = new Vector3(0, 0, _speed);
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) Launch();
    }
}
