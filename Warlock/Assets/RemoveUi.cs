using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveUi : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {

        if(Input.GetKeyDown("space")){
            Destroy(gameObject);
        }
		
	}
}
