using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour {

	int hits = 0;

	AudioSource aud;
	bool foundPlayer = false;
	EnemyStatic es;

	NavMeshAgent agent;
	Animator anim;

	public Transform target;

	float speed;
	float distance;

	public Transform[] wayPoints;
	int wayPointIndex = 0;

	// Use this for initialization
	void Start () {
		es = GetComponent<EnemyStatic> ();
		agent = GetComponent<NavMeshAgent> ();
		anim = GetComponent<Animator> ();
		aud = GetComponent<AudioSource> ();
		agent.destination = target.transform.position;
	}

	// Update is called once per frame
	void Update () {

		distance = Vector3.Distance (target.transform.position, this.transform.position);
		if (distance < 1.5f) {
		
			anim.Play("creature1Attack2");
		}

		speed = agent.speed;
		anim.SetFloat("Speed_f",speed);

		//agent.destination = target.transform.position;
		if(foundPlayer == false){

			RaycastHit hit;
			if (Physics.SphereCast (es.eyes.position,es.radius,es.eyes.forward,out hit, es.maxDistance)&&hit.collider.CompareTag("Player")) {
			
				foundPlayer = true;
			}
			// cast sphere
			Partrol();
		}
		if (foundPlayer == true) {
		
			agent.destination = target.transform.position;
		}

	}

	void Partrol(){
	
		if (wayPoints.Length == 0) {
		
			return;
		}
		agent.destination = wayPoints[wayPointIndex].position;

		if (agent.remainingDistance < 0.5f && !agent.pathPending) {

			wayPointIndex = (wayPointIndex + 1) % wayPoints.Length;
		}
	}


	void OnTriggerEnter (Collider other) {
		if (other.gameObject.tag == "Player") {
			aud.enabled = true;
			aud.Play ();
			hits++;
			if (hits >= 3) {
				SceneManager.LoadScene("3");
			}
			Debug.Log (hits);
		}
	}


}
