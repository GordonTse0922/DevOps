using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using TMPro;
public class Report_week : MonoBehaviour
{
    public TMP_Text report_week;
    public TMP_Text comment_text;
    int week;
    // Start is called before the first frame update
    void Start()
    {
        week = PlayerPrefs.GetInt("week");
        report_week.text="Week"+week+" Report";
        if(week==3){
            comment_text.text="The website responses are quite slow, and it will crash during peek hours!!\nMay be it is because there are too many users.....";
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
