using System.Collections;

using System.Collections.Generic;

using UnityEngine;

using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class ChangeDeploymentText : MonoBehaviour
{
    public TMP_Text text_ui;
    // Start is called before the first frame update
    void Awake()
    {
        int week = PlayerPrefs.GetInt("week");
        if(week>=1){
            text_ui.text="Yon can now change the deployment method for next week!!";
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
