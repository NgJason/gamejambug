using UnityEngine;
using System.Collections;

public enum State{Pursuing, Returning, PatrollingA, PatrollingB};

public class enemy : MonoBehaviour
{
	public Transform	player;
	public Transform	patrolA;
	public Transform	patrolB;
	public Vector3		startingPoint;
	public State		currState;

	public float	fieldOfView;
	public float	visibilityDist;
	public float	giveUpTime;

	private NavMeshAgent	agent;
	
	float	timeLeft;
	
	// Use this for initialization
	void Start ()
	{
		startingPoint = transform.position;
		agent = GetComponent<NavMeshAgent>();
	}
	
	// Update is called once per frame
	void Update ()
	{
		if(SeesPlayer)
		{
			agent.SetDestination(player.position);
			timeLeft = giveUpTime;
			currState = State.Pursuing;
		}

		switch(currState)
		{
		case State.Pursuing:
			if(timeLeft > 0)
			{	timeLeft -= Time.deltaTime;	}
			else
			{
				agent.SetDestination(startingPoint);
				currState = State.Returning;
			}
			break;
		case State.Returning:
			if(Vector3.Distance(transform.position, startingPoint) < .1)
			{	currState = State.PatrollingA;	}
			break;
		case State.PatrollingA:
			if(Vector3.Distance(transform.position, patrolA) < .1)
			{	currState = State.PatrollingB;	}
			break;
		case State.PatrollingB:
			if(Vector3.Distance(transform.position, patrolB) < .1)
			{	currState = State.PatrollingA;	}
			break;
		}
	}

	bool SeesPlayer()
	{
		RaycastHit hit;
		Vector3 rayDirection = player.position - transform.position;

		if(Vector3.Angle(rayDirection, transform.forward) <= fieldOfView / 2)
		{
			if (Physics.Raycast(transform.position, rayDirection, out hit, visibilityDist))
			{	return (hit.transform.CompareTag("Player"));	}
		}

		return false;
	}
}
