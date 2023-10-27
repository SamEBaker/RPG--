using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class healOffering : MonoBehaviour
{
    public int value = 50;
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            PlayerController player = collision.gameObject.GetComponent<PlayerController>();
            if(player.gold >= 100)
            {
                player.gold -= 100;
                GameUI.instance.UpdateGoldText(player.gold);
                player.photonView.RPC("Heal", player.photonPlayer, value);
                GameUI.instance.UpdateTextBlessed();
            }
            else
            {
                GameUI.instance.UpdateTextBroke();
            }
        }
    }
}
