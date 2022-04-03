using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CoinDisplay : UIelement
{
    public Text displayText = null;
    
    public void DisplayCoins()
    {
        if (displayText != null)
        {
            displayText.text =  PlayerPrefs.GetInt("Coins").ToString() + "x";
        }
    }

    public override void UpdateUI()
    {
        base.UpdateUI();

        DisplayCoins();
    }    
}