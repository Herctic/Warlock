using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attack_collider : MonoBehaviour {

    public GameObject enemy;


    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
            
        {
            Animator ani = gameObject.GetComponentInParent(typeof(Animator)) as Animator;
            ani.SetBool("playerClose",true);
            //vp_LocalPlayer.Damage(1);
        }
    }


    private void OnTriggerStay(Collider other)
    {
        if(other.tag == "Player")
        {
            NPC script = enemy.GetComponent<NPC>();
            script.isCollide = true;
        }
    }
    private void OnTriggerExit(Collider other)

    {
        if (other.tag == "Player")

        {
            
            Animator ani = gameObject.GetComponentInParent(typeof(Animator)) as Animator;
            ani.SetBool("playerClose", false);
            NPC script = enemy.GetComponent<NPC>();
            script.isCollide = false;
        }
    }


}
