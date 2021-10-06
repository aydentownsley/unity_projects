using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TyAnimation : MonoBehaviour
{
    static Animator anim;
    public GameObject Player;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float translation = Input.GetAxis("Vertical");
        float rotation = Input.GetAxis("Horizontal");

        if (translation != 0 || rotation != 0)
            anim.SetBool("IsRunning", true);
        else
            anim.SetBool("IsRunning", false);

        if (Input.GetKeyDown(KeyCode.Space))
            anim.SetBool("IsJumping", true);
        else
            anim.SetBool("IsJumping", false);

        if (Player.transform.position.y < -10)
            anim.SetBool("Falling", true);

        if (Player.transform.position.y > 0 && Player.transform.position.y < 1)
        {
            anim.SetTrigger("Grounded");
            anim.SetBool("Falling", false);
        }
    }
}
