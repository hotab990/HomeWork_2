using UnityEngine;

[CreateAssetMenu(fileName = "WorkerConfig", menuName = "Configs/WorkerConfig")]
public class WorkerConfig : ScriptableObject
{
    [SerializeField] private GoWorkStateConfig _goWorkStateConfig;
    [SerializeField] private GoHomeStateConfig _goHomeStateConfig;

    public GoWorkStateConfig GoWorkStateConfig => _goWorkStateConfig;
    public GoHomeStateConfig GoHomeStateConfig => _goHomeStateConfig;
}