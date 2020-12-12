using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectDeployement : MonoBehaviour
{
    GameObject BigBang_Selected;
    GameObject Canary_Selected;
    GameObject BlueGreen_Selected;
    GameObject Next;

    void Awake() {
        Canary_Selected = GameObject.Find("Canary");
        BigBang_Selected = GameObject.Find("BigBang");
        BlueGreen_Selected = GameObject.Find("BLueGreen");
        Next = GameObject.Find("Next");
        Next.SetActive(false);

    }

    public void selectCanary()
    {
        Canary_Selected.SetActive(false);
        BigBang_Selected.SetActive(true);
        BlueGreen_Selected.SetActive(true);
        Next.SetActive(true);

    }
    public void unselectCanary()
    {
        Canary_Selected.SetActive(true);
        Next.SetActive(false);

    }
    public void selectBigBang()
    {
        Canary_Selected.SetActive(true);
        BigBang_Selected.SetActive(false);
        BlueGreen_Selected.SetActive(true);
        Next.SetActive(true);

    }
    public void unselectBigBang()
    {
        BigBang_Selected.SetActive(true);
        Next.SetActive(false);

    }
    public void selectBlueGreen()
    {
        Canary_Selected.SetActive(true);
        BigBang_Selected.SetActive(true);
        BlueGreen_Selected.SetActive(false);
        Next.SetActive(true);

    }
    public void unselectBlueGreen()
    {
        BlueGreen_Selected.SetActive(true);
        Next.SetActive(false);

    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
