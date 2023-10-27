using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class chest : MonoBehaviourPun
{
     PlayerController controller;

    [PunRPC]
    void OnTriggerEnter2D(Collider2D collision)
    {
       if (collision.CompareTag("Player"))
        {
            if (!PhotonNetwork.IsMasterClient)
                return;
            photonView.RPC("GetKey",RpcTarget.All);
            //chestanim.SetTrigger("open");
            PhotonNetwork.Destroy(gameObject);
            photonView.RPC("UpdateTextCata()", RpcTarget.All);
        }
    }
}
