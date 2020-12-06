using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour {

    public GameObject Player;
    private int PlayerHitpoints;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == Player)
        {
            GameObject.Find("FPSController").GetComponent<PlayerLife>().PlayerHitpoints = 0;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == Player)
        {
            GameObject.Find("FPSController").GetComponent<PlayerLife>().PlayerHitpoints = GameObject.Find("FPSController").GetComponent<PlayerLife>().PlayerLifes;
        }
    }

    // Use this for initialization
    void Start () {
        Player = GameObject.Find("FPSController");
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
