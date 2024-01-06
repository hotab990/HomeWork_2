using System;
using UnityEngine;

[Serializable]
public class GoHomeStateConfig
{
    [SerializeField, Range(0, 10)] private float _speed;
    [SerializeField] private Transform _target;

    public float Speed => _speed;

    public Transform Target
    {
        get
        {
            if (Target == null)
                throw new ArgumentOutOfRangeException(nameof(Target));
            return _target;
        }
    }
}