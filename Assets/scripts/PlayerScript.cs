using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    private Animator anim;
    public bool isone=false;
    public bool istwo=false;
    public bool isthree=false;
    public bool isfour=false;
    public bool isfive=false;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        isone = Input.GetKey(KeyCode.UpArrow);
        anim.SetBool("one", isone);

        istwo = Input.GetKey(KeyCode.DownArrow);
        anim.SetBool("two", istwo);

        isthree = Input.GetKey(KeyCode.LeftArrow);
        anim.SetBool("three", isthree);

        isfour = Input.GetKey(KeyCode.RightArrow);
        anim.SetBool("four", isfour);

        isfive = Input.GetKey(KeyCode.RightShift);
        anim.SetBool("five", isfive);


    }
}
