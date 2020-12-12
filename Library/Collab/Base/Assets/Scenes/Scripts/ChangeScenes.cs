using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEditor;

public class ChangeScenes : MonoBehaviour {
    
    public static int counter;
    public static int selected=0;

    public void GoToHomePage() {
        SceneManager.LoadScene(0);
    }

    public void GoToInstruction() {
        PlayerPrefs.DeleteAll();
        SceneManager.LoadScene(1);
    }

    public void GoToTutorial() {
        SceneManager.LoadScene(2);
    }

    public void GoToSelectStaff() {
        SceneManager.LoadScene(3);
    }

    public void GoToIntroduceDepolyment() {
        SceneManager.LoadScene(4);
    }

    public void GoToBigBangIntro(){
        counter++;
        SceneManager.LoadScene(5);
    }

    public void GoToCanaryInro(){
        counter++;
        SceneManager.LoadScene(6);
    }
    public void GoToBlueGreenInro(){
        counter++;
        SceneManager.LoadScene(7);
    }

    public void GoToDeployScene(){
        SceneManager.LoadScene(8);
    }

    public void GoToTasks(){
        SceneManager.LoadScene(9);
    }
    public void GoToTasks_2(){
        SceneManager.LoadScene(16);
    }
    public void GoToGame(){
        SceneManager.LoadScene(10);
    }
    public void GoToReport_1(){
        SceneManager.LoadScene(11);
    }
    public void GoToReport_2(){
        SceneManager.LoadScene(12);
    }
    public void GoToReport_3(){
        SceneManager.LoadScene(13);
    }

    public void GoToFinalReport(){
        int cur=PlayerPrefs.GetInt("week");
        if(cur>=2){
            SceneManager.LoadScene(14);
        }
        else{
            SceneManager.LoadScene(10);
        }
    }
    public void GoToFinalReport_2(){
        SceneManager.LoadScene(15);
    }
    
    public void SelectedBigBang(){
        selected=1;
    }
    public void SelectedCanary(){
        selected=2;
    }
    public void SelectedBlueGreen(){
        selected=3;
    }

    public void Quit() {
        Debug.Log("Quit");
        Application.Quit();
    }

}
