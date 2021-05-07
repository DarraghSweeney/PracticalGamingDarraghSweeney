using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public int HealthTotal = 3;
    GameObject Health1;
    GameObject Health2;
    GameObject Health3;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (HealthTotal == 3)
        {
            print("Health is 3");
        }

        if (HealthTotal == 2)
        {
            print("Health is 2");
        }

        if (HealthTotal == 1)
        {
            print("Health is 1");
        }

        if (HealthTotal <= 0)
        {
            print("You have died");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Damaging")
        {
            HealthTotal -= 1;
        }
    }
}
