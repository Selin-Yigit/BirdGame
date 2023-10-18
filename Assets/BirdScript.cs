using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    // Burada unity deki rigigbody2d componentine ula�t�k. Kaydedip unity'e ge�ti�imizde olu�an slota ilgili component'i s�r�kleyip b�rakt�k.
    public Rigidbody2D myRigidBody;
    public float flapStrength;
    public logicManager logic;
    public bool birdIsAlive = true;
    

    // Start is called before the first frame update. �t runs once.
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<logicManager>();
    }

    // Update is called once per frame
    void Update()
    {
        // myRigidBody.velocity = Vector2.up * 10;  Burada ku�un u�mas�n� sa�lad�k fakat ekran�n d���na ��k�yor bunu if ile ��zd�k.

        if (Input.GetKeyDown(KeyCode.Space)== true && birdIsAlive == true) // Burada unity'nin input sistemi ile ileti�im kurduk. GetKeyDown k�sm� bo�luk tu�una bas�l�p bas�lmad���n� sormam�z� sa�lad�.
        {
            myRigidBody.velocity = Vector2.up * flapStrength;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        birdIsAlive = false;

    }
}
