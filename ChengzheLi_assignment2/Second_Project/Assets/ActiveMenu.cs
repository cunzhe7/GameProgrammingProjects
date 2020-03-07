using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveMenu : MonoBehaviour {


    public GameObject canavas;
    public Camera cam1, cam2,currCam;
    public GameObject ball1, ball2;
    public Vector3 position;

	// Use this for initialization
	void Start () {
        currCam = Camera.main;
        cam2.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown("escape"))
        {
            if (!canavas.activeSelf)
            {
                canavas.SetActive(true);
                ball1.SetActive(false);
                ball2.SetActive(false);
            }
        }
        if (Input.GetKeyDown("space"))
        {
            if (canavas.activeSelf == false)
            {
                if (cam1.enabled == true)
                {
                    cam1.enabled = false;
                    cam2.enabled = true;
                    currCam = cam2;
                }
                else
                {
                    cam2.enabled = false;
                    cam1.enabled = true;
                    currCam = cam1;
                }
            }
            
        }


        if (ball2.activeSelf)
        {
            position = currCam.ScreenToWorldPoint(Input.mousePosition + new Vector3(0,0,452));
            if(position.y <= 75)
            {
                ball2.transform.localScale = new Vector3(100,position.y+25,100);
                ball2.transform.position = new Vector3(ball2.transform.position.x, 75, ball2.transform.position.z);
            }

            ball2.transform.position = position;
            //Debug.Log(position);
        }
	}
}
