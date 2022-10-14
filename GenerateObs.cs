using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateObs : MonoBehaviour
{
    public int score = -1;
    public GameObject rocks;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating ("CreateObstacle", 1f, 1.5f);
    }

    void CreateObstacle()
    {
        Instantiate (rocks);
        score++;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnGUI()
    {
        GUI.color = Color.black;
        GUILayout.Label ("Score: " + score.ToString());
    }
}
