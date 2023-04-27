using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chiz : MonoBehaviour
{
    public GameObject yaroo;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("create",1f,2f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator wait()
    {
        yield return new WaitForSeconds(10f);
    }

    void create()
    {
        StartCoroutine(wait());
        Instantiate(yaroo,this.transform.position,this.transform.rotation);
    }
}
