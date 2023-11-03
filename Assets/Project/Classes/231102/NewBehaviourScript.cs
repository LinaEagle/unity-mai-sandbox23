using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public Camera Camera;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        other.gameObject.name.Contains("");
        //other.gameObject.tag.Equals();
        other.transform.gameObject.GetComponent<Damageable>();
    }
}

public class Damageable : MonoBehaviour
{
    
}
