using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour {
public GameObject go;
public List<GameObject> altObjeler;
public int size;
public float index;
public float aralik;
	
	// Use this for initialization
	void Start () {
		
		for(int i=0; i<size; i++)
        {
		GameObject a=Instantiate(go,new Vector3(gameObject.transform.position.x,gameObject.transform.position.y-index),Quaternion.identity);
		altObjeler.Add(a);
		index=index+aralik;
		a.transform.parent=gameObject.transform;
		}
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	
	}
}
