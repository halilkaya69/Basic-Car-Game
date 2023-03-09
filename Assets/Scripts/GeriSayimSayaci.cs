using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeriSayimSayaci : MonoBehaviour
{

    float toplamSure = 0;
    float gecenSure;
    bool calisiyor = false;
    bool basladi = false;

    public float ToplamSure
    {
        set
        {
            if (!calisiyor)
            {
                toplamSure = value;
            }
        }

    }

    public bool Bitti
    {
        get
        {
            return basladi && !calisiyor;
        }
    }

    public void Calistir()
    {
        if (toplamSure > 0)
        {
            calisiyor = true;
            basladi = true;
            gecenSure = 0;
        }
    }


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (calisiyor)
        {
            gecenSure += Time.deltaTime;
            if (gecenSure >= toplamSure)
            {
                calisiyor = false;
            }
        }



    }
}
