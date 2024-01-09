using System;
using UnityEngine;

public class Player
{
    private const int HealthPoints =100;
    private const int StartPlayerLevel = 1;
    private int _hp;
    private int _level;

    public event Action Defeat;

    public int HP => _hp;
    public int Level => _level;

    public void Start()
    {
        _hp = HealthPoints;
        _level = StartPlayerLevel;
        Debug.Log("StartLevel");
    }

    public void Restart()
    {
        Debug.Log("ClearLevel");
        Start();
    }

    public void OnDefeat()
    {
        Defeat?.Invoke();
    }

    public void GetDamege(int Damage)
    {
        _hp -= Damage;

        if (_hp <= 0)
            OnDefeat();
    }

    public void GetLevel(int Level)
    {
        _level += Level;
    }
}
