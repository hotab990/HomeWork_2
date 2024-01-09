using UnityEngine;

public class GameplayMediator : MonoBehaviour
{
    [SerializeField] private DefeatPanel _defeatPanel;
    [SerializeField] private PlayerUI _playerUI;
    private Player _player;

    private void OnDisable()
    {
        _player.Defeat -= OnLevelDefeat;
    }

    public void Initialize(Player player)
    {
        _player = player;
        _player.Defeat += OnLevelDefeat;
    }

    private void OnLevelDefeat() => _defeatPanel.Show();

    public void RestartLevel()
    {
        _defeatPanel.Hide();
        _player.Restart();
        _playerUI.UpdateUI(_player.HP, _player.Level);
    }
}
