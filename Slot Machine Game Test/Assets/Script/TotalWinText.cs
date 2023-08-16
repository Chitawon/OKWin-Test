using TextUGUI = TMPro.TextMeshProUGUI;
using UnityEngine;

public class TotalWinText : MonoBehaviour
{
    [SerializeField] private TextUGUI totalWinText;

    private static string Text = "Total Win : ";

    // Start is called before the first frame update
    void Start()
    {
        SetText(PlayerData.Instance.TotalWin);
    }

    void Update()
    {
        SetText(PlayerData.Instance.TotalWin);
    }

    private void SetText(int win)
    {
        totalWinText.text = Text + win;
    }
}
