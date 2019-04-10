using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour {
    public Rigidbody2D rb;
    public Transform groundCheckFront;
    public float groundCheckRadius;
    public LayerMask whatIsGround;
    private bool onGroundFront;

    public Transform groundCheckBack;
    public float groundCheckRadiusBack;
    public LayerMask whatIsGroundBack;
    private bool onGroundBack;

    public bool moveForward;

    // Start is called before the first frame update
    void Start() {
        rb = GetComponent<Rigidbody2D>();
        moveForward = true;
    }
    // Update is called once per frame
    void Update() {
        if(moveForward){
            rb.velocity = new Vector2(12, rb.velocity.y);
        }
        
        onGroundFront = Physics2D.OverlapCircle(groundCheckFront.position, groundCheckRadius, whatIsGround);
        onGroundBack = Physics2D.OverlapCircle(groundCheckBack.position, groundCheckRadiusBack, whatIsGroundBack);
        if(!onGroundFront && !onGroundBack && rb.velocity.y == 0){
            moveForward = false;
            Debug.Log("ei ole maas");
            Debug.Log(rb.velocity.x);
            Debug.Log(rb.velocity.y);
            rb.velocity = new Vector2(rb.velocity.x, -7);
        }

        if(Input.GetMouseButtonDown(0) && (onGroundFront || onGroundBack)) {
            rb.velocity = new Vector2(0, 8);
        }
    }

    void OnCollisionEnter2D(Collision2D col) {
        if(col.gameObject.name=="FinishFlower"){
            Debug.Log("PUUDE!!");
        }
    }
}
