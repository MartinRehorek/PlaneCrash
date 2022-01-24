using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class PlayerController : MonoBehaviour
{
        // score
    public Text scoreText;


    public GameManager GameManager;

        // pohyb těla
    Rigidbody2D plane;


    int highscore;
    int score;
    bool dead = false;
    

    public Text Highscoretext;
    public GameObject NewHighScore;
    
 
    
    void Start()
    {
        plane = transform.GetComponent<Rigidbody2D>();    
        
        
        int highscore = PlayerPrefs.GetInt("HighScore");
        Highscoretext.text = PlayerPrefs.GetInt("HighScore").ToString();
        
        
        
        
        NewHighScore.SetActive(false);
    }



    void Update()
    {
        if((Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began) && !dead)
        {
            plane.velocity = new Vector2(0, 180f);
        }
        if(Input.GetKey("space"))
        {
            plane.velocity = new Vector2(0, 180f);
        }

    }
    // po kolizi zamrznuti
    void onCollisionEnter2D( ) 
    {
        
        dead = true;
    }
    
        // bodíky
    void OnTriggerExit2D(Collider2D col){
        if(col.gameObject.tag == "PointTrigger"){
            score ++;
            scoreText.text = score.ToString();
        }
    }
            //když se dotkne = smrt
    private void OnCollisionEnter2D(Collision2D collision)
    {   
        int highscore = PlayerPrefs.GetInt("HighScore");
        Debug.Log("HighScorepokolizi: " + PlayerPrefs.GetInt("HighScore"));
        if (score > highscore)
            {

                PlayerPrefs.SetInt("HighScore", score);
                Highscoretext.text = score.ToString();

                NewHighScore.SetActive(true);
                
            }

        Debug.Log("Score: " + score);
        Debug.Log("HighScore: " + PlayerPrefs.GetInt("HighScore"));
        GameManager.GameOver();
      
        
        
    }

}



