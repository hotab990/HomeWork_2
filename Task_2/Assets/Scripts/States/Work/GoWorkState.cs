using UnityEngine;

public class GoWorkState : WorkerState
{
    //private GoWorkStateConfig _config;
    private float _timer;

    public GoWorkState(IStateSwitcher stateSwitcher, Worker worker) : base(stateSwitcher, worker)
    {
    }

    public override void Enter()
    {
        base.Enter();
        Debug.Log("Отдохнул, пора на работу");
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
            StateSwitcher.SwitchState<WorkState>();
    }

    public override void Exit()
    {
        base.Exit();
    }
}
