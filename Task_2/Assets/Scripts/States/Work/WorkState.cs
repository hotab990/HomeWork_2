using UnityEngine;

public class WorkState : WorkerState
{
    private float _timer;
    public WorkState(IStateSwitcher stateSwitcher, Worker worker) : base(stateSwitcher, worker)
    {
    }

    public override void Enter()
    {
        base.Enter();
        Debug.Log("Начал Работу");
        _timer = 5f;
    }

    public override void Action()
    {
        base.Action();
    }
    public override void Update()
    {
        base.Update();
        _timer -= Time.deltaTime;
        if (_timer  <= 0)
            StateSwitcher.SwitchState<GoHomeState>();
    }

    public override void Exit()
    {
        base.Exit();
    }
}
