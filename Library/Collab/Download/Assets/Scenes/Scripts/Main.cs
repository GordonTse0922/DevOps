using System.Collections;

using System.Collections.Generic;

using UnityEngine;

using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class Main : MonoBehaviour
{

    int selected_staff;
    int nextvacant_design;
    int staff_feature1_Design;
    int staff_feature1_Program;
    int staff_feature1_Test;
    int staff_feature1_Deploy;
    int time_feature1_Design;
    int time_feature1_Program;
    int time_feature1_Test;
    int time_feature1_Deploy;
    int feature_feature1__Design_Working;
    int feature_feature2__Design_Working;
    bool vacant_feature1_Design = true;
    bool vacant_feature1_Program = true;
    bool vacant_feature1_Test = true;
    bool vacant_feature1_Deploy = true;
    int staff_feature2_Design;
    int staff_feature2_Program;
    int staff_feature2_Test;
    int staff_feature2_Deploy;
    int time_feature2_Design;
    int time_feature2_Program;
    int time_feature2_Test;
    int time_feature2_Deploy;
    bool vacant_feature2_Design = true;
    bool vacant_feature2_Program = true;
    bool vacant_feature2_Test = true;
    bool vacant_feature2_Deploy = true;
    int time_int = 30;
    int F1_count = 0;
    int week;
    bool haveError = true;
    bool pause = false;
    bool timeUp = false;
    bool selectFeature = false;
    bool selectDesign = false;
    bool selectDesign2 = false;
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
    bool Designed = false;
    bool Feature1_Done=false;
    public Text time_UI;
    public Text week_UI;
    public TMP_Text End_week;
    public TMP_Text featureTimer;
    public TMP_Text ProgramTimer;
    public TMP_Text TestTimer;
    public TMP_Text DeployTimer;
    public TMP_Text featureTimer2;
    public TMP_Text ProgramTimer2;
    public TMP_Text TestTimer2;
    public TMP_Text DeployTimer2;

    public TMP_Text F1C_UI;
    public List<int> usableStaff;
    public List<int> WIPTasks;
    public List<int> Tasks_Feature1;
    public List<int> Tasks_Feature2;
    public Sprite Feature1;
    public Sprite Feature2;
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
    GameObject designingFeature2;
    GameObject ProgramingFeature2;
    GameObject TestingFeature2;
    GameObject DeployingFeature2;
    GameObject WLFeature;
    GameObject WLFeature2;
    GameObject WLFeature3;
    GameObject WLFeature4;
    GameObject WLFeature5;
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
    GameObject f2t1;
    GameObject f2t2;
    GameObject f2t3;
    GameObject f3t1;
    GameObject f3t2;
    GameObject f3t3;
    GameObject f3t4;
    GameObject f4t1;
    GameObject f4t2;
    GameObject f4t3;
    GameObject f5t1;
    GameObject f5t2;
    GameObject designer;
    GameObject worker;
    GameObject programmer;
    GameObject tester;
    GameObject deployer;
    GameObject designer2nd;
    GameObject worker2nd;
    GameObject programmer2nd;
    GameObject tester2nd;
    GameObject deployer2nd;
    void Awake()
    {
        Invoke("OnEnable", 0);
        int WaitList_Feature1 = PlayerPrefs.GetInt("WaitList-Feature1");
        WeekEnd = GameObject.Find("End");
        report = GameObject.Find("Report");
        gordon = GameObject.Find("Gordon");
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
        f2t1 = GameObject.Find("F2T1");
        f2t2 = GameObject.Find("F2T2");
        f2t3 = GameObject.Find("F2T3");
        f3t1 = GameObject.Find("F3T1");
        f3t2 = GameObject.Find("F3T2");
        f3t3 = GameObject.Find("F3T3");
        f3t4 = GameObject.Find("F3T4");
        f4t1 = GameObject.Find("F4T1");
        f4t2 = GameObject.Find("F4T2");
        f4t3 = GameObject.Find("F4T3");
        f5t1 = GameObject.Find("F5T1");
        f5t2 = GameObject.Find("F5T2");
        designingFeature = GameObject.Find("Design_Feature1");
        ProgramingFeature = GameObject.Find("Program_Feature1");
        TestingFeature = GameObject.Find("Test_Feature1");
        DeployingFeature = GameObject.Find("Deploy_Feature1");
        designingFeature2 = GameObject.Find("Design_Feature2");
        ProgramingFeature2 = GameObject.Find("Program_Feature2");
        TestingFeature2 = GameObject.Find("Test_Feature2");
        DeployingFeature2 = GameObject.Find("Deploy_Feature2");
        WLFeature = GameObject.Find("WL-Feature1");
        WLFeature2 = GameObject.Find("WL-Feature2");
        WLFeature3 = GameObject.Find("WL-Feature3");
        WLFeature4 = GameObject.Find("WL-Feature4");
        WLFeature5 = GameObject.Find("WL-Feature5");
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
        designer2nd = GameObject.Find("worker2");
        programmer2nd = GameObject.Find("Programmer2");
        tester2nd = GameObject.Find("Tester2");
        deployer2nd = GameObject.Find("Deployer2");
        week = PlayerPrefs.GetInt("week") + 1;
        if (week == 1)
        {
            usableStaff = new List<int>(PlayerPrefsX.GetIntArray("staff"));
        }
        else
        {
            usableStaff = new List<int>(PlayerPrefsX.GetIntArray("usableStaff"));
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
        foreach (int staff in usableStaff)
        {
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
        if (week >= 2)
        {
            // week 2 activation
            f1t1.SetActive(false);
            f1t2.SetActive(false);
            f1t3.SetActive(false);
            f2t1.SetActive(false);
            f2t2.SetActive(false);
            f2t3.SetActive(false);
            designingFeature.SetActive(false);
            ProgramingFeature.SetActive(false);
            TestingFeature.SetActive(false);
            DeployingFeature.SetActive(false);
            designingFeature2.SetActive(false);
            ProgramingFeature2.SetActive(false);
            TestingFeature2.SetActive(false);
            DeployingFeature2.SetActive(false);
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
            F1_count = WaitList_Feature1;
            F1C_UI.text = F1_count + "/3";
            WIPTasks = new List<int>(PlayerPrefsX.GetIntArray("WIPTasks"));
            foreach (int task in WIPTasks)
            {
                WIP_Tasks(task);
            }
            WIPTasks.Clear();
            Tasks_Feature1=new List<int>(PlayerPrefsX.GetIntArray("Tasks_Feature1"));
            foreach (int task in Tasks_Feature1)
            {
                ShowTasks_1(task);
            }
            Tasks_Feature2=new List<int>(PlayerPrefsX.GetIntArray("Tasks_Feature2"));
            foreach (int task in Tasks_Feature2)
            {
                ShowTasks_2(task);
            }
            // deployer.SetActive(false);
            // alex.SetActive(true);
        }
        else
        {
            designingFeature.SetActive(false);
            ProgramingFeature.SetActive(false);
            TestingFeature.SetActive(false);
            DeployingFeature.SetActive(false);
            designingFeature2.SetActive(false);
            ProgramingFeature2.SetActive(false);
            TestingFeature2.SetActive(false);
            DeployingFeature2.SetActive(false);
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
            Tasks_Feature1=new List<int>{1,2,3};
            Tasks_Feature2=new List<int>{1,2,3};
        }
    }
    void Start()
    {
        InvokeRepeating("timer", 1, 1);
        InvokeRepeating("Designing_Feature", 1, 1);
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

    void timer()
    {
        time_int -= 1;
        time_UI.text = "Time Left:" + time_int + "hrs";
        if (time_int == 0)
        {
            time_UI.text = "time's up";
            timeUp = true;
            WeekEnd.SetActive(true);
            CancelInvoke("Designing_Feature");
            CancelInvoke("Programming_Feature");
            CancelInvoke("Testing_Feature");
            CancelInvoke("Deploying_Feature");
            CancelInvoke("timer");
            if (designingFeature.activeSelf)
            {
                PlayerPrefs.SetInt("design_timer", time_feature1_Design);
                if (designer.activeSelf)
                {
                    PlayerPrefs.SetInt("design_worker", staff_feature1_Design);
                }
                else{
                    PlayerPrefs.SetInt("design_worker", 0);
                }
                WIPTasks.Add(1);
            }
            else{
                PlayerPrefs.SetInt("design_timer", 0);
            }
            
            if (ProgramingFeature.activeSelf)
            {
                Debug.Log("2");
                PlayerPrefs.SetInt("program_timer", time_feature1_Program);
                //PlayerPrefs.SetInt("program_worker", staff_feature1_Program);
                if (programmer.activeSelf)
                {
                    PlayerPrefs.SetInt("program_worker", staff_feature1_Program);
                }
                WIPTasks.Add(2);
            }
            if (TestingFeature.activeSelf)
            {
                Debug.Log("3");
                PlayerPrefs.SetInt("test_timer", time_feature1_Test);
                //PlayerPrefs.SetInt("test_worker", staff_feature1_Test);
                if (tester.activeSelf)
                {
                    PlayerPrefs.SetInt("test_worker", staff_feature1_Test);
                }
                WIPTasks.Add(3);
            }
            if (DeployingFeature.activeSelf)
            {
                Debug.Log("4");
                PlayerPrefs.SetInt("deploy_timer", time_feature1_Deploy);
                //PlayerPrefs.SetInt("deploy_worker", staff_feature1_Deploy);
                if (deployer.activeSelf)
                {
                    PlayerPrefs.SetInt("deploy_worker", staff_feature1_Deploy);
                }
                WIPTasks.Add(4);
            }
            if (designingFeature2.activeSelf)
            {
                PlayerPrefs.SetInt("design_timer2", time_feature2_Design);
                if (designer2nd.activeSelf)
                {
                    PlayerPrefs.SetInt("design_worker2", staff_feature2_Design);
                }
                else{
                    PlayerPrefs.SetInt("design_worker2", 0);
                }
                WIPTasks.Add(5);
            }
            else{
                PlayerPrefs.SetInt("design_timer2", 0);
            }
            if (ProgramingFeature2.activeSelf)
            {
                PlayerPrefs.SetInt("program_timer2", time_feature2_Program);
                //PlayerPrefs.SetInt("program_worker2", staff_feature2_Program);
                if (programmer2nd.activeSelf)
                {
                    PlayerPrefs.SetInt("program_worker2", staff_feature2_Program);
                }
                WIPTasks.Add(6);
            }
            if (TestingFeature2.activeSelf)
            {
                PlayerPrefs.SetInt("test_timer2", time_feature2_Test);
                //PlayerPrefs.SetInt("test_worker2", staff_feature2_Test);
                if (tester2nd.activeSelf)
                {
                    PlayerPrefs.SetInt("test_worker2", staff_feature2_Test);
                }
                WIPTasks.Add(7);
            }
            if (DeployingFeature2.activeSelf)
            {
                PlayerPrefs.SetInt("deploy_timer2", time_feature1_Deploy);
                //PlayerPrefs.SetInt("deploy_worker2", staff_feature1_Deploy);
                if (deployer2nd.activeSelf)
                {
                    PlayerPrefs.SetInt("deploy_worker2", staff_feature1_Deploy);
                }
                WIPTasks.Add(8);
            }
            Invoke("OnDisable", 0);
            Invoke("GotoReport", 2);
        }
    }
    void GotoReport()
    {
        if (timeUp && week >= 5)
        {
            SceneManager.LoadScene(14);
        }
        else if (timeUp && week >= 1 && week < 5)
        {
            // CancelInvoke("Designing_Feature");
            // CancelInvoke("Programming_Feature");
            SceneManager.LoadScene(11);
        }
    }

    public void PauseGame()
    {
        pause = !pause;
        if (pause)
        {
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1;
        }
    }
    void OnDisable()
    {
        // Save Data to PlayerPrefs API
        PlayerPrefsX.SetIntArray("Tasks_Feature1",Tasks_Feature1.ToArray());
        PlayerPrefsX.SetIntArray("Tasks_Feature2",Tasks_Feature2.ToArray());
        PlayerPrefs.SetInt("week", (week));
        PlayerPrefs.SetInt("WaitList-Feature1", F1_count);
        PlayerPrefsX.SetIntArray("usableStaff", usableStaff.ToArray());
        PlayerPrefsX.SetIntArray("WIPTasks", WIPTasks.ToArray());
        //PlayerPrefs.SetString("WaitList-Feature1",F1C_UI.text);
    }
    void OnEnable()
    {
        // Load Data from PlaterPrefs API
        week = PlayerPrefs.GetInt("week") + 1;
        week_UI.text = "Week " + (week);
        End_week.text = "Week" + week + " End !!";

    }
    void ShowTasks_1(int task){
        Debug.Log(task);
        switch(task){
            case 1:
            f1t1.SetActive(true);
            break;
            case 2:
            f1t2.SetActive(true);
            break;
            case 3:
            f1t3.SetActive(true);
            break;
        }
    }
    void ShowTasks_2(int task){
        Debug.Log(task);
        switch(task){
            case 1:
            f2t1.SetActive(true);
            break;
            case 2:
            f2t2.SetActive(true);
            break;
            case 3:
            f2t3.SetActive(true);
            break;
        }
    }
    void WIP_Tasks(int task)
    {
        switch (task)
        {
            case 1:
                //designingFeature.SetActive(true);
                time_feature1_Design = PlayerPrefs.GetInt("design_timer");
                staff_feature1_Design = PlayerPrefs.GetInt("design_worker");
                designingFeature.SetActive(true);
                if(time_feature1_Design==0){
                    featureTimer.text = "";
                }
                if (staff_feature1_Design == 0)
                {
                    designer.SetActive(false);
                }
                else
                {
                    WhoIsWorking(staff_feature1_Design);
                }
                break;

            case 2:
                time_feature1_Program = PlayerPrefs.GetInt("program_timer");
                staff_feature1_Program = PlayerPrefs.GetInt("program_worker");
                //WhoIsWorking(staff_feature1_Program);
                ProgramingFeature.SetActive(true);
                if(time_feature1_Program==0){
                    ProgramTimer.text = "";
                }
                if (staff_feature1_Program == 0)
                {
                    programmer.SetActive(false);
                }
                else
                {
                    WhoIsWorking(staff_feature1_Program);
                }
                break;

            case 3:
                time_feature1_Test = PlayerPrefs.GetInt("test_timer");
                staff_feature1_Test = PlayerPrefs.GetInt("test_worker");
                //WhoIsWorking(staff_feature1_Test);
                TestingFeature.SetActive(true);
                if(time_feature1_Test==0){
                    TestTimer.text = "";
                }
                if (staff_feature1_Test == 0)
                {
                    tester.SetActive(false);
                }
                else
                {
                    WhoIsWorking(staff_feature1_Test);
                }
                
                break;

            case 4:
                time_feature1_Deploy = PlayerPrefs.GetInt("deploy_timer");
                staff_feature1_Deploy = PlayerPrefs.GetInt("deploy_worker");
                //WhoIsWorking(staff_feature1_Deploy);
                DeployingFeature.SetActive(true);
                if(time_feature1_Deploy==0){
                    DeployTimer.text = "";
                }
                if (staff_feature1_Deploy == 0)
                {
                    deployer.SetActive(false);
                }
                else
                {
                    WhoIsWorking(staff_feature1_Deploy);
                }
                
                break;
            case 5:
                time_feature2_Design = PlayerPrefs.GetInt("design_timer2");
                staff_feature2_Design = PlayerPrefs.GetInt("design_worker2");
                designingFeature2.SetActive(true);
                if(time_feature2_Design==0){
                    featureTimer2.text = "";
                }
                if (staff_feature2_Design == 0)
                {
                    designer2nd.SetActive(false);
                }
                else
                {
                    WhoIsWorking_2nd(staff_feature2_Design);
                }
                
                break;

            case 6:
                time_feature2_Program = PlayerPrefs.GetInt("program_timer2");
                staff_feature2_Program = PlayerPrefs.GetInt("program_worker2");
                //WhoIsWorking_2nd(staff_feature1_Program);
                ProgramingFeature2.SetActive(true);
                if(time_feature2_Program==0){
                    ProgramTimer2.text = "";
                }
                if (staff_feature2_Program == 0)
                {
                    programmer2nd.SetActive(false);
                }
                else
                {
                    WhoIsWorking_2nd(staff_feature1_Program);
                }
                
                break;

            case 7:
                time_feature1_Test = PlayerPrefs.GetInt("test_timer2");
                staff_feature1_Test = PlayerPrefs.GetInt("test_worker2");
                //(staff_feature1_Test);
                if(time_feature2_Test==0){
                    TestTimer2.text = "";
                }
                TestingFeature2.SetActive(true);
                if (staff_feature2_Test == 0)
                {
                    tester2nd.SetActive(false);
                }
                else
                {
                    WhoIsWorking_2nd(staff_feature2_Test);
                }
                
                break;

            case 8:
                time_feature1_Deploy = PlayerPrefs.GetInt("deploy_timer2");
                staff_feature1_Deploy = PlayerPrefs.GetInt("deploy_worker2");
                //WhoIsWorking_2nd(staff_feature1_Deploy);
                DeployingFeature2.SetActive(true);
                if(time_feature2_Deploy==0){
                    DeployTimer2.text = "";
                }
                if (staff_feature2_Deploy == 0)
                {
                    deployer2nd.SetActive(false);
                }
                else
                {
                    WhoIsWorking_2nd(staff_feature1_Deploy);
                }
                
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
        if (vacant_feature1_Design == true)
        {
            selectFeature = true;
            if (selected_staff == 1)
            {
                //isabel.SetActive(false);
                usableStaff.Remove(1);
                HideUsableStaff(1);
                staff_feature1_Design = 1;
            }
            if (selected_staff == 2)
            {
                //daniel.SetActive(false); 
                usableStaff.Remove(2);
                HideUsableStaff(2);
                staff_feature1_Design = 2;
            }
        }
        else
        {
            selectFeature = true;
            if (selected_staff == 1)
            {
                //isabel.SetActive(false);
                usableStaff.Remove(1);
                HideUsableStaff(1);
                staff_feature2_Design = 1;
            }
            if (selected_staff == 2)
            {
                //daniel.SetActive(false); 
                usableStaff.Remove(2);
                HideUsableStaff(2);
                staff_feature2_Design = 2;
            }
        }
    }
    void HideUsableStaff(int staff)
    {
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
                yan.SetActive(false);
                break;

            case 8:
                david.SetActive(false);
                break;

            case 9:
                alex.SetActive(false);
                break;

            case 10:
                aaron.SetActive(false);
                break;
        }
    }
    void ShowUsableStaff(int staff)
    {
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
                yan.SetActive(true);
                break;

            case 8:
                david.SetActive(true);
                break;

            case 9:
                alex.SetActive(true);
                break;

            case 10:
                aaron.SetActive(true);
                break;
        }
    }
    void WhoIsWorking(int staff)
    {
        switch (staff)
        {
            case 1:
                designer.GetComponent<Image>().sprite = designer1;
                break;

            case 2:
                designer.GetComponent<Image>().sprite = designer2;
                break;

            case 3:
                programmer.GetComponent<Image>().sprite = programmer1;
                break;

            case 4:
                programmer.GetComponent<Image>().sprite = programmer2;
                break;

            case 5:
                programmer.GetComponent<Image>().sprite = programmer3;

                break;

            case 6:
                programmer.GetComponent<Image>().sprite = programmer4;

                break;

            case 7:
                tester.GetComponent<Image>().sprite = tester1;

                break;

            case 8:
                tester.GetComponent<Image>().sprite = tester2;

                break;

            case 9:
                deployer.GetComponent<Image>().sprite = deployer1;

                break;

            case 10:
                deployer.GetComponent<Image>().sprite = deployer2;

                break;
        }
    }
        void WhoIsWorking_2nd(int staff)
    {
        switch (staff)
        {
            case 1:
                designer2nd.GetComponent<Image>().sprite = designer1;
                break;

            case 2:
                designer2nd.GetComponent<Image>().sprite = designer2;
                break;

            case 3:
                programmer2nd.GetComponent<Image>().sprite = programmer1;
                break;

            case 4:
                programmer2nd.GetComponent<Image>().sprite = programmer2;
                break;

            case 5:
                programmer2nd.GetComponent<Image>().sprite = programmer3;

                break;

            case 6:
                programmer2nd.GetComponent<Image>().sprite = programmer4;

                break;

            case 7:
                tester2nd.GetComponent<Image>().sprite = tester1;

                break;

            case 8:
                tester2nd.GetComponent<Image>().sprite = tester2;

                break;

            case 9:
                deployer2nd.GetComponent<Image>().sprite = deployer1;

                break;

            case 10:
                deployer2nd.GetComponent<Image>().sprite = deployer2;

                break;
        }

    }
    public void Select_f1t1()
    {
        f1t1.SetActive(false);
        Tasks_Feature1.Remove(1);
        //feature_feature1__Design_Working=1;
        if (vacant_feature1_Design)
        {
            feature_feature1__Design_Working=1;
            if (selected_staff == 1) { time_feature1_Design = 8; }
            else if (selected_staff == 2) { time_feature1_Design = 5; }
            else { time_feature1_Design = 16; }
            designingFeature.GetComponent<Image>().sprite = Feature1;
            designingFeature.SetActive(true);
            designer.SetActive(true);
            WhoIsWorking(selected_staff);
            featureTimer.text = time_feature1_Design + "hrs";
            vacant_feature1_Design = false;
        }
        else
        {
            feature_feature2__Design_Working=1;
            if (selected_staff == 1) { time_feature2_Design = 8; }
            else if (selected_staff == 2) { time_feature2_Design = 5; }
            else { time_feature2_Design = 16; }
            designingFeature2.GetComponent<Image>().sprite = Feature1;
            designingFeature2.SetActive(true);
            designer2nd.SetActive(true);
            WhoIsWorking_2nd(selected_staff);
            featureTimer2.text = time_feature2_Design + "hrs";
            vacant_feature2_Design = false;
        }
    }
    public void Select_f1t2()
    {
        f1t2.SetActive(false);
        Tasks_Feature1.Remove(2);
        //feature_feature1__Design_Working=1;
        //designingFeature.GetComponent<Image>().sprite = designFeature1;
        if (vacant_feature1_Design)
        {
            //time_feature1_Design = 7;
            feature_feature1__Design_Working=1;
            if (selected_staff == 1) { time_feature1_Design = 7; }
            else if (selected_staff == 2) { time_feature1_Design = 4; }
            else { time_feature1_Design = 14; }
            designingFeature.GetComponent<Image>().sprite = Feature1;
            WhoIsWorking(selected_staff);
            designingFeature.SetActive(true);
            designer.SetActive(true);
            featureTimer.text = time_feature1_Design + "hrs";
            vacant_feature1_Design = false;
        }
        else
        {
            feature_feature2__Design_Working=1;
            if (selected_staff == 1) { time_feature2_Design = 7; }
            else if (selected_staff == 2) { time_feature2_Design = 4; }
            else { time_feature2_Design = 14; }
            designingFeature2.GetComponent<Image>().sprite = Feature1;
            WhoIsWorking_2nd(selected_staff);
            designingFeature2.SetActive(true);
            designer2nd.SetActive(true);
            featureTimer2.text = time_feature2_Design + "hrs";
            vacant_feature2_Design = false;
        }
    }
    public void Select_f1t3()
    {
        f1t3.SetActive(false);
        Tasks_Feature1.Remove(3);
        feature_feature1__Design_Working=1;
        //designingFeature.GetComponent<Image>().sprite = designFeature1;
        if (vacant_feature1_Design)
        {//time_feature1_Design = 5;
            feature_feature1__Design_Working=1;
            if (selected_staff == 1) { time_feature1_Design = 5; }
            else if (selected_staff == 2) { time_feature1_Design = 2; }
            else { time_feature1_Design = 10; }
            designingFeature.GetComponent<Image>().sprite = Feature1;
            WhoIsWorking(selected_staff);
            designingFeature.SetActive(true);
            designer.SetActive(true);
            featureTimer.text = time_feature1_Design + "hrs";
            vacant_feature1_Design = false;
        }
        else
        {
            feature_feature2__Design_Working=1;
            if (selected_staff == 1) { time_feature2_Design = 5; }
            else if (selected_staff == 2) { time_feature2_Design = 2; }
            else { time_feature2_Design = 10; }
            WhoIsWorking_2nd(selected_staff);
            designingFeature2.GetComponent<Image>().sprite = Feature1;
            designingFeature2.SetActive(true);
            designer2nd.SetActive(true);
            featureTimer2.text = time_feature2_Design + "hrs";
            vacant_feature2_Design = false;
        }
    }
    public void Select_f2t1()
    {
        f2t1.SetActive(false);
        Tasks_Feature2.Remove(1);
        //feature_feature1__Design_Working=2;
        //designingFeature.GetComponent<Image>().sprite = designFeature2;
        if (vacant_feature1_Design)
        {
            feature_feature1__Design_Working=2;
            if (selected_staff == 1) { time_feature1_Design = 8; }
            else if (selected_staff == 2) { time_feature1_Design = 5; }
            else { time_feature1_Design = 16; }
            designingFeature.GetComponent<Image>().sprite = Feature2;
            designingFeature.SetActive(true);
            designer.SetActive(true);
            WhoIsWorking(selected_staff);
            featureTimer.text = time_feature1_Design + "hrs";
            vacant_feature1_Design = false;

        }
        else
        {
            feature_feature2__Design_Working=2;
            if (selected_staff == 1) { time_feature2_Design = 8; }
            else if (selected_staff == 2) { time_feature2_Design = 5; }
            else { time_feature2_Design = 16; }
            designingFeature2.GetComponent<Image>().sprite = Feature2;
            designingFeature2.SetActive(true);
            designer2nd.SetActive(true);
            WhoIsWorking_2nd(selected_staff);
            featureTimer2.text = time_feature2_Design + "hrs";
            vacant_feature2_Design = false;
        }
    }
    public void Select_f2t2()
    {
        f2t2.SetActive(false);
        Tasks_Feature2.Remove(2);
        //feature_feature1__Design_Working=2;
        //designingFeature.GetComponent<Image>().sprite = designFeature2;
        if (vacant_feature1_Design)
        {
            //time_feature1_Design = 7;
            feature_feature1__Design_Working=2;
            if (selected_staff == 1) { time_feature1_Design = 7; }
            else if (selected_staff == 2) { time_feature1_Design = 4; }
            else { time_feature1_Design = 14; }
            designingFeature.GetComponent<Image>().sprite = Feature2;
            WhoIsWorking(selected_staff);
            designingFeature.SetActive(true);
            designer.SetActive(true);
            featureTimer.text = time_feature1_Design + "hrs";
            vacant_feature1_Design = false;
        }
        else
        {
            feature_feature2__Design_Working=2;
            if (selected_staff == 1) { time_feature2_Design = 7; }
            else if (selected_staff == 2) { time_feature2_Design = 4; }
            else { time_feature2_Design = 14; }
            WhoIsWorking_2nd(selected_staff);
            designingFeature2.GetComponent<Image>().sprite = Feature2;
            designingFeature2.SetActive(true);
            designer2nd.SetActive(true);
            featureTimer2.text = time_feature2_Design + "hrs";
            vacant_feature2_Design = false;
        }
    }
    public void Select_f2t3()
    {
        f2t3.SetActive(false);
        Tasks_Feature2.Remove(3);
        //designingFeature.GetComponent<Image>().sprite = designFeature2;
        if (vacant_feature1_Design)
        {//time_feature1_Design = 5;
            feature_feature1__Design_Working=2;
            if (selected_staff == 1) { time_feature1_Design = 5; }
            else if (selected_staff == 2) { time_feature1_Design = 2; }
            else { time_feature1_Design = 10; }
            designingFeature.GetComponent<Image>().sprite = Feature2;
            WhoIsWorking(selected_staff);
            designingFeature.SetActive(true);
            designer.SetActive(true);
            featureTimer.text = time_feature1_Design + "hrs";
            vacant_feature1_Design = false;
        }
        else
        {
            feature_feature2__Design_Working=2;
            if (selected_staff == 1) { time_feature2_Design = 5; }
            else if (selected_staff == 2) { time_feature2_Design = 2; }
            else { time_feature2_Design = 10; }
            designingFeature2.GetComponent<Image>().sprite = Feature2;
            WhoIsWorking_2nd(selected_staff);
            designingFeature2.SetActive(true);
            designer2nd.SetActive(true);
            featureTimer2.text = time_feature2_Design + "hrs";
            vacant_feature2_Design = false;
        }
    }

    public void Select_Feature_Program()
    {
        if (vacant_feature1_Program)
        {
            

            selectDesign = true;
            time_feature1_Program = 10;
            ProgramTimer.text = time_feature1_Program + "hrs";
            if (selected_staff == 3) { staff_feature1_Program = 3; }
            else if (selected_staff == 4) { staff_feature1_Program = 4; }
            else if (selected_staff == 5) { staff_feature1_Program = 5; }
            else if (selected_staff == 6) { staff_feature1_Program = 6; }
            HideUsableStaff(staff_feature1_Program);
            WhoIsWorking(staff_feature1_Program);
            usableStaff.Remove(staff_feature1_Program);
            if(feature_feature1__Design_Working==1){
                 ProgramingFeature.GetComponent<Image>().sprite = Feature1;
            }
            if(feature_feature1__Design_Working==2){
                 ProgramingFeature.GetComponent<Image>().sprite = Feature2;
            }
            designingFeature.SetActive(false);
            ProgramingFeature.SetActive(true);
            vacant_feature1_Design = true;
            vacant_feature1_Program = false;
        }
        else
        {
            selectDesign = true;
            time_feature2_Program = 10;
            ProgramTimer2.text = time_feature2_Program + "hrs";
            if (selected_staff == 3) { staff_feature2_Program = 3; }
            else if (selected_staff == 4) { staff_feature2_Program = 4; }
            else if (selected_staff == 5) { staff_feature2_Program = 5; }
            else if (selected_staff == 6) { staff_feature2_Program = 6; }
            HideUsableStaff(staff_feature2_Program);
            WhoIsWorking_2nd(staff_feature2_Program);
            usableStaff.Remove(staff_feature2_Program);
            if(feature_feature1__Design_Working==1){
                 ProgramingFeature2.GetComponent<Image>().sprite = Feature1;
            }
            if(feature_feature1__Design_Working==2){
                 ProgramingFeature2.GetComponent<Image>().sprite = Feature2;
            }
            designingFeature.SetActive(false);
            ProgramingFeature2.SetActive(true);
            vacant_feature1_Design = true;
            vacant_feature2_Program = false;
        }

    }
    public void Select_Feature2_Program()
    {
        if (vacant_feature1_Program)
        {
            selectDesign = true;
            time_feature1_Program = 10;
            ProgramTimer.text = time_feature1_Program + "hrs";
            if (selected_staff == 3) { staff_feature1_Program = 3; }
            else if (selected_staff == 4) { staff_feature1_Program = 4; }
            else if (selected_staff == 5) { staff_feature1_Program = 5; }
            else if (selected_staff == 6) { staff_feature1_Program = 6; }
            if(feature_feature2__Design_Working==1){
                 ProgramingFeature.GetComponent<Image>().sprite = Feature1;
            }
            if(feature_feature2__Design_Working==2){
                 ProgramingFeature.GetComponent<Image>().sprite = Feature2;
            }
            HideUsableStaff(staff_feature1_Program);
            WhoIsWorking(staff_feature1_Program);
            usableStaff.Remove(staff_feature1_Program);
            designingFeature2.SetActive(false);
            ProgramingFeature.SetActive(true);
            vacant_feature2_Design = true;
            vacant_feature1_Program = false;
        }
        else
        {
            selectDesign = true;
            time_feature2_Program = 10;
            ProgramTimer2.text = time_feature2_Program + "hrs";
            if (selected_staff == 3) { staff_feature2_Program = 3; }
            else if (selected_staff == 4) { staff_feature2_Program = 4; }
            else if (selected_staff == 5) { staff_feature2_Program = 5; }
            else if (selected_staff == 6) { staff_feature2_Program = 6; }
            if(feature_feature2__Design_Working==1){
                 ProgramingFeature2.GetComponent<Image>().sprite = Feature1;
            }
            if(feature_feature2__Design_Working==2){
                 ProgramingFeature2.GetComponent<Image>().sprite = Feature2;
            }
            HideUsableStaff(staff_feature2_Program);
            WhoIsWorking_2nd(staff_feature2_Program);
            usableStaff.Remove(staff_feature2_Program);
            designingFeature2.SetActive(false);
            ProgramingFeature2.SetActive(true);
            vacant_feature2_Design = true;
            vacant_feature2_Program = false;
        }
    }
    public void Select_Feature_Test()
    {
        if (vacant_feature1_Test)
        {
            selectTest = true;
            time_feature1_Test = 5;
            TestTimer.text = time_feature1_Test + "hrs";
            WLFeature.SetActive(false);
            TestingFeature.SetActive(true);
            if (selected_staff == 7) { staff_feature1_Test = 7; }
            else if (selected_staff == 8) { staff_feature1_Test = 8; }
            HideUsableStaff(staff_feature1_Test);
            usableStaff.Remove(staff_feature1_Test);
            WhoIsWorking(staff_feature1_Test);
            tester.SetActive(true);
            vacant_feature1_Test = false;
        }
        else
        {
            selectTest = true;
            time_feature2_Test = 5;
            TestTimer2.text = time_feature2_Test + "hrs";
            WLFeature.SetActive(false);
            TestingFeature2.SetActive(true);
            if (selected_staff == 7) { staff_feature2_Test = 7; }
            else if (selected_staff == 8) { staff_feature2_Test = 8; }
            HideUsableStaff(staff_feature2_Test);
            usableStaff.Remove(staff_feature2_Test);
            WhoIsWorking_2nd(staff_feature2_Test);
            tester2nd.SetActive(true);
            vacant_feature2_Test = false;
        }
    }
    public void Select_Feature2_Test()
    {
        if (vacant_feature1_Test)
        {
            selectTest = true;
            time_feature1_Test = 5;
            TestTimer.text = time_feature1_Test + "hrs";
            WLFeature2.SetActive(false);
            TestingFeature.SetActive(true);
            if (selected_staff == 7) { staff_feature1_Test = 7; }
            else if (selected_staff == 8) { staff_feature1_Test = 8; }
            HideUsableStaff(staff_feature1_Test);
            usableStaff.Remove(staff_feature1_Test);
            WhoIsWorking(staff_feature1_Test);
            tester.SetActive(true);
            vacant_feature1_Test = false;
        }
        else
        {
            selectTest = true;
            time_feature2_Test = 5;
            TestTimer2.text = time_feature2_Test + "hrs";
            WLFeature2.SetActive(false);
            TestingFeature2.SetActive(true);
            if (selected_staff == 7) { staff_feature2_Test = 7; }
            else if (selected_staff == 8) { staff_feature2_Test = 8; }
            HideUsableStaff(staff_feature2_Test);
            usableStaff.Remove(staff_feature2_Test);
            WhoIsWorking_2nd(staff_feature2_Test);
            tester2nd.SetActive(true);
            vacant_feature2_Test = false;
        }
    }
    public void Select_Feature3_Test()
    {
        if (vacant_feature1_Test)
        {
            selectTest = true;
            time_feature1_Test = 5;
            TestTimer.text = time_feature1_Test + "hrs";
            WLFeature3.SetActive(false);
            TestingFeature.SetActive(true);
            if (selected_staff == 7) { staff_feature1_Test = 7; }
            else if (selected_staff == 8) { staff_feature1_Test = 8; }
            HideUsableStaff(staff_feature1_Test);
            usableStaff.Remove(staff_feature1_Test);
            WhoIsWorking(staff_feature1_Test);
            tester.SetActive(true);
            vacant_feature1_Test = false;
        }
        else
        {
            selectTest = true;
            time_feature2_Test = 5;
            TestTimer2.text = time_feature2_Test + "hrs";
            WLFeature3.SetActive(false);
            TestingFeature2.SetActive(true);
            if (selected_staff == 7) { staff_feature2_Test = 7; }
            else if (selected_staff == 8) { staff_feature2_Test = 8; }
            HideUsableStaff(staff_feature2_Test);
            usableStaff.Remove(staff_feature2_Test);
            WhoIsWorking_2nd(staff_feature2_Test);
            tester2nd.SetActive(true);
            vacant_feature2_Test = false;
        }
    }
    public void Select_Feature4_Test()
    {
        if (vacant_feature1_Test)
        {
            selectTest = true;
            time_feature1_Test = 5;
            TestTimer.text = time_feature1_Test + "hrs";
            WLFeature4.SetActive(false);
            TestingFeature.SetActive(true);
            if (selected_staff == 7) { staff_feature1_Test = 7; }
            else if (selected_staff == 8) { staff_feature1_Test = 8; }
            HideUsableStaff(staff_feature1_Test);
            usableStaff.Remove(staff_feature1_Test);
            WhoIsWorking(staff_feature1_Test);
            tester.SetActive(true);
            vacant_feature1_Test = false;
        }
        else
        {
            selectTest = true;
            time_feature2_Test = 5;
            TestTimer2.text = time_feature2_Test + "hrs";
            WLFeature4.SetActive(false);
            TestingFeature2.SetActive(true);
            if (selected_staff == 7) { staff_feature2_Test = 7; }
            else if (selected_staff == 8) { staff_feature2_Test = 8; }
            HideUsableStaff(staff_feature2_Test);
            usableStaff.Remove(staff_feature2_Test);
            WhoIsWorking_2nd(staff_feature2_Test);
            tester2nd.SetActive(true);
            vacant_feature2_Test = false;
        }
    }
    public void Select_Feature5_Test()
    {
        if (vacant_feature1_Test)
        {
            selectTest = true;
            time_feature1_Test = 5;
            TestTimer.text = time_feature1_Test + "hrs";
            WLFeature5.SetActive(false);
            TestingFeature.SetActive(true);
            if (selected_staff == 7) { staff_feature1_Test = 7; }
            else if (selected_staff == 8) { staff_feature1_Test = 8; }
            HideUsableStaff(staff_feature1_Test);
            usableStaff.Remove(staff_feature1_Test);
            WhoIsWorking(staff_feature1_Test);
            tester.SetActive(true);
            vacant_feature1_Test = false;
        }
        else
        {
            selectTest = true;
            time_feature2_Test = 5;
            TestTimer2.text = time_feature2_Test + "hrs";
            WLFeature5.SetActive(false);
            TestingFeature2.SetActive(true);
            if (selected_staff == 7) { staff_feature2_Test = 7; }
            else if (selected_staff == 8) { staff_feature2_Test = 8; }
            HideUsableStaff(staff_feature2_Test);
            usableStaff.Remove(staff_feature2_Test);
            WhoIsWorking_2nd(staff_feature2_Test);
            tester2nd.SetActive(true);
            vacant_feature2_Test = false;
        }
    }
    public void Select_error_Test()
    {
        if (vacant_feature1_Test)
        {
            selectTest = true;
            time_feature1_Test = 5;
            TestTimer.text = time_feature1_Test + "hrs";
            WLError.SetActive(false);
            TestingFeature.SetActive(true);
            if (selected_staff == 7) { staff_feature1_Test = 7; }
            else if (selected_staff == 8) { staff_feature1_Test = 8; }
            HideUsableStaff(staff_feature1_Test);
            usableStaff.Remove(staff_feature1_Test);
            WhoIsWorking(staff_feature1_Test);
            tester.SetActive(true);
            vacant_feature1_Test = false;
        }
        else
        {
            selectTest = true;
            time_feature2_Test = 5;
            TestTimer2.text = time_feature2_Test + "hrs";
            WLError.SetActive(false);
            TestingFeature2.SetActive(true);
            if (selected_staff == 7) { staff_feature2_Test = 7; }
            else if (selected_staff == 8) { staff_feature2_Test = 8; }
            HideUsableStaff(staff_feature2_Test);
            usableStaff.Remove(staff_feature2_Test);
            WhoIsWorking_2nd(staff_feature2_Test);
            tester2nd.SetActive(true);
            vacant_feature2_Test = false;
        }
    }


    public void Select_Feature_Deploy()
    {
        if (vacant_feature1_Deploy)
        {
            selectDeploy = true;
            time_feature1_Deploy = 3;
            DeployTimer.text = time_feature1_Deploy + "hrs";
            if (selected_staff == 9) { staff_feature1_Deploy = 9; }
            else if (selected_staff == 10) { staff_feature1_Deploy = 10; }
            HideUsableStaff(staff_feature1_Deploy);
            WhoIsWorking(selected_staff);
            usableStaff.Remove(staff_feature1_Deploy);
            deployer.SetActive(true);
            TestingFeature.SetActive(false);
            DeployingFeature.SetActive(true);
        }
        else
        {
            selectDeploy = true;
            time_feature2_Deploy = 3;
            DeployTimer2.text = time_feature2_Deploy + "hrs";
            if (selected_staff == 9) { staff_feature2_Deploy = 9; }
            else if (selected_staff == 10) { staff_feature2_Deploy = 10; }
            HideUsableStaff(staff_feature2_Deploy);
            WhoIsWorking(selected_staff);
            usableStaff.Remove(staff_feature2_Deploy);
            deployer2nd.SetActive(true);
            TestingFeature.SetActive(false);
            DeployingFeature2.SetActive(true);
        }

    }

    public void Select_Feature2_Deploy()
    {
        if (vacant_feature1_Deploy)
        {
            selectDeploy = true;
            time_feature1_Deploy = 3;
            DeployTimer.text = time_feature1_Deploy + "hrs";
            if (selected_staff == 9) { staff_feature1_Deploy = 9; }
            else if (selected_staff == 10) { staff_feature1_Deploy = 10; }
            HideUsableStaff(staff_feature1_Deploy);
            WhoIsWorking(selected_staff);
            usableStaff.Remove(staff_feature1_Deploy);
            deployer.SetActive(true);
            TestingFeature2.SetActive(false);
            DeployingFeature.SetActive(true);
        }
        else
        {
            selectDeploy = true;
            time_feature2_Deploy = 3;
            DeployTimer2.text = time_feature2_Deploy + "hrs";
            if (selected_staff == 9) { staff_feature2_Deploy = 9; }
            else if (selected_staff == 10) { staff_feature2_Deploy = 10; }
            HideUsableStaff(staff_feature2_Deploy);
            WhoIsWorking(selected_staff);
            usableStaff.Remove(staff_feature2_Deploy);
            deployer2nd.SetActive(true);
            TestingFeature2.SetActive(false);
            DeployingFeature2.SetActive(true);
        }

    }


    void Designing_Feature()
    {
        //      if((selectDesigner1||selectDesigner2) && selectFeature)
        {

            time_feature1_Design -= 1;
            featureTimer.text = time_feature1_Design + "hrs";
            time_feature2_Design -= 1;
            featureTimer2.text = time_feature2_Design + "hrs";

            if (time_feature1_Design == 0)
            {
                designer.SetActive(false);
                if (staff_feature1_Design == 1) { ShowUsableStaff(1); usableStaff.Add(1); }
                if (staff_feature1_Design == 2) { ShowUsableStaff(2); usableStaff.Add(2); }
                featureTimer.text = "";
                selectFeature = false;
                //designingFeature.SetActive(false);
                //CancelInvoke("Designing_Feature");
            }
            if (time_feature1_Design <= 0)
            {
                featureTimer.text = "";
                if (staff_feature1_Design == 1) { ShowUsableStaff(1); usableStaff.Add(1); }
                if (staff_feature1_Design == 2) { ShowUsableStaff(2); usableStaff.Add(2); }
            }
            if (time_feature2_Design == 0)
            {
                designer2nd.SetActive(false);
                if (staff_feature2_Design == 1) { ShowUsableStaff(1); usableStaff.Add(1); }
                if (staff_feature2_Design == 2) { ShowUsableStaff(2); usableStaff.Add(2); }
                featureTimer2.text = "";
                selectFeature = false;
                //designingFeature.SetActive(false);
                //CancelInvoke("Designing_Feature");
            }
            if (time_feature2_Design <= 0)
            {
                featureTimer2.text = "";
                if (staff_feature2_Design == 1) { ShowUsableStaff(1); usableStaff.Add(1); }
                if (staff_feature2_Design == 2) { ShowUsableStaff(2); usableStaff.Add(2); }
            }
        }
    }
    void Programming_Feature()
    {
        //     if((selectProgrammer1|| selectProgrammer2|| selectProgrammer3|| selectProgrammer4) &&selectDesign)
        {
            time_feature1_Program -= 1;
            ProgramTimer.text = time_feature1_Program + "hrs";
            time_feature2_Program -= 1;
            ProgramTimer2.text = time_feature2_Program + "hrs";
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
                if (staff_feature1_Program == 3) { ShowUsableStaff(3); usableStaff.Add(3); }
                if (staff_feature1_Program == 4) { ShowUsableStaff(4); usableStaff.Add(4); }
                if (staff_feature1_Program == 5) { ShowUsableStaff(5); usableStaff.Add(5); }
                if (staff_feature1_Program == 6) { ShowUsableStaff(6); usableStaff.Add(6); }
                ProgramingFeature.SetActive(false);
                vacant_feature1_Program = true;

                //CancelInvoke("Programming_Feature");
            }
            if (time_feature2_Program <= 0)
            {
                ProgramTimer2.text = "";
            }
            if (time_feature2_Program == 0)
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
                if (staff_feature2_Program == 3) { ShowUsableStaff(3); usableStaff.Add(3); }
                if (staff_feature2_Program == 4) { ShowUsableStaff(4); usableStaff.Add(4); }
                if (staff_feature2_Program == 5) { ShowUsableStaff(5); usableStaff.Add(5); }
                if (staff_feature2_Program == 6) { ShowUsableStaff(6); usableStaff.Add(6); }
                ProgramingFeature2.SetActive(false);
                vacant_feature2_Program = true;

                //CancelInvoke("Programming_Feature");
            }
        }
    }

    void Testing_Feature()
        {
        //      if ((selectTester1|| selectTester2) && selectTest)

        time_feature1_Test -= 1;
        TestTimer.text = time_feature1_Test + "hrs";
        time_feature2_Test -= 1;
        TestTimer2.text = time_feature2_Test + "hrs";
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
            if (staff_feature1_Test == 7) { yan.SetActive(true); usableStaff.Add(7); }
            if (staff_feature1_Test == 8) { david.SetActive(true); usableStaff.Add(8); }
            TestTimer.text = "";
            selectTest = false;
            TestTimer.color = Color.black;

        }
        if (time_feature2_Test == 1 && haveError == true && week == 4)
        {
            time_feature1_Test = 7;
            haveError = false;
            ErrorMessage.SetActive(true);
            TestTimer2.text = time_feature2_Test + "hrs";
            TestTimer2.color = Color.red;

        }
        if (time_feature2_Test <= 0)
        {
            tester2nd.SetActive(false);
            if (staff_feature2_Test == 7) { yan.SetActive(true); usableStaff.Add(7); }
            if (staff_feature2_Test == 8) { david.SetActive(true); usableStaff.Add(8); }
            TestTimer2.text = "";
            selectTest = false;
            TestTimer2.color = Color.black;

        }

    }
    void Deploying_Feature()
        {
        //    if ((selectDeployer1|| selectDeployer2) && selectDeploy)

        time_feature1_Deploy -= 1;
        DeployTimer.text = time_feature1_Deploy + "hrs";
        time_feature2_Deploy -= 1;
        DeployTimer2.text = time_feature2_Deploy + "hrs";
        if (time_feature1_Deploy <= 0)
        {
            DeployTimer.text = "";
        }
        if (time_feature2_Deploy <= 0)
        {
            DeployTimer2.text = "";
        }
        if (time_feature1_Deploy == 0)
        {
            deployer.SetActive(false);
            if (staff_feature1_Deploy == 9) { alex.SetActive(true); usableStaff.Add(9); }
            if (staff_feature1_Deploy == 10) { aaron.SetActive(true); usableStaff.Add(10); }
            DeployTimer.text = "";
            DeployingFeature.SetActive(false);
            FinishFeature1.SetActive(true);
            selectDeploy = false;
            Feature1_Done = true;
        }
        if (time_feature2_Deploy == 0)
        {
            deployer2nd.SetActive(false);
            if (staff_feature2_Deploy == 9) { alex.SetActive(true); usableStaff.Add(9); }
            if (staff_feature2_Deploy == 10) { aaron.SetActive(true); usableStaff.Add(10); }
            DeployTimer2.text = "";
            DeployingFeature2.SetActive(false);
            FinishFeature1.SetActive(true);
            selectDeploy = false;
            Feature1_Done = true;
        }

    }

    }
