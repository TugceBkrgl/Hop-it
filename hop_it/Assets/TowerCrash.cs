using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerCrash : MonoBehaviour {
    public List<GameObject> objects;
    public GameObject yokEdilecek;
    public Material standart;
    public bool start= false;

	// Use this for initialization
	void Start () {
        foreach(Transform child in transform)
        {
            objects.Add(child.gameObject);

        }

     
            
        

    }
	
	// Update is called once per frame
	void Update () {
        if (start == true)
            StartCoroutine(WaitAndPrint());
    }

    private IEnumerator WaitAndPrint()
    {
        start = false;
        int index = 0;
        while (index<objects.Count)
        {
            yield return new WaitForSeconds(0.05f);
            yokEdilecek = objects[objects.Count - 1];
            indir( objects[objects.Count-1-index] );
            index++;
        }
    }

    void indir(GameObject obje)
    {
        obje.GetComponent<Rigidbody>().useGravity = true;
        obje.GetComponent<Renderer>().material = standart;
    }
}
