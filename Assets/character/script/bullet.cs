using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public GameObject blood;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject,7f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(-0.08f,0f,0f);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "enesy")
        {
            Instantiate(blood,this.transform.position,this.transform.rotation);
        }
        Destroy(this.gameObject);
    }
}
