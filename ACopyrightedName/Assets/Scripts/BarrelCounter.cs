using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BarrelCounter : MonoBehaviour
{

    public static int ScoreValue = 0;
    public static int BarrelsDestroyed = 0;
    Text Barrels;
    // Start is called before the first frame update
    void Start()
    {
        Barrels = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        Barrels.text = "Barrels: " + BarrelsDestroyed + "/32";

        if(BarrelsDestroyed >= 32)
        {
            Info.InfoText = "All Barrels have been destroyed. Good work recruit, You may proceed to the main gate";
        }
    }
}
