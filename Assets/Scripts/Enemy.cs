using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

    public float test = 5f;
    private Transform player;
    public float enemySpeed;
    private Rigidbody2D e_Rigidbody2D;
    public float show;
    private bool m_FacingRight = false;
    //private int move = GameObject.FindGameObjectWithTag("Enemy").GetComponent<Rigidbody2D>().velocity.x;



    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        e_Rigidbody2D = GetComponent<Rigidbody2D>();
    }
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        show = e_Rigidbody2D.velocity.x;

        

    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            test += Time.deltaTime;
            if (player.position.x > transform.position.x)
            {
                e_Rigidbody2D.velocity = new Vector2(enemySpeed, 0);
            }
            else
            {
                e_Rigidbody2D.velocity = new Vector2(-enemySpeed, 0);
            }

            if (e_Rigidbody2D.velocity.x > 0 && !m_FacingRight)
            {
                // ... flip the player.
                Flip();
            }
            // Otherwise if the input is moving the player left and the player is facing right...
            else if (e_Rigidbody2D.velocity.x < 0 && m_FacingRight)
            {
                // ... flip the player.
                Flip();
            }
        }
    }
    void OnTriggerExit2D(Collider2D other2)
    {
        if (other2.tag == "Player")
        {
            e_Rigidbody2D.velocity = new Vector2(0, 0);
        }
    }

    private void Flip()
    {
        // Switch the way the player is labelled as facing.
        m_FacingRight = !m_FacingRight;

        // Multiply the player's x local scale by -1.
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }


    /* public Transform target;//set target from inspector instead of looking in Update
     public float speed = 3f;


     void Start()
     {

     }

     void Update()
     {

     }
     void OnTriggerStay2D(Collider2D other)
     {
         if(other.tag=="Player")
         {
             transform.LookAt(target.position);
             transform.Rotate(new Vector3(0, -90, 0), Space.Self);//correcting the original rotation


             //move towards the player
             if (Vector2.Distance(transform.position, target.position) > 2f)
             {//move if distance from target is greater than 1
                 transform.Translate(new Vector2(speed * Time.deltaTime, 0));

             }
         }
     }
     */
}

