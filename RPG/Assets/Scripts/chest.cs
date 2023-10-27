using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class chest : MonoBehaviourPun
{
    public Animator chestanim;
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (!PhotonNetwork.IsMasterClient)
            return;
        if (collision.CompareTag("Player"))
        {
            PlayerController player = collision.gameObject.GetComponent<PlayerController>();
            player.hasKey = true;
            //chestanim.SetTrigger("open");
            PhotonNetwork.Destroy(gameObject);
            GameUI.instance.UpdateTextCata();
        }
    }
}
