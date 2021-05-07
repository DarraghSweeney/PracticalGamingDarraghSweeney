using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    float cameraDistance = 10;
    float cameraheight = 3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    internal void my_Postition_is(Transform Player)
    {
        transform.position = Player.position - Player.forward * cameraDistance + Vector3.up * cameraheight;
    }
}
