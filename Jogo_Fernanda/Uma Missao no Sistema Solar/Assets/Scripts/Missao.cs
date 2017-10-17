using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missao : MonoBehaviour {

    public GameObject popupMission, fade;

	// Use this for initialization
	void Start () {
        Time.timeScale = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void IniciarMissao()
    {
        Time.timeScale = 1;
        popupMission.SetActive(false);
        fade.SetActive(false);

    }
}
