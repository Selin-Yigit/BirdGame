using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnerScript : MonoBehaviour
{
    //Buradaki amaç her birkaç saniyede bir prefab gameobject kullanýlarak yeni pipe versiyonlarý oluþturmak. Bunun için unityde sahnen dýþýnda kalavak þekilde yeni bir obje oluþturuldu.

    public GameObject pipe; // Slot oluþturuldu ve asset kýsmýndaki prefab sürüklenerek eþleþtirildi.
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
                // timer spawnrate'e eþit ya da ondan fazlaolduðunda pipe oluþturulucak.
                spawnPipe();
                timer = 0;
            }
        }
       
        
        
    }

    public void spawnPipe()
    {
        // farklý boyutlarda pipe oluþturduk.
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;

        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestPoint,highestPoint),0 ), transform.rotation);
        // sadece bu satýr ile býrakýrsak her frame'de pipe oluþacaðý için tek bir pipe oluþmuþ gibi görünüyor ama birden fazla obje oluþuyor.
    }
}
