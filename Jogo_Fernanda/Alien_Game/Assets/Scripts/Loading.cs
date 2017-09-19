using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Loading : MonoBehaviour {

	public string cena;

	// Use this for initialization
	void Start () {
		Invoke ("CarregarCena", 5);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void CarregarCena(){
		SceneManager.LoadScene (cena);
		
	}
}
