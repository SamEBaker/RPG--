using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chestSwords : MonoBehaviour
{
         void OnTriggerEnter2D(Collider2D collision)
    {
        if (!PhotonNetwork.IsMasterClient)
            return;
        if (collision.CompareTag("Player"))
        {
            PlayerController player = collision.gameObject.GetComponent<PlayerController>();
            float whichSword = Random.Range(0, 3);
            if (whichSword == 0)
            {
                player.featherSword.SetActive(true);
                player.norm.SetActive(false);
                player.opSword.SetActive(false);
                player.coolSword.SetActive(!false);
                player.damage = 5;
            }
            else if (whichSword == 1)
            {

                player.norm.SetActive(false);
                player.featherSword.SetActive(false);
                player.opSword.SetActive(false);
                player.coolSword.SetActive(true);
                player.damage = 10;
            }
            else if (whichSword == 2)
            {
                player.norm.SetActive(false);
                player.featherSword.SetActive(false);
                player.coolSword.SetActive(!false);
               player.opSword.SetActive(true);
                player.damage = 20;
            }
                PhotonNetwork.Destroy(gameObject);
        }
    }
}
  