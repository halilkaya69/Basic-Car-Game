using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Toplayici : MonoBehaviour
{
    [SerializeField]
    GameObject yildizPrefab;
    List<GameObject> yildizlar =new List<GameObject> ();

    /// <summary>
    /// hedefteki yýldýzlari söyler
    /// </summary>
    public GameObject HedefYildiz
    {
        get
        {
            if (yildizlar.Count > 0)
            {
                return yildizlar[0];
            }
            else
            {
                return null;
            }
        }
    }

    // Start is called before the first frame update
    //void Start()
    //{
        
    //}

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            Vector3 position =Input.mousePosition; ;
            position.z=-Camera.main.transform.position.z;
            Vector3 oyunDunyasiPosition = Camera.main.ScreenToWorldPoint(position);
            yildizlar.Add(Instantiate(yildizPrefab, oyunDunyasiPosition,Quaternion.identity));
        }


    }
    /// <summary>
    /// parametre olarak gönderilen yýldýzý yok eder
    /// </summary>
    /// <param name="yokEdilecekYildiz"></param>
    public void YildizYokEt(GameObject yokEdilecekYildiz)
    {
        yildizlar.Remove(yokEdilecekYildiz);
        Destroy(yokEdilecekYildiz);
    }


}
