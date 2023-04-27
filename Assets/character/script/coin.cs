using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour
{
    public float turnspeed = 90f;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<obstacle>() != null)
        {
            Destroy(gameObject);
            return;
        }


        //check that the object we collied is player

        if(other.gameObject.name !="player")
        {
            return;
        }
        //add score
        //Gamemanager.inst.IncremenentScore();



        Destroy(gameObject);

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, turnspeed * Time.deltaTime);
    }
}
