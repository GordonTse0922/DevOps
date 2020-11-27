using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using TMPro;
public class Report_week : MonoBehaviour
{
    public TMP_Text report_week;
    int week;
    // Start is called before the first frame update
    void Start()
    {
        week = PlayerPrefs.GetInt("week");
        report_week.text="Week"+week+" Report";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
