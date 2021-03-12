using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinCollect : MonoBehaviour
{
    gamemanager gm;

    void Start()
    {
        gm = FindObjectOfType<gamemanager>();
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);
            gm.subtractCoin();
        }
    }
}
