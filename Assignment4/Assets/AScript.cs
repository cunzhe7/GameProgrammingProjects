using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AScript : MonoBehaviour {

    Animator Controller;
    public GameObject Constructor;
    
	// Use this for initialization
	void Start () {
        Controller = GetComponent<Animator>();
        
	}
	
	// Update is called once per frame
	void Update () {
        Controller.SetBool("isWalking", Input.GetKey("w"));
        if(Input.GetKey("space") && Constructor.transform.position.y == 0)
        {
            Controller.SetBool("jump", true);
            StartCoroutine(Jump());
        }
        else
        {
            Controller.SetBool("jump", false);
        }
        Controller.SetBool("isRunning", Input.GetKey("left shift"));
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        if (z < 0)
            z = 0;
        Vector3 move;
        if (Input.GetKey("left shift"))
        {
            move = transform.right * x + transform.forward * z * 2;
        }
        else
        {
            move = transform.right * x + transform.forward * z;
        }
        if (Controller.GetBool("isWalking"))
        {
            Constructor.transform.Rotate(new Vector3(0, x, 0));
            Constructor.transform.position += move * 0.01f;
        }
    }

    IEnumerator Jump()
    {
        Vector3 pos = Constructor.transform.position;
        for (float k = 0; k < 0.2f; k+=Time.deltaTime)
        {
            pos.y += 0.1f;
            Constructor.transform.position = pos;
            yield return null;
        }
        for(float k = 0.2f; k > 0; k -= Time.deltaTime)
        {
            pos.y -= 0.1f;
            Constructor.transform.position = pos;
            yield return null;
        }
        pos.y = 0;
        Constructor.transform.position = pos;
        yield break;
    }

   
}
