using UnityEngine;
using System.Collections;

public class DoubleJumpEnabler : MonoBehaviour
{

    //This will be used to only allow the double jump if it's before highest jump point. Or not, you choose!
    public bool CanAfterHighestJumpPoint = true;

    //We'll use this to communicate with the playerMove.
    private PlayerMove playerMove;

    //This is to keep track if we have double jumped already or if we can double jump      
    private bool CanDoubleJump = true;
    //In case of us wanting to only double jump if we're still going up on our jump, we need to store the last Y position.
    private float LastY;
    //We'll pick the grounded bool from the Animator and store here to know if we're grounded.
    private bool GroundedBool;

    // Use this for initialization
    void Start()
    {
        //Pick the Player Move component
        playerMove = GetComponent<PlayerMove>();
    }

    // Update is called once per frame
    void Update()
    {
        //If we receive a jump button down, we're not grounded and we can double jump...
        if (Input.GetButtonDown("Jump") && !GroundedBool && CanDoubleJump)
        {
            //Do a jump with the first jump force! :D
            playerMove.Jump(playerMove.jumpForce);
            //And lets set the double jump to false!
            CanDoubleJump = false;
        }
    }

    //This is an udpate that is called less frequently
    void FixedUpdate()
    {
        //Let's pick the Grounded Bool from the animator, since the player grounded bool is private and we can't get it directly..
        GroundedBool = playerMove.animator.GetBool("Grounded");
        //If I can't double jump...
        if (!CanDoubleJump)
        {
            //But I'm grounded
            if (GroundedBool)
            {
                //Then I should turn my Double Jump to on because I can certainly double jump again.
                CanDoubleJump = true;
            }
        }
        //If shouldn't be able to double jump after reaching the highest jump point, we'll need this part of the code
        if (!CanAfterHighestJumpPoint)
        {
            //If i'm not grounded
            if (!GroundedBool)
            {
                //If my current Y position is less than my Previously recorded Y position, then I'm going down
                if (gameObject.transform.position.y < LastY)
                {
                    //So, I'm going down, I shouldn't be able to double jump anymore.
                    CanDoubleJump = false;
                }
                //Anyways, lets record the LastY position for a check later.
                LastY = gameObject.transform.position.y;
            }
        }
    }
}