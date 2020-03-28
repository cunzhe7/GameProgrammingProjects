using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addForce : MonoBehaviour {
    public Rigidbody rb;
    GameObject t;
    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnMouseDown()
    {
        Color32 newcolor = new Color(Random.Range(0F, 1F), Random.Range(0, 1F), Random.Range(0, 1F));
        rb.AddForce(transform.forward * 500f);
        Material material = gameObject.GetComponent<Renderer>().material;
        material.color = newcolor;
    }
}
