using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IconTrigger : MonoBehaviour {

	// public GameObject pistol;
	public GameObject pIcon;
	
	// Update is called once per frame
	public void OnTriggerEnter (Collider other) {
		pIcon.SetActive(true);

	}
}
