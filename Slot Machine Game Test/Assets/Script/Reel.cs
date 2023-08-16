using Random = UnityEngine.Random;
using UnityEngine;
using Image = UnityEngine.UI.Image;

public class Reel : MonoBehaviour
{
    [SerializeField] private Image reelImage;
    [SerializeField] private Reelenum reelEnum;

    [Header("Reel Sprite")]
    [SerializeField] private Sprite cherrySprite;
    [SerializeField] private Sprite orangeSprite;
    [SerializeField] private Sprite watermelonSprite;
    [SerializeField] private Sprite plumlonSprite;
    [SerializeField] private Sprite appleSprite;
    [SerializeField] private Sprite bananaSprite;

    [Header("Reel Wieght")]
    [SerializeField] private int cherryWieght;
    [SerializeField] private int orangeWieght;
    [SerializeField] private int watermelonWieght;
    [SerializeField] private int plumlonWieght;
    [SerializeField] private int appleWieght;
    [SerializeField] private int bananaWieght;

    private int wieghtTotal = 1;

    private void Start()
    {
        wieghtTotal = cherryWieght + orangeWieght + watermelonWieght 
            + plumlonWieght + appleWieght + bananaWieght;

        SetReelImage(cherrySprite);
    }

    private void SetReelImage(Sprite reelSprite)
    {
        reelImage.sprite = reelSprite;
    }

    public void SpinReel()
    {
        int spinResult = Random.Range(1, wieghtTotal);

        if((spinResult -= cherryWieght) < 0)
        {
            SetReelImage(cherrySprite);
            reelEnum = Reelenum.Cherry;
        }
        else if ((spinResult -= orangeWieght) < 0)
        {
            SetReelImage(orangeSprite);
            reelEnum = Reelenum.Orange;
        }
        else if ((spinResult -= watermelonWieght) < 0)
        {
            SetReelImage(watermelonSprite);
            reelEnum = Reelenum.Watermelon;
        }
        else if ((spinResult -= plumlonWieght) < 0)
        {
            SetReelImage(plumlonSprite);
            reelEnum = Reelenum.Plumlon;
        }
        else if ((spinResult -= appleWieght) < 0)
        {
            SetReelImage(appleSprite);
            reelEnum = Reelenum.Apple;
        }
        else if ((spinResult -= bananaWieght) < 0)
        {
            SetReelImage(bananaSprite);
            reelEnum = Reelenum.Banana;
        }
    }

    public Reelenum GetReel()
    {
        return reelEnum;
    }

}