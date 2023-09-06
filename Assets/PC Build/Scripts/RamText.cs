using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RamText : MonoBehaviour
{

    public TMP_Text ramText;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void Ram(TMP_Text ramText)
    {
        ramText.text = "ram";
    }
}
