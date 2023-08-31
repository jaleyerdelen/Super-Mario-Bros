using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideScrolling : MonoBehaviour
{
    private Transform player;

    private void Awake()
    {
        player = GameObject.FindWithTag("Player").transform;
    }

    private void LateUpdate()
    {
        Vector3 cameraPosition = transform.position;
        //cameraPosition.x = player.position.x;
        cameraPosition.x = Mathf.Max(cameraPosition.x, player.position.x); // ileriye dogru takip etmesi icin
        transform.position = cameraPosition;
      
    }
}
