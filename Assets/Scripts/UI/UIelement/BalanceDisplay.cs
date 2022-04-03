using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BalanceDisplay : UIelement
{
        public Text displayText = null;
        public void DisplayBalance()
        {
            if (displayText != null)
            {
                displayText.text =  "Balance: " + PlayerPrefs.GetInt("Coins").ToString() ;
            }
        }
        public override void UpdateUI()
        {
            base.UpdateUI();
        
            DisplayBalance();
        }    
}