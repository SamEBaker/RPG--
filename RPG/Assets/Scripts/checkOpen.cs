using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkOpen : MonoBehaviour
{
    _GameManager gameManager;
    public GameObject catacombs;
    public GameObject TownBG;
    public GameObject CataBG;


    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            PlayerController player = collision.gameObject.GetComponent<PlayerController>();
            if (player.hasKey == true)
            {
                player.transform.position = catacombs.transform.position;
                TownBG.SetActive(false);
                CataBG.SetActive(true);
            }
            else
            {
                GameUI.instance.UpdateTextKey();
            }
        }
    }
}
