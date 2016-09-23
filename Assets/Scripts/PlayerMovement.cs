using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
    public float maxSpeed = 10f;
    bool facingRight = true;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        float move = Input.GetAxis("Horizontal");
        var rBody = GetComponent<Rigidbody2D>();
        rBody.velocity = new Vector2(move * maxSpeed,rBody.velocity.y);

        if(move > 0 && facingRight)
        {
            Flip();
        }
        else if (move < 0 && !facingRight)
        {
            Flip();
        }
	}

    void Flip()
    {
        facingRight = !facingRight;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
}
