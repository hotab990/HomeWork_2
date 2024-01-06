using UnityEngine;

public class RelaxState : WorkerState
{
    private float _timer;
    public RelaxState(IStateSwitcher stateSwitcher, Worker worker) : base(stateSwitcher, worker)
    {
    }

    public override void Enter()
    {
        base.Enter();
        Debug.Log("Пришел домой, отдыхать");
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
        if (_timer <= 0)
            StateSwitcher.SwitchState<GoWorkState>();
    }

    public override void Exit()
    {
        base.Exit();
    }
}
