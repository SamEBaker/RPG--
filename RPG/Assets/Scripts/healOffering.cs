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
                player.GameUI.instance.UpdateGoldText(player.gold);
                player.photonView.RPC("Heal", player.photonPlayer, value);
                pleyer.GameUI.instance.UpdateTextBlessed();
            }
            else
            {
                player.GameUI.instance.UpdateTextBroke();
            }
        }
    }
}
