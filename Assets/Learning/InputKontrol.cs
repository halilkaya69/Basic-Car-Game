using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputKontrol : MonoBehaviour
{
    [SerializeField]
    GameObject motorPrefab;

    List<GameObject> motorList=new List<GameObject> ();
    //GameObject[] motorlar = new GameObject[4];

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            //Debug.Log(Input.mousePosition);

            Vector3 position = Input.mousePosition;
            position.z = -Camera.main.transform.position.z;
            position = Camera.main.ScreenToWorldPoint(position);

            for (int i = 0; i < 10; i++)//sayý keyfi
            {
                motorList.Add(Instantiate(motorPrefab, position, Quaternion.identity));
            }
            
            

        }

        //if (Input.GetMouseButton(0))
        //{
        //    Debug.Log("Pressed left click.");
        //}

        if (Input.GetMouseButtonDown(1))//sað tuþ
        {
            Debug.Log(motorList.Count);
            foreach(GameObject motor in motorList)
            {
                Destroy(motor);
            }

            motorList.Clear();

            //for (int i = 0; i < motorList.Count; i++)
            //{
            //    Destroy(motorList[i]);
            //}
        }

        //if (Input.GetMouseButton(2))
        //{
        //    Debug.Log("Pressed middle click.");
        //}


    }
}
