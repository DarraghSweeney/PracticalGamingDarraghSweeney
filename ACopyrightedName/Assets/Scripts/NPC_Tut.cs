using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC_Tut : MonoBehaviour
{
    private float ResetText;
    private float ResetTextTimer = 10;
    bool PlayerInRange;
    public Transform Player;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(Player);
        ResetText -= Time.deltaTime;
        if (ResetText < 0)
        {
            Info.InfoText = "";
            ResetText = ResetTextTimer;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if ((other.gameObject.tag == "Player"))
        {
            Info.InfoText = "You must be the new recruit I've been told about, get warmed up by finding and breaking all the single barrels around town";

            ResetText = ResetTextTimer;


        }
    }
}
