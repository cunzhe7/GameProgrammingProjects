using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FalseTrigger : MonoBehaviour
{
    public Light finish_zone_light;

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnTriggerEnter(Collider other)
    {
        finish_zone_light.color = Color.blue;
        Debug.Log("Game Condition Not Reached!");
    }
}