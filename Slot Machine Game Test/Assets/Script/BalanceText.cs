using TextUGUI = TMPro.TextMeshProUGUI;
using UnityEngine;

public class BalanceText : MonoBehaviour
{
    [SerializeField] private TextUGUI balanceText;

    private static string Text = "Balance : ";

    void Start()
    {
        SetText(PlayerData.Instance.Balance);
    }

    void Update()
    {
        SetText(PlayerData.Instance.Balance);
    }

    private void SetText(int coins)
    {
        balanceText.text = Text + coins;
    }
}
