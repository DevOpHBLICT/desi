using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scr : MonoBehaviour {
	public void ChangeToScene(int sceneToChangeTo){

		SceneManager.LoadScene(sceneToChangeTo);

	}



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
