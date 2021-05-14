using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class FinishGoal : MonoBehaviour
{
 
    private void OnTriggerEnter(Collider other)
    {
        if ((other.gameObject.tag == "Player") && (BarrelCounter.BarrelsDestroyed >=32))
        {
            SceneManager.LoadScene("MainMenu");
        }
    }
}
