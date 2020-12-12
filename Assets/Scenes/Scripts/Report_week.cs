using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using TMPro;
public class Report_week : MonoBehaviour
{
    public TMP_Text report_week;
    public TMP_Text comment_text;
    public TMP_Text currentBalance;
    int week;
    int capital;
    // Start is called before the first frame update
    void Awake()
    {
        capital=PlayerPrefs.GetInt("capital")+5000;
        currentBalance.text="Current Balance: $"+capital;
        PlayerPrefs.SetInt("capital",capital);
        week = PlayerPrefs.GetInt("week");
        report_week.text="Week"+week+" Report";
        if(week==3){
            comment_text.text="The website responses are quite slow, and it will crash during peek hours!!\nMay be it is because there are too many users.....";
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
