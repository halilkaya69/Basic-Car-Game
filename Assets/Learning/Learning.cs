using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Learning : MonoBehaviour
{



    // Start is called before the first frame update
    void Start()
    {
        Car mycar1 = new Car(Random.Range(10, 20));
        Car mycar2 = new Car(Random.Range(10, 20), "Mavi");

        mycar1.Yavaslatici();
        mycar2.Yavaslatici();


        if (mycar1.MaxHiz > mycar2.MaxHiz)
        {
            Debug.Log("kazanan 1");
        }
        else if (mycar1.MaxHiz < mycar2.MaxHiz)
        {
            Debug.Log("kazanan 2");
        }
        else
        {
            Debug.Log("berabere");
        }


        //int saldiranDusman = 10;
        //bool saldiriDevam = true;


        //while(saldiriDevam)
        //{
        //    saldiranDusman--;
        //    if (saldiranDusman < 3)
        //    {
        //        saldiriDevam = false;  
        //    }
        //    Debug.Log("saldiri altýndasýn düþman:" + saldiranDusman);
        //}

        //do
        //{
        //    saldiranDusman--;
        //    if (saldiranDusman < 3)
        //    {
        //        saldiriDevam = false;
        //    }
        //    Debug.Log("saldiri altýndasýn düþman:" + saldiranDusman);
        //} while (saldiriDevam);




        //int n = 10;
        //if (n > 20 && n <= 30)
        //{
        //    Debug.Log("First phase");
        //}
        //else if (n>30&&n<=99)
        //{
        //    Debug.Log("second phase");
        //}
        //else if(n>100 &&n!=150)
        //{
        //    Debug.Log("third phase");
        //}
        //else
        //{
        //    Debug.Log("NO one");
        //}


        //switch (n)
        //{
        //    case 1:
        //        Debug.Log("first");
        //        break;
        //        case 2:
        //        Debug.Log("second");
        //        break;
        //    default:
        //        Debug.Log("sorry");
        //        break;

        //}

    }

    // Update is called once per frame
    void Update()
    {

    }
}
