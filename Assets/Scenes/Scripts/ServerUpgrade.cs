using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ServerUpgrade : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject yes;
    GameObject no;
    GameObject selected_yes;
    GameObject selected_no;

    void Awake()
    {
        yes=GameObject.Find("Yes");
        no=GameObject.Find("No");
        selected_yes=GameObject.Find("Yes-Chosen");
        selected_no=GameObject.Find("No-Chosen");
        selected_yes.SetActive(true);
        selected_no.SetActive(true);
        yes.SetActive(true);
        no.SetActive(true);
    }
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void selectedYes(){
        // selected_yes.SetActive(true);
        yes.SetActive(false);
    }
    public void selectedNo(){
        //selected_no.SetActive(true);
        no.SetActive(false);
    }
}
