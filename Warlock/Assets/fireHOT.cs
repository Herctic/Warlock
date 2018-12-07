using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireHOT : MonoBehaviour {
    
    float timer = 0;
    float damageTime = 2;


    void update(){
       
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.tag == "Player")
        {
            if (timer >= damageTime)
            {
                
                vp_LocalPlayer.Damage(1);
                timer = 0;
            }
        }

        timer += Time.deltaTime;
    }
}
