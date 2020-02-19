using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Scenes : MonoBehaviour {
    public Button button_1;
    public Button button_2;
    public GameObject canavas;
    public GameObject ball1;
    public GameObject ball2;

    public void ss1()
    {
        ball1.SetActive(true);
        canavas.SetActive(false);
    }

    public void ss2()
    {
        ball2.SetActive(true);
        canavas.SetActive(false);
    }

    // Use this for initialization
    void Start () {
       
    }
	
	// Update is called once per frame
	void Update () {
        button_1.onClick.AddListener(ss1);
        button_2.onClick.AddListener(ss2);
    }
}
