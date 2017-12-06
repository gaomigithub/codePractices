using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour {
	public string nextScene;
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.B)) {
			SceneManager.LoadScene (nextScene);
		}

	}
}
