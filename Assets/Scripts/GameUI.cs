using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameUI : MonoBehaviour
{
    public TextMeshProUGUI goldText;
    public static GameUI instance;
    public TextMeshProUGUI infoText;

    void Awake()
    {
        instance = this;
    }

    public void UpdateGoldText(int gold)
    {
        goldText.text = ": " + gold;
    }
    public void UpdateTextKey()
    {
        infoText.text = "Locked! There must be a key around here...";
    }

    public void UpdateTextBlessed()
    {
        infoText.text = "The Statue accepts the offering and heals you!";
    }

    public void UpdateTextBroke()
    {
        infoText.text = "The Statue cries...Your offer isnt enough...ur too broke...";
    }

    public void UpdateTextCata()
    {
        infoText.text = "Kill all the monsters in the Catacombs!";
    }
}
