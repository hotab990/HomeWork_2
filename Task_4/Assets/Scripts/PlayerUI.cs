using TMPro;
using UnityEngine;

public class PlayerUI:MonoBehaviour
{
    [SerializeField] private TMP_Text HpUI;
    [SerializeField] private TMP_Text LevelUI;

    public PlayerUI(TMP_Text hpUI, TMP_Text levelUI)
    {
        HpUI = hpUI;
        LevelUI = levelUI;
    }

    public void UpdateUI(int HP, int Level)
    {
        HpUI.text = HP.ToString();
        LevelUI.text = Level.ToString();
    }
}
