using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementControl : MonoBehaviour
{
    float colliderBoyYarim;
    float colliderEnYarim;


    // Start is called before the first frame update
    void Start()
    {
        //benim yaptýðým
        Rigidbody2D rb2D = GetComponent<Rigidbody2D>();
        rb2D.AddForce(new Vector2(Random.Range(-5,5),Random.Range(-5,5)), ForceMode2D.Impulse);

        //adamýn yaptýðý
        //Rigidbody2D myrigitbody2d = GetComponent<Rigidbody2D>();
        //myrigitbody2d.AddForce(new Vector2(0,5),ForceMode2D.Impulse);

        BoxCollider2D collider = GetComponent<BoxCollider2D>();

        colliderBoyYarim = collider.size.y / 2;
        colliderEnYarim = collider.size.x / 2;

    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        //Debug.Log("carptýk");
    }

    // Update is called once per frame
    void Update()
    {
        //motor mouse imlecini takip edecek
        //Vector3 position = Input.mousePosition;
        //position.z = -Camera.main.transform.position.z;
        //position = Camera.main.ScreenToWorldPoint(position);
        //transform.position = position;
        //EkrandaKal();
    }

    void EkrandaKal()
    {
        Vector3 position = transform.position;

        if (position.x - colliderEnYarim < EkranHesaplayici.Sol)
        {
            position.x = EkranHesaplayici.Sol + colliderEnYarim;
        }
        else if (position.x + colliderEnYarim > EkranHesaplayici.Sag)
        {
            position.x = EkranHesaplayici.Sag - colliderEnYarim;
        }

        if (position.y + colliderBoyYarim > EkranHesaplayici.Ust)
        {
            position.y = EkranHesaplayici.Ust - colliderBoyYarim;
        }
        else if (position.y - colliderBoyYarim < EkranHesaplayici.Alt)
        {
            position.y = EkranHesaplayici.Alt + colliderBoyYarim;
        }

        transform.position = position;
        //positioný oyun objesinin pozisyonuna atarýz
    }
        

}
