using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class birrd : MonoBehaviour
{
    public float flyPower;

    GameObject gameController;
    GameObject obj;
    public bool isEndGame;
    public AudioClip flyClip;
    public AudioClip gameOverClip;

    private AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        obj = gameObject; 
        flyPower=20;
        audioSource = obj.GetComponent<AudioSource>();
        audioSource.clip = flyClip;
         if(gameController == null){
            gameController = GameObject.FindGameObjectWithTag("GameController");
         }
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetMouseButton(0)){
          if(!gameController.GetComponent<GameController>().isEndGame)
              audioSource.Play();
             obj.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, flyPower));
        
       }
   }
    
    void OnCollisionEnter2D(Collision2D other){
      EndGame();
      
    }
    void OnTriggerEnter2D(Collider2D other){
      gameController.GetComponent<GameController>().GetPoin();

    }
    void EndGame(){
      audioSource.clip = gameOverClip;
        audioSource.Play();
        
      gameController.GetComponent<GameController>().EndGame();
       

    }
 
}
