using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    // Burada unity deki rigigbody2d componentine ulaþtýk. Kaydedip unity'e geçtiðimizde oluþan slota ilgili component'i sürükleyip býraktýk.
    public Rigidbody2D myRigidBody;
    public float flapStrength;
    public logicManager logic;
    public bool birdIsAlive = true;
    

    // Start is called before the first frame update. Ýt runs once.
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<logicManager>();
    }

    // Update is called once per frame
    void Update()
    {
        // myRigidBody.velocity = Vector2.up * 10;  Burada kuþun uçmasýný saðladýk fakat ekranýn dýþýna çýkýyor bunu if ile çözdük.

        if (Input.GetKeyDown(KeyCode.Space)== true && birdIsAlive == true) // Burada unity'nin input sistemi ile iletiþim kurduk. GetKeyDown kýsmý boþluk tuþuna basýlýp basýlmadýðýný sormamýzý saðladý.
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
