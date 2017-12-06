using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
/*
	 * Create and inventory that keeps track of the number 
	 * 	of Gold Keys and Silver Keys.
	 * 
	 * When we crash into a gold key we want to increment
	 * 	 our gold key count. We also want to remove that key from the scene.
	 * 
	 * And when we crash into a silver key we want ot increment 
	 * 	 our silver key count. We also want to remove that key from the scene.
	 * /
*/

public class Inventory : MonoBehaviour {

	public int goldKeyCount = 0;
	public int silverKeyCount = 0;

	public int goldKeyToCollect = 0;
	public int silverKeyToCollect = 0;

	public Text goldKeys;
	public Text silverKeys;

	void OnTriggerEnter (Collider col) {
		if (col.gameObject.tag == "MainGate") {
			if (goldKeyCount >= goldKeyToCollect &&
				silverKeyCount >= silverKeyToCollect) {
				//This is where we are 
				SceneManager.LoadScene("2");
				}
			
		}
	}
	void OnCollisionEnter (Collision col) {
		if (col.gameObject.tag == "GoldKey") {
		goldKeyCount = goldKeyCount + 1;
		goldKeys.text = "Gold Keys: " + goldKeyCount + " / " + goldKeyToCollect;
		
		Destroy (col.gameObject);
		}
		
		if (col.gameObject.tag == "SilverKey") {
		silverKeyCount = silverKeyCount + 1;
		silverKeys.text = "Silver Keys: " + silverKeyCount + " / " + silverKeyToCollect;
		
		Destroy (col.gameObject);
		}
	}

		
}
