using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SkipeScene : MonoBehaviour {

	//public GameObject infoPlaneta;
	//public string scene;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void PassarCena(string scene){
	
		SceneManager.LoadScene (scene);
	}

	public void AtivarPopup(GameObject infoPlaneta){
		infoPlaneta.SetActive (true);
	}
	public void FecharPopup(GameObject infoPlaneta2){
		infoPlaneta2.SetActive (false);
	}
}
