using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WinCondition : MonoBehaviour {


    private GameObject monsters;
    public Text winText;
    public Text playAgain;

	// Use this for initialization
	void Start () {
        winText.text = "";
        playAgain.text = "";
        monsters = this.gameObject;
	}
	
	// Update is called once per frame
	void Update () {

        if(monsters.transform.childCount == 0){
            winText.text = "You Win!";
            playAgain.text = "Press space to play again!";
            if (Input.GetKeyDown("space")){
                SceneManager.LoadScene(0);
            }
               
        }
	}
}
