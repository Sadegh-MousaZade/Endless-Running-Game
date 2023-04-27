using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class groundsspan : MonoBehaviour
{
    public GameObject groudTile;
    Vector3 nextspawnpoint;

    public void spawnTile()
    {
       GameObject temp= Instantiate(groudTile,nextspawnpoint,Quaternion.identity);
       nextspawnpoint=temp.transform.GetChild(1).transform.position;

    }
    
    // Start is called before the first frame update
    void Start()
    {
        for(int i=0;i<15;i++)
        {
            spawnTile();

        }

    }

}
