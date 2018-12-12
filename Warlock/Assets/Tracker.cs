using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tracker : MonoBehaviour {

	public GameObject spider;
	public GameObject spider1;
	public GameObject spider2;
	public GameObject bones;
	public GameObject bones1;
	public GameObject dragon;

	public GameObject ispider;
	public GameObject ispider1;
	public GameObject ispider2;
	public GameObject ibones;
	public GameObject ibones1;
	public GameObject idragon;

	void Update () {
		if (spider == null) {
			ispider.SetActive(false);
		}
		if (spider1 == null) {
			ispider1.SetActive(false);
		}
		if (spider2 == null) {
			ispider2.SetActive(false);
		}
		if (bones == null) {
			ibones.SetActive(false);
		}
		if (bones == null) {
			ibones1.SetActive(false);
		}
		if (dragon == null) {
			idragon.SetActive(false);
		}
	}

}
