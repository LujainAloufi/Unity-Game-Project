using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PipesCounter : MonoBehaviour
{

    public LogicScript logic;
    public AudioSource WinSound;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();    }

    // Update is called once per frame
    void Update()
    {
        
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
    if (collision.gameObject.layer == 3)
        {

            logic.PipesCounter(1);
            Destroy(gameObject);
          
           if (logic.pipeCount%10 ==0)
{
           WinSound.Play();

} 

           // WinSound.Play();

        }




    }
}