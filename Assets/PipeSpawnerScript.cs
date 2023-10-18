using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnerScript : MonoBehaviour
{
    //Buradaki ama� her birka� saniyede bir prefab gameobject kullan�larak yeni pipe versiyonlar� olu�turmak. Bunun i�in unityde sahnen d���nda kalavak �ekilde yeni bir obje olu�turuldu.

    public GameObject pipe; // Slot olu�turuldu ve asset k�sm�ndaki prefab s�r�klenerek e�le�tirildi.
    public float spawnRate = 2;
    public float timer = 0;
    public float heightOffset = 10;
    public bool isOver;
 
    void Start()
    {
        spawnPipe();
        isOver = false;
    }

    void Update()
    {
       if(isOver)
        {
            timer = 0;
        }
       else
       {
            if (timer < spawnRate)
            {
                // timer her frame'i sayar.
                timer = timer + Time.deltaTime;
            }
            else
            {
                // timer spawnrate'e e�it ya da ondan fazlaoldu�unda pipe olu�turulucak.
                spawnPipe();
                timer = 0;
            }
        }
       
        
        
    }

    public void spawnPipe()
    {
        // farkl� boyutlarda pipe olu�turduk.
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;

        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestPoint,highestPoint),0 ), transform.rotation);
        // sadece bu sat�r ile b�rak�rsak her frame'de pipe olu�aca�� i�in tek bir pipe olu�mu� gibi g�r�n�yor ama birden fazla obje olu�uyor.
    }
}
