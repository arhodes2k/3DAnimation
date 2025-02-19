using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PeteController : MonoBehaviour
{

    [SerializeField] float turn; 
    [SerializeField] float speed;
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        turn = Input.GetAxis("Horizontal"); 
        speed = Input.GetAxis("Vertical");

        anim.SetFloat("speed", speed);
        anim.SetFloat("Turn", turn);
    }
}
