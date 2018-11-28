using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NPC : MonoBehaviour {

    // Use this for initialization

    public GameObject[] targets;
    public bool spiderTrigger;
    public GameObject player;
    private bool trigger = true;
	private int currentTarget;
	private int nextTarget;

	private NavMeshAgent me;

	void Start () {
		
		me = GetComponent<NavMeshAgent>();

	}
	
	// Update is called once per frame
	void Update () {
        if (spiderTrigger)
        {
            if (trigger)
            {
                me.speed = me.speed * 3;
                GetComponent<Animator>().SetBool("trigger", true);
                trigger = false;
            }
            me.destination = player.transform.position;

        }
        else
        {
            //speed = me.velocity.magnitude;
            me.destination = targets[currentTarget].transform.position;

            if (Vector3.Distance(me.transform.position, targets[currentTarget].transform.position) <= 1)
            {
                //GetComponent<Animator>().SetBool("Walking", false);
                ProgressToNext();

            }
        }

	}
	public void ProgressToNext()
	{

		//GetComponent<Animator>().SetBool("Walking", true);
		nextTarget = Random.Range(0, targets.Length);
		while(nextTarget == currentTarget)
		{
			nextTarget = Random.Range(0, targets.Length);
		}

        currentTarget = nextTarget;

		// if(currentTarget >= targets.Length)
		// {
		// 	currentTarget = 0;
		// }

	}

}
    

