using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dragonTrigger : MonoBehaviour
{

    public GameObject dragon;

    public void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Player")
        {
            NPC s1 = dragon.GetComponent<NPC>();
            s1.areaTrigger = true;
        }
    }
}
