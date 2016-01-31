using UnityEngine;
using System.Collections;

public class PlayerHealth : MonoBehaviour {

    public int playerHealth = 100;
    public bool dead = false;
    public bool specialAttack;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (playerHealth == 0)
        {
            dead = true;
        }

	}
    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "Enemy")
        {
            playerHealth -= 1;
        }
    }
}
