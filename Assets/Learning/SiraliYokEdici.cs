using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SiraliYokEdici : MonoBehaviour
{

    [SerializeField]
    GameObject motorPrefab;

    GameObject car;

    List<GameObject> motorList;

    GameObject hedefMotor;

    // Start is called before the first frame update
    void Start()
    {
        car = GameObject.FindGameObjectWithTag("Player");
        motorList = new List<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 position = Input.mousePosition;
            position.z =-Camera.main.transform.position.z;
            position = Camera.main.ScreenToWorldPoint(position);

            GameObject motor = Instantiate(motorPrefab, position, Quaternion.identity);
            motorList.Add(motor);
        }


        if(Input.GetMouseButtonDown(1))
        {
            HedefiYokEt();
        }
    }
    
    GameObject EnYakinMotor()
    {
        GameObject enYakinMotor;
        float enYakinMesafe;

        if(motorList.Count ==0)
        {
            return null;
        }
        else
        {
            enYakinMotor = motorList[0];
            enYakinMesafe = MesafeOlcer(enYakinMotor);
        }

        foreach(GameObject motor in motorList)
        {
            float mesafe = MesafeOlcer(motor);
            if(mesafe<enYakinMesafe)
            {
                enYakinMesafe-= mesafe;
                enYakinMotor=motor;
            }
        }
        return enYakinMotor;
    }

    public void HedefiYokEt()
    {
        hedefMotor=EnYakinMotor();
        if(hedefMotor!=null)
        {
            hedefMotor.GetComponent<YokEdici>().MotorYokEdici(1);
            motorList.Remove(hedefMotor);
        }
    }

    float MesafeOlcer(GameObject hedef)
    {
        return Vector3.Distance(car.transform.position, hedef.transform.position);
    }

}
