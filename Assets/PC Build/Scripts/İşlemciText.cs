using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class İşlemciText : MonoBehaviour
{

    public TMP_Text işlemciText;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void İşlemci(TMP_Text işlemciText)
    {
        işlemciText.text = "İşlemci";
    }
}
