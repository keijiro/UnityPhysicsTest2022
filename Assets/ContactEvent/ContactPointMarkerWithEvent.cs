using UnityEngine;
using Unity.Collections;
using System.Collections.Generic;

sealed class ContactPointMarkerWithEvent : MonoBehaviour
{
    [SerializeField] Mesh _mesh = null;
    [SerializeField] Material _material = null;

    List<Matrix4x4> _matrices = new List<Matrix4x4>();

    void OnEnable()
      => Physics.ContactEvent += ContactCallback;

    void OnDisable()
      => Physics.ContactEvent -= ContactCallback;

    void ContactCallback(PhysicsScene scene, NativeArray<ContactPairHeader>.ReadOnly headers)
    {
        foreach (var header in headers)
        {
            for (var i = 0; i < header.pairCount; i++)
            {
                var pair = header.GetContactPair(i);
                for (var j = 0; j < pair.contactCount; j++)
                {
                    _matrices.Add(Matrix4x4.Translate(pair.GetContactPoint(j).position));
                }
            }
        }
    }

    void LateUpdate()
    {
        Graphics.DrawMeshInstanced(_mesh, 0, _material, _matrices);
        _matrices.Clear();
    }
}
