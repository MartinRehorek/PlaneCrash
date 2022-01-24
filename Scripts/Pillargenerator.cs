using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pillargenerator : MonoBehaviour

{
    [SerializeField] GameObject Pillars;
   

    public int timer = 250;

    public bool Aktivace = false;

    

    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void FixedUpdate()
    {
        //ios?
        if(Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
         Aktivace = true;
        }
        // android
       

        //pc
        if(Input.GetKeyDown("space"))
        {
            Aktivace = true;
        }

        if (Aktivace == true)
        {
            timer++;
        }
        

        if(timer >= 220)
        {
            timer = 0;

            GameObject Pillar = Instantiate(Pillars,new Vector2(Pillars.transform.position.x,Pillars.transform.position.y + Random.Range(-30,450)),Pillars.transform.rotation);
            Destroy(Pillar,10); 

            
        
    }
  
    }
}  
