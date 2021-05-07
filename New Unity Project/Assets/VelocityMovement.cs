using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VelocityMovement : MonoBehaviour
{
    Rigidbody PlayerBody;

    public float speed = 100f;
    void Start()
    {
        PlayerBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float LeftRightMove = Input.GetAxisRaw("Horizontal");
        float ForwardBackMove = Input.GetAxisRaw("Vertical");

        PlayerBody.velocity = new Vector3(LeftRightMove * speed, PlayerBody.velocity.y, ForwardBackMove * speed)*Time.deltaTime;
    }
}
