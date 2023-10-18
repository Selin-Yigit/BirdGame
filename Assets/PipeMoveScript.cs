using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMoveScript : MonoBehaviour
{
    public float moveSpeed = 5;
    public float deadZone = -46;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // pipe'lar hareket ettirilirken x,y ve z boyutlarýnýn ayný anda hareket etmesini istiyoruz. Oyun 2d olsa bile sahnenin derinliði olmasý gerektiði için sahne 3d'dir.
        // Bunu gerçekleþtirmek için þimdiki pozisyonu 3 boyutlu olacak þekilde sola doðru belirlenen hýzda hareket ettirdik. Fakat burada oyun her bilgisayarda farklý hýzda çalýþabilir yani
        // frame rate'e olan baðýmlýlýktan kurtulmuþ oluruz ve bu çarpým her seferinde ayný þekilde gerçekleþmiþ olur.
        transform.position = transform.position+(Vector3.left*moveSpeed) * Time.deltaTime;

        // Sahnede farklý boyutlu pipe lar oluþturmak için daha sonra yazdýðýmýz parent asset kýsmýna sürükle býrak ile atýldý. sonrasýnda hiyerarþiden sildik. Prefabricated gameobject olarak adlandýrýlýr.
        // bu gameobject kullanýlarak daha fazla pipe oluþturulacak.

        if(transform.position.x < deadZone)
        {
            Debug.Log("Pipe Deleted");
            Destroy(gameObject);
        }
    }
}
