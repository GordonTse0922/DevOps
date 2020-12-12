using System.Collections;

using System.Collections.Generic;

using UnityEngine;

using UnityEngine.UI; //使用Unity UI程式庫。
using UnityEngine.SceneManagement;

public class Test_Timer : MonoBehaviour {

    int time_int = 10;
    bool timeUp=false;
    public Text time_UI;
    public GameObject report;
    public GameObject WeekEnd;
    void Awake() {
        WeekEnd=GameObject.Find("End");
        report=GameObject.Find("Report");
        WeekEnd.SetActive(false);
    }
    void Start(){
        InvokeRepeating("timer", 1, 1);
        if(timeUp){
            Invoke("GotoReport",2);
        }
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
            Invoke("GotoReport",2);
       }
    }
    void GotoReport()
    {
        if(timeUp){
        SceneManager.LoadScene(11);
        }
    }

}