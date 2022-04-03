using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BSS : MonoBehaviour
{
    public List<Text> buttonTexts;
    public List<int> prices;
    public GameObject update;
    private void Start()
    {
        update.GetComponent<BalanceDisplay>().UpdateUI();
        PlayerPrefs.SetInt("Selected", 0);
        if (PlayerPrefs.GetInt("Bought") == 0)
        {
            PlayerPrefs.SetInt("Bought", 1);
        }

        for (int i = 0; i < prices.Count; i++)
        {
            if ((PlayerPrefs.GetInt("Bought") & (0x1 << i)) != 0)
            {
                buttonTexts[i].text = "Select";
            }

            if (PlayerPrefs.GetInt("Selected") == i)
            {
                buttonTexts[i].text = "Selected";
            }
        }
    }
    public void logic(int Skin)
    {
        if((PlayerPrefs.GetInt("Bought") & (0x1<<(Skin)))==0)
        {
            //Debug.Log(PlayerPrefs.GetInt("Coins") + "\n" + prices[Skin - 1] + "\n" + Skin);
            if (PlayerPrefs.GetInt("Coins") >= prices[Skin])
            {
                PlayerPrefs.SetInt("Bought", (PlayerPrefs.GetInt("Bought") | (0x1 << (Skin))));
                buttonTexts[Skin].text = "Select";
                PlayerPrefs.SetInt("Coins", PlayerPrefs.GetInt("Coins") - prices[Skin]);
            }
        }
        else
        {
            if (PlayerPrefs.GetInt("Selected") == Skin)
            {
                return;
            }
            buttonTexts[PlayerPrefs.GetInt("Selected")].text = "Select";
            PlayerPrefs.SetInt("Selected", Skin);
            buttonTexts[Skin].text = "Selected";
            SelectSkin.setSkin(Skin);
        }
        update.GetComponent<BalanceDisplay>().UpdateUI();

    }
}