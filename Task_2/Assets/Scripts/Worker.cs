using UnityEngine;
[RequireComponent(typeof(CharacterController))]
public class Worker : MonoBehaviour
{
    [SerializeField] private WorkerConfig _config;
    [SerializeField] private Transform _workPoint;
    [SerializeField] private Transform _homePoint;

    private WorkerStateMachine _stateMachine;
    private CharacterController _characterController;

    public Transform WorkPoint => _workPoint;
    public Transform HomePoint => _homePoint;
    public CharacterController Controller => _characterController;
    public WorkerConfig Config => _config;

    private void Awake()
    {
        _characterController = GetComponent<CharacterController>();
        _stateMachine = new WorkerStateMachine(this);
    }

    private void Update()
    {
        _stateMachine.Action();
        _stateMachine.Update();
    }
}
