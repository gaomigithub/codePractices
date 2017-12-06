using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour {

	public GameObject torchFire;
	private GameObject torch;
	public Torch torchScript;

	// Use this for initialization
	void Start () {
		torch = GameObject.Find("Torch");
		torchScript = torch.gameObject.GetComponent<Torch>();
	}
	

	void OnTriggerEnter (Collider other) {
		if (other.gameObject.tag == "Player" && torchScript.hasTorch) {
			torchFire.SetActive (true);
		}
	}
}
