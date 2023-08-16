using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Payline : MonoBehaviour
{
    [SerializeField] private Reel leftReel;
    [SerializeField] private Reel centerReel;
    [SerializeField] private Reel rightReel;

    [SerializeField] private string text;

    public void Spin()
    {
        leftReel.SpinReel();
        centerReel.SpinReel();
        rightReel.SpinReel();
        CheckSpinResult();
    }

    private void CheckSpinResult()
    {
        var leftSpin = leftReel.GetReel();
        var centerSpin = centerReel.GetReel();
        var rightSpin = rightReel.GetReel();

        if (leftSpin == Reelenum.Banana && centerSpin == Reelenum.Banana && rightSpin == Reelenum.Banana)
        {
            PlayerData.Instance.ChangeBalance(500);
            PlayerData.Instance.ChangeTotalWin(1);
        }
        else if (leftSpin == Reelenum.Apple && centerSpin == Reelenum.Apple && rightSpin == Reelenum.Apple)
        {
            PlayerData.Instance.ChangeBalance(100);
            PlayerData.Instance.ChangeTotalWin(1);
        }
        else if (leftSpin == Reelenum.Plumlon && centerSpin == Reelenum.Plumlon && rightSpin == Reelenum.Plumlon)
        {
            PlayerData.Instance.ChangeBalance(50);
            PlayerData.Instance.ChangeTotalWin(1);
        }
        else if (leftSpin == Reelenum.Watermelon && centerSpin == Reelenum.Watermelon && rightSpin == Reelenum.Watermelon)
        {
            PlayerData.Instance.ChangeBalance(20);
            PlayerData.Instance.ChangeTotalWin(1);
        }
        else if (leftSpin == Reelenum.Orange && centerSpin == Reelenum.Orange && rightSpin == Reelenum.Orange)
        {
            PlayerData.Instance.ChangeBalance(15);
            PlayerData.Instance.ChangeTotalWin(1);
        }
        else if (leftSpin == Reelenum.Cherry && centerSpin == Reelenum.Cherry && rightSpin == Reelenum.Cherry)
        {
            PlayerData.Instance.ChangeBalance(10);
            PlayerData.Instance.ChangeTotalWin(1);
        }
        else if (leftSpin == Reelenum.Cherry && centerSpin == Reelenum.Cherry)
        {
            PlayerData.Instance.ChangeBalance(5);
        }
        else if (leftSpin == Reelenum.Cherry)
        {
            PlayerData.Instance.ChangeBalance(2);
        }

        Debug.Log(text + leftSpin + " " + centerSpin + " " + rightSpin);
    }
}
