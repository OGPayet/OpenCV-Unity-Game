using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerMouvement : MonoBehaviour
{
    public CharacterController2D controller;

    float horizontalMove = 0f;
    bool jump = false;
    public float runSpeed = 40f;
    public Animator animator;
    public Rigidbody2D rb;
    private int value = 0;
    public TextMeshProUGUI Coinscount;
    public TextMeshProUGUI Wintext;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
            animator.SetBool("Jump",true);
        }


        if (value == 10)
        {
            Wintext.gameObject.SetActive(true);
        }

    }

    public void onlanding()
    {
        if (animator.GetBool("Fall"))
        {
            animator.SetBool("Fall", false);
            jump = false;
           
        }
    }

    private void FixedUpdate()
    {
       //Debug.Log(animator.GetBool("Fall"));
        controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
       
        if (rb.velocity.y < 0 && jump)
        {
            animator.SetBool("Jump",false);
            animator.SetBool("Fall", true);

        }
        
    }
   
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Coin"))
        {
           collision.gameObject.SetActive(false);
            value = value + 1;
            Coinscount.text = value.ToString();
        }

    }
}   

