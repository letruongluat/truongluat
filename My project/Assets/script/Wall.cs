using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    public float moveSpeed;
    public float minY;
    public float maxY;
private float oldPosition;
private GameObject obj;
// Start is called before the first frame update
void Start()
{
    obj = gameObject;
    oldPosition = 10;
   
    moveSpeed = 5;
    minY =-4;
    maxY = -8;
} 
// Update is called once per frame
void Update()
{
    obj.transform.Translate(new Vector3(-1* Time.deltaTime * moveSpeed,0, 0));

 }
 void OnTriggerEnter2D(Collider2D other){
    Debug.Log("wall");
    if(other.gameObject.tag.Equals("resetwall"))
    obj.transform.position =  new Vector3(oldPosition,Random.Range( minY, maxY+1 ) , 0);
    
 }
}

