using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skeletonTrigger : MonoBehaviour {

    public GameObject skel;

    public void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Player")
        {
            NPC s1 = skel.GetComponent<NPC>();
            s1.areaTrigger = true;
        }
    }
}
