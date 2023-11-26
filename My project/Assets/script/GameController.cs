using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class GameController : MonoBehaviour
{
     public bool isEndGame;
    bool isStartFirstTime = true;
    // Start is called before the first frame update
    int gamePoin = 0;
     public Text txtPoin;
    public GameObject plnEndGame;
    public Text txtEndPoit;
    public Button btnRestart;

    void Start()
    {
         Time.timeScale = 0;
         isEndGame = false;
         isStartFirstTime = true;
         plnEndGame.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(isEndGame){
            if(Input.GetMouseButtonDown(0) && isStartFirstTime){
                StartGame();
            
          }
        }else{
                 
            if(Input.GetMouseButtonDown(0)){
  Time.timeScale= 1;
        }
    }
    }

    public void GetPoin(){
       gamePoin++;
      txtPoin.text = " Poin: "+gamePoin.ToString();
    }
     void StartGame(){
         SceneManager.LoadScene(0);
     }
    public void Restart(){
        StartGame();
    }
    public void EndGame(){
        isEndGame = true;
       isStartFirstTime = false;
        Time.timeScale = 0;
        plnEndGame.SetActive(true);
        txtEndPoit.text = "Your Poin\n"+gamePoin.ToString();
    }
}
