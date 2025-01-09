using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{

    public Rigidbody2D myRigidbody;
    public float flapStrength;
    public LogicScript logic;

    public GameObject bird;

    public bool birdIsAlive = true;

    public AudioSource gameBG;


    // Start is called before the first frame update
    void Start()
    {
        // ربط الكائن الذي يحتوي على LogicScript
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();

        // تغيير اسم الطائر
        gameObject.name = "Finn";
        gameBG.Play();

    }

    // Update is called once per frame
    void Update()
    {
        // تحقق من ضغط زر المسافة للطيران
        if (Input.GetKeyDown(KeyCode.Space) && birdIsAlive)
        {
            myRigidbody.velocity = Vector2.up * flapStrength;
        }

if (logic.pipeCount==5)
{
      logic.Winner();
      birdIsAlive = false;
Destroy(bird);
        gameBG.Stop();

}


    }




    // يتم استدعاء هذه الدالة عند حدوث تصادم
    public void OnCollisionEnter2D(Collision2D collision)
    {
        // تحقق مما إذا كان الطائر لا يزال على قيد الحياة لتجنب تكرار العمليات
        if (birdIsAlive)
        {
            // إذا اصطدم الطائر بجسم يحمل العلامة المحددة
            if (collision.gameObject.tag == "CollTag")
            {
                // تشغيل الصوت
             //   audioPlayer.Play();
            }

            // استدعاء نهاية اللعبة
            logic.gameOver();
            gameBG.Stop();
            birdIsAlive = false; // الطائر لم يعد حيًا
        }



    }






}