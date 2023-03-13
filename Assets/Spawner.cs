using UnityEngine;

sealed class Spawner : MonoBehaviour
{
    [SerializeField] GameObject _prefab = null;
    [SerializeField] int _spawnCount = 10;
    [SerializeField] Vector3 _extent = Vector3.one;

    void Start()
    {
        Random.InitState(1000);

        var center = transform.position;

        for (var i = 0; i < _spawnCount; i++)
        {
            var pos = new Vector3(Random.value, Random.value, Random.value);
            pos = Vector3.Scale(pos - Vector3.one * 0.5f, _extent) + center;

            var rot = Random.rotation;

            Instantiate(_prefab, pos, rot);
        }
    }
}
