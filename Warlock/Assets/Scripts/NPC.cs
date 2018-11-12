using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NPC : MonoBehaviour {

	// Use this for initialization

	public GameObject[] targets;
	private int currentTarget;
	private int nextTarget;

	private NavMeshAgent me;
	public float speed;

	void Start () {
		
		me = GetComponent<NavMeshAgent>();

	}
	
	// Update is called once per frame
	void Update () {
		
		speed = me.velocity.magnitude;
		me.destination = targets[currentTarget].transform.position;

		if (Vector3.Distance(transform.position, targets[currentTarget].transform.position) == 0)
		{
			GetComponent<Animator>().SetBool("Walking", false);

		}


	}
	public void ProgressToNext()
	{

		GetComponent<Animator>().SetBool("Walking", true);
		nextTarget = Random.Range(0, targets.Length);
		while(nextTarget == currentTarget)
		{
			nextTarget = Random.Range(0, targets.Length);
		}

		// if(currentTarget >= targets.Length)
		// {
		// 	currentTarget = 0;
		// }

	}
}
