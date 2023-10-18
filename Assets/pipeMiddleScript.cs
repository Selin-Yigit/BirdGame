using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipeMiddleScript : MonoBehaviour
{
    public logicManager logic;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<logicManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //unity üzerinde bir boxcollider oluþturduk. bu elementi tetikleyici yani trigger olarak kullanmak için isTrigger'ý iþaretledik. Buradaki amaç, karakter bu box collider'a deðdiðinde
        // scorun artmasýný saðlamak. yani her pipe'tan geçtiðinde skorun artmasýný hedefledik. Fakat bunu yapabilmek için daha önce yazdýðýmýz addScore fonksiyonuna ihtiyacýmýz var.
        // bu fonksiyon aulaþabilmek için yukarýda referans oluþturduk fakat burada karþýmýza bir sýkýntý çýktý. bu sýkýntý bizim amacýmýz olan her pipe ta score arttýrma durumunda
        // fonksiyonun bulunduðu script sadece pipe oluþtuðunda eriþilebilir. yani kodda ilk pipe oluþtuðunda ifadesini kullanmayý amaçlýyoruz. bunun için unityde logicManager gameobject'e týkladýk
        // ve tag kýsmýnda Logic adlý bir tag oluþturduk. daga sonra yeniden logicManager game object'ine dönerek tag kýsmýndan Logic tag'ini seçtik.

        if(collision.gameObject.layer == 3)
        {
            logic.addScore(1);
        }
        

    }
}
