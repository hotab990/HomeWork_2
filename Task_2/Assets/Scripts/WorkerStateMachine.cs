using System.Collections.Generic;
using System.Linq;

public class WorkerStateMachine: IStateSwitcher
{
    private List<IState> _states;
    private IState _currentState;

    public WorkerStateMachine(Worker worker)
    {
        _states = new List<IState>()
        {
            new RelaxState(this, worker),
            new GoWorkState(this, worker),
            new WorkState(this, worker),
            new GoHomeState(this, worker)
        };

        _currentState = _states[0];
        _currentState.Enter();
    }

    public void SwitchState<State>() where State : IState
    {
        IState state = _states.FirstOrDefault(state => state is State);

        _currentState.Exit();
        _currentState = state;
        _currentState.Enter();
    }

    public void Action() => _currentState.Action();

    public void Update() => _currentState.Update();
}
