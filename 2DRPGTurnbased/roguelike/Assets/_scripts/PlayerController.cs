using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D theRB;       //the Rigidbody
    public float moveSpeed;

    public Animator myAnim; //My Animator

    public static PlayerController instance;    //reference only to the Object with the script on it

    public string areaTransitionName;
    private Vector3 bottomLeftLimit;
    private Vector3 topRightLimit;

    public bool canMove = true;


    void Start()
    {
        if (instance == null)           
        {
            instance = this;
        }
        else
        {
            if (instance != this)
            {
                Destroy(gameObject);        //if there is another gameObject then Destroy it
            }
        }
        
        DontDestroyOnLoad(gameObject);
    }

    
    void Update()
    {
        if (canMove)
        {
            theRB.velocity = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")) * moveSpeed;

            myAnim.SetFloat("moveX", theRB.velocity.x);
            myAnim.SetFloat("moveY", theRB.velocity.y);
        }
        else
        {
            theRB.velocity = Vector2.zero;
        }
        
        if(Input.GetAxisRaw("Horizontal") == 1 || Input.GetAxisRaw("Horizontal") == -1 || Input.GetAxisRaw("Vertical")  == 1 || Input.GetAxisRaw("Vertical") == -1)   //if the Horizontal or Vertical axis is equal to 1 or -1 
        {
            if (canMove)
            {
                myAnim.SetFloat("lastMoveX", Input.GetAxisRaw("Horizontal"));
                myAnim.SetFloat("lastMoveY", Input.GetAxisRaw("Vertical"));
            }
        }

        transform.position = new Vector3(Mathf.Clamp(transform.position.x, bottomLeftLimit.x, topRightLimit.x), Mathf.Clamp(transform.position.y, bottomLeftLimit.y, topRightLimit.y), transform.position.z);

    }
    public void SetBounds(Vector3 botLeft, Vector3 topRight)
    {
        bottomLeftLimit = botLeft + new Vector3(.5f, 1f, 0f);
        topRightLimit = topRight + new Vector3(-.5f, -1f, 0f);
    }
}
