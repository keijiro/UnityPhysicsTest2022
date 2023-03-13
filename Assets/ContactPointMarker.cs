using UnityEngine;
using System.Collections.Generic;

sealed class ContactPointMarker : MonoBehaviour
{
    [SerializeField] Mesh _mesh = null;
    [SerializeField] Material _material = null;

    List<Matrix4x4> _matrices = new List<Matrix4x4>();

    void OnCollisionStay(Collision collision)
    {
        for (var i = 0; i < collision.contactCount; i++)
            _matrices.Add(Matrix4x4.Translate(collision.GetContact(i).point));
    }

    void LateUpdate()
    {
        Graphics.DrawMeshInstanced(_mesh, 0, _material, _matrices);
        _matrices.Clear();
    }
}
