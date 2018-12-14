
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public GameObject sari;
    public GameObject kirmizi;
    public GameObject yesil;
    public GameObject mavi;
    public int mahmut;
    public Transform point;
    public GameObject yaratilacak;

	void Start () {

        create();
    }

    void create() {
        
        for (int i = 0; i < mahmut; i++)
        {
            int randomNumber = Random.Range(1, 5);
            if (randomNumber == 1)
                yaratilacak = sari;
            else if (randomNumber == 2)
                yaratilacak = mavi;
            else if (randomNumber == 3)
                yaratilacak = yesil;
            else if (randomNumber == 4)
                yaratilacak = kirmizi;



            Instantiate(yaratilacak, point.position, Quaternion.identity);
            point.position = new Vector3(point.position.x + 2, point.position.y, 0);

        }
       

    }
	
	
	void Update () {
        
    }
}
