using UnityEngine;
using System.Collections;

public class EnemyHealth : MonoBehaviour {

    public int enemyHealth = 1;
    public bool dead = false;
    public bool specialAttack;
    public bool siphon;
    //public float test;

    // Update is called once per frame

	void Update () {
        if (enemyHealth <= 0)
        {
            dead = true;
        }
        if (dead == true)
        {
            Destroy(gameObject.GetComponent<Renderer>());
        }

        specialAttack = GameObject.FindGameObjectWithTag("Background").GetComponent<Rotate>().specialAttack;
    }

    void SiphonTrue()
    {
        siphon = true;
    }
    void SiphonFalse()
    {
        siphon = false;
    }


    /*void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player" && siphon == true)
        {
            //test += Time.deltaTime;
            enemyHealth -= 1;       
        }
        if(other.gameObject.tag=="Scythe")
        {
            test += Time.deltaTime;
        }
        //test += Time.deltaTime;
    }*/
    void OnTriggerStay2D(Collider2D other)
    {
        if (other.tag == "Player" && siphon == true)
        {
            //test += Time.deltaTime;
            enemyHealth -= 1;
        }
    }
}
