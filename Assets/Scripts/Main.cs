using System.Collections;

using System.Collections.Generic;

using UnityEngine;

using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class Main: MonoBehaviour {

    int time_int = 10;
    int week;
    bool pause =false;
    bool timeUp=false;
    public Text time_UI;
    public Text week_UI;
    public TMP_Text End_week;
    GameObject report;
    GameObject WeekEnd;
    void Awake() {
        Invoke("OnEnable",0);
        WeekEnd=GameObject.Find("End");
        report=GameObject.Find("Report");
        WeekEnd.SetActive(false);
    }
    void Start(){
        InvokeRepeating("timer", 1, 1);
    }
    void Update() {
    }

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

}