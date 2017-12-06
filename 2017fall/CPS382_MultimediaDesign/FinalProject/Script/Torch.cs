using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Torch : MonoBehaviour {

	public bool canPickUp = false;
	public bool hasTorch = false;

	public GameObject textRemind;

	public GameObject lHandSocket;
	// Use this for initialization
	void Start () {
		lHandSocket = GameObject.Find ("LHandSocket");
		textRemind.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {

		if (!hasTorch) {
		
			if (canPickUp && Input.GetKeyUp (KeyCode.Q)) {
			
				PickUp ();
			}
		} else {
		
			if (Input.GetKeyUp (KeyCode.Q))
				Drop ();
		}

	}

	void OnTriggerEnter(Collider other){
	
		if (other.GetComponent<Collider>().tag == "Player") {
			canPickUp = true;
			textRemind.SetActive (true);
		}
	}
	void OnTriggerExit(Collider other){
	
		if (other.GetComponent<Collider>().tag == "Player") {
			canPickUp = false;

		}
	}
	void PickUp () {

		//change the position of the torch to the rHandSocket
		gameObject.transform.position = lHandSocket.transform.position;
		gameObject.transform.rotation = lHandSocket.transform.rotation;
		gameObject.transform.parent = lHandSocket.transform;
		gameObject.GetComponent<Rigidbody>().isKinematic = true;
		gameObject.GetComponent<Collider>().enabled = false;

		hasTorch = true;
		textRemind.SetActive (false);
	}

	void Drop (){
		gameObject.transform.parent = null;
		gameObject.GetComponent<Rigidbody>().isKinematic = false;
		gameObject.GetComponent<Collider>().enabled = true;

		hasTorch = false;
	}
}
