using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrianSpecialAttack : MonoBehaviour {

    public GameObject Left;
    public GameObject Right;
    public GameObject Up;
    public GameObject Down;
    private Animator anim;
    private Animations anima;
    public int Delay;
    public int Delay2;
    public int Delay3;
    public int Delay4;
    private int Time;
    private Rigidbody2D rb;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        anima = GetComponent<Animations>();
        Left.SetActive(false);
        Right.SetActive(false);
        Down.SetActive(false);
        Up.SetActive(false);

    }

    // Update is called once per frame
    void Update() {
        Time++;
        Delay3++;
        Delay4++;
        if (Time > Delay)
        {
            rb.constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezePositionY | RigidbodyConstraints2D.FreezeRotation;
            anim.SetBool("Wow", true);
            if (Delay3 >= 250)
            {
                Left.SetActive(true);
                Right.SetActive(true);
                Down.SetActive(true);
                Up.SetActive(true);
                anima.speed = 0;
            }
            if (Time > Delay2)
            {
                anim.SetBool("Wow", false);
                if (Delay4 >= 430)
                {
                    rb.constraints = RigidbodyConstraints2D.FreezeRotation;
                    Left.SetActive(false);
                    Right.SetActive(false);
                    Down.SetActive(false);
                    Up.SetActive(false);
                    Delay4 = 0;
                    anima.speed = 1.1f;
                    Time = 0;
                    Delay3 = 0;
                }
                
            }
        }
    }
}