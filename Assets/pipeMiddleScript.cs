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
        //unity �zerinde bir boxcollider olu�turduk. bu elementi tetikleyici yani trigger olarak kullanmak i�in isTrigger'� i�aretledik. Buradaki ama�, karakter bu box collider'a de�di�inde
        // scorun artmas�n� sa�lamak. yani her pipe'tan ge�ti�inde skorun artmas�n� hedefledik. Fakat bunu yapabilmek i�in daha �nce yazd���m�z addScore fonksiyonuna ihtiyac�m�z var.
        // bu fonksiyon aula�abilmek i�in yukar�da referans olu�turduk fakat burada kar��m�za bir s�k�nt� ��kt�. bu s�k�nt� bizim amac�m�z olan her pipe ta score artt�rma durumunda
        // fonksiyonun bulundu�u script sadece pipe olu�tu�unda eri�ilebilir. yani kodda ilk pipe olu�tu�unda ifadesini kullanmay� ama�l�yoruz. bunun i�in unityde logicManager gameobject'e t�klad�k
        // ve tag k�sm�nda Logic adl� bir tag olu�turduk. daga sonra yeniden logicManager game object'ine d�nerek tag k�sm�ndan Logic tag'ini se�tik.

        if(collision.gameObject.layer == 3)
        {
            logic.addScore(1);
        }
        

    }
}
