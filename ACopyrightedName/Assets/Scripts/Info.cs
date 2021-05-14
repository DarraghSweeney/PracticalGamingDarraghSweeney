using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Info : MonoBehaviour
{
    public static string InfoText;
    Text InfoBox;
    // Start is called before the first frame update
    void Start()
    {
        InfoBox = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        InfoBox.text = InfoText;
    }


}
