using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLife : MonoBehaviour {

    [SerializeField] public GameObject SpawnPoint;
    private bool respawn = false;
    [SerializeField] public int PlayerLifes;
    [HideInInspector] public int PlayerHitpoints;

	// Use this for initialization
	void Start () {
        PlayerHitpoints = PlayerLifes;
        SpawnPoint = GameObject.Find("Spawnpoints/Spawnpoint");
	}
	
	// Update is called once per frame
	void Update () {
        if (PlayerHitpoints <= 0)
        {
            respawn = true;
        }
        else
        {
            respawn = false;
        }

        if (respawn)
        {

            transform.position = SpawnPoint.transform.position;

        }
    }
}
