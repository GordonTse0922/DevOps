using System.Collections;

using System.Collections.Generic;

using UnityEngine;

using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class Main: MonoBehaviour {

    int time_feature = 5;
    int time_feature_Program= 10;
    int time_int = 30;
    int week;
    bool pause =false;
    bool timeUp=false;
    bool selectDesigner=false;
    bool selectFeature=false;
    bool selectProgrammer=false;
    bool Designed=false;
    public Text time_UI;
    public Text week_UI;
    public TMP_Text End_week;
    public TMP_Text featureTimer;
    public TMP_Text ProgramTimer;
    GameObject report;
    GameObject WeekEnd;
    GameObject gordon;
    GameObject isabel;
    GameObject designingFeature;
    GameObject ProgramingFeature;
    GameObject feature1;
    GameObject designer;
    GameObject worker;
    GameObject programmer;
    void Awake() {
        Invoke("OnEnable",0);
        WeekEnd=GameObject.Find("End");
        report=GameObject.Find("Report");
        gordon=GameObject.Find("Gordon");
        isabel=GameObject.Find("Isabel");
        feature1=GameObject.Find("Feature");
        designingFeature=GameObject.Find("Design_Feature1");
        ProgramingFeature=GameObject.Find("Program_Feature1");
        designer=GameObject.Find("worker");
        programmer=GameObject.Find("Programmer1");
        designingFeature.SetActive(false);
        WeekEnd.SetActive(false);
        ProgramingFeature.SetActive(false);
    }
    void Start(){
        InvokeRepeating("timer", 1, 1);
        InvokeRepeating("Designing_Feature", 1,1);
        InvokeRepeating("Programming_Feature",1,1);
    }
    // void FixedUpdate(){
    //     if(selectStaff&&selectFeature){
    //         Invoke("Working_Feature", 1);
    //     }
    // }

    void timer(){
        time_int -= 1;
        time_UI.text = "Time Left:"+time_int+ "hrs";
        if (time_int == 0) {
            time_UI.text = "time's up";
            timeUp=true;
            WeekEnd.SetActive(true);
            CancelInvoke("timer");
            Invoke("OnDisable",0);
            Invoke("GotoReport",2);
       }
    }
    void GotoReport()
    {
        if(timeUp){
        SceneManager.LoadScene(11);
        }
    }

    public void PauseGame ()
    {
        pause=!pause;
        if(pause){
        Time.timeScale = 0;
        }
        else{
            Time.timeScale = 1;
        }
    }
    void OnDisable()
    {
        // Save Data to PlayerPrefs API
        PlayerPrefs.SetInt("week", (week));
    }
    void OnEnable()
    {
        // Load Data from PlaterPrefs API
        week = PlayerPrefs.GetInt("week")+1;
        week_UI.text="Week "+(week);
        End_week.text="Week"+week+" End !!";

    }
    public void Select_Designer(){
        selectDesigner=true;

    }
     public void Select_Programmer(){
        selectProgrammer=true;

    }
    public void Select_Feature(){
        selectFeature=true;
    }
    void Designing_Feature(){
        if(selectDesigner&&selectFeature){
            designingFeature.SetActive(true);
            isabel.SetActive(false);
            feature1.SetActive(false);
            time_feature -= 1;
            featureTimer.text = time_feature+ "hrs";
            if (time_feature == 0) {
                designer.SetActive(false);
                isabel.SetActive(true);
                featureTimer.text ="";
                selectFeature=false;
                //designingFeature.SetActive(false);
                CancelInvoke("Designing_Feature");
             }
        }
    }
    void Programming_Feature(){
        if(selectProgrammer&&selectFeature){
            designingFeature.SetActive(false);
            ProgramingFeature.SetActive(true);
            gordon.SetActive(false);
            time_feature_Program -= 1;
            ProgramTimer.text = time_feature_Program+ "hrs";
            if (time_feature_Program == 0) {
                //programmer.SetActive(false);
                gordon.SetActive(true);
                ProgramTimer.text ="";
                ProgramingFeature.SetActive(false);
                CancelInvoke("Programming_Feature");
             }
        }
    }

}