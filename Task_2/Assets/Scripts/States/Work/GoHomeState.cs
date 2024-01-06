using UnityEngine;

public class GoHomeState : WorkerState
{
    //private GoHomeStateConfig _config;
    private float _timer;
    public GoHomeState(IStateSwitcher stateSwitcher, Worker worker) : base(stateSwitcher, worker)
    {
    }

    public override void Enter()
    {
        base.Enter();
        Debug.Log("Работу закончил, иду домой");
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
            StateSwitcher.SwitchState<RelaxState>();
    }

    public override void Exit()
    {
        base.Exit();
    }
}
