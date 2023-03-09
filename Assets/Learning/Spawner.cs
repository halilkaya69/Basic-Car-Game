using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    [SerializeField]
    GameObject motorPrefab;
    
    GeriSayimSayaci geriSayimSayaci;


    // Start is called before the first frame update
    void Start()
    {
        geriSayimSayaci = gameObject.AddComponent<GeriSayimSayaci>();
        geriSayimSayaci.ToplamSure = 1;//keyfi
        geriSayimSayaci.Calistir();
    }

    // Update is called once per frame
    void Update()
    {
        if (geriSayimSayaci)
        {
            //zamaný gelince objeyi spawnla
            SpawnMotor();
            geriSayimSayaci.Calistir();

        }
    }


    void SpawnMotor()
    {
        Instantiate(motorPrefab);
    }



}


    

