using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Onclick : MonoBehaviour {
    public bool isCorrect;
	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnMouseUp()
    {
        if (isCorrect)
        {
            //播放正確音效
        }else
        {
            //播放錯誤音效
        }
        GameObject.Find("Manager").GetComponent<QustionGenerator>().GenerateQuestion();
    }
}
