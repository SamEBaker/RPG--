using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class healOffering : MonoBehaviourPun
{
    public int value = 50;
    public int cost = -100;
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            PlayerController player = collision.gameObject.GetComponent<PlayerController>();
            PhotonView photonView = collision.GetComponent<PhotonView>();
            if(photonView != null && photonView.IsMine)
                if(player.gold >= 100)
                {
                    player.photonView.RPC("GiveGold", player.photonPlayer, cost);
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
