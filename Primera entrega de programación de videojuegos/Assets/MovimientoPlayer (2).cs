using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoPlayer : MonoBehaviour
{
    private Rigidbody2D rb;
    private Animator anim;
    private float DireX = 0f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        DireX = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(DireX * 8, rb.velocity.y);
       

        if (Input.GetButtonDown("Jump")){

            rb.velocity = new Vector2(rb.velocity.x, 7f);
        }
 
        UpdateAnimationUpdate();
    }

    private void UpdateAnimationUpdate()
    {
        if (DireX > 0f)
        {
            anim.SetBool("running", true);
        }
        else if (DireX < 0f)
        {
            anim.SetBool("running", true);
        }
        else
        {
            anim.SetBool("running", false);
        }
    }
}
