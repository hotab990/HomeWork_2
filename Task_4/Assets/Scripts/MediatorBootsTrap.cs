using UnityEngine;

public class MediatorBootsTrap : MonoBehaviour
{
    [SerializeField, Range(1, 100)] private int DamageToDeal;
    [SerializeField, Range(1, 10)] private int LevelToAdd;

    [SerializeField] PlayerUI _playerUI;

    [SerializeField] private GameplayMediator _gameplayMediator;
    [SerializeField] private DefeatPanel _defeatPanel;

    private Player _player;

    private void Awake()
    {
        _player = new Player();

        _gameplayMediator.Initialize(_player);
        _defeatPanel.Initialize(_gameplayMediator);

        _player.Start();
        _playerUI.UpdateUI(_player.HP, _player.Level);
    }

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Q))
        { _player.GetDamege(DamageToDeal);
          _playerUI.UpdateUI(_player.HP, _player.Level); }

        if (Input.GetKeyDown(KeyCode.E))
        { _player.GetLevel(LevelToAdd);
          _playerUI.UpdateUI(_player.HP, _player.Level); }
    }
}
