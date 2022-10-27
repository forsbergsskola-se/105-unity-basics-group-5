using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovement : MonoBehaviour //note: i may have gone a bit too far in a couple of places.
{
    //setup for addforce functions instead of translates:
    private Rigidbody thisbody;
    //todo: set final limits and make thrust, maxjumpspeed, jumptimer private
    public float thrust; 
    public float maxjumpspeed;
    public float maxspeed;
    public float jumptimer;
    public bool isgrounded;

    private void Start() { thisbody = GetComponent<Rigidbody>(); }
    //setup end
    
    //collision/'grounded' detection
    private void OnCollisionEnter()
    {
        isgrounded = true;
    }
    private void OnCollisionStay()
    {
        isgrounded = true;
    }
    private void OnCollisionExit()
    {
        isgrounded = false;
    }
    
    void Update()
    {
        if (isgrounded)
        {
            //wrapping full movement in isgrounded - because you can't alter movement midair!
            if (Input.GetKey(KeyCode.W))
                thisbody.AddForce(transform.right * thrust); //LEGACY CODE: transform.Translate(0.005f, 0f, 0f);
            if (Input.GetKey(KeyCode.S))
                thisbody.AddForce(transform.right * -thrust); //LEGACY CODE: transform.Translate(-0.005f, 0f, 0f);
            if (Input.GetKey(KeyCode.A)) transform.Rotate(0f, -0.15f, 0f);
            if (Input.GetKey(KeyCode.D)) transform.Rotate(0f, 0.15f, 0f);
            /*dev notes for above:
             legacy code commented out, just in case reversion is necessary.
             addforce is using transform.right due to the map technically being 'sideways'.
            */

            //Jump logic:
            if (Input.GetKeyDown(KeyCode.Space))
            {
                while (jumptimer < 1)
                {
                    thisbody.AddForce(transform.up * thrust);
                    jumptimer += Time.fixedDeltaTime;
                }

                jumptimer = 0;
            }
        }
        //speed limits:
        //bug: following currently gimps jumping and moving at the same time, limiting y-axis move to magnitude. not sure how to fix.

        if (thisbody.velocity.y > maxjumpspeed) //up velocity limiter
        {
            thisbody.velocity = thisbody.velocity.normalized * maxjumpspeed;
        }

        if (thisbody.velocity.magnitude > maxspeed)
        {
            thisbody.velocity = thisbody.velocity.normalized * maxspeed;
        }
    }
}
