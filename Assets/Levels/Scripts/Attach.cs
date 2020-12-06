using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class Attach : MonoBehaviour {

    public GameObject Player;
    [SerializeField] private float SpeedBoost;
    private bool EndSpeedBoost;
    private bool Grounded;
    private float NormalRunspeed;

    // When the Player triggers the Collider this is called once per frame
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject == Player)
        {
            Player.transform.parent = transform;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == Player)
        {
            Player.transform.parent = transform;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == Player)
        {
            Player.transform.parent = null;
            GameObject.Find("FPSController").GetComponent<FirstPersonController>().m_RunSpeed += SpeedBoost;
            EndSpeedBoost = true;
        }
        if (GameObject.Find("FPSController").GetComponent<FirstPersonController>().m_RunSpeed > NormalRunspeed + SpeedBoost)
        {
            GameObject.Find("FPSController").GetComponent<FirstPersonController>().m_RunSpeed = NormalRunspeed + SpeedBoost;
        }
    }

    // Use this for initialization
    void Start () {
        EndSpeedBoost = false;
        NormalRunspeed = GameObject.Find("FPSController").GetComponent<FirstPersonController>().m_RunSpeed;
    }
	
	// Update is called once per frame
	void Update () {

        Grounded = GameObject.Find("FPSController").GetComponent<FirstPersonController>().m_CharacterController.isGrounded;

        if (Grounded && EndSpeedBoost)
        {
            GameObject.Find("FPSController").GetComponent<FirstPersonController>().m_RunSpeed = NormalRunspeed;
            EndSpeedBoost = false;
        } else if (Grounded)
        {
            EndSpeedBoost = true;
        }

        /*if (GameObject.Find("FPSController").GetComponent<FirstPersonController>().m_RunSpeed > NormalRunspeed + SpeedBoost)
        {
            GameObject.Find("FPSController").GetComponent<FirstPersonController>().m_RunSpeed = NormalRunspeed + SpeedBoost;
        }*/
    }
}
