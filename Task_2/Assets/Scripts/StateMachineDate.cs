using System;
using UnityEngine;

public class StateMachineData
{
    private Transform _target;
    private float _speed;

    public float Speed
    {
        get => _speed;
        set
        {
            if (value < 0)
                throw new ArgumentOutOfRangeException(nameof(value));

            _speed = value;
        }
    }
    public Transform Target
    {
        get => _target;
        set
        {
            if (value ==null)
                throw new ArgumentOutOfRangeException(nameof(value));

            _target = value;
        }
    }
}