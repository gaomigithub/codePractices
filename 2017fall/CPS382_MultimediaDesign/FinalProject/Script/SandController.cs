using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SandController : MonoBehaviour {

	public string nextScene;

	void OnCollisionEnter(Collision col){
		SceneManager.LoadScene (nextScene);
	}
}
