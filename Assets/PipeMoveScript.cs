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
        // pipe'lar hareket ettirilirken x,y ve z boyutlar�n�n ayn� anda hareket etmesini istiyoruz. Oyun 2d olsa bile sahnenin derinli�i olmas� gerekti�i i�in sahne 3d'dir.
        // Bunu ger�ekle�tirmek i�in �imdiki pozisyonu 3 boyutlu olacak �ekilde sola do�ru belirlenen h�zda hareket ettirdik. Fakat burada oyun her bilgisayarda farkl� h�zda �al��abilir yani
        // frame rate'e olan ba��ml�l�ktan kurtulmu� oluruz ve bu �arp�m her seferinde ayn� �ekilde ger�ekle�mi� olur.
        transform.position = transform.position+(Vector3.left*moveSpeed) * Time.deltaTime;

        // Sahnede farkl� boyutlu pipe lar olu�turmak i�in daha sonra yazd���m�z parent asset k�sm�na s�r�kle b�rak ile at�ld�. sonras�nda hiyerar�iden sildik. Prefabricated gameobject olarak adland�r�l�r.
        // bu gameobject kullan�larak daha fazla pipe olu�turulacak.

        if(transform.position.x < deadZone)
        {
            Debug.Log("Pipe Deleted");
            Destroy(gameObject);
        }
    }
}
