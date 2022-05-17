using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public float speed = 5.0f;
    public float jumpPower = 5.0f;
    int jumpCount;
    Animator animator;

    void Start()
    {
        animator = this.GetComponent<Animator>();
    }

    void Update()
    {
        //Playerの移動コード
        if (Input.GetKey("right") == true)
        {
            this.transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
            this.transform.rotation = Quaternion.Euler(0, 90, 0);
        }
        if (Input.GetKey("left") == true)
        {
            this.transform.position -= new Vector3(speed * Time.deltaTime, 0, 0);
            this.transform.rotation = Quaternion.Euler(0, 270, 0);
        }

        //Playerのジャンプのコード
        if (Input.GetKeyDown("space") == true && jumpCount < 2)
        {
            this.GetComponent<Rigidbody>().velocity = new Vector3(0, jumpPower, 0);
            jumpCount += 1;
        }

        //PlayerのAnimation切り替えのコード
        if (Input.GetKeyDown("right"))
        {
            animator.SetBool("Running", true);
        }
        if (Input.GetKeyUp("right"))
        {
            animator.SetBool("Running", false);
        }
        if (Input.GetKeyDown("left"))
        {
            animator.SetBool("Running", true);
        }
        if (Input.GetKeyUp("left"))
        {
            animator.SetBool("Running", false);
        }

    }

    //地面に触れたらジャンプカウントをリセットするコード
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Ground")
        {
            jumpCount = 0;
        }
    }
}