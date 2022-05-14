using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("space")== true)
        {
            //オブジェクト名.GetComponent<コンポーネント名>();
            this.gameObject.GetComponent<BoxCollider>().isTrigger = true;
        }
        
    }
}
