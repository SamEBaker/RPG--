using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tp : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject CataBG;
    public GameObject TownBG;


    void OnTriggerEnter2D(Collider2D collision)
    {
        if (!PhotonNetwork.IsMasterClient)
            return;
        if (collision.CompareTag("Player"))
        {
            PlayerController player = collision.gameObject.GetComponent<PlayerController>();
            player.transform.position = new Vector3(-14, 34, 0);
            TownBG.SetActive(true);
            CataBG.SetActive(false);
        }
    }
}
