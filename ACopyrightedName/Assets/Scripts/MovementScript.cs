using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{   enum Player_States { Attacking, Walking};
    Player_States is_currently = Player_States.Walking;
    public float ForwardSpeed = 1.5f;
    public float RightSpeed = 1.5f;
    public float turnSpeed = 1f;
    private float Yaw = 0.0f;
    Animator Char_Animation;
    Rigidbody PlayerRb;
    CapsuleCollider sword;
    private float cooldowntimer;
    public ParticleSystem SprintEffect;

    private float CoolDownTime = 0.7f;

    // Start is called before the first frame update
    void Start()
    {
        Char_Animation = GetComponent<Animator>();
        foreach (CapsuleCollider c in GetComponentsInChildren<CapsuleCollider>())
            if (c.tag == "Sword")
            {
                sword = c;
                print("Found Sword");
                sword.enabled = false;
            }
       

    }

    // Update is called once per frame
    void Update()
    {
        //Animations
        switch(is_currently)
            {
            case Player_States.Walking:
                if (Input.GetKey(KeyCode.W))
                {
                    if (Input.GetKey(KeyCode.LeftShift))
                    {
                        SprintEffect.Play();
                        ForwardSpeed = 4f;

                        
                    }
                    else
                    {
                        ForwardSpeed = 1.5f;

                        Char_Animation.SetBool("IsWalking", true);

                        SprintEffect.Stop();
                    }

                    
                }


                else
                {
                    Char_Animation.SetBool("IsWalking", false);
                    ForwardSpeed = 0f;
                   
                }


                if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D)) Char_Animation.SetBool("Strafe", true);
                else Char_Animation.SetBool("Strafe", false);

                if (Input.GetKey(KeyCode.A)) RightSpeed = -1.5f;
                if (Input.GetKey(KeyCode.D)) RightSpeed = 1.5f;

                if (Input.GetKey(KeyCode.S))
                {
                    Char_Animation.SetBool("IsBackWalking", true);
                    ForwardSpeed = -1.5f;
                }
                else Char_Animation.SetBool("IsBackWalking", false);

                if (Input.GetKey(KeyCode.Mouse0))
                {
                    Char_Animation.SetTrigger("Attack");
                    is_currently = Player_States.Attacking;
                    sword.enabled = true;
                    cooldowntimer = CoolDownTime;
                }

                Char_Animation.SetFloat("ForwardSpeed", ForwardSpeed);

                //Character Movement
                float LeftRight = Input.GetAxisRaw("Horizontal");
                float ForBack = Input.GetAxisRaw("Vertical");


                Yaw += turnSpeed * Input.GetAxis("Mouse X");

                transform.eulerAngles = new Vector3(0, Yaw, 0);

                if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
                    transform.position += transform.right * RightSpeed * Time.deltaTime;


                if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S))
                    transform.position += transform.forward * ForwardSpeed * Time.deltaTime;

                break;

            case Player_States.Attacking:

                cooldowntimer -= Time.deltaTime;
                if (cooldowntimer <0 )
                {
                    is_currently = Player_States.Walking;
                    sword.enabled = false;

                }


                break;



        }


    }
       

 }

    

