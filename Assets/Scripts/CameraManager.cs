using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public GameObject Player;

    void Update()
    { 
        Vector3 PlayerPosition = Player.transform.position;
        this.transform.position = new Vector3(PlayerPosition.x, 
        this.transform.position.y, this.transform.position.z); 
    }
}
