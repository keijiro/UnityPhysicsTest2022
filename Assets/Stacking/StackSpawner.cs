using UnityEngine;

sealed class StackSpawner : MonoBehaviour
{
    [SerializeField] GameObject _prefab = null;
    [SerializeField] float _spawnSpeed = 20;
    [SerializeField] float _spawnRadius = 0.1f;

    float _acc;

    void Update()
    {
        var center = transform.position;

        _acc += _spawnSpeed * Time.deltaTime;

        for (; _acc >= 1; _acc--)
        {
            var pos = center + Random.insideUnitSphere * _spawnRadius;
            var rot = Random.rotation;
            Instantiate(_prefab, pos, rot);
        }
    }
}
