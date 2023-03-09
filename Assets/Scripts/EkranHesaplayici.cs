using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class EkranHesaplayici 
{
    static float sol;
    static float sag;
    static float ust;
    static float alt;

    /// <summary>
    /// sol ekranýn koordinatlarýný verir
    /// </summary>
    public static float Sol
    {
        get { return sol; }
    }

    /// <summary>
    /// sað ekranýn koordinatlarýný verir
    /// </summary>
    public static float Sag
    {
        get { return sag; }
    }

    /// <summary>
    /// ust ekranýn koordinatlarýný verir
    /// </summary>
    public static float Ust
    {
        get { return ust; }
    }

    /// <summary>
    /// alt ekranýn koordinatlarýný verir
    /// </summary>
    public static float Alt
    {
        get { return alt; }
    }

    public static void Init()
    {
        float ekranZekseni=-Camera.main.transform.position.z;
        Vector3 solALtKose =new Vector3(0,0,ekranZekseni);
        Vector3 sagUstKose =new Vector3(Screen.width,Screen.height,ekranZekseni);

        Vector3 solAltKoseOyunDunyasi = Camera.main.ScreenToWorldPoint(solALtKose);
        Vector3 sagUstKoseOyunDunyasi = Camera.main.ScreenToWorldPoint(sagUstKose);

        sol=solAltKoseOyunDunyasi.x;
        sag = sagUstKoseOyunDunyasi.x;
        alt = solAltKoseOyunDunyasi.y;
        ust = sagUstKoseOyunDunyasi.y;


    }
}
