using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class SelectStaff : MonoBehaviour
{
    bool select_Gordon=false;
    bool select_Isabel=false;
    bool select_Edwin=false;
    bool select_Yan=false;
    bool select_Kevin=false;
    bool select_David=false;
    bool select_Alex=false;
    bool select_Daniel=false;
    bool select_Aaron=false;
    bool select_Theresa=false;
    GameObject Gordon_Selected;
    GameObject Isabel_Selected;
    GameObject Edwin_Selected;
    GameObject Yan_Selected;
    GameObject Kevin_Selected;
    GameObject David_Selected;
    GameObject Alex_Selected;
    GameObject Daniel_Selected;
    GameObject Aaron_Selected;
    GameObject Theresa_Selected;
    public Text Captial;

    int capital=7000;
    List<int> selected = new List<int>();

    // Start is called before the first frame update
    
    void Awake()
    {
        Gordon_Selected=GameObject.Find("Gordon-Select");
        Isabel_Selected=GameObject.Find("Isabel-Select");
        Edwin_Selected=GameObject.Find("Edwin-Select");
        Yan_Selected=GameObject.Find("Yan-Select");
        Kevin_Selected=GameObject.Find("Kevin-Select");
        David_Selected=GameObject.Find("David-Select");
        Alex_Selected=GameObject.Find("Alex-Select");
        Daniel_Selected=GameObject.Find("Daniel-Select");
        Aaron_Selected=GameObject.Find("Aaron-Select");
        Theresa_Selected=GameObject.Find("Theresa-Select");
        Gordon_Selected.SetActive(false);
        Isabel_Selected.SetActive(false);
        Edwin_Selected.SetActive(false);
        Yan_Selected.SetActive(false);
        Kevin_Selected.SetActive(false);
        David_Selected.SetActive(false);
        Alex_Selected.SetActive(false);
        Daniel_Selected.SetActive(false);
        Aaron_Selected.SetActive(false);
        Theresa_Selected.SetActive(false);
        Captial.text="Captial: $"+capital;
    }

    public void selectGordon(){
        select_Gordon=!select_Gordon;
        if(select_Gordon){
            Gordon_Selected.SetActive(true);
            capital-=2500;
            Captial.text="Captial: $"+capital;
            selected.Add(6);
        }
        else{
            Gordon_Selected.SetActive(false);
            capital+=2500;
            Captial.text="Captial: $"+capital;
            selected.Remove(6);
        }
    }

    public void selectIsabel(){
        select_Isabel=!select_Isabel;
        if(select_Isabel){
            Isabel_Selected.SetActive(true);
            capital-=1000;
            Captial.text="Captial: $"+capital;
            selected.Add(1);
        }
        else{
            Isabel_Selected.SetActive(false);
            capital+=1000;
            Captial.text="Captial: $"+capital;
            selected.Remove(1);
        }
    }
    public void selectEdwin(){
        select_Edwin=!select_Edwin;
        if(select_Edwin){
            Edwin_Selected.SetActive(true);
            capital-=1800;
            Captial.text="Captial: $"+capital;
            selected.Add(3);
        }
        else{
            Edwin_Selected.SetActive(false);
            capital+=1800;
            Captial.text="Captial: $"+capital;
            selected.Remove(3);
        }
    }
    public void selectYan(){
        select_Yan=!select_Yan;
        if(select_Yan){
            Yan_Selected.SetActive(true);
            capital-=1500;
            Captial.text="Captial: $"+capital;
            selected.Add(8);
        }
        else{
            Yan_Selected.SetActive(false);
            capital+=1500;
            Captial.text="Captial: $"+capital;
            selected.Remove(8);
        }
    }
    public void selectKevin(){
        select_Kevin=!select_Kevin;
        if(select_Kevin){
            Kevin_Selected.SetActive(true);
            capital-=2000;
            Captial.text="Captial: $"+capital;
            selected.Add(5);
        }
        else{
            Kevin_Selected.SetActive(false);
            capital+=2000;
            Captial.text="Captial: $"+capital;
            selected.Remove(5);
        }
    }
    public void selectDavid(){
        select_David=!select_David;
        if(select_David){
            David_Selected.SetActive(true);
            capital-=1000;
            Captial.text="Captial: $"+capital;
            selected.Add(7);
        }
        else{
            David_Selected.SetActive(false);
            capital+=1000;
            Captial.text="Captial: $"+capital;
            selected.Remove(7);
        }
    }
    public void selectAlex(){
        select_Alex=!select_Alex;
        if(select_Alex){
            Alex_Selected.SetActive(true);
            capital-=1000;
            Captial.text="Captial: $"+capital;
            selected.Add(9);
        }
        else{
            Alex_Selected.SetActive(false);
            capital+=1000;
            Captial.text="Captial: $"+capital;
            selected.Remove(9);
        }
    }
    public void selectDaniel(){
        select_Daniel=!select_Daniel;
        if(select_Daniel){
            Daniel_Selected.SetActive(true);
            capital-=3000;
            Captial.text="Captial: $"+capital;
            selected.Add(4);
        }
        else{
            Daniel_Selected.SetActive(false);
            capital+=3000;
            Captial.text="Captial: $"+capital;
            selected.Remove(4);
        }
    }
    public void selectAaron(){
        select_Aaron=!select_Aaron;
        if(select_Aaron){
            Aaron_Selected.SetActive(true);
            capital-=1500;
            Captial.text="Captial: $"+capital;
            selected.Add(10);
        }
        else{
            Aaron_Selected.SetActive(false);
            capital+=1500;
            Captial.text="Captial: $"+capital;
            selected.Remove(10);
        }
    }

    public void selectTheresa(){
        select_Theresa=!select_Theresa;
        if(select_Theresa){
            Theresa_Selected.SetActive(true);
            capital-=1500;
            Captial.text="Captial: $"+capital;
            selected.Add(2);
        }
        else{
            Theresa_Selected.SetActive(false);
            capital+=1500;
            Captial.text="Captial: $"+capital;
            selected.Remove(2);
        }
    }
    


    void Start(){

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SaveAndExit(){
        PlayerPrefsX.SetIntArray("staff",selected.ToArray());
        //PlayerPrefsX.Save();
        SceneManager.LoadScene(4);
    }
}
