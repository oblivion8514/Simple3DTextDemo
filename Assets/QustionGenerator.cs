using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QustionGenerator : MonoBehaviour {
    char op;
    public int a=0;
    public int b=0;
    public int sol=0;
    public GameObject question;
    public GameObject option1;
    public GameObject option2;

	// Use this for initialization
	void Start () {
        Random.InitState((int)System.DateTime.Now.Ticks);
        GenerateQuestion();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void GenerateQuestion()
    {
        a = Random.Range(0, 100);
        b = Random.Range(0, 100);
        int r= Random.Range(0,3);
        
        if (r == 1)
        {
            op = '+';
            sol = a + b;
        }
        else if (r == 2)
        {
            op = '-';
            sol = a - b;
        }
        else//else if r==3:
        {
            op = '*';
            sol = a * b;
        }
        question.GetComponent<TextMesh>().text = a.ToString() + op + b.ToString() + " =?";
        r = Random.Range(0, 2);
        if (r == 0)//let option1 is correct answer
        {
            option1.GetComponent<TextMesh>().text = sol.ToString();
            option1.GetComponent<Onclick>().isCorrect = true;
            option2.GetComponent<TextMesh>().text = (sol+ 2 * Random.Range(0, 2) - 1).ToString();
            option2.GetComponent<Onclick>().isCorrect = false;
        }
        else
        {
            option1.GetComponent<TextMesh>().text = (sol + 2 * Random.Range(0, 2) - 1).ToString();
            option1.GetComponent<Onclick>().isCorrect = false;
            option2.GetComponent<TextMesh>().text = sol.ToString();
            option2.GetComponent<Onclick>().isCorrect = true;
        }
        option1.AddComponent<BoxCollider>();
        //option1.GetComponent<BoxCollider>().isTrigger =true;
        option2.AddComponent<BoxCollider>();
        //option2.GetComponent<BoxCollider>().isTrigger = true;
    }
}
