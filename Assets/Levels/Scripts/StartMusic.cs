using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartMusic : MonoBehaviour {

	// Use this for initialization
	void Start () {
        GameObject.FindGameObjectWithTag("Music").GetComponent<Music>().PlayMusic();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
