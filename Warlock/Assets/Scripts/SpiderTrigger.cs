﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderTrigger : MonoBehaviour {

    public GameObject spider1;
    public GameObject spider2;
    public GameObject spider3;

    // Use this for initialization
    private void OnTriggerEnter(Collider other)
    {
        NPC s1 = spider1.GetComponent<NPC>();
        NPC s2 = spider2.GetComponent<NPC>();
        NPC s3 = spider3.GetComponent<NPC>();

        s1.areaTrigger = true;
        s2.areaTrigger = true;
        s3.areaTrigger = true;

        Destroy(gameObject);

    }
}
