using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attack_collider : MonoBehaviour {



    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
            
        {
            Animator ani = gameObject.GetComponentInParent(typeof(Animator)) as Animator;
            ani.SetBool("playerClose",true);
        }
    }

    private void OnTriggerExit(Collider other)

    {
        if (other.tag == "Player")

        {
            Animator ani = gameObject.GetComponentInParent(typeof(Animator)) as Animator;
            ani.SetBool("playerClose", false);
        }
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
