using UnityEngine;
using TMPro;

public class CoinsUIManager : MonoBehaviour
{
    public TextMeshProUGUI coinsText;
    private int lastCoinsValue;

    void Start()
    {
        lastCoinsValue = GlobalVariables.Coins;
        UpdateCoinsUI();
    }

    void Update()
    {
        if (GlobalVariables.Coins != lastCoinsValue)
        {
            lastCoinsValue = GlobalVariables.Coins;
            UpdateCoinsUI();
        }
    }

    void UpdateCoinsUI()
    {
        coinsText.text = "Coins: " + GlobalVariables.Coins;
    }
}
