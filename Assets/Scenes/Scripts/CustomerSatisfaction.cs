using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomerSatisfaction : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject Select_1;
    GameObject Select_2;
    GameObject Select_3;
    void Awake()
    {
        Select_1=GameObject.Find("Select-1");
        Select_2=GameObject.Find("Select-2");
        Select_3=GameObject.Find("Select-3");
        Select_2.SetActive(false);
        Select_3.SetActive(false);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
