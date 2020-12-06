using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoints : MonoBehaviour {

    public GameObject Player;
    [SerializeField] private GameObject Checkpoint;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == Player)
        {
            GameObject.Find("FPSController").GetComponent<PlayerLife>().SpawnPoint = Checkpoint;
        }
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
