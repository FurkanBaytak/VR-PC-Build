using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EkranKartıText : MonoBehaviour
{

    public TMP_Text ekranKartıText;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void EkranKartı(TMP_Text ekranKartıText)
    {
        ekranKartıText.text = "ekranKartı";
    }
}
