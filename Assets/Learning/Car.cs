using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    int maxHiz;
    string renk;

    public int MaxHiz { 
        get
        {
            return maxHiz;
        
        }
        set { maxHiz= value; }
    }
    public string Renk { get 
        {
            return renk;
        }
        set { renk = value; }
    }

    /// <summary>
    /// hiz ve renk
    /// </summary>
    /// <param name="maxHiz"></param>
    /// <param name="renk"></param>
    public Car(int maxHiz,string renk)//renk="default" veya iki constructor yaz�lmal�
    {
        this.maxHiz = maxHiz;
        this.renk = renk;
    }
    /// <summary>
    /// sadece hiz
    /// </summary>
    /// <param name="maxHiz"></param>
    public Car(int maxHiz)
    {
        this.maxHiz = maxHiz;
    }

    /// <summary>
    /// uzay gemisi h�zland�rma s�per g�c�(
    /// </summary>
    public void Hizlandirici()
    {
        maxHiz += Random.Range(5, 20);
        Debug.Log(maxHiz);
    }

    /// <summary>
    /// uzay gemisi yav�latma
    /// </summary>
    public void Yavaslatici()
    {
        maxHiz -= Random.Range(5, 20);
        Debug.Log(maxHiz);
    }

}
