using UnityEngine;

sealed class WallBuilder : MonoBehaviour
{
    [SerializeField] GameObject _prefab = null;
    [SerializeField] Vector2Int _dimensions = new Vector2Int(10, 10);
    [SerializeField] Vector2 _interval = new Vector2(0.1f, 0.1f);

    void Start()
    {
        for (var i = 0; i < _dimensions.x; i++)
        {
            var x = (i - (_dimensions.x - 1.0f) / 2) * _interval.x;
            for (var j = 0; j < _dimensions.y; j++)
            {
                var y = (j + 0.5f) * _interval.y;
                var pos = new Vector3(x, y, 0) + transform.position;
                var go = Instantiate(_prefab, pos, Quaternion.identity);
                go.GetComponent<Rigidbody>().Sleep();
            }
        }
    }
}
