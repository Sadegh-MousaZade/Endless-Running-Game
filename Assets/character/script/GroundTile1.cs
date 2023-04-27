using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundTile1 : MonoBehaviour
{
    groundsspan groundsspawner;
    // Start is called before the first frame update
    private void Start()
    {
        groundsspawner=GameObject.FindObjectOfType<groundsspan>();
        spawnobstacle();
        spawncoins();
    }
    private void onTriggerexit(Collider other)
    {
        groundsspawner.spawnTile();
        Destroy(gameObject,2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public GameObject obstaclefab;

    public void spawnobstacle ()
    {
        // random point
        int obstaclespawnindex = Random.Range(2,5);
        Transform spawnpoint=transform.GetChild(obstaclespawnindex).transform ;

        //spawn the obtace
        Instantiate(obstaclefab, spawnpoint.position, Quaternion.identity, transform);
        
    }
    public GameObject coinfab;

    void spawncoins()
    {
        int coinTospawn = 10;
        for (int i=0;i<coinTospawn;i++)
        {
            GameObject temp = Instantiate(coinfab,transform);
            temp.transform.position = GetRandomPointcollider(GetComponent<Collider>());

        }
    }
    Vector3 GetRandomPointcollider(Collider collider)
    {
        Vector3 point = new Vector3
            (Random.Range(collider.bounds.min.x, collider.bounds.max.x),
            Random.Range(collider.bounds.min.y, collider.bounds.max.y),
            Random.Range(collider.bounds.min.z, collider.bounds.max.z));
        if(point != collider.ClosestPoint(point))
        {
            point = GetRandomPointcollider(collider);
        }

        point.y = 1;
        return point;
    }

}
