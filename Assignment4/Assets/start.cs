using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class start : MonoBehaviour {
    public UnityEngine.UI.Button button;
    public GameObject canavas;
    public GameObject Constructor;
    // Use this for initialization
    void Start () {
        button.onClick.AddListener(delegate { StartGame(); });
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    void StartGame()
    {
        Constructor.SetActive(true);
        canavas.SetActive(false);
    }
}
