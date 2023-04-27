using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class obstacle : MonoBehaviour
{
    movment movment;


    // Start is called before the first frame update
    void Start()
    {
        movment = GameObject.FindObjectOfType<movment>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "player")
        {
            movment.Die();
        }
        //kill player
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
