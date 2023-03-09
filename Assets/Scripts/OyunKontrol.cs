using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OyunKontrol : MonoBehaviour
{
    [SerializeField]
    GameObject carPrefab;

    [SerializeField]
    List<GameObject> motorPrefabs=new List<GameObject> ();

    GameObject car;

    List<GameObject> motorList = new List<GameObject>();

    [SerializeField]
    int zorluk = 1;
    [SerializeField]
    int carpan = 5;

    UIKontrol uikontrol;

    // Start is called before the first frame update
    void Start()
    {
        
        uikontrol = GetComponent<UIKontrol>();//ikiside main camerada olduðu için kýsa

    }
    public void OyunuBaslat()
    {
        uikontrol.OyunBasladi();
        car = Instantiate(carPrefab);
        car.transform.position = new Vector3(-EkranHesaplayici.Ust - 1.0f, 0);

        MotorUret(3);//keyfi 5
    }

    

    void MotorUret(int adet)
    {
        Vector3 position = new Vector3();
        for (int i = 0; i < adet; i++)
        {
            position.z = -Camera.main.transform.position.z;
            position = Camera.main.ScreenToWorldPoint(position);
            position.x =EkranHesaplayici.Sag - 1;
            position.y = Random.Range(EkranHesaplayici.Alt, EkranHesaplayici.Ust);

            GameObject motor = Instantiate(motorPrefabs[Random.Range(0,3)],position,Quaternion.identity);//çünkü 3 motor var
            motorList.Add(motor);
        }
    }

    public void MotorYokOldu(GameObject motor)
    {
        uikontrol.MotorYokOldu(motor);
        motorList.Remove(motor);
        if(motorList.Count <=zorluk)
        {
            zorluk++;
            MotorUret(zorluk * carpan);
        }
    }

    public void OyunBitir()
    {
        foreach (GameObject motor in motorList)
        {
            motor.GetComponent<Motor>().MotorYokEt();
        }
        motorList.Clear();
        zorluk= 1;//baþtakine döndürdük
        uikontrol.OyunBitti();
    }

}
