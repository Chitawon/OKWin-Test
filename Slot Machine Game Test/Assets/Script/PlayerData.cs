using UnityEngine;

public class PlayerData : MonoBehaviour
{
    public static PlayerData Instance;

    [SerializeField] private int balance = 100;
    [SerializeField] private int totalWin;
     
    public int TotalWin { get { return totalWin;} }
    public int Balance { get { return balance; } }

    private void Awake()
    {
        Instance = this;
        DontDestroyOnLoad(this);
    }

    public void ChangeBalance(int coins)
    {
        balance += coins;
    }

    public void ChangeTotalWin(int win)
    {
        totalWin += win;
    }
}


