using UnityEngine;
using System.Collections;

public class Rotate : MonoBehaviour {
    public float speed = 1f;
    public bool specialAttack;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(new Vector3(0, 0, speed) * Time.deltaTime);
	}
    void True()
    {
        specialAttack = true;
    }
    void False()
    {
        specialAttack = false;
    }
}
