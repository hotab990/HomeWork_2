using UnityEngine.InputSystem;

public class WalkingState : GroundedState
{
    private WalkingStateConfig _config;

    public WalkingState(IStateSwitcher stateSwitcher, Character character, StateMachineData data) : base(stateSwitcher, character, data)
        => _config = character.Config.WalkingStateConfig;

    public override void Enter()
    {
        base.Enter();

        Data.Speed = _config.Speed;

        View.StartRunning();
    }

    public override void Exit()
    {
        base.Exit();

        View.StopRunning();
    }

    public override void Update()
    {
        base.Update();

        if (IsHorizontalInputZero())
            StateSwitcher.SwitchState<IdlingState>();
    }

    protected override void AddInputActionsCallbacks()
    {
        base.AddInputActionsCallbacks();

        Input.Movement.Run.started += OnRunKeyPressed;
    }

    protected override void RemoveInputActionsCallbacks()
    {
        base.RemoveInputActionsCallbacks();

        Input.Movement.Run.started -= OnRunKeyPressed;
    }

    private void OnRunKeyPressed(InputAction.CallbackContext obj) => StateSwitcher.SwitchState<RunningState>();
}
