using System.Collections;

using System.Collections.Generic;

using UnityEngine;

using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class Main: MonoBehaviour {

    int selected_staff;
    int staff_feature1_Design;
    int staff_feature1_Program;
    int staff_feature1_Test;
    int staff_feature1_Deploy;
    int time_feature1_Design;
    int time_feature1_Program;
    int time_feature1_Test;
    int time_feature1_Deploy;
    int time_int = 10;
    int F1_count = 0;
    int week;
    bool haveError = true;
    bool pause =false;
    bool timeUp=false;
    bool selectFeature = false;
    bool selectDesign = false;
    bool selectTest = false;
    bool selectDeploy = false;
    bool selectDesigner1 = false;
    bool selectDesigner2 = false;
    bool selectProgrammer1 = false;
    bool selectProgrammer2 = false;
    bool selectProgrammer3 = false;
    bool selectProgrammer4 = false;
    bool selectTester1 = false;
    bool selectTester2 = false;
    bool selectDeployer1 = false;
    bool selectDeployer2 = false;
    bool Designed =false;
    public Text time_UI;
    public Text week_UI;
    public TMP_Text End_week;
    public TMP_Text featureTimer;
    public TMP_Text ProgramTimer;
    public TMP_Text TestTimer;
    public TMP_Text DeployTimer;
    public TMP_Text F1C_UI;
    public List<int> usableStaff;
    public List<int> WIPTasks;
    public Sprite designer1;
    public Sprite designer2;
    public Sprite programmer1;
    public Sprite programmer2;
    public Sprite programmer3;
    public Sprite programmer4;
    public Sprite tester1;
    public Sprite tester2;
    public Sprite deployer1;
    public Sprite deployer2;


    GameObject report;
    GameObject WeekEnd;
    GameObject gordon;
    GameObject isabel;
    GameObject yan;
    GameObject alex;
    GameObject kevin;
    GameObject david;
    GameObject theresa;
    GameObject aaron;
    GameObject edwin;
    GameObject daniel;
    GameObject designingFeature;
    GameObject ProgramingFeature;
    GameObject TestingFeature;
    GameObject DeployingFeature;
    GameObject WLFeature;
    GameObject ErrorMessage;
    GameObject Error;
    GameObject WLError;
    GameObject FinishError;
    GameObject FinishFeature1;
    GameObject FinishFeature2;
    GameObject FinishFeature3;
    GameObject FinishFeature4;
    GameObject FinishFeature5;
    GameObject f1t1;
    GameObject f1t2;
    GameObject f1t3;
    GameObject designer;
    GameObject worker;
    GameObject programmer;
    GameObject tester;
    GameObject deployer;
    void Awake() {
        Invoke("OnEnable",0);
        int WaitList_Feature1=PlayerPrefs.GetInt("WaitList-Feature1");
        WeekEnd=GameObject.Find("End");
        report=GameObject.Find("Report");
        gordon=GameObject.Find("Gordon");
        isabel = GameObject.Find("Isabel");
        yan = GameObject.Find("Yan");
        alex = GameObject.Find("Alex");
        kevin = GameObject.Find("Kevin");
        david = GameObject.Find("David");
        theresa = GameObject.Find("Theresa");
        aaron = GameObject.Find("Aaron");
        edwin = GameObject.Find("Edwin");
        daniel = GameObject.Find("Daniel");
        f1t1 = GameObject.Find("F1T1");
        f1t2 = GameObject.Find("F1T2");
        f1t3 = GameObject.Find("F1T3");
        designingFeature = GameObject.Find("Design_Feature1");
        ProgramingFeature = GameObject.Find("Program_Feature1");
        TestingFeature = GameObject.Find("Test_Feature1");
        DeployingFeature = GameObject.Find("Deploy_Feature1");
        WLFeature = GameObject.Find("WL-Feature1");
        ErrorMessage = GameObject.Find("ErrorMessage");
        Error = GameObject.Find("Error");
        WLError = GameObject.Find("WL-Error");
        FinishError = GameObject.Find("Finish-Error");
        FinishFeature1 = GameObject.Find("Finish-Feature1");
        FinishFeature2 = GameObject.Find("Finish-Feature2");
        FinishFeature3 = GameObject.Find("Finish-Feature3");
        FinishFeature4 = GameObject.Find("Finish-Feature4");
        FinishFeature5 = GameObject.Find("Finish-Feature5");
        designer = GameObject.Find("worker");
        programmer = GameObject.Find("Programmer1");
        tester = GameObject.Find("Tester1");
        deployer = GameObject.Find("Deployer1");
        week = PlayerPrefs.GetInt("week")+1;
        if(week==1){
            usableStaff = new List<int> (PlayerPrefsX.GetIntArray("staff")); 
        }
        else{
            usableStaff = new List<int> (PlayerPrefsX.GetIntArray("usableStaff")); 
        }
        //usableStaff =PlayerPrefsX.GetIntArray("staff");
        isabel.SetActive(false);
        theresa.SetActive(false);
        edwin.SetActive(false);
        daniel.SetActive(false);
        kevin.SetActive(false);
        gordon.SetActive(false);
        david.SetActive(false);
        yan.SetActive(false);
        alex.SetActive(false);
        aaron.SetActive(false);
        foreach (int staff in usableStaff){
            switch (staff)
            {
                case 1:
                    isabel.SetActive(true);
                    break;

                case 2:
                    theresa.SetActive(true);
                    break;

                case 3:
                    edwin.SetActive(true);
                    break;
                
                case 4:
                    daniel.SetActive(true);
                    break;
                
                case 5:
                    kevin.SetActive(true);
                    break;
                
                case 6:
                    gordon.SetActive(true);
                    break;
                
                case 7:
                    david.SetActive(true);
                    break;
                
                case 8:
                    yan.SetActive(true);
                    break;

                case 9:
                    alex.SetActive(true);
                    break;

                case 10:
                    aaron.SetActive(true);
                    break;
            }

        }
        WIPTasks=new List<int> (PlayerPrefsX.GetIntArray("WIPTasks"));
            foreach (int task in WIPTasks){
                WIP_Tasks(task);
        }
        if (week >= 2)
        {
            // week 2 activation
            f1t1.SetActive(false);
            f1t2.SetActive(false);
            f1t3.SetActive(false);
            designingFeature.SetActive(false);
            featureTimer.text="";
            ProgramingFeature.SetActive(false);
            TestingFeature.SetActive(false);
            DeployingFeature.SetActive(false);
            FinishFeature1.SetActive(false);
            FinishFeature2.SetActive(false);
            FinishFeature3.SetActive(false);
            FinishFeature4.SetActive(false);
            FinishFeature5.SetActive(false);
            ErrorMessage.SetActive(false);
            Error.SetActive(false);
            WLError.SetActive(false);
            FinishError.SetActive(false);
            WeekEnd.SetActive(false);
            F1_count=WaitList_Feature1;
            F1C_UI.text = F1_count + "/3";
            // deployer.SetActive(false);
            // alex.SetActive(true);
        }
        else
        {
            designingFeature.SetActive(false);
            ProgramingFeature.SetActive(false);
            TestingFeature.SetActive(false);
            DeployingFeature.SetActive(false);
            FinishFeature1.SetActive(false);
            FinishFeature2.SetActive(false);
            FinishFeature3.SetActive(false);
            FinishFeature4.SetActive(false);
            FinishFeature5.SetActive(false);
            ErrorMessage.SetActive(false);
            Error.SetActive(false);
            WLError.SetActive(false);
            FinishError.SetActive(false);
            WeekEnd.SetActive(false);
        }
    }
    void Start(){
        InvokeRepeating("timer", 1, 1);
        InvokeRepeating("Designing_Feature", 1,1);
        InvokeRepeating("Programming_Feature", 1, 1);
        InvokeRepeating("Testing_Feature", 1, 1);
        InvokeRepeating("Deploying_Feature", 1, 1);
        //InvokeRepeating("ShowUsableStaff",1,1);
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
            CancelInvoke("Designing_Feature");
            CancelInvoke("Programming_Feature");
            CancelInvoke("Testing_Feature");
            CancelInvoke("Deploying_Feature");
            CancelInvoke("timer");
            if(designingFeature.activeSelf){
            Debug.Log("1");
            WIPTasks.Add(1);
            }
            if(ProgramingFeature.activeSelf){
            Debug.Log("2");
            WIPTasks.Add(2);
            }
            if(TestingFeature.activeSelf){
             Debug.Log("3");
             WIPTasks.Add(3);
            }
            if(DeployingFeature.activeSelf){
             Debug.Log("4");
             WIPTasks.Add(4);
            }
            Invoke("OnDisable",0);
            Invoke("GotoReport",2);
       }
    }
    void GotoReport()
    {
        if(timeUp&&week>=5){
            SceneManager.LoadScene(14);
        }
        else if(timeUp&&week>=1&&week<5){
            // CancelInvoke("Designing_Feature");
            // CancelInvoke("Programming_Feature");
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
        PlayerPrefs.SetInt("WaitList-Feature1",F1_count);
        PlayerPrefsX.SetIntArray("usableStaff",usableStaff.ToArray());
        PlayerPrefsX.SetIntArray("WIPTasks",WIPTasks.ToArray());
        //PlayerPrefs.SetString("WaitList-Feature1",F1C_UI.text);
    }
    void OnEnable()
    {
        // Load Data from PlaterPrefs API
        week = PlayerPrefs.GetInt("week")+1;
        week_UI.text="Week "+(week);
        End_week.text="Week"+week+" End !!";

    }
    void WIP_Tasks(int task){
            switch (task)
            {
                case 1:
                    designingFeature.SetActive(true);
                    break;

                case 2:
                    ProgramingFeature.SetActive(true);
                    break;

                case 3:
                    TestingFeature.SetActive(true);
                    break;
                
                case 4:
                    DeployingFeature.SetActive(true);
                    break;
            }
    }


    public void Select_Designer1()
    {
        selected_staff = 1;
        
    }
    public void Select_Designer2()
    {
        selected_staff = 2;
        
    }

    public void Select_Programmer1()
    {
        selected_staff = 3;
       
    }
    public void Select_Programmer2()
    {
        selected_staff = 4;
       
    }
    public void Select_Programmer3()
    {
        selected_staff = 5;
        
    }
    public void Select_Programmer4()
    {
        selected_staff = 6;
      
    }

    public void Select_Tester1()
    {
        selected_staff = 7;
       
    }
    public void Select_Tester2()
    {
        selected_staff = 8;
        
    }
    public void Select_Deployer1()
    {
        selected_staff = 9;
        
       
    }
    public void Select_Deployer2()
    {
        selected_staff = 10;
        
    }

    public void Select_Feature()
    {
        selectFeature = true;
        if (selected_staff == 1) {
            //isabel.SetActive(false);
            usableStaff.Remove(1); 
            HideUsableStaff(1);
            staff_feature1_Design = 1; 
            }
        if (selected_staff == 2) {
            //daniel.SetActive(false); 
            usableStaff.Remove(2);
            HideUsableStaff(2);
            staff_feature1_Design = 2;
            }
    }
    void HideUsableStaff(int staff){
            // foreach (int staff in usableStaff){
            switch (staff)
            {
                case 1:
                    isabel.SetActive(false);
                    break;

                case 2:
                    theresa.SetActive(false);
                    break;

                case 3:
                    edwin.SetActive(false);
                    break;
                
                case 4:
                    daniel.SetActive(false);
                    break;
                
                case 5:
                    kevin.SetActive(false);
                    break;
                
                case 6:
                    gordon.SetActive(false);
                    break;
                
                case 7:
                    david.SetActive(false);
                    break;
                
                case 8:
                    yan.SetActive(false);
                    break;

                case 9:
                    alex.SetActive(false);
                    break;

                case 10:
                    aaron.SetActive(false);
                    break;
        }
    }
    void ShowUsableStaff(int staff){
            // foreach (int staff in usableStaff){
            switch (staff)
            {
                case 1:
                    isabel.SetActive(true);
                    break;

                case 2:
                    theresa.SetActive(true);
                    break;

                case 3:
                    edwin.SetActive(true);
                    break;
                
                case 4:
                    daniel.SetActive(true);
                    break;
                
                case 5:
                    kevin.SetActive(true);
                    break;
                
                case 6:
                    gordon.SetActive(true);
                    break;
                
                case 7:
                    david.SetActive(true);
                    break;
                
                case 8:
                    yan.SetActive(true);
                    break;

                case 9:
                    alex.SetActive(true);
                    break;

                case 10:
                    aaron.SetActive(true);
                    break;
            }
    }
    void WhoIsWorking(int staff){
        switch (staff)
            {
                case 1:
                    designer.GetComponent<Image> ().sprite = designer1;
                    break;

                case 2:
                    designer.GetComponent<Image> ().sprite = designer2;
                    break;

                case 3:
                    programmer.GetComponent<Image> ().sprite = programmer1;
                    break;
                
                case 4:
                    programmer.GetComponent<Image> ().sprite = programmer2;
                    break;
                
                case 5:
                    programmer.GetComponent<Image> ().sprite = programmer3;
                    
                    break;
                
                case 6:
                    programmer.GetComponent<Image> ().sprite = programmer4;
                    
                    break;
                
                case 7:
                    tester.GetComponent<Image> ().sprite = tester1;
                    
                    break;
                
                case 8:
                    tester.GetComponent<Image> ().sprite = tester2;
                    
                    break;

                case 9:
                    deployer.GetComponent<Image> ().sprite = deployer1;
                    
                    break;

                case 10:
                    deployer.GetComponent<Image> ().sprite = deployer2;
                    
                    break;
            }

    }
    public void Select_f1t1()
    {
        f1t1.SetActive(false);
        if (selected_staff == 1) { time_feature1_Design = 8; }
        else if (selected_staff == 2) { time_feature1_Design = 5; }
        else{time_feature1_Design = 16;}
        WhoIsWorking(selected_staff);
        designingFeature.SetActive(true);
        designer.SetActive(true);
        featureTimer.text = time_feature1_Design + "hrs";
    }
    public void Select_f1t2()
    {
        f1t2.SetActive(false);
        //time_feature1_Design = 7;
        if (selected_staff == 1) { time_feature1_Design = 7;  }
        else if (selected_staff == 2) { time_feature1_Design = 4; }
        else{time_feature1_Design = 14;}
        WhoIsWorking(selected_staff);
        designingFeature.SetActive(true);
        designer.SetActive(true);
        featureTimer.text = time_feature1_Design + "hrs";
    }
    public void Select_f1t3()
    {
        f1t3.SetActive(false);
        //time_feature1_Design = 5;
        if (selected_staff == 1) { time_feature1_Design = 5; }
        else if (selected_staff == 2) { time_feature1_Design = 2; }
        else{time_feature1_Design = 10; }
        WhoIsWorking(selected_staff);
        designingFeature.SetActive(true);
        designer.SetActive(true);
        featureTimer.text = time_feature1_Design + "hrs";
    }

    public void Select_Feature_Program()
    {
        selectDesign = true;
        time_feature1_Program = 10;
        ProgramTimer.text = time_feature1_Program + "hrs";
        if (selected_staff == 3) { staff_feature1_Program = 3; }
        else if (selected_staff == 4) { staff_feature1_Program = 4; }
        else if (selected_staff == 5) { staff_feature1_Program = 5; }
        else if (selected_staff == 6) {staff_feature1_Program = 6; }
        else{staff_feature1_Program = 18;}
        HideUsableStaff(selected_staff); 
        WhoIsWorking(selected_staff);
        usableStaff.Remove(selected_staff);
        designingFeature.SetActive(false);
        ProgramingFeature.SetActive(true);

    }
    public void Select_Feature_Test()
    {
        selectTest = true;
        time_feature1_Test = 5;
        WLFeature.SetActive(false);
        TestingFeature.SetActive(true);
        if (selected_staff == 7) { staff_feature1_Test = 7; }
        else if (selected_staff == 8) { staff_feature1_Test = 8; }
        else{staff_feature1_Test = 16; }
        HideUsableStaff(selected_staff); 
        usableStaff.Remove(selected_staff);
        WhoIsWorking(selected_staff);
        tester.SetActive(true);
        //  TestTimer.text = time_feature1_Design + "hrs";
    }
    public void Select_Feature_Deploy()
    {
        selectDeploy = true;
        time_feature1_Deploy = 3;
        TestingFeature.SetActive(false);
        DeployingFeature.SetActive(true);
        if (selected_staff == 9) { staff_feature1_Deploy = 9; }
        else if (selected_staff == 10) {staff_feature1_Deploy = 10; }
        else{staff_feature1_Deploy = 20; }
        HideUsableStaff(selected_staff); 
        usableStaff.Remove(selected_staff);
        WhoIsWorking(selected_staff);
        deployer.SetActive(true);
    }


    void Designing_Feature()
    {
        //      if((selectDesigner1||selectDesigner2) && selectFeature)
        {

            time_feature1_Design -= 1;
            featureTimer.text = time_feature1_Design + "hrs";

            if (time_feature1_Design <= 0)
            {
                designer.SetActive(false);
                if (staff_feature1_Design == 1) { ShowUsableStaff(1); usableStaff.Add(1);}
                if (staff_feature1_Design == 2) { ShowUsableStaff(2); usableStaff.Add(2);}
                featureTimer.text = "";
                selectFeature = false;
                //designingFeature.SetActive(false);
                //CancelInvoke("Designing_Feature");
            }
        }
    }
    void Programming_Feature()
    {
        //     if((selectProgrammer1|| selectProgrammer2|| selectProgrammer3|| selectProgrammer4) &&selectDesign)
        {
            time_feature1_Program -= 1;
            ProgramTimer.text = time_feature1_Program + "hrs";
            if (time_feature1_Program <= 0)
            {
                ProgramTimer.text = "";
            }
            if (time_feature1_Program == 0)
            {
                //Pprogrammer.SetActive(false);
                F1_count++;
                if (F1_count > 3)
                {
                    F1C_UI.text = "3/3";
                }
                else
                {
                    F1C_UI.text = F1_count + "/3";
                }
                if (staff_feature1_Program == 3) { ShowUsableStaff(3);usableStaff.Add(3); }
                if (staff_feature1_Program == 4) { ShowUsableStaff(4);usableStaff.Add(4); }
                if (staff_feature1_Program == 5) { ShowUsableStaff(5);usableStaff.Add(5);  }
                if (staff_feature1_Program == 6) { ShowUsableStaff(6);usableStaff.Add(6); }
                ProgramingFeature.SetActive(false);
                
                //CancelInvoke("Programming_Feature");
            }
        }

        void Testing_Feature()
        {
            //      if ((selectTester1|| selectTester2) && selectTest)
            {
                time_feature1_Test -= 1;
                TestTimer.text = time_feature1_Test + "hrs";
                if (time_feature1_Test == 1 && haveError == true && week == 2)
                {
                    time_feature1_Test = 6;
                    haveError = false;
                    ErrorMessage.SetActive(true);
                    TestTimer.text = time_feature1_Test + "hrs";
                    TestTimer.color = Color.red;

                }
                if (time_feature1_Test <= 0)
                {
                    tester.SetActive(false);
                    if (staff_feature1_Test == 7) {david.SetActive(true);usableStaff.Add(7); }
                    if (staff_feature1_Test == 8) {yan.SetActive(true);usableStaff.Add(8); }
                    TestTimer.text = "";
                    selectTest = false;
                    TestTimer.color = Color.black;

                }
            }
        }
        void Deploying_Feature()
        {
            //    if ((selectDeployer1|| selectDeployer2) && selectDeploy)
            {
                time_feature1_Deploy -= 1;
                DeployTimer.text = time_feature1_Deploy + "hrs";
                if (time_feature1_Deploy <= 0)
                {
                    deployer.SetActive(false);
                    if (staff_feature1_Deploy == 9) {alex.SetActive(true);usableStaff.Add(9); }
                    if (staff_feature1_Deploy == 10) { aaron.SetActive(true);usableStaff.Add(10); }
                    DeployTimer.text = "";
                    DeployingFeature.SetActive(false);
                    FinishFeature1.SetActive(true);
                    selectDeploy = false;
                }
            }
        }

        

    }
}