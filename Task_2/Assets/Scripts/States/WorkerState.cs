using System;
using UnityEngine;

public abstract class WorkerState : IState
{
    protected readonly IStateSwitcher StateSwitcher;
    protected readonly StateMachineData Data;

    private readonly Worker _worker;

    //private readonly Transform _target;

    public WorkerState(IStateSwitcher stateSwitcher, Worker worker)
    {
        StateSwitcher = stateSwitcher;
        _worker = worker;
        //_target = target;
    }

    protected CharacterController CharacterController => _worker.Controller;

    public virtual void Enter() => Debug.Log(GetType());

    public virtual void Exit() => Debug.Log("ChangeState");


    public virtual void Action()
    {
        //isOnTargetPosition();
    }


    public virtual void Update()
    {
        //CharacterController.Move(CurrentTarget() * Time.deltaTime);
    }

    private Vector3 CurrentTarget() => Data.Target.position;

    //protected bool isOnTargetPosition()
    //{
    //    Debug.Log("Проверка идет");
    //    if (_worker.transform.position.x == _target.transform.position.x
    //        && _worker.transform.position.z == _target.transform.position.z)
    //    {
    //        return true;
    //    }
    //    else
    //        return false;
    //}
    }
