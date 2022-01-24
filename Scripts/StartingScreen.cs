using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartingScreen : MonoBehaviour



{
    public GameObject StartingScreenCanvas;
    public GameObject ClickToFlyUp;
    public GameObject Counter;
    
    
    // Start is called before the first frame update
    void Start()
    {
        Counter.SetActive(false);
    }


    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            
            DestroyImmediate (StartingScreenCanvas,true); 
            DestroyImmediate (ClickToFlyUp,true);
            Counter.SetActive(true);
        }
        if(Input.GetKeyDown("space"))
        {
            DestroyImmediate (StartingScreenCanvas,true); 
            DestroyImmediate (ClickToFlyUp,true);
            Counter.SetActive(true);  
        }
    }
}
