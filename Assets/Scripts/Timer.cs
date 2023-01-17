using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour

{
    private float time;
   
    void Start()
    {
        
    }

    
    void Update()
    {
        time = Time.time;
       time =  Mathf.Round(time * 100f) / 100f;
       GetComponent<TextMeshProUGUI>().text = time.ToString();
    }
}
